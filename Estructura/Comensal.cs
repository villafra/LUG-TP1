using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    public class Comensal
    {
        public int Codigo { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }

        public Comensal(string email)
        {
            Email = email;
        }

        public Comensal(string usuario, string email) 
        {
            Usuario = usuario;
            Email = email;
        }
    }
}
