using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class Cooperativa : IObservador
    {
        public void Actualizar(Empleado empleado)
        {
            empleado.SALARIOTOTAL -= empleado.SALARIOTOTAL * 0.20;
            Console.WriteLine(this);
            Console.WriteLine(empleado);
        }   

        public override string ToString()
        {
            return string.Format($"\n↓ Este esta afiliado a la Cooperativa por lo que se le ha aplicado un 0.19% de descuento ↓");
        }
    }
}
