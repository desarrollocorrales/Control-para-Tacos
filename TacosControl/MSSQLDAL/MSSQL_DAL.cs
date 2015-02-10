using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TacosControl.Modelos;

namespace TacosControl.MSSQLDAL
{
    public class MSSQL_DAL
    {
        SqlConnection Conexion;
        SqlCommand Comando;
        SqlDataAdapter Adapter;

        public MSSQL_DAL()
        {
            string StringDeConexion = obtenerStringConexion(); 
            Conexion = new SqlConnection(StringDeConexion);
            
            Comando = new SqlCommand();
            Comando.Connection = Conexion;

            Adapter = new SqlDataAdapter();
        }

        private string obtenerStringConexion()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.UserID = Properties.Settings.Default.MSSQLUser;
            scsb.Password = Properties.Settings.Default.MSSQLPass;
            scsb.DataSource = Properties.Settings.Default.MSSQLServer + "," + Properties.Settings.Default.MSSQLPort;
            scsb.InitialCatalog = Properties.Settings.Default.MSSQLDatabase;

            return scsb.ConnectionString;
        }

        public void ProbarConexion(string usuario, string password, string server, string puerto)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.UserID = usuario;
            scsb.Password = password;
            scsb.DataSource = string.Format("{0}, {1}", server, puerto); ;

            Conexion.ConnectionString = scsb.ConnectionString;

            Conexion.Open();
            Conexion.Close();
        }

        public List<string> obtenerBasesDeDatos()
        {
            Conexion.Open();

            Comando.CommandText = "SELECT name FROM master..sysdatabases";
            Adapter.SelectCommand = Comando;

            DataTable TablaRespuesta = new DataTable();
            Adapter.Fill(TablaRespuesta);

            List<string> ListaBasesDeDatos = new List<string>();
            foreach (DataRow fila in TablaRespuesta.Rows)
            {
                ListaBasesDeDatos.Add(Convert.ToString(fila[0]));
            }
            Conexion.Close();

            return ListaBasesDeDatos;
        }

        #region *** Insumos ***
        public List<MSInsumos> obtenerInsumos()
        {
            List<MSInsumos> lstInsumos = new List<MSInsumos>();
            Conexion.Open();
            
            Comando.CommandText =
                string.Format(@"SELECT DISTINCT idinsumo, descripcion, unidad FROM insumos");

            Adapter.SelectCommand = Comando;
            DataTable TablaResultados = new DataTable();
            Adapter.Fill(TablaResultados);

            MSInsumos insumo;
            foreach(DataRow fila in TablaResultados.Rows)
            {
                insumo = new MSInsumos();
                insumo.idInsumo = Convert.ToString(fila["idinsumo"]);
                insumo.Descripcion = Convert.ToString(fila["descripcion"]);
                insumo.Unidad = Convert.ToString(fila["unidad"]);

                lstInsumos.Add(insumo);
            }

            Conexion.Close();
            return lstInsumos;
        }
        #endregion

        #region *** Productos ***
        public List<MSProductos> obtenerProductos()
        {
            List<MSProductos> lstProductos = new List<MSProductos>();
            Conexion.Open();

            Comando.CommandText =
                string.Format(@"SELECT DISTINCT idproducto, descripcion FROM productos");

            Adapter.SelectCommand = Comando;
            DataTable TablaResultados = new DataTable();
            Adapter.Fill(TablaResultados);

            MSProductos producto;
            foreach (DataRow fila in TablaResultados.Rows)
            {
                producto = new MSProductos();
                producto.idProducto = Convert.ToString(fila["idproducto"]);
                producto.Descripcion = Convert.ToString(fila["descripcion"]);

                lstProductos.Add(producto);
            }

            Conexion.Close();
            return lstProductos;
        }
        #endregion

        #region *** Recetas ***
        public List<MSRecetas> obtenerRecetas()
        {
            List<MSRecetas> lstRecetas = new List<MSRecetas>();

            Conexion.Open();

            Comando.CommandText =
                string.Format(@"SELECT idproducto, idinsumo, cantidad FROM costos");

            Adapter.SelectCommand = Comando;
            DataTable TablaResultados = new DataTable();
            Adapter.Fill(TablaResultados);

            MSRecetas receta;
            foreach (DataRow fila in TablaResultados.Rows)
            {
                receta = new MSRecetas();
                receta.idProducto = Convert.ToString(fila["idproducto"]);
                receta.idInsumo = Convert.ToString(fila["idinsumo"]);
                receta.Cantidad = Convert.ToDecimal(fila["cantidad"]);
                lstRecetas.Add(receta);
            }

            Conexion.Close();

            return lstRecetas;
        }
        #endregion

        #region *** Ventas ***
        public List<MSVentas> obtenerVentasDelDia(DateTime fecha)
        {
            DateTime fechainicio = fecha;
            DateTime fechafinal = fecha.AddDays(1);

            List<MSVentas> lstVentas = new List<MSVentas>();

            Conexion.Open();

            Comando.CommandText =
                string.Format(@"SELECT 
                                  idproducto, cantidad, fecha
                                FROM
                                  vwrepproductosvendidoscheques
                                WHERE
                                  fecha BETWEEN '{0} 06:00:00' AND '{1} 03:00:00'", 
                                  fechainicio.ToString("yyyy-MM-dd"), fechafinal.ToString("yyyy-MM-dd"));

            Adapter.SelectCommand = Comando;
            DataTable TablaResultados = new DataTable();
            Adapter.Fill(TablaResultados);

            MSVentas ventas;
            foreach (DataRow fila in TablaResultados.Rows)
            {
                ventas = new MSVentas();
                ventas.idProducto = Convert.ToString(fila["idproducto"]);
                ventas.Cantidad = Convert.ToInt32(fila["cantidad"]);
                ventas.Fecha = Convert.ToDateTime(fila["fecha"]);

                lstVentas.Add(ventas);
            }

            Conexion.Close();

            return lstVentas;
        }
        #endregion
    }
}
