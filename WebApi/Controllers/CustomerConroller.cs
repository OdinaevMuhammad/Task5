using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController
    {
        private CustomerSevices _CustomerService;

        public CustomerController()
        {
            _CustomerService = new CustomerSevices();
        }


        [HttpGet("GetInfo")]
        public List<Customer> GetCustomer()
        {
            return _CustomerService.GetInfoCustomer();
        }

        [HttpPost("Insert")]
        public int InsertStudent(Customer Customer)
        {
            return _CustomerService.InsertCustomer(Customer);
        }

        [HttpPut("Update")]
        public int UpdateCustomer(Customer Customer)
        {
            return _CustomerService.UpdateCustomer(Customer);
        }

        [HttpDelete("Delete")]
        public int DeleteCustomer(int id)
        {
            return _CustomerService.DeleteCustomer(id);
        }             
    }

}