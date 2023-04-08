using Microsoft.AspNetCore.Mvc;
using eShop.Domain;
using eShop.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace eShop.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly eShopContext _eShopContext;

        public CustomerController(eShopContext eShopContext)
        {
            _eShopContext = eShopContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _eShopContext.Customers.ToList();
            return Ok(data);
        }
    }
}
