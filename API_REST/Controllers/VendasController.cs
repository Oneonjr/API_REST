using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;
using Microsoft.AspNetCore.Mvc;
using API_REST.Context;

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
        public List<Vendas> BuscarTodasVendas()
        {
           
            return _context.Vendas.ToList();
        }

        [HttpPost]
        public IActionResult CriarVendas(Vendas vendas)
        {   
            
            _context.Add(vendas);
            _context.SaveChanges();
            return Ok(vendas);
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Vendas vendas)
        {
            var vendasBanco =_context.Vendas.Find(id);

            if (vendasBanco == null)
            
                return NotFound();
            
            
            vendasBanco.Status = vendas.Status;


            _context.Vendas.Update(vendasBanco);
            _context.SaveChanges();

            return Ok(vendasBanco);
        }


    }
}