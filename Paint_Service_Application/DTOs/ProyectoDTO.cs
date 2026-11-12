using System.ComponentModel.DataAnnotations;

namespace Paint_Service_Application.DTOs
{
    public class ProyectoDTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreProyecto { get; set; }

        [Required]
        public string FechaInicio { get; set; }

        [Required]
        public string FechaFin { get; set; }

        [Range(1, double.MaxValue)]
        public double Costo { get; set; }

        [Required]
        public int ClienteID { get; set; }
    }
}
