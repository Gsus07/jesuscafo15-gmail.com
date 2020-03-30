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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCantidadBodega.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void DtgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGestionProductos_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = true;
            dataGridView1.Visible = false;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = false;
            dataGridView1.Visible = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            RespuestaProducto respuesta = new RespuestaProducto();
            Producto producto = new Producto();
            producto.CodigoProducto = txtId.Text;
            producto.Nombre = txtDescripcion.Text;
            producto.CantidadBodega = int.Parse(txtCantidadBodega.Text);
            producto.ValorUnitario = decimal.Parse(txtValorUnitario.Text);
            respuesta = productoService.Guardar(producto);
            Limpiar();
            MessageBox.Show(respuesta.Mensaje);
        }
        public void BuscarId()
        {
            ProductoService productoService = new ProductoService();
            RespuestaProducto respuesta = new RespuestaProducto();
            respuesta = productoService.Buscar(txtIDb.Text);
            if (respuesta.IsError == false)
            {
                txtId.Text = respuesta.Producto.CodigoProducto;
                txtDescripcion.Text = respuesta.Producto.Nombre;
                txtCantidadBodega.Text = respuesta.Producto.CantidadBodega.ToString();
                txtValorUnitario.Text = respuesta.Producto.ValorUnitario.ToString();

            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarId();
        }

        private void pbConsultar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            RespuestaProducto respuesta = new RespuestaProducto();
            respuesta = productoService.ConsultarTodos();
            if (respuesta.IsError == false)
            {

                dataGridView1.DataSource = respuesta.Productos;

            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BuscarId();
            var respuestamensaje = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo);
            if (respuestamensaje == DialogResult.Yes)
            {
                ProductoService productoService = new ProductoService();
                RespuestaProducto respuesta = new RespuestaProducto();
                respuesta= productoService.Eliminar(txtIDb.Text);
                if (respuesta.IsError == false)
                {
                    MessageBox.Show(respuesta.Mensaje);
                    Limpiar();
                    txtId.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }

            }
            else
            {
                Limpiar();
            }
        }
    }
}
