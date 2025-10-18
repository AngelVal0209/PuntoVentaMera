using Proyecto.BLL.Interfaces;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Servicios
{
    public class ClienteService : IClienteService
    {

        private readonly IGenericRepository<Cliente> _clienteRepositorio;

        public ClienteService(IGenericRepository<Cliente> clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public async Task<bool> Actualizar(Cliente modelo)
        {
            try 
            {
                return await _clienteRepositorio.Actualizar(modelo);
            }
            catch
            {
                return false;
            }
           
        }

        public async Task<bool> Crear(Cliente modelo)
        {
            try 
            {
                return await _clienteRepositorio.Crear(modelo);
            } 
            catch 
            {
                return false;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                return await _clienteRepositorio.Eliminar(id);
            }
            catch 
            { 
                return false; 
            }
            
        }

        public async Task<Cliente> obtener(int id)
        {
            return await _clienteRepositorio.obtener(id);
        }

        public async Task<IQueryable<Cliente>> obtenerTodos()
        {
            return await _clienteRepositorio.obtenerTodos();
        }
    }
}
