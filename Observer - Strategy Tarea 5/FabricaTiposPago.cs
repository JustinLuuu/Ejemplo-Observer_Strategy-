using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    static class FabricaTiposPago
    {
        public static FormasPago FabricarFormasPago(string opcion)
        {
            if(opcion == "1")
            {
                return new PagoNormal();
            }
            else if(opcion == "2")
            {
                return new PagoFaseDos();
            }
            else if(opcion == "3")
            {
                return new PagoCuarentenaTotal();
            }
            else
            {
                return new PagoNormal();
            }

        }
         

    }
}
