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
        public string UnidadMedida { get; set; }
        public int Stock { get; set; }

        public Ingrediente(int codigo, string nombre, string tipo, bool refrigeración, string unidadMedida, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Refrigeración = refrigeración;
            UnidadMedida = unidadMedida;
            Stock = stock;
        }

        public Ingrediente(string nombre, string tipo, bool refrigeración, string unidadMedida, int stock)
        {
            Nombre = nombre;
            Tipo = tipo;
            Refrigeración = refrigeración;
            UnidadMedida = unidadMedida;
            Stock = stock;
        }

        public void AgregarStock(int cantidad)
        {
            Stock += cantidad;
        }

        public int DevolverRefrigeracion(Ingrediente ingrediente)
        {
            int booleano = 0;
            if (ingrediente.Refrigeración == true)
            {
                booleano= 1;
            }
            return booleano;
        }
    }
}
