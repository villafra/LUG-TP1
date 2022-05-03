using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Bebida : IStock
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Presentación { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Bebida(int codigo, string nombre, string tipo, string presentación, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Presentación = presentación;
            Precio = precio;
        }

        public void AgregarStock(int cantidad)
        {
            Stock += cantidad;
        }
    }
}
