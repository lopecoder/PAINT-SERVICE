using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_Service.API.Models
{
    public class Proyecto
    {
        //NO USE DATEONLY PARA PREVEER POSIBLES RETRASOS EN LOS PROYECTOS TANTO EN SU COMIENZO COMO EN SU ENTREGA
        //ESTO LO DEJO A DISCRECION DEL PINTOR Y LAS CIRCUSNTANCIAS
        //IMPLEMENTAR FUNCIONALIDAD QUE LE PERMITA AL PINTOR INDICAR LA FECHA DE INICIO Y LA FECHA DE ENTREGA Y LUEGO VINCULAR
        private int _ID;
        private string _NombreProyecto;
        private string _FechaInicio;
        private string  _FechaFin;
        private double _Costo;

        //Construccion del constructor mediante el ctor

        public Proyecto(int ID, string NombreProyecto, string FechaInicio, string FechaFin, double Costo)
        {
            _ID = ID;//Esto se hace para evitar tener que usar el this. segun Juan Z.
            _NombreProyecto = NombreProyecto;
            _FechaInicio = FechaInicio;
            _FechaFin = FechaFin;
            _Costo = Costo;
        }

        // Sobrescritura de la clase Proyecto, esto permite que la informacion sea legible en la consola
        // Mediante le Metodo ToString
        public override string ToString() 
        {
            return $"Su ID del proyecto es: {_ID}\nNombre del proyecto: {_NombreProyecto}\nFecha de Incio de proyecto: {_FechaInicio}\nFecha de Entrega: {_FechaFin}\nCosto Total: {_Costo} $RD";
        }
    }
}
