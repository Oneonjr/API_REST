using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Context;
using API_REST.Models;
using API_REST.Repositorios.Intefaces;

namespace API_REST.Repositorios
{
    public class VendedorRepositorio : IVendedorRepositorio
    {
        private readonly VendasContext _dbContext;
        public VendedorRepositorio(VendasContext vendasContext)
        {
            _dbContext =vendasContext;
        }

        public Task<VendedorModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VendedorModel>> BuscarVendedor()
        {
            throw new NotImplementedException();
        }

        public Task<VendedorModel> Adicionar(VendedorModel vendedor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VendedorModel> Atualizar(VendedorModel vendedor, int id)
        {
            throw new NotImplementedException();
        }


    }
}