using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexión
{
    public class Login
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

        public Login(int iD, string usuario, string pass)
        {
            ID = iD;
            Usuario = usuario;
            Pass = pass;
        }

        public string ValidarIngreso(string usuario, string contraseña)
        {
            if (ValidarUsuario(usuario))
            {
                if (ValidarPass(contraseña))
                {
                    return "Acceso Concedido";
                }
                else
                {
                    return "La contraseña es incorrecta";
                }
            }
            else
            {
                return "Usuario no Registrado en el sistema.";
            }
        }
        public bool ValidarUsuario(string usuario)
        {
            return Usuario == usuario;
        }

        public bool ValidarPass(string pass)
        {
            return Pass == pass;
        }
    }
}
