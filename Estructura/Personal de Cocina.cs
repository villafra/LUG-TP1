using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class PersonalCocina : Empleado
    {
        public PersonalCocina(int dNI, string nombre, string apellido, DateTime fechaNacimiento, Turno NombreTurno) : base(dNI, nombre, apellido, fechaNacimiento, NombreTurno)
        {
        }
    }
}
