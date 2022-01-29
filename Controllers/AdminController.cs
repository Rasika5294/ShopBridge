using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Models;
using ShopBridge.Services;
using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private static ILogger<AdminController> _logger;
        private readonly IAdminServices _iadminservices;
        public AdminController(IAdminServices iadminservices, ILogger<AdminController> logger)
        {
            this._iadminservices = iadminservices;
            _logger = logger;
        }
        
        [HttpGet]
        [Route("CheckIfAdminisValid/{email}")]
        public async Task<IActionResult> CheckIfAdminisValid(string email)
        {
            try
            {
                return new ObjectResult(await _iadminservices.CheckIfAdminisValid(email));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;  
            }
        }
        
        [HttpGet]
        [Route("Product/GetAllProduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpGet]
        [Route("Product/GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetProductById(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpPost]
        [Route("Product/AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                return new ObjectResult(_iadminservices.AddProduct(product));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpDelete]
        [Route("Product/DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_iadminservices.DeleteProduct(id));

        }
        
        [HttpPut]
        [Route("Product/UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                return new ObjectResult (_iadminservices.UpdateProduct(product));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
            
        }
        
        [HttpPost]
        [Route("User/AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                return new ObjectResult(_iadminservices.AddUser(user));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }
        
        [HttpGet]
        [Route("Product/GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetAllUsers());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ExceptionCaught");
                return null;
            }
        }

    }

}
