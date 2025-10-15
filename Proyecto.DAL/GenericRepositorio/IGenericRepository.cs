using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DAL.Repositorio
{
    public interface IGenericRepository<TEntityModel> where TEntityModel : class
    {
        Task<bool> Crear(TEntityModel modelo);
        Task<bool> Actualizar(TEntityModel modelo);
        Task<bool> Eliminar(int id);
        Task<TEntityModel> obtener(int id);
        Task<IQueryable<TEntityModel>> obtenerTodos();

    }
}
