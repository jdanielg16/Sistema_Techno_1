using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class Conexion //Clase Conexion a la base datos
    {
        private string Base; //Nombre de la base datos del servidor
        private string Servidor; // Nombre de nuestro servidor de datos
        private string UsuarioBD; // Usuario del servidor de datos
        private string ClaveBD;// Clave del usuario de datos
        private static Conexion Con = null;//conectividad tipo stream, manera de autenticar atraves de Sql Server

        private Conexion()
        {
            this.Base="Nombre de la base";
            this.Servidor = "Nombre del sevidor";
            this.UsuarioBD = "Usuario";
            this.ClaveBD = "Contrasena "; 

        }
        
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base + "; " +
                    "                      User Id=" + UsuarioBD + ";Password=" + this.ClaveBD;
             }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if(Con==null)
            {
                Con = new Conexion(); 
            }
            return Con;
        }
    }
}
