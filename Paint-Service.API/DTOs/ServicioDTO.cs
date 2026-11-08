namespace Paint_Service.API.DTOs
{
    public class ServicioDTO
    {
        public int ID { get; set; }
        public string TipoTrabajo { get; set; }
        public string Fecha { get; set; }
        public string Materiales { get; set; }
        public double Costo { get; set; }
        public int Proyecto_id { get; set; }
    }
}
