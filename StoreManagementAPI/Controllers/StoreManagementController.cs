using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreManagementController : ControllerBase
    {
        

        private readonly ILogger<StoreManagementController> _logger;

        private ProductRepository prodRepo = new ProductRepository();

        private MemberRepository memRepo = new MemberRepository();

        private OrderRepository ordRepo = new OrderRepository();

        private OrderDetailRepository orddetailRepo = new OrderDetailRepository();

        public StoreManagementController(ILogger<StoreManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => prodRepo.GetProducts();
        [HttpPost]
        public IActionResult PostProduct(Product p)
        {
            prodRepo.SaveProduct(p);
            return NoContent();
        }
        [HttpDelete("id")]
        public IActionResult DeleteProduct(int id)
        {
            var p = prodRepo.GetProductById(id);
            if (p == null)
            {
                return NotFound();
            }
            prodRepo.DeleteProduct(p);
            return NoContent();
        }
        [HttpPut("id")]
        public IActionResult UpdateProduct(int id, Product p)
        {
            var pTemp = prodRepo.GetProductById(id);
            if (p == null)
            {
                return NotFound();
            }
            prodRepo.UpdateProduct(p);
            return NoContent();
        }

       
    }
}