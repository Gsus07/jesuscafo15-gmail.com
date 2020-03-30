using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class RespuestaProducto
    {
        public string Mensaje { get; set; }
        public bool IsError { get; set; }
        public List<Producto> Productos { get; set; }
        public Producto Producto { get; set; }
    }
}
