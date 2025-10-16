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
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _usuarioRepositorio;
        public UsuarioService(IGenericRepository<Usuario> usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<bool> Crear(Usuario modelo)
        {
            return await _usuarioRepositorio.Crear(modelo);
        }

        public async Task<bool> Actualizar(Usuario modelo)
        {
            return await _usuarioRepositorio.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _usuarioRepositorio.Eliminar(id);
        }

        public async Task<Usuario> obtener(int id)
        {
            return await _usuarioRepositorio.obtener(id);
        }

        public async Task<IQueryable<Usuario>> obtenerTodos()
        {
            return await _usuarioRepositorio.obtenerTodos();
        }
    }
}
