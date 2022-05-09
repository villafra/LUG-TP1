using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Plato
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }
        public int Stock { get; set; }
        public decimal Costo { get; set; }

        public Plato(int codigo, string nombre, string tipo, string clase, decimal costo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
            Costo = costo;
        }

        public Plato(int codigo, string nombre, string tipo, string clase, int stock, decimal costo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
            Stock = stock;
            Costo = costo;
        }

        public Plato(string nombre, string tipo, string clase, int stock, decimal costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
            Stock = stock;
            Costo = costo;
        }

        public Plato(string nombre, string tipo, string clase, decimal costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
            Costo = costo;
        }

    }
}
