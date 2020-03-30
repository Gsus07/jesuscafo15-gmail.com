using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ProyectoGUI
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public  void Limpiar()
        {
            txtId.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            CmbTipo.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnGestionAdmins_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            PanelFormulario.Visible = true;
        }

        private void PanelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            PanelFormulario.Visible = false;
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            UsuarioService usuarioService = new UsuarioService();
            Respuesta respuesta = new Respuesta();
            Usuario usuario = new Usuario();
            usuario.IDUsuario = txtId.Text;
            usuario.User = txtUsuario.Text;
            usuario.Tipo = CmbTipo.Text;
            usuario.Contraseña = txtContraseña.Text;
            respuesta = usuarioService.Guardar(usuario);
            Limpiar();
            MessageBox.Show(respuesta.Mensaje);
        }

        public void BuscarId()
        {
            UsuarioService usuarioService = new UsuarioService();
            Respuesta respuesta = new Respuesta();
            respuesta = usuarioService.Buscar(txtIDb.Text);
            if (respuesta.IsError == false)
            {
                txtId.Text = respuesta.Usuario.IDUsuario;
                txtUsuario.Text = respuesta.Usuario.User;
                txtContraseña.Text = respuesta.Usuario.Contraseña;
                CmbTipo.Text = respuesta.Usuario.Tipo;
                txtId.ReadOnly = true;
                
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
            UsuarioService usuarioService = new UsuarioService();
            Respuesta respuesta = new Respuesta();
            respuesta = usuarioService.ConsultarTodos();
            if (respuesta.IsError == false)
            {

                dataGridView1.DataSource = respuesta.Usuarios;
                
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BuscarId();
            var respuesta = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Respuesta respuestaEliminar = new Respuesta();
                UsuarioService usuarioService = new UsuarioService();
                respuestaEliminar = usuarioService.Eliminar(txtIDb.Text);
                if (respuestaEliminar.IsError == false)
                {
                    MessageBox.Show(respuestaEliminar.Mensaje);
                    Limpiar();
                    txtId.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show(respuestaEliminar.Mensaje);
                }

            }
            else
            {
                Limpiar();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.IDUsuario = txtId.Text;
            usuario.User = txtUsuario.Text;
            usuario.Tipo = CmbTipo.Text;
            usuario.Contraseña = txtContraseña.Text;
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Advertencia", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Respuesta respuestaEditar = new Respuesta();
                UsuarioService usuarioService = new UsuarioService();
                respuestaEditar = usuarioService.Editar(usuario);
                if (respuestaEditar.IsError == false)
                {
                    MessageBox.Show(respuestaEditar.Mensaje);
                    Limpiar();
                    txtId.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show(respuestaEditar.Mensaje);
                }

            }
            else
            {
                Limpiar();
            }
        }
    }
}
