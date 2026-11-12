using System.ComponentModel.DataAnnotations;

namespace Paint_Service_Application.DTOs
{
    public class ClienteDTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }
    }
}
