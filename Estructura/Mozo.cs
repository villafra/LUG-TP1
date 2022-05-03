using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class Mozo : Empleado
    {
        public List<int> Puntos = new List<int>();
        public int Puntuación { get; set; }

        public Mozo(long dNI, string nombre, string apellido, DateTime fechaNacimiento, Turno NombreTurno) : base(dNI, nombre, apellido, fechaNacimiento, NombreTurno)
        {
            
        }

        public Mozo(int legajo, long dNI, string nombre, string apellido, DateTime fechaNacimiento, Turno turno) : base(legajo, dNI, nombre, apellido, fechaNacimiento, turno)
        {
        }

        public Mozo(int legajo, long dNI, string nombre, string apellido, DateTime fechaNacimiento, Turno turno, int puntuación) : base(legajo, dNI, nombre, apellido, fechaNacimiento, turno)
        { 
            Puntuación = puntuación;
        }

        public Mozo(int legajo, long dNI, string nombre, string apellido) : base(legajo, dNI, nombre, apellido)
        {
        }

        public double Average(Mozo mozo)
        {
            if (mozo.Puntos.Count != 0)
            {
                return mozo.Puntos.Average();
            }
            else
            {
                return 0;
            }
            
        }
    }
}
