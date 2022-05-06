using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Plato
    {
        public List<Ingrediente>Ingredientes = new List<Ingrediente>();
        public Ingrediente Principal;
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }

        public Plato(int codigo, string nombre, string tipo, string clase)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
        }

        public Plato(Ingrediente principal, int codigo, string nombre, string tipo, string clase)
        {
            Principal = principal;
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
        }

        public Plato(List<Ingrediente> ingredientes, Ingrediente principal, int codigo, string nombre, string tipo, string clase)
        {
            Ingredientes = ingredientes;
            Principal = principal;
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            Clase = clase;
        }
    }
}
