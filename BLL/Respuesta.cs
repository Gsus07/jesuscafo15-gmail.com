using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class Respuesta
    {
        public string Mensaje { get; set; }
        public bool IsError { get; set; }
        public List<Usuario> Usuarios{ get; set; }
        public Usuario Usuario { get; set; }
    }
}
