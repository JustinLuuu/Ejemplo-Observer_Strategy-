using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class Funeraria : IObservador
    {
        public void Actualizar(Empleado empleado)
        {
            if(empleado.SALARIOTOTAL > 750)
            {
                empleado.SALARIOTOTAL -= empleado.SALARIOTOTAL * 0.25;
                Console.WriteLine(this);
                Console.WriteLine(empleado);
            }
        }

        public override string ToString()
        {
            return string.Format($"\n↓ Este esta afiliado a la Funeraria por lo que se le ha aplicado un 0.25% de descuento ↓");
        }

    }
}
