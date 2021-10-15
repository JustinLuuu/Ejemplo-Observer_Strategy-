using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class ContextoPago
    {
        private FormasPago pagoAlgoritmo;

        public ContextoPago(FormasPago pagoAlgoritmo)
        {
            this.pagoAlgoritmo = pagoAlgoritmo;
        }

        public void RealizarPago(Empleado empleado)
        {          
            pagoAlgoritmo.Pago(empleado);
            empleado.SUSCRIPTORES.NotificarSus(empleado);
           //empleado.NotificarSub();
        }

    }
}
