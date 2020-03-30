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
    public class ProductoRepository
    {
        OracleDataReader lector;
        private OracleConnection conexion;
        List<Producto> productos = new List<Producto>();

        public ProductoRepository(OracleConnection connection)
        {
            conexion = connection;
        }

        public void Guardar(Producto producto)
        {
            using (var comando = conexion.CreateCommand())
            {
                OracleTransaction transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "Insert Into producto(idproducto, descripcion, cantidadbodega, valorunitario)Values" +
                "(:id,:nombre,:cantidadBodega,:valorunit)";

                comando.Parameters.Add("id", OracleDbType.Varchar2).Value = producto.CodigoProducto;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = producto.Nombre;
                comando.Parameters.Add("cantidadBodega", OracleDbType.Int16).Value = producto.CantidadBodega;
                comando.Parameters.Add("valorunit", OracleDbType.Decimal).Value = producto.ValorUnitario;
                comando.ExecuteNonQuery();
                transaction.Commit();
            }
        }

        public List<Producto> ConsultarTodos()
        {
            productos.Clear();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * FROM producto";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto = MapearProducto(lector);
                    productos.Add(producto);


                }
            }
            return productos;
        }

        public Producto Buscar(string identificacion)
        {
            Producto producto = new Producto();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from producto where idproducto =: identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                lector = comando.ExecuteReader();
                while (lector.Read())
                { 
                    producto = MapearProducto(lector);
                }
            }
            return producto;

        }

        public void Eliminar(string identificacion)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "delete from producto where idproducto=:identificacion";
                comando.Parameters.Add("identificacion", OracleDbType.Varchar2).Value = identificacion;
                comando.ExecuteNonQuery();
            }
        }

        public Producto MapearProducto(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.CodigoProducto = (string)reader["idproducto"];
            producto.Nombre = (string)reader["descripcion"];
            producto.CantidadBodega = (decimal)reader["cantidadbodega"];
            producto.ValorUnitario = (decimal)reader["valorunitario"];
            return producto;

        }

    }
}
