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
        public List<Comensal> CantidadDeComensales { get; set; }
        public bool Estado { get; set; }

        public Reserva(int codigo, Mesa mesaReservada, DateTime fechaReserva, bool estado)
        {
            Codigo = codigo;
            MesaReservada = mesaReservada;
            FechaReserva = fechaReserva;
            Estado = estado;
        }

        public Reserva(int codigo, Mesa mesaReservada, Pedido pedidoReservado, DateTime fechaReserva, List<Comensal> cantidadDeComensales, bool estado)
        {
            Codigo = codigo;
            MesaReservada = mesaReservada;
            PedidoReservado = pedidoReservado;
            FechaReserva = fechaReserva;
            CantidadDeComensales = cantidadDeComensales;
            Estado = estado;
        }
    }
}
