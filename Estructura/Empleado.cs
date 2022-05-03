using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public abstract class Empleado
    {
        public Turno turno;
        public int Legajo { get; set; }
        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected Empleado(int legajo, long dNI, string nombre, string apellido, DateTime fechaNacimiento,Turno turno)
        {
            Legajo = legajo;
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            this.turno = turno;
        }

        public Empleado(long dNI, string nombre, string apellido, DateTime fechaNacimiento, Turno turno)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            this.turno = turno;

        }

        protected Empleado(int legajo, long dNI, string nombre, string apellido)
        {
            Legajo = legajo;
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int DevolverEdad(DateTime FechaNacimiento)
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month)
            {
                edad -= 1;
            }
            if (FechaNacimiento.Month==DateTime.Now.Month && DateTime.Now.Day < FechaNacimiento.Day)
            {
                edad -= 1;
            }
            return edad;
        }
    }
}
