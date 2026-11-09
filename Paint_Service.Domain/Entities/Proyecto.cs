using System;

namespace Paint_Service.Domain.Entities.Entities
{
    public class Proyecto
    {
        // NO USE DATEONLY PARA PREVEER POSIBLES RETRASOS EN LOS PROYECTOS
        // ESTO LO DEJO A DISCRECIÓN DEL PINTOR Y LAS CIRCUNSTANCIAS

        public int ID { get; set; }
        public string NombreProyecto { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public double Costo { get; set; }

        public int ClienteID { get; set; }

        public Cliente? Cliente { get; set; }

        public ICollection<Servicio>? Servicios { get; set; }


        public Proyecto()
        {
        }
        public Proyecto(int id, string nombreProyecto, string fechaInicio, string fechaFin, double costo)
        {
            ID = id;
            NombreProyecto = nombreProyecto;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Costo = costo;
        }

        // Sobrescribir ToString()
        public override string ToString()
        {
            return $"Su ID del proyecto es: {ID}\n" +
                   $"Nombre del proyecto: {NombreProyecto}\n" +
                   $"Fecha de Inicio: {FechaInicio}\n" +
                   $"Fecha de Entrega: {FechaFin}\n" +
                   $"Costo Total: {Costo} $RD";
        }
    }
}
