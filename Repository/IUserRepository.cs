using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IUserRepository
    {
        public bool AddUser(User user);
        Task<User> CheckIfUserisValid(string email);
        Task<IEnumerable<Product>> GetProductByCategury(string category);
        public bool AddOrder(Order order);
        public bool UpdateOrder(Order order);
        public bool DeleteOrder(int id);
        public IEnumerable<Order> GetAllOrders(int id);

    }
}
