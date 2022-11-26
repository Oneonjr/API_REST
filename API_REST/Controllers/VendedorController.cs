using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_REST.Models;

namespace API_REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedorController
    {
        [HttpGet]
        public ActionResult<List<VendedorModel>> BuscarVendedor()
        {
            return Ok();
        }

        private ActionResult<List<VendedorModel>> Ok()
        {
            throw new NotImplementedException();
        }
    }
}