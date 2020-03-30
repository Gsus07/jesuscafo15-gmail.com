using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class RespuestaFactura
    {
        public string Mensaje { get; set; }
        public bool IsError { get; set; }
        public List<Factura> Facturas{ get; set; }
        public Factura Factura { get; set; }
    }
}
