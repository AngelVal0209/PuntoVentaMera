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
    public class ProveedorService : IProveedorService
    {

        private readonly IGenericRepository<Proveedor> _proveedorRepositorio;
        public ProveedorService(IGenericRepository<Proveedor> proveedorRepositorio)
        {
            _proveedorRepositorio = proveedorRepositorio;
        }
        public async Task<bool> Actualizar(Proveedor modelo)
        {
            return await _proveedorRepositorio.Actualizar(modelo);
        }

        public async Task<bool> Crear(Proveedor modelo)
        {
            return await _proveedorRepositorio.Crear(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _proveedorRepositorio.Eliminar(id);
        }

        public async Task<Proveedor> obtener(int id)
        {
            return await _proveedorRepositorio.obtener(id);
        }

        public async Task<IQueryable<Proveedor>> obtenerTodos()
        {
            return await _proveedorRepositorio.obtenerTodos();
        }
    }
}
