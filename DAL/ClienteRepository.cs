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
    public class ClienteRepository
    {
        OracleDataReader lector;
        private OracleConnection conexion;
        List<Cliente> clientes = new List<Cliente>();

        public ClienteRepository(OracleConnection connection)
        {
            conexion = connection;
        }

        public void Guardar(Cliente cliente)
        {
            using (var comando = conexion.CreateCommand())
            {
                Domicilio domicilio = cliente.Domicilio;
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "Insert Into cliente(cedula,primernombre,segundonombre,primerapellido,segundoapellido,edad,genero,fechanacimiento,telefono,correo,domicilioid)" +
                    "Values"+ "(:cedula,:primernombre,:segundonombre,:primerapellido,:segundoapellido,:edad,:genero,:fechanacimiento,:telefono,:correo,:domicilioid)";
                comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
                comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                comando.Parameters.Add("segundonombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                comando.Parameters.Add("segundoapellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                comando.Parameters.Add("edad", OracleDbType.Decimal).Value = cliente.Edad;
                comando.Parameters.Add("genero", OracleDbType.Varchar2).Value = cliente.Genero;
                comando.Parameters.Add("fechanacimiento", OracleDbType.Date).Value = cliente.FechaNacimiento;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = cliente.Correo;
                comando.Parameters.Add("domicilioid", OracleDbType.Varchar2).Value = cliente.Domicilio.Domicilioid;

                comando.ExecuteNonQuery();
                transaction.Commit();

                GuardarDomicilio(domicilio);
            }
        }
        public void GuardarDomicilio(Domicilio domicilio)
        {
            using (var comando = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                
                comando.CommandText = "Insert Into domicilio(id,direccion,barrio,ciudad)" +
                    "Values(:id,:direccion,:barrio,:ciudad)";
                comando.Parameters.Add("id", OracleDbType.Varchar2).Value = domicilio.Domicilioid;
                comando.Parameters.Add("direccion", OracleDbType.Varchar2).Value = domicilio.Direccion;
                comando.Parameters.Add("barrio", OracleDbType.Varchar2).Value = domicilio.Barrio;
                comando.Parameters.Add("ciudad", OracleDbType.Varchar2).Value = domicilio.Ciudad;

                comando.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public Cliente BuscarCliente(string identificacion)
        {
            Cliente cliente = new Cliente();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from cliente where cedula =: identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    cliente = MapearCliente(lector);
                }
            }
            return cliente;

        }

        public Domicilio BuscarDomicilio(string identificacion)
        {
            Domicilio domicilio = new Domicilio();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from domicilio where id =: identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    domicilio = MapearDomicilio(lector);
                }
            }
            return domicilio;

        }

        public Cliente MapearCliente(OracleDataReader reader)
        {
            Cliente cliente = new Cliente();
            string iddomicilio;
            cliente.Cedula = (string)reader["cedula"];
            cliente.PrimerNombre = (string)reader["primernombre"];
            cliente.SegundoNombre = (string)reader["segundonombre"];
            cliente.PrimerApellido = (string)reader["primerapellido"];
            cliente.SegundoApellido = (string)reader["segundoapellido"];
            cliente.Edad = (decimal)reader["edad"];
            cliente.Genero = (string)reader["genero"];
            cliente.FechaNacimiento = (DateTime)reader["fechanacimiento"];
            cliente.Telefono = (string)reader["telefono"];
            cliente.Correo = (string)reader["correo"];
            iddomicilio = (string)reader["domicilioid"];
            cliente.Domicilio = BuscarDomicilio(iddomicilio);
            return cliente;

        }

        public Domicilio MapearDomicilio(OracleDataReader reader)
        {
            Domicilio domicilio = new Domicilio();
            domicilio.Domicilioid = (string)reader["id"];
            domicilio.Direccion = (string)reader["direccion"];
            domicilio.Barrio = (string)reader["barrio"];
            domicilio.Ciudad = (string)reader["ciudad"];
            return domicilio;

        }


    }
}
