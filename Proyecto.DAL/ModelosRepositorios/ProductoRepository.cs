using Microsoft.EntityFrameworkCore;
using Proyecto.DAL.DataContext;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DAL.ModelosRepositorios
{
    public class ProductoRepository : IGenericRepository<Producto>
    {
        private readonly PuntoVentaContext _dbContext;

        public ProductoRepository(PuntoVentaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Crear(Producto modelo)
        {
            await _dbContext.Productos.AddAsync(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Actualizar(Producto modelo)
        {
            _dbContext.Productos.Update(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var modelo = await _dbContext.Productos.FirstOrDefaultAsync(p => p.IdProducto == id);
            if (modelo == null)
                return false;

            _dbContext.Productos.Remove(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Producto> obtener(int id)
        {
            return await _dbContext.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.MovimientoStocks)
                .FirstOrDefaultAsync(p => p.IdProducto == id);
        }

        public Task<IQueryable<Producto>> obtenerTodos()
        {
            IQueryable<Producto> query = _dbContext.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.MovimientoStocks);
            return Task.FromResult(query);
        }
    }
}
