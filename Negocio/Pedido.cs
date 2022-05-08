using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructura;
using Cocina;

namespace Negocio
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public Mesa CodigoMesa { get; set; }
        public Mozo CodigoMozo { get; set; }
        public DateTime FechaHoradeInicio { get; set; }
        public List<Plato> Platos = new List<Plato>();
        public List<Bebida> Bebidas = new List<Bebida>();
        public string Observaciones { get; set; }
        public decimal Monto { get; set; }
        public bool Activo { get; set; }

        public Pedido(Mesa codigoMesa, Mozo codigoMozo, DateTime fechaHoradeInicio, string observaciones, decimal monto, bool activo)
        {
            CodigoMesa = codigoMesa;
            CodigoMozo = codigoMozo;
            FechaHoradeInicio = fechaHoradeInicio;
            Observaciones = observaciones;
            Monto = monto;
            Activo = activo;
        }

        public Pedido(int numeroPedido, Mesa codigoMesa, Mozo codigoMozo, DateTime fechaHoradeInicio, string observaciones, decimal monto)
        {
            NumeroPedido = numeroPedido;
            CodigoMesa = codigoMesa;
            CodigoMozo = codigoMozo;
            FechaHoradeInicio = fechaHoradeInicio;
            Observaciones = observaciones;
            Monto = monto;
        }

        public Pedido(int numeroPedido, DateTime fechaHoradeInicio, string observaciones, decimal monto, bool activo)
        {
            NumeroPedido = numeroPedido;
            FechaHoradeInicio = fechaHoradeInicio;
            Observaciones = observaciones;
            Monto = monto;
            Activo = activo;
        }

        public Pedido(int numeroPedido, Mesa codigoMesa, Mozo codigoMozo, DateTime fechaHoradeInicio, string observaciones, decimal monto, bool activo) 
        {
            NumeroPedido = numeroPedido;
            CodigoMesa = codigoMesa;
            CodigoMozo = codigoMozo; 
            FechaHoradeInicio = fechaHoradeInicio;
            Observaciones = observaciones;
            Monto = monto;
            Activo = activo;
        }

        public void CalcularMonto()
        {
            Monto = 0;
            foreach(var plato in Platos)
            {
                Monto += plato.Costo;
            }
            foreach(var bebida in Bebidas)
            {
                Monto += bebida.Precio;
            }
        }
    }
}
