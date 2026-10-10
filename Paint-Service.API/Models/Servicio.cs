using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_Service.API.Models
{
    public class Servicio
    {
        private int _ID;
        private string _TipoTrabajo;
        private string _Fecha; //IMPLEMENTAR FORMA DE QUE LA FECHA SE ASIGNE AUTOMATICAMENTE
        private string _Materiales;
        private double _Costo;
        private int _Proyecto_id; //IMPLEMENTAR COMO ASIGNAR LA INFORMACION DE ID DE LA CLASE PROYECTO A royecto_id

        public Servicio(int ID, string TipoTrabajo, string Fecha, string Materiales, double Costo, int Proyecto_id)
        {
            _ID = ID;
            _TipoTrabajo = TipoTrabajo;
            _Materiales = Materiales;
            _Costo = Costo;
            _Proyecto_id = Proyecto_id;

        }


        public override string ToString()
        {
            return $"ID: {_ID}\nTipo de trabajo: {_TipoTrabajo}\nMateriales: {_Materiales}\nCosto: {_Costo}\nProyecto_ID: {_Proyecto_id}";
        }

    }
}
