using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using TacosControl.Entity;
using TacosControl.Modelos;
using TacosControl.MSSQLDAL;
using TacosControl.MySQLDAL;

namespace TacosControl.GUIs
{
    public partial class Frm_Principal : Form
    {
        private int CuentaMinutos;
        private bool SentinelaEjecutar;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            InicializarComboConsultas();
            InicializarParametrosMysql();
            InicializarParametrosMSSQL();
            InicializarTabCorreos();
            CuentaMinutos = 0;
            SentinelaEjecutar = true;
        }

        private void InicializarComboConsultas()
        {
            cbObjetos.DataSource = Enum.GetValues(typeof(Enumeradores.Objetos));
        }
        private void InicializarParametrosMysql()
        {
            txbServidor.Text = Properties.Settings.Default.MysqlServer;
            txbUsuario.Text = Properties.Settings.Default.MysqlUser;
            txbContraseña.Text = Properties.Settings.Default.MysqlPass;
            nudPuerto.Value =Properties.Settings.Default.MysqlPort;
        }
        private void InicializarParametrosMSSQL()
        {
            txbMSSQLServidor.Text = Properties.Settings.Default.MSSQLServer;
            txbMSSQLUsuario.Text = Properties.Settings.Default.MSSQLUser;
            txbMSSQLPassword.Text = Properties.Settings.Default.MSSQLPass;
            txbMSSQLPuerto.Text = Properties.Settings.Default.MSSQLPort;
        }
        private void InicializarTabCorreos()
        {
            txbCorreo.Text = Properties.Settings.Default.MailSender;
            txbCorreoServer.Text = Properties.Settings.Default.MailServer;
            nudCorreoPuerto.Value = Properties.Settings.Default.MailPort;

            StringBuilder sbCorreos = new StringBuilder();            
            foreach (string correo in Properties.Settings.Default.ListaDeCorreos)
            {
                sbCorreos.AppendLine(correo);
            }
            sbCorreos.Append(string.Empty);
            txbListCorreos.Text = sbCorreos.ToString();
        }

        private void cbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ObjetoSeleccionado = (Enumeradores.Objetos)cbObjetos.SelectedItem;

