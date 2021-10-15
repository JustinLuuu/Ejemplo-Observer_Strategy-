using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class Empleado
    {
        public string NOMBRE { get; set; }
        public int HORASLABURO { get; set; }
        public double PRECIOHORA { get; set; }
        public double SALARIOTOTAL { get; set; }

        public Descontador SUSCRIPTORES = new Descontador();   
            
        public Empleado(string nombre)
        {
            NOMBRE = nombre;
            HORASLABURO = 7;
            PRECIOHORA = 500;
        }           
      
        public override string ToString()
        {
            return string.Format($"por lo que el empleado {NOMBRE} tiene un salario total de: {SALARIOTOTAL} RD$");
        }

    }   
}
