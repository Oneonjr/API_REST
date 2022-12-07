using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;

namespace Entities
{
    public class VendasEntities : Vendas
    {
        public List<Vendas> ListaVendas {get; set;}
    }
}