using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public decimal CantidadBodega { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
