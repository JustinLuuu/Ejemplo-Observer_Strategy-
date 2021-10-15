using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class Gestiones
    {
       private IObservador suscriptor;
       private Empleado empleado;
       private string opcion, entidad;
       private int choose;

        public void CrearEmpleado()
        {
            string nombre;
                
            Console.WriteLine("--> Set Para Crear Empleados <-- \n");

            Console.WriteLine("Diga el nombre del Empleado:");
            nombre = Console.ReadLine().ToUpper();          
            TablitaLogica.Guardar(new Empleado(nombre));

            Console.Clear();            

            Console.WriteLine("Pulse [1] para afiliar al empleado [{0}] a nuestras entidades" +
            " o Pulse [0] para ir al Menu Principal", nombre);
            opcion = Console.ReadLine();
            Console.Clear();

            if(opcion == "1")
            {
                AgregarInscripcionEmpleado();
            }
            else
            {
                Program.Main();
            }
          
        }

        public void PagarEmpleado()
        {
            ContextoPago contexto;

            Console.WriteLine("--> Set Para Pagar Empleados <-- \n");

            Console.WriteLine("Escriba [1] para Pago adecuado a Tiempos Normales");
            Console.WriteLine("Escriba [2] para Pago adecuado a Cuarentena Fase 2");
            Console.WriteLine("Escriba [3] para Pago adecuado a Cuarentena Total");
            opcion = Console.ReadLine();
            Console.Clear();
            
            contexto = new ContextoPago(FabricaTiposPago.FabricarFormasPago(opcion));

            if (TablitaLogica.Any())
            {                
                ListadoEmpleados();
                Console.WriteLine("Elija un Empleado conforme sea su # para pagarle:");
                choose = int.Parse(Console.ReadLine());
                empleado = TablitaLogica.DevolverEmpleado(choose);
                Console.Clear();

                if(empleado != null)
                {
                    contexto.RealizarPago(empleado);
                }
                else
                {
                    Console.WriteLine($"Ese # de empleado: [{choose}] no existe !");
                }
            }
            else
            {
                Console.WriteLine("Aun no se han creado Empleados !!");
            }
            
        }

        public void AgregarInscripcionEmpleado()
        {
            Console.WriteLine("--> Set Para Afiliar Empleados <-- \n");

            Console.WriteLine("Pulse [1] para Afiliar Empleado a Cooperativa");
            Console.WriteLine("Pulse [2] para Afiliar Empleado a Plan Funerario");
            opcion = Console.ReadLine();
            (entidad, suscriptor) = ReconocerEntidad(opcion);            
            Console.Clear();

            if (TablitaLogica.Any())    
            {
                if (suscriptor != null)
                {
                    ListadoEmpleados();
                    Console.WriteLine("Elija un Empleado conforme sea su # para afiliarlo a la entidad de [{0}]:", entidad);
                    choose = int.Parse(Console.ReadLine());
                    empleado = TablitaLogica.DevolverEmpleado(choose);
                    Console.Clear();

                    if (empleado != null) 
                    {
                        empleado.SUSCRIPTORES.AgregarAfilicacion(suscriptor);
                        Console.WriteLine("El empleado {0} fue afiliado con exito" +
                        " en la entidad de [{1}] ", empleado.NOMBRE, entidad);
                    }
                    else
                    {
                        Console.WriteLine($"Ese # de empleado: [{choose}] no existe !");
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta !");
                }
             
            }
            else
            {
                Console.WriteLine("No hay empleados creados todavia !");
            }
          
        }

        public void QuitarInscripcionEmpleado()
        {
            Console.WriteLine("--> Set Para Desafiliar Empleados <-- \n");

            Console.WriteLine("Pulse [1] para desafiliar Empleado a Cooperativa");
            Console.WriteLine("Pulse [2] para desafiliar Empleado a Plan Funerario");
            opcion = Console.ReadLine();
            (entidad, suscriptor) = ReconocerEntidad(opcion);
            Console.Clear();

            if (TablitaLogica.Any())
            {
                if (suscriptor != null)
                {
                    ListadoEmpleados();
                    Console.WriteLine("Elija un Empleado conforme sea su # para desafiliarlo de la entidad de [{0}]:", entidad);
                    choose = int.Parse(Console.ReadLine());
                    empleado = TablitaLogica.DevolverEmpleado(choose);
                    Console.Clear();

                    if (empleado != null)
                    {
                        empleado.SUSCRIPTORES.EliminarAfiliacion(suscriptor);
                        Console.WriteLine("El empleado {0} fue desafiliado con exito" +
                         " de la entidad de [{1}] ", empleado.NOMBRE, entidad);
                    }
                    else
                    {
                        Console.WriteLine($"Ese # de empleado: [{choose}] no existe !");
                    }
                }
                else
                {
                    Console.WriteLine("Opcion incorrecta !");
                }

            }
            else
            {
                Console.WriteLine("No hay empleados creados todavia !");
            }
        }


        public void ListadoEmpleados()
        {
            if (TablitaLogica.Any())
            {
                Console.WriteLine("--> Listado de Empleados <-- \n");

                TablitaLogica.DevolverListado();
            }
            else
            {
                Console.WriteLine("Aun no se han creado Empleados !!");
            }
        }


        private (string, IObservador) ReconocerEntidad(string opcion)
        {
            if (opcion == "1")
                return ("COOPERATIVA", new Cooperativa());
            else if (opcion == "2")
                return ("PLAN FUNERARIO", new Funeraria());

            return (null, null);
        }




    }
}
