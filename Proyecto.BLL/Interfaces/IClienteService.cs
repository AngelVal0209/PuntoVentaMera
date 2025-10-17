using Proyecto.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BLL.Interfaces
{
    public interface IClienteService
    {
        Task<bool> Crear(Cliente modelo);
        Task<bool> Actualizar(Cliente modelo);
        Task<bool> Eliminar(int id);
        Task<Cliente> obtener(int id);
        Task<IQueryable<Cliente>> obtenerTodos();
    }
}
