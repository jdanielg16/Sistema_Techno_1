using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
   public class E_Usuarios
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string TipoDocumento { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string Clave { get; set; }
        public bool  Estado { get; set; }

    }
}
