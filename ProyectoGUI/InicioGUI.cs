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
    public partial class InicioGUI : Form
    {
        public InicioGUI()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam );

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconMaximizar.Visible = true;
            IconMinimizar.Visible = false;

        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconMinimizar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void PbTitulo_Click(object sender, EventArgs e)
        {
            TextoIntro.Visible = true;
            IconEmpresa.Visible = true;
            TextoAdmin.Visible = false;
            TextoEmpleados.Visible = false;
            BtnIngresarAdmin.Visible = false;
            BtnIngresarEmpleado.Visible = false;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            TextoIntro.Visible = false;
            IconEmpresa.Visible = true;
            TextoAdmin.Visible = false;
            TextoEmpleados.Visible = true;
            BtnIngresarAdmin.Visible = false;
            BtnIngresarEmpleado.Visible = true;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            TextoIntro.Visible = false;
            IconEmpresa.Visible = true;
            TextoAdmin.Visible = true;
            TextoEmpleados.Visible = false;
            BtnIngresarAdmin.Visible = true;
            BtnIngresarEmpleado.Visible = false;
        }

        private void BtnIngresarAdmin_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmLoginAdministrador frmLoginAdministrador = new FrmLoginAdministrador();
            frmLoginAdministrador.Visible = true;
        }

        private void BtnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmLoginEmpleado frmLoginEmpleado = new FrmLoginEmpleado();
            frmLoginEmpleado.Visible = true;

        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
