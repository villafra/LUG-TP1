using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Negocio
{
    public class PedidoCancelado
    {
        public int ID { get; set; }
        public int Codigo_Pedido { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; }

        public PedidoCancelado(int iD, int codigo_Pedido, decimal monto, string motivo)
        {
            ID = iD;
            Codigo_Pedido = codigo_Pedido;
            Monto = monto;
            Motivo = motivo;
        }

        public PedidoCancelado(int codigo_Pedido, decimal monto)
        {
            Codigo_Pedido = codigo_Pedido;
            Monto = monto;
            Motivo = AgregarMotivo();
        }

        private string AgregarMotivo()
        {
            string motivo;

            motivo = Interaction.InputBox("Ingrese Motivo: ", "Restó");
            while (motivo == "")
            {
                motivo = Interaction.InputBox("Ingrese Motivo: ", "Restó");
            }
            return motivo;
        }
    }

}
