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
    public class ClienteService
    {
        ClienteRepository repository;
        OracleConnection connection;

        public ClienteService()
        {
            string cadena = "Data Source = localhost:1521/xepdb1; User Id=proyecto; password=123; ";
            connection = new OracleConnection(cadena);
            repository = new ClienteRepository(connection);
        }
        public RespuestaCliente Guardar(Cliente cliente)
        {
            RespuestaCliente respuesta = new RespuestaCliente();
            Email email = new Email();
            try
            {
                email.EnviarEmail(cliente);
                connection.Open();
                repository.Guardar(cliente);
                respuesta.IsError = false;
                respuesta.Mensaje = "Cliente Guardado";
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
        public RespuestaCliente Buscar(string identificacion)
        {
            RespuestaCliente respuesta = new RespuestaCliente();

            try
            {
                connection.Open();
                respuesta.Cliente = repository.BuscarCliente(identificacion);
                respuesta.IsError = false;
                respuesta.Mensaje = "Consulta realizada de manera exitosa";

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
