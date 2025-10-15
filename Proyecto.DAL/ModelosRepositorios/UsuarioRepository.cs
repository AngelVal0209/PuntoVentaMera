using Microsoft.EntityFrameworkCore;
using Proyecto.DAL.DataContext;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAL.ModelosRepositorios
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly PuntoVentaContext _dbContext;
        public UsuarioRepository (PuntoVentaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
            _dbContext.Usuarios.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Crear(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Usuario modelo = _dbContext.Usuarios.First(c => c.IdUsuario == id);
            _dbContext.Usuarios.Remove(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Usuario> obtener(int id)
        {
            return await _dbContext.Usuarios.FindAsync(id);
        }

        public async Task<IQueryable<Usuario>> obtenerTodos()
        {
            IQueryable<Usuario> queryUsuario = _dbContext.Usuarios;
            return queryUsuario;
        }
    }
}
