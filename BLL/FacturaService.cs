using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using InfraStructure;
namespace BLL
{
    public class FacturaService
    {
        FacturaRepository repository;
        OracleConnection connection;

        public FacturaService()
        {
            string cadena = "Data Source = localhost:1521/xepdb1; User Id=proyecto; password=123; ";
            connection = new OracleConnection(cadena);
            repository = new FacturaRepository(connection);
        }

        public RespuestaFactura Guardar(Factura factura)
        {
            RespuestaFactura respuesta = new RespuestaFactura();
            GenerarFactura generarFactura = new GenerarFactura();
            try
            {

                connection.Open();
                generarFactura.GuardarPdf(factura);
                repository.GuardarFactura(factura);
                respuesta.IsError = false;
                respuesta.Mensaje = "Factura Guardada";
                return respuesta;

            }
            catch (Exception ex)
            {
                respuesta.IsError = true;
                respuesta.Mensaje = "Error al procesar la informacion" + ex.Message;
                return respuesta;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
