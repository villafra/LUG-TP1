using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Transaccion
    {
        public int ID { get; set; }
        public int Pedido { get; set; }
        public DateTime FechayHora { get; set; }
        public decimal Monto { get; set; }
        public int Mesa { get; set; }
        public int Mozo { get; set; }

        public Transaccion(int iD, int pedido, DateTime fechayHora, decimal monto, int mesa, int mozo)
        {
            ID = iD;
            Pedido = pedido;
            FechayHora = fechayHora;
            Monto = monto;
            Mesa = mesa;
            Mozo = mozo;
        }

        public Transaccion(int pedido, DateTime fechayHora, decimal monto, int mesa, int mozo)
        {
            Pedido = pedido;
            FechayHora = fechayHora;
            Monto = monto;
            Mesa = mesa;
            Mozo = mozo;
        }
    }
}
