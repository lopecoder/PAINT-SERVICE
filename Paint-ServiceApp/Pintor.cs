using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_ServiceApp
{
    public class Pintor //Clase Pintor
    {
        private int _ID;
        private string _Nombre;
        private string _Especialidad;

        public Pintor(int ID, string Nombre, string Especialidad)//Constructor
        {
            _ID = ID;
            _Nombre = Nombre;
            _Especialidad = Especialidad;
        }

        public override string ToString()//Sobreescritura del metodo ToString para que sean visibles la info de la clase Pintor
        {
            return $"ID: {_ID}\nNombre: {_Nombre}\nEspecialidad: {_Especialidad}";
        }
    }


}
