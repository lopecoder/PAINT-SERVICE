using System;

namespace Paint_Service.API.Models
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

        // Constructor vacío requerido para ASP.NET y Swagger
        public Proyecto()
        {
        }

        // Constructor con parámetros
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
