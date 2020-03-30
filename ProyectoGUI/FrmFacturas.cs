using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
namespace ProyectoGUI
{
    public partial class FrmFacturas : Form
    {
        Factura factura = new Factura();
        public FrmFacturas()
        {
             
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            PanelDatagrid.Visible = true;
            PanelFormulario.Visible = false;

        }

       

        private void PanelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGestionProductos_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = true;
  
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void AgregarDetalle_Click(object sender, EventArgs e)
        {
            txtdetallefactura.Text = "";
            txtproducto.Text = "";
            txtcantidad.Text = "";
            txtiva.Text = "";
        }

        private void AgregarDetalle_Click_1(object sender, EventArgs e)
        {
            
            ProductoService productoService = new ProductoService();
            RespuestaProducto respuesta = new RespuestaProducto();
            respuesta = productoService.Buscar(txtproducto.Text);
            Producto producto = respuesta.Producto;
            decimal precio = producto.ValorUnitario * int.Parse(txtcantidad.Text);
            
            if (respuesta.IsError == false)
            {

                dataGridView4.Rows.Add(txtdetallefactura.Text,producto.Nombre,producto.ValorUnitario,txtcantidad.Text,txtiva.Text,precio);
                factura.AgregarDetalleFactura(txtdetallefactura.Text,producto, int.Parse(txtcantidad.Text), decimal.Parse(txtiva.Text));
                factura.CalcularTotal();
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            

        }
        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FacturaService facturaService = new FacturaService();         
            ClienteService clienteService = new ClienteService();
            RespuestaCliente respuestaCliente = new RespuestaCliente();
            respuestaCliente = clienteService.Buscar(txtcedula.Text);
            Cliente cliente = respuestaCliente.Cliente;

            factura.FechaFactura = dateTimePicker1.Value;
            factura.CodigoFactura = txtId.Text;
            factura.cliente = cliente;
            
            RespuestaFactura respuestaFactura = facturaService.Guardar(factura);
            if (respuestaFactura.IsError == false)
            {
                MessageBox.Show(respuestaFactura.Mensaje);
                dataGridView4.Rows.Clear();
                factura = null;
            }
            else
            {
                MessageBox.Show(respuestaFactura.Mensaje);
            }
            
            
            
        }
    }
}
