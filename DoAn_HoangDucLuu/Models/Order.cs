using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoAn_HoangDucLuu.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsProcessed { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public SanPham Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
