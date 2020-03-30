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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

        

        private void BtnGestionClientes_Click_1(object sender, EventArgs e)
        {
            PanelFormulario.Visible = true;
            dataGridView1.Visible = false;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            PanelFormulario.Visible = false;
            dataGridView1.Visible = true;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            Registro2.Visible = true;
        }

        private void PbAtras_Click_1(object sender, EventArgs e)
        {
            Registro2.Visible = false;
        }

        private void siguiente2_Click(object sender, EventArgs e)
        {
            registro3.Visible = true;
        }

        private void atras2_Click(object sender, EventArgs e)
        {
            registro3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registro3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Limpiar()
        {
            txtId.Text = string.Empty;
            txtprimerN.Text = string.Empty;
            txtPrimerA.Text = string.Empty;
            txtSegundoN.Text = string.Empty;
            txtSegundoA.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            CmbGenero.Text = string.Empty;
            CmbBarrio.Text = string.Empty;
            CmbCiudad.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtiddireccion.Text = string.Empty;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            Domicilio domicilio = new Domicilio();
            RespuestaCliente respuesta = new RespuestaCliente();
            Cliente cliente = new Cliente();
            cliente.Cedula=txtId.Text;
            cliente.PrimerNombre = txtprimerN.Text;
            cliente.PrimerApellido = txtPrimerA.Text;
            cliente.SegundoNombre = txtSegundoN.Text;
            cliente.SegundoApellido = txtSegundoA.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Telefono = TxtTelefono.Text;
            cliente.Genero = CmbGenero.Text;
            domicilio.Barrio = CmbBarrio.Text;
            domicilio.Ciudad = CmbCiudad.Text;
            domicilio.Direccion = txtdireccion.Text;
            domicilio.Domicilioid = txtiddireccion.Text;
            cliente.Domicilio = domicilio;
            cliente.FechaNacimiento = DtpFechaNacimiento.Value;
            cliente.CalcularEdad();
            respuesta = clienteService.Guardar(cliente);
            Limpiar();
            MessageBox.Show(respuesta.Mensaje);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //ClienteService clienteService = new ClienteService();
            //RespuestaCliente respuestaCliente = clienteService.Buscar(txtIDb.Text);
            //txtId.Text = respuestaCliente.Cliente.Cedula;
            //txtprimerN.Text = respuestaCliente.Cliente.Cedula;
            //txtPrimerA.Text = respuestaCliente.Cliente.Cedula;
            //txtSegundoN.Text = respuestaCliente.Cliente.Cedula;
            //txtSegundoA.Text = respuestaCliente.Cliente.Cedula;
            //txtCorreo.Text = string.Empty;
            //TxtTelefono.Text = string.Empty;
            //CmbGenero.Text = string.Empty;
            //CmbBarrio.Text = string.Empty;
            //CmbCiudad.Text = string.Empty;
            //txtdireccion.Text = string.Empty;
            //txtiddireccion.Text = string.Empty;


        }
    }
}
