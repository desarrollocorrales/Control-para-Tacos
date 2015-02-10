using System.Text;

namespace TacosControl.MySQLDAL
{
    public class Mysql_DAL
    {
        public string obtenerStringDeConexion()
        {
            string sServidor = Properties.Settings.Default.MysqlServer;
            string sUsuario = Properties.Settings.Default.MysqlUser;
            string sPassword = Properties.Settings.Default.MysqlPass;
            string sDatabase = Properties.Settings.Default.MysqlDatabase;
            int iPuerto = Properties.Settings.Default.MysqlPort;


            StringBuilder StringConexion = new StringBuilder();
            StringConexion.Append("metadata=res://*/Entity.TacosControl.csdl|");
            StringConexion.Append("res://*/Entity.TacosControl.ssdl|");
            StringConexion.Append("res://*/Entity.TacosControl.msl;");
            StringConexion.Append("provider=MySql.Data.MySqlClient;");
            StringConexion.Append("provider connection string=\"");
            StringConexion.Append(string.Format("server={0};", sServidor));
            StringConexion.Append(string.Format("user id={0};", sUsuario));
            StringConexion.Append(string.Format("password={0};", sPassword));
            StringConexion.Append(string.Format("port={0};", iPuerto));
            StringConexion.Append(string.Format("database={0};", sDatabase));
            StringConexion.Append("persistsecurityinfo=True\"");

            return (StringConexion.ToString());
        }
    }
}
