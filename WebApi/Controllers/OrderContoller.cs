using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController
    {
        private OrderSevices _OrdersService;

        public OrdersController()
        {
            _OrdersService = new OrderSevices();
        }


        [HttpGet("GetInfo")]
        public List<Orders> GetOrders()
        {
            return _OrdersService.GetInfoOrders();
        }

        [HttpPost("Insert")]
        public int InsertStudent(Orders Orders)
        {
            return _OrdersService.InsertOrders(Orders);
        }

        [HttpPut("Update")]
        public int UpdateOrders(Orders Orders)
        {
            return _OrdersService.UpdateOrders(Orders);
        }

        [HttpDelete("Delete")]
        public int DeleteOrders(int id)
        {
            return _OrdersService.DeleteOrders(id);
        }             
    }

}