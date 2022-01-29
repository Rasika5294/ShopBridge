using ShopBridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IAdminRepository
    {
        Task<Admin> CheckIfAdminisValid(string email);
        public bool AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        public bool DeleteProduct(int id);
        public bool UpdateProduct(Product product);
        Task<Product> GetProductById(int id);
        public bool AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();

    }
}
