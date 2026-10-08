using Paint_ServiceApp;
using static Paint_ServiceApp.Clientes;
using static Paint_ServiceApp.Proyecto;




//Instanciando clase Proyectos

Console.Write("Ingrese Fecha de inicio del proyecto: ");
string FechaInicio = Console.ReadLine();
Console.Write("Ingrese Fecha de Entrega del proyecto: ");
string FechaFinal = Console.ReadLine();
var Proyecto1 = new Proyecto(1, "Casa_Lopez", FechaInicio, FechaFinal, 25000.45);
Console.WriteLine(Proyecto1);



//Console.WriteLine("Hello, World!");
//Instanciar clase Clientes

//var Cliente1 = new Cliente(1, "Alberto", "809-549-6895", "Virginia Ortea #18 Los Prados");

//// Sobreescribir el la clase Clientes para ver parametros
//Console.WriteLine(Cliente1);


