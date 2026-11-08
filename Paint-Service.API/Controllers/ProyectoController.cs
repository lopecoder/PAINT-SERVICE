using Microsoft.AspNetCore.Mvc;
using Paint_Service.API.Models.Entities;
using System.Linq;
namespace Paint_Service.API.Controllers
{
    [ApiController]
    [Route("api/proyectos")]
    public class ProyectoController : ControllerBase
    {
        private static readonly List<Proyecto> _proyectos = new List<Proyecto>
        {
            new Proyecto
            {
                ID = 1,
                NombreProyecto = "Pintura Casa",
                FechaInicio = "2026-11-01",
                FechaFin = "2026-11-05",
                Costo = 15000
            }
        };

        // GET: api/proyectos
        [HttpGet]
        public ActionResult<IEnumerable<Proyecto>> GetAll()
        {
            return Ok(_proyectos);
        }

        // GET: api/proyectos/1
        [HttpGet("{id}")]
        public ActionResult<Proyecto> GetById(int id)
        {
            var proyecto = _proyectos.FirstOrDefault(p => p.ID == id);

            if (proyecto == null)
            {
                return NotFound();
            }

            return Ok(proyecto);
        }

        // POST: api/proyectos
        [HttpPost]
        public ActionResult<Proyecto> Create(Proyecto proyecto)
        {
            int newId = _proyectos.Any()
                ? _proyectos.Max(p => p.ID) + 1
                : 1;

            proyecto.ID = newId;

            _proyectos.Add(proyecto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = proyecto.ID },
                proyecto);
        }

        // PUT: api/proyectos/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Proyecto proyecto)
        {
            var existing = _proyectos.FirstOrDefault(p => p.ID == id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.NombreProyecto = proyecto.NombreProyecto;
            existing.FechaInicio = proyecto.FechaInicio;
            existing.FechaFin = proyecto.FechaFin;
            existing.Costo = proyecto.Costo;

            return NoContent();
        }

        // DELETE: api/proyectos/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var proyecto = _proyectos.FirstOrDefault(p => p.ID == id);

            if (proyecto == null)
            {
                return NotFound();
            }

            _proyectos.Remove(proyecto);

            return NoContent();
        }
    }
}
