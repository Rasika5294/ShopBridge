using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ShopBridge.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
