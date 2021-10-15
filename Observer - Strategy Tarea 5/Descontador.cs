using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer___Strategy_Tarea_5
{
    class Descontador
    {
        List<IObservador> ListaDescontadores;

        public Descontador()
        {
            ListaDescontadores = new List<IObservador>();
        }

        public void AgregarAfilicacion(IObservador subAgregado)
        {
            ListaDescontadores.RemoveAll(a => a.GetType() == subAgregado.GetType());
            ListaDescontadores.Add(subAgregado);
        }

        public void EliminarAfiliacion(IObservador observador)
        {
            ListaDescontadores.RemoveAll(a => a.GetType() == observador.GetType());
        }

        public void NotificarSus(Empleado emp)
        {
            foreach (var subscriptor in ListaDescontadores)
            {
                subscriptor.Actualizar(emp);
            }
        }

        public bool ComprobarAfiliacion(IObservador observador)
        {
            return ListaDescontadores.Exists(x => x.GetType() == observador.GetType());
        }
    }
}