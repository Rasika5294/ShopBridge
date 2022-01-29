using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IUserServices
    {
        public bool AddUser(User user);  
        Task<User> CheckIfUserisValid(string email);
        Task<IEnumerable<Product>> GetProductByCategury(string category);
        public bool AddOrder(Order order);
        public IEnumerable<Order> GetAllOrders(int id);
        public bool UpdateOrder(Order order);
        public bool DeleteOrder(int id);

    }
}
