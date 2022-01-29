using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IAdminServices
    {
        Task<Admin> CheckIfAdminisValid(string email);
        public bool AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        public bool DeleteProduct(int id);
        public bool UpdateProduct(Product product);
        public bool AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
