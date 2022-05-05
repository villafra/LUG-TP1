using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class Mesa
    {
        public List<Comensal> Ocupación = new List<Comensal>();
        public int Codigo { get; set; }
        public int NroDeMesa { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public int CantidadComensales { get; set; }

        public Mesa(int codigo, int Nrodemesa, int capacidad, string estado, int cantidadComensales)
        {
            Codigo = codigo;
            NroDeMesa = Nrodemesa;
            Capacidad = capacidad;
            Estado = estado;
            CantidadComensales = cantidadComensales;
        }

        public Mesa(int nroDeMesa, int capacidad, string estado, int cantidadComensales)
        {
            NroDeMesa = nroDeMesa;
            Capacidad = capacidad;
            Estado = estado;
            CantidadComensales = cantidadComensales;
        }

        public Mesa(int codigo, int nroDeMesa, int capacidad, string estado)
        {
            Codigo = codigo;
            NroDeMesa = nroDeMesa;
            Capacidad = capacidad;
            Estado = estado;
        }
    }
}
