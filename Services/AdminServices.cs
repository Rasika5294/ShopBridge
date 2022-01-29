using ShopBridge.Models;
using ShopBridge.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IAdminRepository _iadminRepository;
        public AdminServices(IAdminRepository iadminRepository)
        {
            this._iadminRepository = iadminRepository;  
        }
        public Task<Admin> CheckIfAdminisValid(string email)
        {
           return _iadminRepository.CheckIfAdminisValid(email);
        }
        public bool AddProduct(Product product)
        {
            return _iadminRepository.AddProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return (_iadminRepository.DeleteProduct(id));
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _iadminRepository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _iadminRepository.GetProductById(id);    
        }

        public bool UpdateProduct(Product product)
        {
           return _iadminRepository.UpdateProduct(product); 
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _iadminRepository.GetAllUsers();
        }

        public bool AddUser(User user)
        {
            return _iadminRepository.AddUser(user);
        }
    }
}
