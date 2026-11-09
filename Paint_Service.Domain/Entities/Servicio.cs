using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_Service.Domain.Entities.Entities
{

    public class Servicio
    {
        public int ID { get; set; }
        public string TipoTrabajo { get; set; }
        public string Fecha { get; set; }
        public string Materiales { get; set; }
        public double Costo { get; set; }
        public int ProyectoID { get; set; }

        public Proyecto? Proyecto { get; set; }

        //public Servicio(int id, string tipoTrabajo, string fecha, string materiales, double costo, int proyecto_id)
        //{
        //    ID = id;
        //    TipoTrabajo = tipoTrabajo;
        //    Fecha = fecha;
        //    Materiales = materiales;
        //    Costo = costo;
        //    Proyecto_id = proyecto_id;
        //} // 

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Tipo de trabajo: {TipoTrabajo}\n" +
                   $"Fecha: {Fecha}\n" +
                   $"Materiales: {Materiales}\n" +
                   $"Costo: {Costo}\n" +
                   $"Proyecto_ID: {ProyectoID}";
        }
    }
}
