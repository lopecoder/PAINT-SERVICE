namespace Paint_Service.API.DTOs
{
    public class ProyectoDTO
    {
        public int ID { get; set; }
        public string NombreProyecto { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public double Costo { get; set; }
    }
}
