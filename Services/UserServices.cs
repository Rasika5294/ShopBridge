using ShopBridge.Models;
using ShopBridge.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _iuserRepository;
        public UserServices(IUserRepository iuserRepository)
        {
                this._iuserRepository = iuserRepository;
        }

        public bool AddOrder(Order order)
        {
            return _iuserRepository.AddOrder(order);
        }

        public bool AddUser(User user)
        {
            return (_iuserRepository.AddUser(user));
        }

        public async Task<User> CheckIfUserisValid(string email)
        {
           return await _iuserRepository.CheckIfUserisValid(email);   
        }

        public bool DeleteOrder(int id)
        {
            return _iuserRepository.DeleteOrder(id);
        }

        public IEnumerable<Order> GetAllOrders(int id)
        {
            return _iuserRepository.GetAllOrders(id);
        }

        public async Task<IEnumerable<Product>> GetProductByCategury(string category)
        {
            return await _iuserRepository.GetProductByCategury(category);
        }

        public bool UpdateOrder(Order order)
        {
            return _iuserRepository.UpdateOrder(order);
        }
    }
}
