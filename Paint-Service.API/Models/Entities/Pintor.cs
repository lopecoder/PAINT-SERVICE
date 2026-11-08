using System;

namespace Paint_Service.API.Models.Entities
{
    public class Pintor
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Especialidad { get; set; }

        public bool Disponibilidad { get; set; }

       
        public Pintor(int id, string nombre, string especialidad, bool disponibilidad)
        {
            ID = id;
            Nombre = nombre;
            Especialidad = especialidad;
            Disponibilidad = disponibilidad;
        }

        // Sobreescritura del método ToString()
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Especialidad: {Especialidad}\n" +
                   $"Disponibilidad: {Disponibilidad}";
        }
    }
}

