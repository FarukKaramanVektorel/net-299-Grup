using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _db;

        public OrderRepository(AppDbContext db) => _db = db;

        async Task IOrderRepository.AddAllAsync(IEnumerable<Order> orders)=>await _db.Orders.AddRangeAsync(orders);

        async Task IOrderRepository.AddAsync(Order order) => await _db.Orders.AddAsync(order);

        async Task<List<Order>> IOrderRepository.GetAllAsync()=>await _db.Orders.ToListAsync();

        Task<Order?> IOrderRepository.GetByIdAsync(int id) => _db.Orders.FirstOrDefaultAsync(o => o.Id == id);
    }
}
