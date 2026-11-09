using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_Service.API.Models.Entities
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
        public ICollection<Proyecto>? Proyectos { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\nNombre: {Nombre}\nTelefono: {Telefono}\nDireccion: {Direccion}";
        }
    }
}
