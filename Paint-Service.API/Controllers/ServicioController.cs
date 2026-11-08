using Microsoft.AspNetCore.Mvc;
using Paint_Service.API.Models.Entities;
using System.Linq;

namespace Paint_Service.API.Controllers
{
    [ApiController]
    [Route("api/servicios")]
    public class ServicioController : ControllerBase
    {
        private static readonly List<Servicio> _servicios = new List<Servicio>
        {
            new Servicio
            (
                1,
                "Pintura Interior",
                "06/10/2026",
                "Pintura Blanca y Rodillo",
                5000,
                1
            )
        };

        // GET: api/servicios
        [HttpGet]
        public ActionResult<IEnumerable<Servicio>> GetAll()
        {
            return Ok(_servicios);
        }

        // GET: api/servicios/1
        [HttpGet("{id}")]
        public ActionResult<Servicio> GetById(int id)
        {
            var servicio = _servicios.FirstOrDefault(s => s.ID == id);

            if (servicio == null)
            {
                return NotFound();
            }

            return Ok(servicio);
        }

        // POST: api/servicios
        [HttpPost]
        public ActionResult<Servicio> Create(Servicio servicio)
        {
            int newId = _servicios.Any()
                ? _servicios.Max(s => s.ID) + 1
                : 1;

            servicio.ID = newId;

            _servicios.Add(servicio);

            return CreatedAtAction(
                nameof(GetById),
                new { id = servicio.ID },
                servicio
            );
        }

        // PUT: api/servicios/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Servicio servicio)
        {
            var existing = _servicios.FirstOrDefault(s => s.ID == id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.TipoTrabajo = servicio.TipoTrabajo;
            existing.Fecha = servicio.Fecha;
            existing.Materiales = servicio.Materiales;
            existing.Costo = servicio.Costo;
            existing.Proyecto_id = servicio.Proyecto_id;

            return NoContent();
        }

        // DELETE: api/servicios/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var servicio = _servicios.FirstOrDefault(s => s.ID == id);

            if (servicio == null)
            {
                return NotFound();
            }

            _servicios.Remove(servicio);

            return NoContent();
        }
    }
}
