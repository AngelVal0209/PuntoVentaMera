using Microsoft.EntityFrameworkCore;
using Proyecto.DAL.DataContext;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.DAL.ModelosRepositorios
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly PuntoVentaContext _dbContext;
        private readonly DbSet<Usuario> _dbSet;

        public UsuarioRepository(PuntoVentaContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Usuario>();
        }

        public async Task<bool> Crear(Usuario modelo)
        {
            await _dbSet.AddAsync(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
            _dbSet.Update(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var modelo = await _dbSet.FindAsync(id);
            if (modelo == null)
                return false;

            _dbSet.Remove(modelo);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Usuario> obtener(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task<IQueryable<Usuario>> obtenerTodos()
        {
            return Task.FromResult(_dbSet.AsQueryable());
        }
    }
}
