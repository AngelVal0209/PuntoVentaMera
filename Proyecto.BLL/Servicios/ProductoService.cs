using Proyecto.BLL.Interfaces;
using Proyecto.DAL.Repositorio;
using Proyecto.MODELS;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.BLL.Servicios
{
    public class ProductoService : IProductoService
    {
        private readonly IGenericRepository<Producto> _productoRepositorio;

        public ProductoService(IGenericRepository<Producto> productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        public async Task<bool> Crear(Producto modelo)
        {
            try
            {
                return await _productoRepositorio.Crear(modelo);
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Actualizar(Producto modelo)
        {
            try
            {
                return await _productoRepositorio.Actualizar(modelo);
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
                return await _productoRepositorio.Eliminar(id);
            }
            catch
            {
                return false;
            }
        }

        public async Task<Producto> obtener(int id)
        {
            return await _productoRepositorio.obtener(id);
        }

        public async Task<IQueryable<Producto>> obtenerTodos()
        {
            return await _productoRepositorio.obtenerTodos();
        }
    }
}
