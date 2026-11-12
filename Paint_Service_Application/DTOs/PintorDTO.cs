using System.ComponentModel.DataAnnotations;

namespace Paint_Service_Application.DTOs
{
    public class PintorDTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Especialidad { get; set; }

        public bool Disponibilidad { get; set; }
    }
}
