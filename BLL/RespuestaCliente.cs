using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class RespuestaCliente
    {
        public string Mensaje { get; set; }
        public bool IsError { get; set; }
        public List<Cliente> Clientes{ get; set; }
        public Cliente Cliente { get; set; }
    }
}
