using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    static class TablitaLogica
    {
        private static List<Empleado> ListaEmpleados = new List<Empleado>() 
        { 
             
        };

        public static Empleado DevolverEmpleado(int empleadoId)
        {
            if(empleadoId < ListaEmpleados.Count && empleadoId >=0)
            {
                return ListaEmpleados[empleadoId];
            }
            else
            {
                return null;
            }
        }

       
        public static void Guardar(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
        }

        public static bool Any()
        {
            return ListaEmpleados.Any();
        }

        public static void DevolverListado()
        {
           for(int i =0; i < ListaEmpleados.Count; i++)
           {              
               Console.WriteLine($"----- [ Empleado #{i} ] ----- \n");
               Console.WriteLine($"Nombre: {ListaEmpleados[i].NOMBRE}");
               Console.WriteLine($"Horas de laburo: {ListaEmpleados[i].HORASLABURO}");
               Console.WriteLine($"Pago x Hora: {ListaEmpleados[i].PRECIOHORA}");
               Console.WriteLine($"Afilicion a Cooperativa : {ListaEmpleados[i].SUSCRIPTORES.ComprobarAfiliacion(new Cooperativa())}");
               Console.WriteLine($"Afilicion al Plan Funerario : {ListaEmpleados[i].SUSCRIPTORES.ComprobarAfiliacion(new Funeraria())}");

               Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
           }         
           
        }
    
        
    }

}
