using System;
using System.Collections.Generic;
using System.Text;

namespace HuamanS14.Models
{
    public class Compra
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public string Vendedor { get; set; }
    }
}
