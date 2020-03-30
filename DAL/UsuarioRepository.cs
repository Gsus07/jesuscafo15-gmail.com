using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using System.IO;
namespace DAL
{
    public class UsuarioRepository
    {
        OracleDataReader lector;
        private OracleConnection conexion;
        List<Usuario> usuarios = new List<Usuario>();

        public UsuarioRepository(OracleConnection connection)
        {
            conexion = connection;
        }

        public void Guardar(Usuario usuario)
        {
            using (var  comando = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "Insert Into usuario(id, usuario, tipo, contraseña)Values" +
                "(:id,:usuario,:tipo,:contraseña)";
                comando.Parameters.Add("id", OracleDbType.Varchar2).Value = usuario.IDUsuario;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = usuario.User;
                comando.Parameters.Add("tipo", OracleDbType.Varchar2).Value = usuario.Tipo;
                comando.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = usuario.Contraseña;
                comando.ExecuteNonQuery();
                transaction.Commit();
            }
        } 
        public List<Usuario> ConsultarTodos()
        {
            usuarios.Clear();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * FROM usuario";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario = MapearUsuario(lector);
                    usuarios.Add(usuario);


                }
            }
            return usuarios;
        }
        public Usuario Buscar(string identificacion)
        {
            Usuario usuario = new Usuario();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from usuario where id=:identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    usuario = MapearUsuario(lector);
                }
            }
            return usuario;
            
        }

        public void Eliminar (string identificacion)
        {
            using (var comando = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "delete from usuario where id=:identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                comando.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public int Editar(Usuario usuario)
        {
            using (var command = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                command.Transaction = transaction;
                command.CommandText = $"update usuario set usuario=:usuario ,tipo=:tipo ,contraseña=:contraseña where id={usuario.IDUsuario}";
                //command.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = usuario.IDUsuario;
                command.Parameters.Add("usuario", OracleDbType.Varchar2).Value = usuario.User;
                command.Parameters.Add("tipo", OracleDbType.Varchar2).Value = usuario.Tipo;
                command.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = usuario.Contraseña;
                int filasAfectadas = command.ExecuteNonQuery();
                transaction.Commit();
                return filasAfectadas;
                
            }
        }
        public Usuario MapearUsuario(OracleDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.IDUsuario = (string)reader["id"];
            usuario.User = (string)reader["usuario"];
            usuario.Tipo = (string)reader["tipo"];
            usuario.Contraseña = (string)reader["contraseña"];
            return usuario;

        }

        public List<Usuario> BuscarTipo (string tipo)
        {
            usuarios.Clear();
            usuarios = ConsultarTodos().Where(ct => ct.Tipo == tipo).ToList();
            return usuarios;
            
        }
    }
}
