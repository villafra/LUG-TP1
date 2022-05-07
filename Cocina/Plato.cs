using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Plato :IStock
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }
        public int Stock { get; set; }

        public Plato(int codigo, string nombre, string tipo, string clase)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
        }

        public Plato(string nombre, string tipo, string clase)
        {
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
        }

        public void AgregarStock(int cantidad)
        {
            Stock += cantidad;
        }
    }
}
