using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Ingrediente :IStock
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public bool Refrigeración { get; set; }
        public int Stock { get; set; }

        public void AgregarStock(int cantidad)
        {
            Stock += cantidad;
        }
    }
}
