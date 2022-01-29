using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ShopBridge.Models
{
    public partial class Order
    {
        public Order()
        {
            Users = new HashSet<User>();
        }

        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }
        [Required]
        public int? OrderQuantity { get; set; }
        [Required]
        public string ProductName { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
