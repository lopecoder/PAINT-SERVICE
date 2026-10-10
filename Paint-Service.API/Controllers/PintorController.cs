using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Paint_Service.API.Models;
using System.Linq;


namespace Paint_Service.API.Controllers
{
    [ApiController]
    [Route("api/pintores")]
    public class PintoresController : ControllerBase
    {
        private static readonly List<Pintor> _pintores = new List<Pintor>
        {
            new Pintor { ID = 1, Nombre = "José Ramírez", Especialidad = "Interior", Disponibilidad = true },
            new Pintor { ID = 2, Nombre = "Ana López", Especialidad = "Exterior", Disponibilidad = false },
            new Pintor { ID = 3, Nombre = "Pedro Martínez", Especialidad = "Decorativo", Disponibilidad = true }
        };

        // GET: api/pintores
        [HttpGet]
        public ActionResult<IEnumerable<Pintor>> GetAll()
        {
            return Ok(_pintores);
        }

        // GET: api/pintores/5
        [HttpGet("{id}")]
        public ActionResult<Pintor> GetById(int id)
        {
            var pintor = _pintores.FirstOrDefault(p => p.ID == id);
            if (pintor == null)
            {
                return NotFound();
            }
            return Ok(pintor);
        }

        // POST: api/pintores
        [HttpPost]
        public ActionResult<Pintor> Create(Pintor pintor)
        {
            if (string.IsNullOrWhiteSpace(pintor.Nombre))
            {
                return BadRequest("El nombre del pintor es obligatorio.");
            }

            int newId = _pintores.Any() ? _pintores.Max(p => p.ID) + 1 : 1;
            pintor.ID = newId;
            _pintores.Add(pintor);

            return CreatedAtAction(nameof(GetById), new { id = pintor.ID }, pintor);
        }

        // PUT: api/pintores/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pintor pintor)
        {
            var existing = _pintores.FirstOrDefault(p => p.ID == id);
            if (existing == null)
            {
                return NotFound();
            }

            if (pintor.ID != id)
            {
                return BadRequest("El ID del pintor no coincide con la ruta.");
            }

            existing.Nombre = pintor.Nombre;
            existing.Especialidad = pintor.Especialidad;
            existing.Disponibilidad = pintor.Disponibilidad;

            return NoContent();
        }

        // DELETE: api/pintores/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pintor = _pintores.FirstOrDefault(p => p.ID == id);
            if (pintor == null)
            {
                return NotFound();
            }

            _pintores.Remove(pintor);
            return NoContent();
        }
    }

    // Clase modelo Pintor
    public class Pintor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
