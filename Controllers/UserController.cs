using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopBridge.Models;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static ILogger<AdminController> _logger;
        private readonly IUserServices _iuserServices;
        public UserController(IUserServices iuserServices, ILogger<AdminController> logger)
        {
            this._iuserServices = iuserServices;
            _logger = logger;   
        }
        
        [HttpGet]
        [Route("CheckIfUserisValid/{email}")]
        public async Task<IActionResult> CheckIfUserisValid(string email)
        {
            try
            {
                return new ObjectResult(await _iuserServices.CheckIfUserisValid(email));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetProductByCategury/{category}")]
        public async Task<IActionResult> GetProductByCategury(string category)
        {
            try
            {
                return new ObjectResult(await _iuserServices.GetProductByCategury(category));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpPost]
        [Route("Orders/AddOrder")]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                return new ObjectResult(_iuserServices.AddOrder(order));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpPost]
        [Route("Users/AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                return new ObjectResult(_iuserServices.AddUser(user));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpGet]
        [Route("Orders/GetAllOrders/{id}")]
        public IActionResult GetAllOrders(int id)
        {
            try
            {
                return new ObjectResult(_iuserServices.GetAllOrders(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }

        [HttpPut]
        [Route("Orders/UpdateOrder")]
        public IActionResult UpdateProduct(Order order)
        {
            try
            {
                return new ObjectResult(_iuserServices.UpdateOrder(order));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
            
        }
        
        [HttpDelete]
        [Route("Orders/DeleteOrder/{id}")]
        public IActionResult  DeleteOrder(int id)
        {
            try
            {
                return new ObjectResult(_iuserServices.DeleteOrder(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
            
        }
    }
}
