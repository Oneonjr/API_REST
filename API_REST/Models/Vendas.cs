using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public int QuantidadeItens { get; set; }
        public int VendedorId { get; set; }
        public VendedorModel Vendedor { get; set; }

    }
}