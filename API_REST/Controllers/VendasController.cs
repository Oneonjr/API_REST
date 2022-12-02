using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
         [HttpGet]
        public ActionResult<List<Vendas>> BuscarVendas()
        {
            return Ok();
        }

    }
}