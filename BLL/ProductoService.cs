using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.IO;
namespace BLL
{
    public class ProductoService
    {
        ProductoRepository repository;
        OracleConnection connection;
        public ProductoService()
        {
            string cadena = "Data Source = localhost:1521/xepdb1; User Id=proyecto; password=123; ";
            connection = new OracleConnection(cadena);
            repository = new ProductoRepository(connection);
        }

        public RespuestaProducto Guardar(Producto producto)
        {
            RespuestaProducto respuesta = new RespuestaProducto();

            try
            {
                connection.Open();
                repository.Guardar(producto);
                respuesta.IsError = false;
                respuesta.Mensaje = "EL Producto ha sido almacenado";
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

        public RespuestaProducto ConsultarTodos()
        {
            RespuestaProducto respuesta = new RespuestaProducto();

            try
            {
                connection.Open();
                respuesta.Productos = repository.ConsultarTodos();
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

        public RespuestaProducto Buscar(string identificacion)
        {
            RespuestaProducto respuesta = new RespuestaProducto();

            try
            {
                connection.Open();
                respuesta.Producto = repository.Buscar(identificacion);
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

        public RespuestaProducto Eliminar(string identificacion)
        {
            RespuestaProducto respuesta = new RespuestaProducto();

            try
            {
                connection.Open();
                repository.Eliminar(identificacion);
                respuesta.IsError = false;
                respuesta.Mensaje = "El usuario ha sido eliminado correctamente";

                return respuesta;

            }
            catch (Exception ex)
            {
                respuesta.IsError = true;
                respuesta.Mensaje = "Error al procesar la informacion " + ex.Message;
                return respuesta;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
