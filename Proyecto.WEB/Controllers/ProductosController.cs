using Microsoft.AspNetCore.Mvc;
using Proyecto.BLL.Interfaces;
using Proyecto.MODELS;
using Proyecto.WEB.Models.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.WEB.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var productos = await _productoService.obtenerTodos();

            var productosVM = productos.Select(p => new ProductoViewModel
            {
                IdProducto = p.IdProducto,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                PrecioCompra = p.PrecioCompra,
                PrecioVenta = p.PrecioVenta,
                Stock = p.Stock,
                IdCategoria = p.IdCategoria,
                NombreCategoria = p.IdCategoriaNavigation.Nombre, // Incluimos ?
                Activo = p.Activo ?? false,
                CodigoBarras = p.CodigoBarras
            }).ToList();

            return View(productosVM);
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var producto = await _productoService.obtener(id);
            if (producto == null) return NotFound();

            var productoVM = new ProductoViewModel
            {
                IdProducto = producto.IdProducto,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                PrecioCompra = producto.PrecioCompra,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                IdCategoria = producto.IdCategoria,
                NombreCategoria = producto.IdCategoriaNavigation?.Nombre,
                Activo = producto.Activo ?? false,
                CodigoBarras = producto.CodigoBarras
            };

            return View(productoVM);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductoViewModel productoVM)
        {
            if (ModelState.IsValid)
            {
                var producto = new Producto
                {
                    Nombre = productoVM.Nombre,
                    Descripcion = productoVM.Descripcion,
                    PrecioCompra = productoVM.PrecioCompra,
                    PrecioVenta = productoVM.PrecioVenta,
                    Stock = productoVM.Stock,
                    IdCategoria = productoVM.IdCategoria,
                    Activo = productoVM.Activo,
                    CodigoBarras = productoVM.CodigoBarras
                };

                await _productoService.Crear(producto);
                return RedirectToAction(nameof(Index));
            }

            return View(productoVM);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var producto = await _productoService.obtener(id);
            if (producto == null) return NotFound();

            var productoVM = new ProductoViewModel
            {
                IdProducto = producto.IdProducto,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                PrecioCompra = producto.PrecioCompra,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                IdCategoria = producto.IdCategoria,
                NombreCategoria = producto.IdCategoriaNavigation?.Nombre,
                Activo = producto.Activo ?? false,
                CodigoBarras = producto.CodigoBarras
            };

            return View(productoVM);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductoViewModel productoVM)
        {
            if (id != productoVM.IdProducto) return BadRequest();

            if (ModelState.IsValid)
            {
                var producto = new Producto
                {
                    IdProducto = productoVM.IdProducto,
                    Nombre = productoVM.Nombre,
                    Descripcion = productoVM.Descripcion,
                    PrecioCompra = productoVM.PrecioCompra,
                    PrecioVenta = productoVM.PrecioVenta,
                    Stock = productoVM.Stock,
                    IdCategoria = productoVM.IdCategoria,
                    Activo = productoVM.Activo,
                    CodigoBarras = productoVM.CodigoBarras
                };

                await _productoService.Actualizar(producto);
                return RedirectToAction(nameof(Index));
            }

            return View(productoVM);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _productoService.obtener(id);
            if (producto == null) return NotFound();

            var productoVM = new ProductoViewModel
            {
                IdProducto = producto.IdProducto,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                PrecioCompra = producto.PrecioCompra,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                IdCategoria = producto.IdCategoria,
                NombreCategoria = producto.IdCategoriaNavigation?.Nombre,
                Activo = producto.Activo ?? false,
                CodigoBarras = producto.CodigoBarras
            };

            return View(productoVM);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _productoService.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
