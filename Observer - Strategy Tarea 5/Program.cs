using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Observer___Strategy_Tarea_5
{

    class Program
    {             
        public static void Main()
        {
            //List<int> numeros = new List<int>()
            //{
            //    1,2,3
            //};

            //int p = numeros.Sum();
            //Console.WriteLine(p);

            //Console.ReadKey();

            //List<int> numerosPares = numeros.FindAll(a=> a % 2 ==0);

            //numerosPares.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("--> Bienvenido al programita de la Empresa S.R.L <-- \n");

            Console.WriteLine("Pulse [1] para Crear Empleados <--");
            Console.WriteLine("Pulse [2] para Pagar a Empleados <--");
            Console.WriteLine("Pulse [3] para Afiliar a Empleados <--");
            Console.WriteLine("Pulse [4] para Desafiliar a Empleados <--");
            Console.WriteLine("Pulse [5] para Ver Listado Empleados <--");            

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion) 
            {
                case "1":
                    new Gestiones().CrearEmpleado(); 
                    break;

                case "2":
                    new Gestiones().PagarEmpleado();
                    break;

                case "3":
                    new Gestiones().AgregarInscripcionEmpleado();
                    break;

                case "4":
                    new Gestiones().QuitarInscripcionEmpleado();
                    break;

                case "5":
                    new Gestiones().ListadoEmpleados();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta !");
                    break;

            }

            Console.WriteLine("\nPulse una tecla para continuar..");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
