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


        // [HttpPost]
        // public IActionResult CriarVendedor(VendedorModel vendedor)
        // {   
        //     _context.Add(vendedor);
        //     _context.SaveChanges();
        //     return Ok(vendedor);
        // }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, VendedorModel vendedor)
        {
            var vendedorBanco =_context.Vendedor.Find(id);

            if (vendedorBanco == null)
            
                return NotFound();
            

            vendedorBanco.Nome = vendedor.Nome;
            vendedorBanco.Email = vendedor.Email;
            vendedorBanco.Cpf = vendedor.Cpf;
            vendedorBanco.Telefone = vendedor.Telefone;

            _context.Vendedor.Update(vendedorBanco);
            _context.SaveChanges();

            return Ok(vendedorBanco);
        }
    }

}