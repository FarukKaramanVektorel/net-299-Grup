using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public string Product { get; private set; } = string.Empty;

        public decimal Price { get; private set; }
        public Orderstatus Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public Order() { }

        public Order(string product,decimal price)
        {
            if (string.IsNullOrWhiteSpace(product))
            {
                throw new ArgumentNullException("Ürün adı boş olamaz.",nameof(product));
            }
            if (price <= 0)
            {
                throw new ArgumentException("Fiyat 0 dan büyük olmalı.", nameof(price));
            }
            Product = product;
            Price = price;
            Status = Orderstatus.Created;
            CreatedDate= DateTime.Now;
        }

        public void Ship()
        {
            if (Status != Orderstatus.Shipped)
            {
                throw new InvalidOperationException("Sadece oluşturulmuş siparişler kargolanabilir");
            }
            Status = Orderstatus.Shipped;
        }
        public void Cancel()
        {
            if (Status == Orderstatus.Shipped)
            {
                throw new InvalidOperationException("Kargolanan sipariş iptal edilemez");
            }
            Status = Orderstatus.Canceled;
        }
       
    }
}