            switch (ObjetoSeleccionado)
            {
                case Enumeradores.Objetos.Productos:
                {
                    CambiarGrid(gridProductos);
                    break;
                }
                case Enumeradores.Objetos.Insumos:
                {
                    CambiarGrid(gridInsumos);
                    break;
                }
                case Enumeradores.Objetos.Recetas:
                {
                    CambiarGrid(gridRecetas);
                    break;
                }
            }
        }

        private void CambiarGrid(DevExpress.XtraGrid.GridControl Grid)
        {
            gridInsumos.Visible = false;
            gridProductos.Visible = false;
            gridRecetas.Visible = false;

            Grid.Visible = true;
            Grid.Dock = DockStyle.Fill;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var ObjetoSeleccionado = (Enumeradores.Objetos)cbObjetos.SelectedItem;
            
            pictLoading.Visible = true;
            pictLoading.BringToFront();

            Application.DoEvents();

            switch (ObjetoSeleccionado)
            {
                case Enumeradores.Objetos.Productos:
                    {
                        ConsultarProductos();
                        break;
                    }
                case Enumeradores.Objetos.Insumos:
                    {
                        ConsultarInsumos();
                        break;
                    }
                case Enumeradores.Objetos.Recetas:
                    {
                        ConsultarRecetas();
                        break;
                    }
            }

            pictLoading.Visible = false;
        }
        private void ConsultarProductos()
        {
            Mysql_DAL MyDal = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(MyDal.obtenerStringDeConexion());
            List<productos> lstProductos = Contexto.productos.ToList();

            gridProductos.DataSource = lstProductos;
            gvProductos.BestFitColumns();
            gridProductos.Refresh();
        }
        private void ConsultarInsumos()
        {
            Mysql_DAL MyDal = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(MyDal.obtenerStringDeConexion());
            List<insumos> lstInsumos = Contexto.insumos.ToList();

            gridInsumos.DataSource = lstInsumos;
            gvInsumos.BestFitColumns();
            gridInsumos.Refresh();
        }
        private void ConsultarRecetas()
        {
            Mysql_DAL MyDal = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(MyDal.obtenerStringDeConexion());
            List<recetas> lstRecetas = Contexto.recetas.ToList();

            gridRecetas.DataSource = lstRecetas;
            gvRecetas.BestFitColumns();
            gridRecetas.Refresh();
        }

        private void gvRecetas_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                Tacos_Control_Entities Contexto = ProbarConexion();

                //Los datos son correctos, Mostrar las bases de datos.
                ListarBasesDeDatos(Contexto);
                lblDatabase.Visible = true;
                cbDatabase.Visible = true;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Los parametros son correctos");
                sb.AppendLine("Por favor, seleccione la base de datos y guarde la configuracion.");
                MessageBox.Show(sb.ToString(), "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OcultarControles();
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }
        private Tacos_Control_Entities ProbarConexion()
        {
            try
            {
                string StringConexion = obtenerStringDeConexion();
                Tacos_Control_Entities Contexto = new Tacos_Control_Entities(StringConexion);
                
                Contexto.Connection.Open();
                Contexto.Connection.Close();

                return Contexto;                                                              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void OcultarControles()
        {
            txbServidor.Enabled = false;
            txbUsuario.Enabled = false;
            txbContraseña.Enabled = false;
            nudPuerto.Enabled = false;
            btnProbarConexion.Visible = false;
            btnGuardar.Visible = true;
        }

        private string obtenerStringDeConexion()
        {
            StringBuilder StringConexion = new StringBuilder();
            StringConexion.Append("metadata=res://*/Entity.TacosControl.csdl|");
            StringConexion.Append("res://*/Entity.TacosControl.ssdl|");
            StringConexion.Append("res://*/Entity.TacosControl.msl;");
            StringConexion.Append("provider=MySql.Data.MySqlClient;");
            StringConexion.Append("provider connection string=\"");
            StringConexion.Append(string.Format("server={0};", txbServidor.Text));
            StringConexion.Append(string.Format("user id={0};", txbUsuario.Text));
            StringConexion.Append(string.Format("password={0};", txbContraseña.Text));
            StringConexion.Append(string.Format("port={0};", nudPuerto.Value));
            StringConexion.Append("persistsecurityinfo=True\"");

            return (StringConexion.ToString());
        }

        private void ListarBasesDeDatos(Tacos_Control_Entities pContexto)
        {
            List<string> ListaBaseDeDatos = pContexto.ExecuteStoreQuery<string>("Show Databases").ToList();
            
            ListaBaseDeDatos.Remove("information_schema");
            cbDatabase.DataSource = ListaBaseDeDatos;
            
            string sDataBase = Properties.Settings.Default.MysqlDatabase;
            int index = cbDatabase.FindStringExact(sDataBase);
            if (index != -1)
                cbDatabase.SelectedIndex = index;
            
        }
        private void ExponerExepcion(Exception ex)
        {
            string TipoExepcion = ex.GetType().ToString();
            string Mensaje = string.Empty;
            if (ex.InnerException == null)
            {
                Mensaje = ex.Message;
                MessageBox.Show(Mensaje, TipoExepcion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Mensaje = ex.InnerException.Message;
                MessageBox.Show(Mensaje, TipoExepcion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MysqlServer = txbServidor.Text;
            Properties.Settings.Default.MysqlUser = txbUsuario.Text;
            Properties.Settings.Default.MysqlPass = txbContraseña.Text;
            Properties.Settings.Default.MysqlPort = Convert.ToInt32(nudPuerto.Value);
            Properties.Settings.Default.MysqlDatabase = cbDatabase.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("La configuración a sido guardada con exito", "Guardar", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblAccion.Visible = true;
            cbDatabase.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnProbarMSSQL_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.MSSQLServer = txbMSSQLServidor.Text;
                Properties.Settings.Default.MSSQLUser = txbMSSQLUsuario.Text;
                Properties.Settings.Default.MSSQLPass = txbMSSQLPassword.Text;
                Properties.Settings.Default.MSSQLPort = txbMSSQLPuerto.Text;

                MSSQL_DAL DAL = new MSSQL_DAL();
                
                DAL.ProbarConexion(txbMSSQLUsuario.Text, txbMSSQLPassword.Text, txbMSSQLServidor.Text, txbMSSQLPuerto.Text);
                //Los datos son correctos, Mostrar las bases de datos.
                ListarBaseDeDatosMSSQL(DAL);

                txbMSSQLServidor.Enabled = false;
                txbMSSQLUsuario.Enabled = false;
                txbMSSQLPassword.Enabled = false;
                txbMSSQLPuerto.Enabled = false;

                lblMSSQLDatabase.Visible = true;
                cbMSSQLBaseDeDatos.Visible = true;
                btnGuardarMSSQL.Visible = true;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Los parametros son correctos");
                sb.AppendLine("Por favor, seleccione la base de datos y guarde la configuracion.");
                MessageBox.Show(sb.ToString(), "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }

        private void btnGuardarMSSQL_Click(object sender, EventArgs e)
        {
            GuardarConfiguracionMSSQL();
        }
        private void GuardarConfiguracionMSSQL()
        {
            Properties.Settings.Default.MSSQLServer = txbMSSQLServidor.Text;
            Properties.Settings.Default.MSSQLUser = txbMSSQLUsuario.Text;
            Properties.Settings.Default.MSSQLPass = txbMSSQLPassword.Text;
            Properties.Settings.Default.MSSQLPort = txbMSSQLPuerto.Text;
            Properties.Settings.Default.MSSQLDatabase = cbMSSQLBaseDeDatos.Text;
            
            Properties.Settings.Default.Save();

            MessageBox.Show("La configuración a sido guardada con exito", "Guardar",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblAccionMSSQL.Visible = true;
            cbMSSQLBaseDeDatos.Enabled = false;
            btnGuardarMSSQL.Enabled = false;
        }
        private void ListarBaseDeDatosMSSQL(MSSQL_DAL Dal)
        {
            string sDatabase = Properties.Settings.Default.MSSQLDatabase;

            List<string> ListaBasesDeDatos = Dal.obtenerBasesDeDatos();
            cbMSSQLBaseDeDatos.DataSource = ListaBasesDeDatos;

            int index = cbMSSQLBaseDeDatos.FindStringExact(sDatabase);
            if (index != -1)
                cbMSSQLBaseDeDatos.SelectedIndex = index;
        }

        #region *** Exportar Productos ***

        private void btnExportarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarExportarProductos() == true)
                {
                    ExportarProductos();
                }
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }
        private void ExportarProductos()
        {
            lblAccionExportar.Text = string.Empty;
            lblAccionExportar.Paste("Conectando a la base de datos de SoftRestaurant...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            MSSQL_DAL MS_DAL = new MSSQL_DAL();
            List<MSProductos> lstProductos = MS_DAL.obtenerProductos();

            lblAccionExportar.Paste("Conectando a la base de datos Mysql...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            Mysql_DAL My_DAL = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(My_DAL.obtenerStringDeConexion());
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 0;");
            Contexto.ExecuteStoreCommand("  TRUNCATE TABLE productos;");
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 1;");

            lblAccionExportar.Paste("Iniciando exportación...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            int ContarProductos = 0;
            productos myProducto;

            barProgreso.Minimum = 0;
            barProgreso.Value = 0;
            barProgreso.Maximum = lstProductos.Count;
            foreach (MSProductos producto in lstProductos)
            {
                myProducto = new productos();
                myProducto.id_producto = producto.idProducto;
                myProducto.producto = producto.Descripcion;

                Contexto.productos.AddObject(myProducto);
                ContarProductos++;
                barProgreso.Value = ContarProductos;

                lblAccionExportar.Paste("   Exportando producto ID: " + myProducto.id_producto);
                lblAccionExportar.Paste(" Descripcion: " + myProducto.producto);
                lblAccionExportar.Paste(Environment.NewLine);
                Application.DoEvents();
            }
            Contexto.SaveChanges();

            lblAccionExportar.Paste("Termina proceso de exportación...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            MessageBox.Show("Se exportaron "+ContarProductos+" productos");
        }
        private bool ValidarExportarProductos()
        {
            bool bRespuesta = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Esta accion borrará los productos existentes en la base de datos Mysql");
            sb.AppendLine("y los reemplazara por los productos existentes en SoftRestaurant.");
            sb.AppendLine();
            sb.AppendLine("¿Esta seguro que desea realizar esta acción?");
            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
                bRespuesta = true;

            return bRespuesta;
        }

        #endregion

        #region *** Exportar Insumos ***

        private void btnExportarInsumos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarExportarInsumos() == true)
                {
                    ExportarInsumos();
                }
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }
        private void ExportarInsumos()
        {
            lblAccionExportar.Text = string.Empty;
            lblAccionExportar.Paste("Conectando a la base de datos de SoftRestaurant...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            MSSQL_DAL MS_DAL = new MSSQL_DAL();
            List<MSInsumos> lstInsumos = MS_DAL.obtenerInsumos();

            lblAccionExportar.Paste("Conectando a la base de datos MySQL...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            Mysql_DAL My_DAL = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(My_DAL.obtenerStringDeConexion());
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 0;");
            Contexto.ExecuteStoreCommand("TRUNCATE TABLE insumos");
            Contexto.ExecuteStoreCommand("SET FOREIGN_KEY_CHECKS = 1;");

            lblAccionExportar.Paste("Inicia proceso de exportación...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            int ContarInsumos = 0;
            insumos myInsumo;
            barProgreso.Minimum = 0;
            barProgreso.Value = 0;
            barProgreso.Maximum = lstInsumos.Count;

            foreach (MSInsumos insumo in lstInsumos)
            {
                myInsumo = new insumos();
                myInsumo.id_insumo = insumo.idInsumo;
                myInsumo.insumo = insumo.Descripcion;
                myInsumo.unidad = insumo.Unidad;

                Contexto.insumos.AddObject(myInsumo);
                ContarInsumos++;
                barProgreso.Value = ContarInsumos;

                lblAccionExportar.Paste("    Exportando Insumo ID: " + myInsumo.id_insumo);
                lblAccionExportar.Paste(" Descripcion: " + myInsumo.insumo);
                lblAccionExportar.Paste(" Unidad: " + myInsumo.unidad);
                lblAccionExportar.Paste(Environment.NewLine);
                Application.DoEvents();

            }

            Contexto.SaveChanges();

            lblAccionExportar.Paste("Termina proceso de exportación...");
            Application.DoEvents();

            MessageBox.Show("Se exportaron " + ContarInsumos + " Insumos");
        }
        private bool ValidarExportarInsumos()
        {
            bool bRespuesta = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Esta accion borrará los insumos existentes en la base de datos Mysql");
            sb.AppendLine("y los reemplazara por los insumos existentes en SoftRestaurant.");
            sb.AppendLine();
            sb.AppendLine("¿Esta seguro que desea realizar esta acción?");
            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                bRespuesta = true;

            return bRespuesta;
        }
        
        #endregion

        #region *** Exportar Recetas ***
        
        private void btnExportarRecetas_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarExportarRecetas() == true)
                {
                    ExportarRecetas();
                }
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }
        private void ExportarRecetas()
        {
            lblAccionExportar.Text = string.Empty;
            lblAccionExportar.Paste("Conectando a la base de datos de SoftRestaurant...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            MSSQL_DAL MS_DAL = new MSSQL_DAL();
            List<MSRecetas> lstRecetas = MS_DAL.obtenerRecetas();

            lblAccionExportar.Paste("Conectando a la base de datos MySQL...");
            lblAccionExportar.Paste(Environment.NewLine);
            Application.DoEvents();

            Mysql_DAL My_DAL = new Mysql_DAL();
            Tacos_Control_Entities Contexto = new Tacos_Control_Entities(My_DAL.obtenerStringDeConexion());
            Contexto.ExecuteStoreCommand("TRUNCATE TABLE recetas");

            string comando;
            int contador = 0;
            barProgreso.Minimum = 0;
            barProgreso.Value = 0;
            barProgreso.Maximum = lstRecetas.Count;
            foreach (MSRecetas receta in lstRecetas)
            {
                comando =
                    string.Format(@"INSERT INTO 
                                           recetas (id_producto, id_insumo, cantidad) 
                                         VALUES    ('{0}',       '{1}',     {2})",
                                                   receta.idProducto, receta.idInsumo, receta.Cantidad);
                Contexto.ExecuteStoreCommand(comando);

                lblAccionExportar.Paste("  Exportando registro id_producto = " + receta.idProducto);
                lblAccionExportar.Paste(" | id_insumo = " + receta.idInsumo);
                lblAccionExportar.Paste(" | cantidad = " + receta.Cantidad);
                lblAccionExportar.Paste(Environment.NewLine);
                contador++;
                barProgreso.Value = contador;
                Application.DoEvents();
            }

            lblAccionExportar.Paste("Termina proceso de exportación...");

            MessageBox.Show("Se exportaron todas las recetas");
        }
        private bool ValidarExportarRecetas()
        {
            bool bRespuesta = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Esta accion sustituirá las recetas existentes en la base de datos Mysql");
            sb.AppendLine("y las reemplazara con las recetas existentes en SoftRestaurant.");
            sb.AppendLine();
            sb.AppendLine("¿Esta seguro que desea realizar esta acción?");
            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                bRespuesta = true;

            return bRespuesta;
        }

        #endregion

        #region *** Exportar ventas ***

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportarVentas(dtpFecha.Value);
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }
        private void ExportarVentas(DateTime fecha)
        {
            txbExportarVentas.Text = string.Empty;
            txbExportarVentas.Paste("Obteniendo las ventas del dia " + fecha.ToString("dd/MMMM/yyyy"));
            txbExportarVentas.Paste(Environment.NewLine);
            Application.DoEvents();

            MSSQL_DAL DAL = new MSSQL_DAL();
            List<MSVentas> lstVentas = DAL.obtenerVentasDelDia(dtpFecha.Value);

            txbExportarVentas.Paste("Conectando a la base de datos MySQL");
            txbExportarVentas.Paste(Environment.NewLine);
            Application.DoEvents();

            Mysql_DAL myDal = new Mysql_DAL();
            Tacos_Control_Entities Tacontexto = new Tacos_Control_Entities(myDal.obtenerStringDeConexion());

            // *** Borrar las ventas del dia ***
            BorrarVentasMySQL(dtpFecha.Value, Tacontexto);

            string consulta;
            txbExportarVentas.Paste("Inicia el proceso de exportación de ventas...");
            txbExportarVentas.Paste(Environment.NewLine);
            Application.DoEvents();

            foreach (MSVentas venta in lstVentas)
            {
                consulta =
                    string.Format(@"INSERT INTO ventas (id_producto, cantidad, fecha) 
                                             VALUES ('{0}', {1}, '{2}')",
                                         venta.idProducto, venta.Cantidad, venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));

                Tacontexto.ExecuteStoreCommand(consulta);
                
                txbExportarVentas.Paste(string.Format("  Exportando venta - [Producto : {0}] | [Cantidad : {1}] | [Fecha: {2}]", venta.idProducto, venta.Cantidad, venta.Fecha.ToString("dd-MM-yyyy HH:mm:ss")));
                txbExportarVentas.Paste(Environment.NewLine);
                Application.DoEvents();
            }

            txbExportarVentas.Paste("Termina el proceso de exportación de ventas...");
            Application.DoEvents();

            EnviarEmail(dtpFecha.Value);

            MessageBox.Show("Ventas Exportadas");
        }
        private void ExportarVentasBGW(DateTime fecha)
        {
            MSSQL_DAL DAL = new MSSQL_DAL();
            List<MSVentas> lstVentas = DAL.obtenerVentasDelDia(dtpFecha.Value);

            Mysql_DAL myDal = new Mysql_DAL();
            Tacos_Control_Entities Tacontexto = new Tacos_Control_Entities(myDal.obtenerStringDeConexion());

            // *** Borrar las ventas del dia ***
            BorrarVentasMySQL(dtpFecha.Value, Tacontexto);

            string consulta;
            foreach (MSVentas venta in lstVentas)
            {
                consulta =
                    string.Format(@"INSERT INTO ventas (id_producto, cantidad, fecha) 
                                             VALUES ('{0}', {1}, '{2}')",
                                         venta.idProducto, venta.Cantidad, venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));

                Tacontexto.ExecuteStoreCommand(consulta);
            }
        }

        private void BorrarVentasMySQL(DateTime fecha, Tacos_Control_Entities Tacontexto)
        {
            string fechaInicio = fecha.ToString("yyyy-MM-dd") + " 06:00:00";
            string fechaFinal  = fecha.AddDays(1).ToString("yyyy-MM-dd") + " 03:00:00";
            string consulta = 
                string.Format("DELETE FROM ventas WHERE fecha BETWEEN '{0}' AND '{1}'", fechaInicio, fechaFinal);
            Tacontexto.ExecuteStoreCommand(consulta);
        }
        #endregion

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabName = tbControl.SelectedTab.Name;
            if ((tabName == "tabConfig") || (tabName == "tabExportar") || (tabName == "tabCorreo"))
            {
                Frm_Login frmValidar = new Frm_Login();
                frmValidar.ShowDialog();
                if (frmValidar.Valido == false)
                {
                    MessageBox.Show("Error al validar el usuario administrador...");
                    tbControl.SelectedIndex = 0;
                }
            }
        }

        private void Frm_Principal_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void niTacosControl_DoubleClick(object sender, EventArgs e)
        {            
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #region *** tabCorreos ***
        private void btnGuardarCorreos_Click(object sender, EventArgs e)
        {            
            Properties.Settings.Default.ListaDeCorreos = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.ListaDeCorreos.AddRange(ObtenerCorreos());
            Properties.Settings.Default.Save();

            MessageBox.Show("Los correos han sido guardados con exito...", "Guardar", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string[] ObtenerCorreos()
        {
            StringReader sr = new StringReader(txbListCorreos.Text);
            List<string> lstCorreos = new List<string>();
            
            while (true)
            {
                string correo = sr.ReadLine();
                if (correo != null)
                {
                    correo = correo.Trim();
                    if (correo != string.Empty)
                        lstCorreos.Add(correo);
                }
                else
                    break;
            }

            string[] arrayCorreos = lstCorreos.Distinct().ToArray();
            return arrayCorreos;
        }
        #endregion

        #region *** Temporizador ***
        private void timEjecutar_Tick(object sender, EventArgs e)
        {            
            try
            {
                bgwTemporizador.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ExponerExepcion(ex);
            }
        }

        private TimeSpan ObtenerHoraServer(ref DateTime Fecha)
        {
            Mysql_DAL myDal = new Mysql_DAL();
            Tacos_Control_Entities Tacontexto = new Tacos_Control_Entities(myDal.obtenerStringDeConexion());

            var FechaHora = Tacontexto.ExecuteStoreQuery<DateTime>("SELECT NOW()").ToList();
            Fecha = FechaHora[0].Date;
            TimeSpan Tiempo = FechaHora[0].TimeOfDay;

            return Tiempo;
        }
        
        private void bgwTemporizador_DoWork(object sender, DoWorkEventArgs e)
        {
            timEjecutar.Stop();
            if (CuentaMinutos == 25)
            {
                int HoraInicio = Convert.ToInt32(ConfigurationManager.AppSettings["HoraInicio"]);
                int HoraTermino = Convert.ToInt32(ConfigurationManager.AppSettings["HoraTermino"]);

                DateTime Fecha = new DateTime();
                TimeSpan HoraEjecucionInicio = new TimeSpan(HoraInicio, 0, 0);
                TimeSpan HoraEjecucionFin = new TimeSpan(HoraTermino, 0, 0);

                TimeSpan tiempo = ObtenerHoraServer(ref Fecha);

                if (tiempo > HoraEjecucionInicio && tiempo < HoraEjecucionFin)
                {
                    //Es hora de ejecutar la exportación
                    if (SentinelaEjecutar == true)
                    {
                        //Exportar ventas del dia anterior
                        ExportarVentasBGW(Fecha.AddDays(-1));

                        //Enviar Email
                        EnviarEmail(Fecha.AddDays(-1));

                        //Desactivar el sentinela
                        SentinelaEjecutar = false;
                    }                    
                }
                else
                {
                    //Activar el sentinela
                    SentinelaEjecutar = true;
                }

                CuentaMinutos = 0;
            }
            else
            {
                CuentaMinutos++;
            }

        }
        private void bgwTemporizador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timEjecutar.Start();
        }

        #endregion     
  
        #region *** Enviar Emails ***

        private void EnviarEmail(DateTime fecha)
        {
            MailMessage Correo = new MailMessage();
            string Sucursal = ConfigurationManager.AppSettings["Sucursal"];
            Correo.From = new MailAddress("automata@loscorrales.com.mx", "Ventas Tacos " + Sucursal);
            
            foreach(string direccion in Properties.Settings.Default.ListaDeCorreos)
            {
                Correo.To.Add(direccion);
            }

            Correo.Subject = "Ventas de Tacos " + Sucursal;
            Correo.Body = "Se exportaron las ventas de tacos: [" + Sucursal + "] del dia: " + fecha.ToString("dd-MMM-yyyy");
            Correo.IsBodyHtml = false;

            SmtpClient SmtpMail = new SmtpClient();
            SmtpMail.Host = Properties.Settings.Default.MailServer;
            SmtpMail.Port = Properties.Settings.Default.MailPort;
            string usuario = Properties.Settings.Default.MailSender;
            string password = Properties.Settings.Default.MailPassword;
            SmtpMail.Credentials = new System.Net.NetworkCredential(usuario, password);
            SmtpMail.EnableSsl = false;
            SmtpMail.Send(Correo);
        }

        #endregion

        private void Frm_Principal_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
