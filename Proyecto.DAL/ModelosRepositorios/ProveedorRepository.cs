using Proyecto.DAL.DataContext;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAL.ModelosRepositorios
{
    public class ProveedorRepository : IGenericRepository<Proveedor>
    {
        private readonly PuntoVentaContext _dbContext;

        public ProveedorRepository(PuntoVentaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Crear(Proveedor modelo)
        {
            await _dbContext.Proveedors.AddAsync(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Actualizar(Proveedor modelo)
        {
            _dbContext.Proveedors.Update(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var modelo = await _dbContext.Proveedors.FirstOrDefaultAsync(c => c.IdProveedor == id);
            if (modelo == null)
                return false;

            _dbContext.Proveedors.Remove(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Proveedor> obtener(int id)
        {
            return await _dbContext.Proveedors.FindAsync(id);
        }

        public Task<IQueryable<Proveedor>> obtenerTodos()
        {
            return Task.FromResult(_dbContext.Proveedors.AsQueryable());
        }
    }
}
