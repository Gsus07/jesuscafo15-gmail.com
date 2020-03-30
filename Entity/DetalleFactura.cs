using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public string iddetallefactura { get; set; }
        public Producto Productos;
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal Iva { get; set; }

        public void CalcularTotal()
        {
            Total = Cantidad * Productos.ValorUnitario;
        }

        public decimal CalcularIva()
        {
            return Total * (Iva/100);
        }

    }
}
