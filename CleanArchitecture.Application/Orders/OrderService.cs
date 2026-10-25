using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace CleanArchitecture.Application.Orders
{
    public class OrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IUnitOfWork _uow;

        public OrderService(IOrderRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<OrderDto> CreateAsync(CreateOrderRequest dto)
        {
            var order = new Order(dto.Product, dto.Price);

            await _repo.AddAsync(order);
            await _uow.SaveCahangesAsyync();
            return ToDto(order);
        }

        public async Task<List<OrderDto>> CreateAsync(List<CreateOrderRequest> dto)
        {
            var orders = dto.Select(d => new Order(d.Product, d.Price)).ToList();

            await _repo.AddAllAsync(orders);
            await _uow.SaveCahangesAsyync();
            return orders.Select(ToDto).ToList();
        }


        private OrderDto ToDto(Order order) => new(order.Id, order.Product, order.Price, order.Status.ToString(), order.CreatedDate);


        public async Task<OrderDto?> GetByIdasync(int id)
        {
            var order=await _repo.GetByIdAsync(id);
            return order is null?null: ToDto(order);
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            var orders = await _repo.GetAllAsync();
            return orders.OrderByDescending(o => o.CreatedDate).Select(ToDto).ToList();
        }

        public async Task<OrderDto?> ShipAsync(int id)
        {
            var order = await _repo.GetByIdAsync(id);
            if(order is null) return null;
            order.Ship();
            await _uow.SaveCahangesAsyync();
            return ToDto(order);
        }

        public async Task<OrderDto?> CancelAsync(int id)
        {
            var order = await _repo.GetByIdAsync(id);
            if (order is null) return null;
            order.Cancel();
            await _uow.SaveCahangesAsyync();
            return ToDto(order);
        }


    }




}
