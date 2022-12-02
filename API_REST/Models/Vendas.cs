using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Models
{
    public class Vendas
    {
        public int IdVendas { get; set; }
        public int QuantidadeItens { get; set; }
        public string Situacao { get; set; }

    }
}