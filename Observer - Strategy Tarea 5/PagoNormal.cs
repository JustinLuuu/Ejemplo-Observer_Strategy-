using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class PagoNormal : FormasPago
    {       
        public override void Pago(Empleado empleado)
        {
            salarioDiario = empleado.HORASLABURO * empleado.PRECIOHORA;
            salarioSubTotal = salarioDiario * 30;
            empleado.SALARIOTOTAL = salarioSubTotal - (salarioSubTotal * AFP) - (salarioSubTotal * ARS);

            Console.WriteLine("[ Pago en terminos de Tiempos Normales ] \n");

            Console.WriteLine($"Se le descontó un {AFP}% de descuento aplicando AFP y {ARS}% de descuento aplicando ARS,");
            Console.WriteLine(empleado);
        }

    }
}
