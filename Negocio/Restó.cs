﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspecto;
using Estructura;
using Cocina;
using Conexión;
using System.Data;

namespace Negocio
{
    public class Restó
    {
        public List<Mesa> ListadeMesas = new List<Mesa>();
        public List<Pedido>ListadePedidos = new List<Pedido>();
        public List<Reserva>ListadeReservas = new List<Reserva>();
        public List<Plato> ListadePlatos = new List<Plato>();
        public List<Bebida> ListadeBebidas = new List<Bebida>();
        public List<Mozo>ListadeMozos = new List<Mozo>();
        public List<PersonalCocina>ListadePersonalCocina = new List<PersonalCocina>();
        public List<Turno> ListadeTurnos = new List<Turno>();
        List<Pedido> PedidosXplato = new List<Pedido>();
        Conectar conexion = new Conectar();

        #region Querys Listados

        public List<Mesa> QueryMesas()
        {
            string query = @"Select * from Mesa";
            ListadeMesas.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                Mesa nuevaMesa = new Mesa(Convert.ToInt32(row[0].ToString()), Convert.ToInt32(row[1].ToString()), Convert.ToInt32(row[2].ToString()), row[3].ToString(),  Convert.ToInt32(row[4].ToString()));
                ListadeMesas.Add(nuevaMesa);
            }
            return ListadeMesas;
        }
        public Mesa BuscarMesa(int nrodeMesa)
        {
            string query = @"select * from Mesa where Mesa.Nro_Mesa= " + nrodeMesa;
            Mesa nuevaMesa=null;
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                nuevaMesa = new Mesa(Convert.ToInt32(row[0].ToString()), Convert.ToInt32(row[1].ToString()), Convert.ToInt32(row[2].ToString()), row[3].ToString(), Convert.ToInt32(row[4].ToString()));
            }
            return nuevaMesa;
        }

        public List<Mozo> QueryMozos()
        {
            string query = @"select * from Mozo";
            ListadeMozos.Clear();
            foreach(DataRow row in conexion.DevolverListado(query).Rows)
            {
                Mozo nuevoMozo = new Mozo(Convert.ToInt32(row[0].ToString()), Convert.ToInt32(row[1].ToString()), row[2].ToString(), row[3].ToString(), Convert.ToDateTime(row[4].ToString()), BuscarTurno(Convert.ToInt32(row[5].ToString())));
                QueryPuntaje(nuevoMozo);
                nuevoMozo.Puntuación = Convert.ToInt32(nuevoMozo.Average(nuevoMozo));
                ListadeMozos.Add(nuevoMozo);
            }
            return ListadeMozos;
        }
        public Mozo BuscarMozo(int NrodeMozo)
        {
            string query = @"select * from Mozo where Mozo.Legajo= " + NrodeMozo;
            Mozo nuevoMozo = null;
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                nuevoMozo = new Mozo(Convert.ToInt32(row[0].ToString()), Convert.ToInt32(row[1].ToString()), row[2].ToString(), row[3].ToString(), Convert.ToDateTime(row[4].ToString()), BuscarTurno(Convert.ToInt32(row[5].ToString())));
                QueryPuntaje(nuevoMozo);
                nuevoMozo.Puntuación = Convert.ToInt32(nuevoMozo.Average(nuevoMozo));
            }
            return nuevoMozo;
        }
        public void QueryPuntaje(Mozo nuevoMozo)
        {
            string query = @"select Mozo_Puntuacion.Puntuacion from Mozo_Puntuacion where Legajo_Mozo= " + nuevoMozo.Legajo;
            nuevoMozo.Puntos.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                nuevoMozo.Puntos.Add(Convert.ToInt32(row[0].ToString()));
            }
        }
        public List<Turno> QueryTurnos()
        {
            string query = @"Select * from Turno";
            ListadeTurnos.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                Turno nuevoTurno = new Turno(Convert.ToInt32(row[0].ToString()), row[1].ToString(), Convert.ToDateTime(row[2].ToString()), Convert.ToDateTime(row[3].ToString()));
                ListadeTurnos.Add(nuevoTurno);
            }
            return ListadeTurnos;
        }

        public List<Plato> QueryPlatos()
        {
            string query = @"Select * from Plato";
            ListadePlatos.Clear();
            foreach(DataRow row in conexion.DevolverListado(query).Rows)
            {
                Plato nuevoPlato = new Plato(Convert.ToInt32(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString());
                ListadePlatos.Add(nuevoPlato);
            }
            return ListadePlatos;
        }
        public List<Bebida> QueryBebidas()
        {
            string query = @"Select * from Bebida";
            ListadeBebidas.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                if (row[6].ToString() == "")
                {
                    Bebida nuevaBebida = new Bebida(Convert.ToInt32(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), Convert.ToDouble(row[4].ToString()), Convert.ToInt32(row[5].ToString()));
                    ListadeBebidas.Add(nuevaBebida);
                }
                else
                {
                    Bebida_Alcoholica nuevaBebida = new Bebida_Alcoholica(Convert.ToInt32(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), Convert.ToDouble(row[4].ToString()), Convert.ToInt32(row[5].ToString()), Convert.ToDouble(row[6].ToString()));
                    ListadeBebidas.Add(nuevaBebida);
                }

                
            }
            return ListadeBebidas;
        }
        public List<Mozo> FillListadoMozosEnTurno(Turno turno)
        {
            string query = @"select * from Turno inner join Mozo on Mozo.Codigo_Turno=Turno.Codigo_Turno where Turno.Codigo_Turno=" + turno.Codigo;
            turno.ListaMozos.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                Mozo mozo = new Mozo(Convert.ToInt32(row[4].ToString()), Convert.ToInt32(row[5].ToString()), row[6].ToString(), row[7].ToString(), Convert.ToDateTime(row[8].ToString()), BuscarTurno(Convert.ToInt32(row[9].ToString())));
                turno.ListaMozos.Add(mozo);
            }
            return turno.ListaMozos;
        }

        public List<Pedido> FillPedidosconPlato (Plato plato)
        {
            string query = @"Select * from Pedido_Plato inner join Pedido on Pedido_Plato.Codigo_Pedido=Pedido.Codigo_Pedido where Pedido_Plato.Codigo_Plato= " + plato.Codigo;
            PedidosXplato.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                Pedido pedido = new Pedido(Convert.ToInt32(row[3].ToString()), BuscarMesa(Convert.ToInt32(row[4].ToString())), BuscarMozo(Convert.ToInt32(row[5].ToString())), Convert.ToDateTime(row[6].ToString()), row[7].ToString(), Convert.ToDecimal(row[8].ToString()));
                PedidosXplato.Add(pedido);
            }
            return PedidosXplato;
        }
        public void FillTurnos()
        {
            string query = @"Select * from Turno";
            ListadeTurnos.Clear();
            foreach (DataRow row in conexion.DevolverListado(query).Rows)
            {
                Turno nuevoTurno = new Turno(Convert.ToInt32(row[0].ToString()), row[1].ToString(), Convert.ToDateTime(row[2].ToString()), Convert.ToDateTime(row[3].ToString()));
                ListadeTurnos.Add(nuevoTurno);
            }
        }
        
        public List<string> ListarTurnos()
        {
            List<string> array = new List<string>();
            int x = 0;
            array.Add("");
            foreach(var item in ListadeTurnos)
            {
                array.Add(item.NombreTurno);
                x += 1;
            }
            return array;
        }

        public Turno DevolverTurno(string nombre)
        {
            Turno turno = ListadeTurnos.Find(x => x.NombreTurno == nombre);
            return turno;
        }

        #endregion

        #region FormatoDataGridViews
        public void DGVMesas(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Número";
            dgv.Columns[2].HeaderText = "Capacidad Máxima";
            dgv.Columns[3].HeaderText = "Estado Actual";
            dgv.Columns[4].HeaderText = "Cant Ocupantes";
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void DGVMozos(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Puntuación";
            dgv.Columns[0].DisplayIndex = 5;
            dgv.Columns[1].HeaderText = "Legajo";
            dgv.Columns[2].HeaderText = "DNI";
            dgv.Columns[3].HeaderText = "Nombre";
            dgv.Columns[4].HeaderText = "Apellido";
            dgv.Columns[5].Visible = false;
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void DGVTurnos(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nombre del Turno";
            dgv.Columns[2].HeaderText = "Hora de Inicio";
            dgv.Columns[2].DefaultCellStyle.Format = "t";
            dgv.Columns[3].HeaderText = "Hora de Fin";
            dgv.Columns[3].DefaultCellStyle.Format = "t";

            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void DGVTurnosMozos(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[5].Visible = false;
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void DGVPlatos(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Nombre del Plato";
            dgv.Columns[2].HeaderText = "Tipo de Plato";
            dgv.Columns[3].HeaderText = "Clase de Plato";

            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void DGVPedidosXPlatos(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Número";
            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].HeaderText = "Monto";
            dgv.Columns[7].Visible = false;

            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void DGVBebidas(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Nombre";
            dgv.Columns[2].HeaderText = "Tipo";
            dgv.Columns[3].HeaderText = "Presentación";
            dgv.Columns[4].HeaderText = "Precio";
            dgv.Columns[5].HeaderText = "Stock";

            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion

        #region Calculos Grales

        public Turno BuscarTurno(int Codigoturno)
        {
            Turno turno = ListadeTurnos.Find(x => x.Codigo == Codigoturno);
            return turno;
        }

        public int CantidadMozosXTurno(Turno turno)
        {
            string query = @"select count(Mozo.Codigo_Turno) as Cantidad from Turno inner join Mozo on Mozo.Codigo_Turno=Turno.Codigo_Turno where Turno.Codigo_Turno= " + turno.Codigo;
            return conexion.Cantidades(query);

        }

        public double PromedioPlatosEnPedido(Plato plato)
        {
            string query = @"select avg (Pedido_Plato.Codigo_Plato) as Promedio from Pedido_Plato where Codigo_Plato= " + plato.Codigo;
            int frecuencia = conexion.Cantidades(query);
            string query2 = @"select count (Pedido.Codigo_Pedido) as Total from Pedido";
            int total = conexion.Cantidades(query2);
            return (double)frecuencia / (double)total;
        }

        #endregion
        public string ABMMesa(string accion, Mesa mesa)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Mesa ([Nro_Mesa], Capacidad, Estado, CantidadComensales) values (" + mesa.NroDeMesa + "," + mesa.Capacidad + ",'" + mesa.Estado + "'," + mesa.CantidadComensales + ")";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Mesa set [Nro_Mesa]= " + mesa.NroDeMesa + ", Capacidad= " + mesa.Capacidad + ", Estado= '" + mesa.Estado + "' where [Id_Mesa]= " + mesa.Codigo; 
            }
            else
            {
                query = @"Delete from Mesa where [Id_Mesa]=" + mesa.Codigo;
            }
            return query;
        }

        public string ABMMozo(string accion, Mozo mozo)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Mozo (DNI, Nombre, Apellido, [Fecha Nacimiento], [Codigo_Turno]) values (" + mozo.DNI + ",'" + mozo.Nombre + "','" + mozo.Apellido + "','" + mozo.FechaNacimiento + "'," + mozo.turno.Codigo + ")";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Mozo set DNI= " + mozo.DNI + ", Nombre= '" + mozo.Nombre + "', Apellido= '" + mozo.Apellido + "', [Fecha Nacimiento]= '" + mozo.FechaNacimiento + "', [Codigo_Turno]= " + mozo.turno.Codigo + ", Puntuacion= " + mozo.Puntuación + "where [Legajo]= " + mozo.Legajo;
            }
            else
            {
                query = @"Delete from Mozo where [Legajo]=" + mozo.Legajo;
            }
            return query;
        }

        public string ABMTurno(string accion, Turno turno)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Turno ([Nombre Turno], [Hora Inicio], [Hora Fin]) values ( '" + turno.NombreTurno + "','" + turno.HoraInicio + "','" + turno.HoraFin + "')";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Turno set [Nombre Turno]= '" + turno.NombreTurno + "', [Hora Inicio]= '" + turno.HoraInicio.ToString("HH:mm") + "', [Hora Fin]= '" + turno.HoraFin.ToString("HH:mm") + "' where Codigo_Turno= " + turno.Codigo;
            }
            else
            {
                query = @"Delete from Turno where [Codigo_Turno]=" + turno.Codigo;
            }
            return query;
        }

        public string ABMPlato(string accion, Plato plato)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Plato (Nombre, Tipo, Clase) values ( '" + plato.Nombre + "','" + plato.Tipo + "','" + plato.Clase + "')";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Plato set Nombre= '" + plato.Nombre + "', Tipo= '" + plato.Tipo + "', Clase= '" + plato.Clase + "' where Codigo_Plato= " + plato.Codigo;
            }
            else
            {
                query = @"Delete from Plato where [Codigo_Plato]=" + plato.Codigo;
            }
            return query;
        }

        public string ABMBebida(string accion, Bebida bebida)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Bebida (Nombre, Tipo, Presentación, Precio,Stock) values('" + bebida.Nombre + "','" + bebida.Tipo + "','" + bebida.Presentación + "'," + bebida.Precio + ", 0)";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Bebida set Nombre= '" + bebida.Nombre + "', Tipo= '" + bebida.Tipo + "', Presentación= '" + bebida.Presentación + "', Precio= " + bebida.Precio + ", Stock= " +  bebida.Stock + "where Codigo_Bebida= " + bebida.Codigo;
            }
            else
            {
                query = @"Delete from Bebida where [Codigo_Bebida]=" + bebida.Codigo;
            }
            return query;
        }

        public string ABMBebidaAlcoholica(string accion, Bebida_Alcoholica bebida)
        {
            string query;
            if (accion == "Alta")
            {
                query = @"Insert into Bebida (Nombre, Tipo, Presentación, Precio, Stock, [Graduacion Alcoholica]) values('" + bebida.Nombre + "','" + bebida.Tipo + "','" + bebida.Presentación + "'," + bebida.Precio + ",0," + bebida.GraduaciónAlcoholica + ")";
            }
            else if (accion == "Modificar")
            {
                query = @"Update Bebida set Nombre= '" + bebida.Nombre + "', Tipo= '" + bebida.Tipo + "', Presentación= '" + bebida.Presentación + "', Precio= " + bebida.Precio + "Stock= " + bebida.Stock + " [Graduacion Alcoholica]= " + bebida.GraduaciónAlcoholica + " where Codigo_Bebida= " + bebida.Codigo;
            }
            else
            {
                query = @"Delete from Bebida where [Codigo_Bebida]=" + bebida.Codigo;
            }
            return query;
        }
        public void ABMAction (string query)
        {
            conexion.EscribirDatos(query);
        }
    }
}
