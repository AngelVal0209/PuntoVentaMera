using Proyecto.BLL.Interfaces;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.BLL.Servicios
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IGenericRepository<Categorium> _categoriaRepositorio;

        public CategoriaService(IGenericRepository<Categorium> categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<bool> Crear(Categorium modelo)
        {
            return await _categoriaRepositorio.Crear(modelo);
        }

        public async Task<bool> Actualizar(Categorium modelo)
        {
            return await _categoriaRepositorio.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _categoriaRepositorio.Eliminar(id);
        }

        public async Task<Categorium> obtener(int id)
        {
            return await _categoriaRepositorio.obtener(id);
        }

        public async Task<IQueryable<Categorium>> obtenerTodos()
        {
            return await _categoriaRepositorio.obtenerTodos();
        }
    }
}
