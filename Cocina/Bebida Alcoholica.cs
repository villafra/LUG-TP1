using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Bebida_Alcoholica : Bebida
    {
        public decimal GraduaciónAlcoholica { get; set; }

        public Bebida_Alcoholica(int codigo, string nombre, string tipo, string presentación, double precio, decimal graduaciónalcoholica) : base(codigo, nombre, tipo, presentación, precio)
        {
            GraduaciónAlcoholica = graduaciónalcoholica;
        }

    }
}
