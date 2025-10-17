using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Interfaces
{
    public interface IProveedorService
    {
        Task<bool> Crear(Proveedor modelo);
        Task<bool> Actualizar(Proveedor modelo);
        Task<bool> Eliminar(int id);
        Task<Proveedor> obtener(int id);
        Task<IQueryable<Proveedor>> obtenerTodos();
    }
}
