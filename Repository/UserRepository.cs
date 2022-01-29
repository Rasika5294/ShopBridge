using Microsoft.EntityFrameworkCore;
using ShopBridge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ShopBridgeContext _context;
        public UserRepository(ShopBridgeContext context)
        {
            this._context = context;
        }

        public bool AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<User> CheckIfUserisValid(string email)
        {
            return await _context.Users.Where(user => user.Email == email).SingleOrDefaultAsync();
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                Order order = _context.Orders.Find(id);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    _context.SaveChanges();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public  IEnumerable<Order> GetAllOrders(int id)
        {
            return _context.Orders.Where(order => order.UserId == id).ToList();
        }

        public async Task<IEnumerable<Product>> GetProductByCategury(string category)
        {
           return await _context.Products.Where(product => product.Category == category).ToListAsync(); 
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
