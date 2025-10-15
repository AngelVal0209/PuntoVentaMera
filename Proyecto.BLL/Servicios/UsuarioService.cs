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
        private readonly IGenericRepository<Usuario> _repository;
        public UsuarioService(IGenericRepository<Usuario> _usuarioRepo)
        {
            _repository = _usuarioRepo;
        }
        public async Task<bool> Actualizar(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Crear(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> obtener(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Usuario>> obtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
