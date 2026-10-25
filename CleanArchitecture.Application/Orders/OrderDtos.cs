using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Orders;

public record CreateOrderRequest(string Product, decimal Price);

public record OrderDto(int Id, string Product, decimal Price, string Status, DateTime CreatedDate);
