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
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Bebida(int codigo, string nombre, string tipo, string presentación, decimal precio, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Presentación = presentación;
            Precio = precio;
            Stock = stock;
        }

        public Bebida(string nombre, string tipo, string presentación, decimal precio, int stock)
        {
            Nombre = nombre;
            Tipo = tipo;
            Presentación = presentación;
            Precio = precio;
            Stock = stock;
        }

        public void AgregarStock(int cantidad)
        {
            Stock += cantidad;
        }

      
        
    }
}
