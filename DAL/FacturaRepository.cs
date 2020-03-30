using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.IO;
namespace DAL
{
    public class FacturaRepository
    {
        OracleDataReader lector;
        private OracleConnection conexion;
        List<Factura> Facturas = new List<Factura>();

        public FacturaRepository(OracleConnection connection)
        {
            conexion = connection;
        }

        public void GuardarFactura(Factura factura)
        {
            using (var comando = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;

                comando.CommandText = "Insert Into factura(id,fecha,subtotal,totaldescuento,totaliva,total,cedula)" +
                    "Values(seq_factura.nextval,:fecha,:subtotal,:totaldescuento,:totaliva,:total,:cedula)";
                comando.Parameters.Add("fecha", OracleDbType.Date).Value = factura.FechaFactura;
                comando.Parameters.Add("subtotal", OracleDbType.Decimal).Value = factura.Subtotal;
                comando.Parameters.Add("totaldescuento", OracleDbType.Decimal).Value = factura.TotalDescuento;
                comando.Parameters.Add("totaliva", OracleDbType.Decimal).Value = factura.TotalIva;
                comando.Parameters.Add("total", OracleDbType.Decimal).Value = factura.Total;
                comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = factura.cliente.Cedula;
                comando.ExecuteNonQuery();
                transaction.Commit();
                GuardarDetalleFactura(factura.DetalleFacturas);
               
                

            }
        }

        public void GuardarDetalleFactura(List<DetalleFactura> detalleFacturas)
        {
            foreach (var detalleFactura in detalleFacturas)
            {
                using (var comando = conexion.CreateCommand())
                {
                    OracleTransaction transaction = conexion.BeginTransaction();
                    comando.Transaction = transaction;
                    comando.CommandText = "Insert Into detallefactura(facturaid,productoid,iva,precio,cantidad,iddetallefactura)" +
                        "Values(seq_factura.nextval,:productoid,:iva,:precio,:cantidad,:iddetallefactura)";
                    comando.Parameters.Add("productoid", OracleDbType.Varchar2).Value = detalleFactura.Productos.CodigoProducto;
                    comando.Parameters.Add("iva", OracleDbType.Varchar2).Value = detalleFactura.Iva;
                    comando.Parameters.Add("precio", OracleDbType.Varchar2).Value = detalleFactura.Total;
                    comando.Parameters.Add("cantidad", OracleDbType.Varchar2).Value = detalleFactura.Cantidad;
                    comando.Parameters.Add("iddetallefactura", OracleDbType.Varchar2).Value = detalleFactura.iddetallefactura;
                    comando.ExecuteNonQuery();
                    transaction.Commit();
                }

            }
            
        }

    }
}
