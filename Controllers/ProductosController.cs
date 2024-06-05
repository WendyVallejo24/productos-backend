using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoUsabilidad.Data;
using proyectoUsabilidad.DTO;
using proyectoUsabilidad.Models;

namespace proyectoUsabilidad.Controllers
{
    [Route("api/productos")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class ProductosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> GetProductos()
        {
            var productos = await _context.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .Include(p => p.UnidadMedida)
                .ToListAsync();
            return productos;
        }

        [HttpGet("{id}", Name = nameof(GetProductosById))]
        public async Task<ActionResult<Productos>> GetProductosById(int id)
        {
            var producto = await _context.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .Include(p => p.UnidadMedida)
                .FirstOrDefaultAsync(p => p.Codigo == id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpPost]
        public async Task<ActionResult<Productos>> PostProductos(ProductoUpdateDto productoDto)
        {
            // Validación de datos
            if (productoDto == null || string.IsNullOrEmpty(productoDto.Nombre) ||
                productoDto.Existencia <= 0 || productoDto.Precio <= 0.0 || 
                productoDto.IdCategoria <= 0 || productoDto.IdMarca <= 0 || 
                productoDto.IdUnidadMed <= 0)
            {
                return BadRequest("Datos inválidos.");
            }

            Productos nuevoProducto = new Productos
            {
                Nombre = productoDto.Nombre,
                Existencia = productoDto.Existencia,
                Precio = productoDto.Precio,
                IdCategoria = productoDto.IdCategoria,
                IdMarca = productoDto.IdMarca,
                IdUnidadMed = productoDto.IdUnidadMed
            };

            _context.Productos.Add(nuevoProducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductosById), new { id = nuevoProducto.Codigo }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductos(int id, ProductoUpdateDto productoDto)
        {
            if (id != productoDto.Codigo)
            {
                return BadRequest();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            // Validación de datos
            if (string.IsNullOrEmpty(productoDto.Nombre) ||
                productoDto.Existencia <= 0 || productoDto.Precio <= 0.0 ||
                productoDto.IdCategoria <= 0 || productoDto.IdMarca <= 0 || 
                productoDto.IdUnidadMed <= 0)
            {
                return BadRequest("Datos inválidos.");
            }

            producto.Nombre = productoDto.Nombre;
            producto.Existencia = productoDto.Existencia;
            producto.Precio = productoDto.Precio;
            producto.IdCategoria = productoDto.IdCategoria;
            producto.IdMarca = productoDto.IdMarca;
            producto.IdUnidadMed = productoDto.IdUnidadMed;

            _context.Entry(producto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductos(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
