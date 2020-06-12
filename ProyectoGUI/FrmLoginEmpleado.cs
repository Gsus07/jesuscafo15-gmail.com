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
using BLL;
namespace ProyectoGUI
{
    public partial class FrmLoginEmpleado : Form
    {
        public FrmLoginEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Respuesta respuesta = new Respuesta();
            UsuarioService usuarioService = new UsuarioService();
            respuesta = usuarioService.BuscarTipo("Empleado");
            foreach (var item in respuesta.Usuarios)
            {
                if (item.User == txtUsuario.Text && item.Contraseña == txtContraseña.Text)
                {
                    Visible = false;
                    FrmMenuAdministrardor frmMenuEmpleado = new FrmMenuAdministrador();
                    frmMenuEmpleado.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO / CONTRASEÑA INVALIDOS");
                }
            }*/
            Visible = false;
            FrmFacturas frmMenuEmpleado = new FrmFacturas();
            frmMenuEmpleado.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
            InicioGUI inicio = new InicioGUI();
            inicio.Visible = true;
        }
    }
}
