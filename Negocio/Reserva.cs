using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructura;

namespace Negocio
{
    public class Reserva
    {
        public int Codigo { get; set; }
        public Mesa MesaReservada { get; set; }
        public Pedido PedidoReservado { get; set; }
        public DateTime FechaReserva { get; set; }
        public int CantidadDeComensales { get; set; }
        public bool Estado { get; set; }

        public Reserva(int codigo, DateTime fechaReserva, int CantidaddeComensales ,bool estado)
        {
            Codigo = codigo;
            FechaReserva = fechaReserva;
            CantidadDeComensales = CantidaddeComensales;
            Estado = estado;
        }

        public Reserva(int codigo, Mesa mesaReservada, Pedido pedidoReservado, DateTime fechaReserva, int cantidadDeComensales, bool estado)
        {
            Codigo = codigo;
            MesaReservada = mesaReservada;
            PedidoReservado = pedidoReservado;
            FechaReserva = fechaReserva;
            CantidadDeComensales = cantidadDeComensales;
            Estado = estado;
        }
        public void AsignarMesa(Mesa mesa)
        {
            MesaReservada = mesa;
         
        }
    }
}
