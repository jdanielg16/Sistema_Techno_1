using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Productos
    { 
        public string Idcodigo { get; set; }
        public int  IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string  NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public  bool Estado { get; set; }
        public byte[] imagen { get; set; }


    }
}
