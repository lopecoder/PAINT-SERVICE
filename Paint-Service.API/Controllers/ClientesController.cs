using Microsoft.AspNetCore.Mvc;
using Paint_Service.API.Models; // Importa el namespace donde está la clase Cliente
using System.Linq;
using static Paint_Service.API.Models.Entities.Clientes;

namespace Paint_Service.API.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private static readonly List<Cliente> _clientes = new List<Cliente>
        {
            new Cliente { ID = 1, Nombre = "Juan Pérez", Telefono = "809-555-1234", Direccion = "Av. Máximo Gómez #45" },
            new Cliente { ID = 2, Nombre = "María Gómez", Telefono = "809-555-5678", Direccion = "Calle Duarte #120" },
            new Cliente { ID = 3, Nombre = "Carlos Rodríguez", Telefono = "809-555-9012", Direccion = "Av. Independencia #300" }
        };

        // GET: api/clientes
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetAll()
        {
            return Ok(_clientes);
        }

        // GET: api/clientes/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> GetById(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.ID == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST: api/clientes
        [HttpPost]
        public ActionResult<Cliente> Create(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return BadRequest("El nombre del cliente es obligatorio.");
            }

            int newId = _clientes.Any() ? _clientes.Max(c => c.ID) + 1 : 1;
            cliente.ID = newId;
            _clientes.Add(cliente);

            return CreatedAtAction(nameof(GetById), new { id = cliente.ID }, cliente);
        }

        
        [HttpPut("{id}")]
        public IActionResult Update(int id, Cliente cliente)
        {
            var existing = _clientes.FirstOrDefault(c => c.ID == id);
            if (existing == null)
            {
                return NotFound();
            }

            if (cliente.ID != id)
            {
                return BadRequest("El ID del cliente no coincide con la ruta.");
            }

            existing.Nombre = cliente.Nombre;
            existing.Telefono = cliente.Telefono;
            existing.Direccion = cliente.Direccion;

            return NoContent();
        }

        // DELETE: api/clientes/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.ID == id);
            if (cliente == null)
            {
                return NotFound();
            }

            _clientes.Remove(cliente);
            return NoContent();
        }

    }
}

