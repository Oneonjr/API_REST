using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Enum;

namespace API_REST.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public int QuantidadeItens { get; set; }
        public DateTime DataHorario { get; set; }

        public StatusVenda Status { get; set; }
        public int VendedorId { get; set; }
        public VendedorModel Vendedor { get; set; }

    }
}