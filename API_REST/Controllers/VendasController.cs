using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;
using Microsoft.AspNetCore.Mvc;
using API_REST.Context;
using API_REST.Entities;



namespace API_REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendasController : ControllerBase
    {
        private readonly VendasContext _context;

        public VendasController(VendasContext context)
        {
            _context = context;
        }
        
        [HttpGet("{id}")] //Mostrará o id na barra de navegação.
        public IActionResult BuscarVendasPorId(int id)
        {
            var vendas = _context.Vendedor.Find(id);
            return Ok(vendas);
        }

        [HttpPost]
        public IActionResult CriarVendas(Vendas vendas)
        {   
            
            
            return Ok(vendas);
        }



    }
}