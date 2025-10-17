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
            return await _clienteRepositorio.Actualizar(modelo);
        }

        public async Task<bool> Crear(Cliente modelo)
        {
            return await _clienteRepositorio.Crear(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _clienteRepositorio.Eliminar(id);
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
