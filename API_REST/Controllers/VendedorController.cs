using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_REST.Models;
using API_REST.Context;

namespace API_REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly VendasContext _context;

        public VendedorController(VendasContext context)
        {
            _context = context;
        }
    
        [HttpGet("{id}")] //Mostrará o id na barra de navegação.
        public IActionResult BuscarVendedorPorId(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            return Ok(vendedor);
        }


        [HttpPost]
        public IActionResult CriarVendedor(VendedorModel vendedor)
        {   
            _context.Add(vendedor);
            return Ok(vendedor);
        }
    }

}