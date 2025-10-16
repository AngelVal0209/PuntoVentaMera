using Microsoft.AspNetCore.Mvc;
using Proyecto.BLL.Interfaces;
using Proyecto.MODELS;
using Proyecto.WEB.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.WEB.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioService.obtenerTodos();

            var usuariosVM = usuarios.Select(u => new UsuarioViewModel
            {
                IdUsuario = u.IdUsuario,
                Nombre = u.Nombre,
                Usuario1 = u.Usuario1,
                Clave = u.Clave,
                IdRol = u.IdRol,
                NombreRol = u.IdRolNavigation.Nombre,
                FechaCreacion = u.FechaCreacion,
                Activo = true 
            }).ToList();

            return View(usuariosVM);
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var usuario = await _usuarioService.obtener(id);
            if (usuario == null) return NotFound();

            var usuarioVM = new UsuarioViewModel
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Usuario1 = usuario.Usuario1,
                Clave = usuario.Clave,
                IdRol = usuario.IdRol,
                NombreRol = usuario.IdRolNavigation?.Nombre,
                FechaCreacion = usuario.FechaCreacion,
                Activo = true
            };

            return View(usuarioVM);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioViewModel usuarioVM)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    Nombre = usuarioVM.Nombre,
                    Usuario1 = usuarioVM.Usuario1,
                    Clave = usuarioVM.Clave,
                    IdRol = usuarioVM.IdRol,
                    FechaCreacion = DateTime.Now
                };

                await _usuarioService.Crear(usuario);
                return RedirectToAction(nameof(Index));
            }

            return View(usuarioVM);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var usuario = await _usuarioService.obtener(id);
            if (usuario == null) return NotFound();

            var usuarioVM = new UsuarioViewModel
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Usuario1 = usuario.Usuario1,
                Clave = usuario.Clave,
                IdRol = usuario.IdRol,
                NombreRol = usuario.IdRolNavigation?.Nombre,
                FechaCreacion = usuario.FechaCreacion,
                Activo = true
            };

            return View(usuarioVM);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UsuarioViewModel usuarioVM)
        {
            if (id != usuarioVM.IdUsuario) return BadRequest();

            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    IdUsuario = usuarioVM.IdUsuario,
                    Nombre = usuarioVM.Nombre,
                    Usuario1 = usuarioVM.Usuario1,
                    Clave = usuarioVM.Clave,
                    IdRol = usuarioVM.IdRol,
                    FechaCreacion = usuarioVM.FechaCreacion
                };

                await _usuarioService.Actualizar(usuario);
                return RedirectToAction(nameof(Index));
            }

            return View(usuarioVM);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var usuario = await _usuarioService.obtener(id);
            if (usuario == null) return NotFound();

            var usuarioVM = new UsuarioViewModel
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Usuario1 = usuario.Usuario1,
                IdRol = usuario.IdRol,
                NombreRol = usuario.IdRolNavigation?.Nombre,
                FechaCreacion = usuario.FechaCreacion,
                Activo = true
            };

            return View(usuarioVM);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _usuarioService.Eliminar(id);
            return RedirectToAction("Index", "Productos");
        }
    }
}
