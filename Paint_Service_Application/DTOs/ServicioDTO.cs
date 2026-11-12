using System.ComponentModel.DataAnnotations;

namespace Paint_Service_Application.DTOs
{
    public class ServicioDTO
    {

        
            public int ID { get; set; }

            [Required]
            [StringLength(100)]
            public string TipoTrabajo { get; set; }

            [Required]
            public string Fecha { get; set; }

            [Required]
            [StringLength(200)]
            public string Materiales { get; set; }

            [Range(1, double.MaxValue)]
            public double Costo { get; set; }

            [Required]
            public int ProyectoID { get; set; }
        }
}
