﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
  public class E_Factura
    {
        public int idFactura { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
}
