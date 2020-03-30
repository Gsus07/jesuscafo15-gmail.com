using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ProyectoGUI
{
    public partial class FrmMenuEmpleado : Form
    {
        public FrmMenuEmpleado()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿DESEA SALIR DEL PROGRAMA?", "SALIR", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconMinimizar.Visible = true;
            IconMaximizar.Visible = false;

        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconMaximizar.Visible = true;
            IconMinimizar.Visible = false;

        }

        private void IconOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void button7_Click(object sender, EventArgs e)
        {

        }

        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PnlContenedor.Controls.Add(formulario);
                PnlContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        

        private void BtnCerrarSesion_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR SESION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                FrmLoginEmpleado frmloginEmpleado = new FrmLoginEmpleado();
                frmloginEmpleado.Show();
            }

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmClientes>();

        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario<FrmFacturas>();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProductos>();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
