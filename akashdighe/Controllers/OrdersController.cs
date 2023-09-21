using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecomm.Data;
using Ecomm.Entity;

namespace akashdighe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EcommContext _context;

        public OrdersController(EcommContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders(int? customerId)
        {
            if (customerId == null)
            {
                return BadRequest("customerId is required.");
            }

            var orders = await _context.Orders
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return NotFound($"No orders found for customerId {customerId}.");
            }

            return orders;
        }

    }
}
