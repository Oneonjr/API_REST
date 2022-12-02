using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Models
{
    public class VendedorModel
    {
        public int IdVendedor { get; set; } 
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}