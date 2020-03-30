using DAL;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;
namespace BLL

{
    public class UsuarioService
    {

        UsuarioRepository repository;
        OracleConnection connection;
        
        public UsuarioService()
        {
            string cadena = "Data Source = localhost:1521/xepdb1; User Id=proyecto; password=123; ";
            connection = new OracleConnection(cadena);
            repository = new UsuarioRepository(connection);
        }
        public Respuesta BuscarTipo(string tipo)
        {
            Respuesta respuesta = new Respuesta();
            
            try
            {
                connection.Open();
                respuesta.IsError = false;
                respuesta.Usuarios = repository.BuscarTipo(tipo);
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

        public Respuesta Guardar(Usuario usuario)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                connection.Open();
                repository.Guardar(usuario);
                respuesta.IsError = false;
                respuesta.Mensaje = "Usuario Guardado";
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

        public Respuesta ConsultarTodos()
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                connection.Open();
                respuesta.Usuarios = repository.ConsultarTodos();
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
        public Respuesta Buscar(string identificacion)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
                connection.Open();
                respuesta.Usuario = repository.Buscar(identificacion);
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

        public Respuesta Eliminar(string identificacion)
        {
            Respuesta respuesta = new Respuesta();

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

        public Respuesta Editar(Usuario usuario)
        {
            Respuesta respuesta = new Respuesta();

            try
            {
              connection.Open();
              int filasAfectadas= repository.Editar(usuario);
              respuesta.IsError = false;
              respuesta.Mensaje=(filasAfectadas < 0) ? "No se Afectaron los registros verificar Base de Datos" : "EL USUARIO HA SIDO MODIFICADO CORRECTAMENTE";
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
