using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Productos
    { 
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int existencia { get; set; }
        public byte[] imagen { get; set; }
        public DateTime Ingreso_Fecha { get; set; }
    }
}
