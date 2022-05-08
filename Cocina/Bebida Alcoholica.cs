using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Bebida_Alcoholica : Bebida
    {
        public double GraduaciónAlcoholica { get; set; }
        public Bebida_Alcoholica(string nombre, string tipo, string presentación, decimal precio, int stock, double graduacion) : base(nombre, tipo, presentación, precio, stock)
        {
            GraduaciónAlcoholica = graduacion;
        }

        public Bebida_Alcoholica(int codigo, string nombre, string tipo, string presentación, decimal precio, int stock, double graduacion) : base(codigo, nombre, tipo, presentación, precio, stock)
        {
            GraduaciónAlcoholica = graduacion;
        }

       

      

    }
}
