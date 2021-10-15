using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    abstract class FormasPago
    {
        protected double salarioDiario, salarioSubTotal; 
        protected const double AFP = 0.0287, ARS = 0.0304;

        public abstract void Pago(Empleado empleado);
    }
}
