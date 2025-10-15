using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Interfaces
{
    public interface IProductoService
    {
        Task<bool> Crear(Producto modelo);
        Task<bool> Actualizar(Producto modelo);
        Task<bool> Eliminar(int id);
        Task<Producto> obtener(int id);
        Task<IQueryable<Producto>> obtenerTodos();
    }
}
