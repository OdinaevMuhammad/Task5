using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private ProductSevices _ProductService;

        public ProductController()
        {
            _ProductService = new ProductSevices();
        }


        [HttpGet("GetInfo")]
        public List<Product> GetProduct()
        {
            return _ProductService.GetInfoProduct();
        }

        [HttpPost("Insert")]
        public int InsertStudent(Product Product)
        {
            return _ProductService.InsertProduct(Product);
        }

        [HttpPut("Update")]
        public int UpdateProduct(Product Product)
        {
            return _ProductService.UpdateProduct(Product);
        }

        [HttpDelete("Delete")]
        public int DeleteProduct(int id)
        {
            return _ProductService.Deleteproduct(id);
        }             
    }

}
