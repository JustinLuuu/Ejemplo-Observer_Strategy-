using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class PagoFaseDos : FormasPago
    {
        public override void Pago(Empleado empleado)
        {
            salarioDiario = empleado.HORASLABURO * empleado.PRECIOHORA;
            salarioSubTotal = salarioDiario * 15;
            empleado.SALARIOTOTAL = salarioSubTotal - (salarioSubTotal * ARS);

            Console.WriteLine("[ Pago en terminos de Cuarentena Fase 2 ] \n");

            Console.WriteLine($"Se le descontó un {ARS}% de descuento aplicando ARS,");
            Console.WriteLine(empleado);
        }

    }
}
