using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;

namespace API_REST.Repositorios.Intefaces
{
    public interface IVendedorRepositorio
    {
        Task<List<VendedorModel>> BuscarVendedor();
        Task<VendedorModel> BuscarPorId(int id);
        Task<VendedorModel> Adicionar(VendedorModel vendedor);
        Task<VendedorModel> Atualizar(VendedorModel vendedor,int id);
        Task<bool> Apagar(int id);

    }
}