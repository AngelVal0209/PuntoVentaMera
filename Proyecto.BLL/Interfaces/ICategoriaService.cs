using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Interfaces
{
    public interface ICategoriaService
    {
        Task<bool> Crear(Categorium modelo);
        Task<bool> Actualizar(Categorium modelo);
        Task<bool> Eliminar(int id);
        Task<Categorium> obtener(int id);
        Task<IQueryable<Categorium>> obtenerTodos();
    }
}
