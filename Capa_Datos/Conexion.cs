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
        private static Conexion con = null;

        private Conexion()
        {
            this.Base="ss";
        }
    }
}
