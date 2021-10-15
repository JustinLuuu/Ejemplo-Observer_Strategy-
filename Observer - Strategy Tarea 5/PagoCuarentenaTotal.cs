using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class PagoCuarentenaTotal : FormasPago
    {
        public override void Pago(Empleado empleado)
        {
            salarioDiario = empleado.HORASLABURO * empleado.PRECIOHORA;
            salarioSubTotal = salarioDiario * 7;
            empleado.SALARIOTOTAL = salarioSubTotal;

            Console.WriteLine("[ Pago en terminos de Cuarentena Total ] \n");

            Console.WriteLine("No se le ha aplicado descuentos,");
            Console.WriteLine(empleado);

        }

    }
}
