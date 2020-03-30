using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entity
{
    public class Factura
    {
        public string CodigoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public Cliente cliente;
        public List<DetalleFactura> DetalleFacturas;

        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }        
        public decimal TotalDescuento { get; set; }
        public decimal TotalIva { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {            
            DetalleFacturas = new List<DetalleFactura>();
        }
        public void AgregarDetalleFactura(string iddetalle,Producto producto,int cantidad, decimal Iva)
        {
            DetalleFactura detalleFactura = new DetalleFactura();
            detalleFactura.iddetallefactura = iddetalle;
            detalleFactura.Productos = producto;
            detalleFactura.Cantidad = cantidad;
            detalleFactura.CalcularTotal();
            detalleFactura.Iva = Iva;
            DetalleFacturas.Add(detalleFactura);            
        }

        public void CalcularSubtotal()
        {
            Subtotal = DetalleFacturas.Sum(d => d.Total);
        }        

        public void CalcularDescuento()
        {
            TotalDescuento = Subtotal * Descuento;
        }

        public void CalcularTotalIva()
        {
            TotalIva=DetalleFacturas.Sum(d => d.CalcularIva());
        }

        public void CalcularTotal()
        {
            CalcularSubtotal();
            CalcularTotalIva();
            CalcularDescuento();
            Total = Subtotal + TotalIva - TotalDescuento;
        }
    }
}
