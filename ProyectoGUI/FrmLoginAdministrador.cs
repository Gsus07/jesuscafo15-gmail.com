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
    public partial class FrmLoginAdministrador : Form
    {
        public FrmLoginAdministrador()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txtUsuario.Text == "system" && txtContraseña.Text == "root")
            {
                Visible = false;
                FrmMenuAministrador frmMenuAministrador = new FrmMenuAministrador();
                frmMenuAministrador.Show();
            }
            else
            {
                Respuesta respuesta = new Respuesta();
                UsuarioService usuarioService = new UsuarioService();
                respuesta = usuarioService.BuscarTipo("Administrador");
                foreach (var item in respuesta.Usuarios)
                {
                    if (item.User == txtUsuario.Text && item.Contraseña == txtContraseña.Text)
                    {
                        Visible = false;
                        FrmMenuAministrador frmMenuAministrador = new FrmMenuAministrador();
                        frmMenuAministrador.Show();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO / CONTRASEÑA INVALIDOS");
                    }
                }


            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
            InicioGUI inicio = new InicioGUI();
            inicio.Visible = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
