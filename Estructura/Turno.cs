using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class Turno
    {
        public List<Mozo> ListaMozos = new List<Mozo>();

        public int Codigo { get; set; }
        public string NombreTurno { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }

        public Turno(int codigo, string nombreTurno, DateTime horaInicio, DateTime horaFin)
        {
            Codigo = codigo;
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

        public Turno(string nombreTurno, DateTime horaInicio, DateTime horaFin)
        {
            NombreTurno = nombreTurno;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }


    }
}
