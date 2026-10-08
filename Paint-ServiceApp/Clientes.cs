using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_ServiceApp
{
    public class Clientes
    {
        public class Cliente // COMO CREAR CLASE SEGUN LAS EXPLICACIONES DE JUAN ZULUAGA    
        {
            private int _ID { get; set; } //Los get y set no me afectaron el codigo 
            private string _Nombre { get; set; }
            private string _Telefono { get; set; }
            private string _Direccion { get; set; }

            public Cliente(int ID, string Nombre, string Telefono, string Direccion) //Constructor 
            {
                _ID = ID;
                _Nombre = Nombre;
                _Telefono = Telefono;
                _Direccion = Direccion;
            }

            //SOBREESCRITURA DEL METODO ToSring
            public override string ToString()
            {
                return $"ID: {_ID}\nNombre: {_Nombre}\nTelefono: {_Telefono}\nDireccion: {_Direccion}";
            }

        }

    }
}
