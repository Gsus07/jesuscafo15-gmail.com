namespace ProyectoGUI
{
    partial class InicioGUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioGUI));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbTitulo = new System.Windows.Forms.PictureBox();
            this.IconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconOcultar = new System.Windows.Forms.PictureBox();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextoIntro = new System.Windows.Forms.Label();
            this.BtnIngresarAdmin = new System.Windows.Forms.Button();
            this.BtnIngresarEmpleado = new System.Windows.Forms.Button();
            this.TextoEmpleados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconEmpresa = new System.Windows.Forms.PictureBox();
            this.TextoAdmin = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.PnlMenu.SuspendLayout();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.PnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMenu.Controls.Add(this.lblFecha);
            this.PnlMenu.Controls.Add(this.lblHora);
            this.PnlMenu.Controls.Add(this.BtnAdmin);
            this.PnlMenu.Controls.Add(this.BtnEmpleados);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(209, 431);
            this.PnlMenu.TabIndex = 0;
            this.PnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(-2, 367);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Location = new System.Drawing.Point(29, 336);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 20);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "label1";
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdmin.FlatAppearance.BorderSize = 0;
            this.BtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.Image")));
            this.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmin.Location = new System.Drawing.Point(11, 132);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(177, 40);
            this.BtnAdmin.TabIndex = 2;
            this.BtnAdmin.Text = "Administrador";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleados.Image")));
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(11, 86);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(177, 40);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.Text = "Empleado";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.PbTitulo);
            this.PnlTitulo.Controls.Add(this.IconMaximizar);
            this.PnlTitulo.Controls.Add(this.IconOcultar);
            this.PnlTitulo.Controls.Add(this.IconMinimizar);
            this.PnlTitulo.Controls.Add(this.IconCerrar);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(209, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(377, 54);
            this.PnlTitulo.TabIndex = 1;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbTitulo
            // 
            this.PbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.PbTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("PbTitulo.Image")));
            this.PbTitulo.Location = new System.Drawing.Point(0, 8);
            this.PbTitulo.Name = "PbTitulo";
            this.PbTitulo.Size = new System.Drawing.Size(217, 43);
            this.PbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTitulo.TabIndex = 0;
            this.PbTitulo.TabStop = false;
            this.PbTitulo.Click += new System.EventHandler(this.PbTitulo_Click);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximizar.Image")));
            this.IconMaximizar.Location = new System.Drawing.Point(316, 3);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(26, 21);
            this.IconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMaximizar.TabIndex = 1;
            this.IconMaximizar.TabStop = false;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconOcultar
            // 
            this.IconOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconOcultar.Image = ((System.Drawing.Image)(resources.GetObject("IconOcultar.Image")));
            this.IconOcultar.Location = new System.Drawing.Point(284, 3);
            this.IconOcultar.Name = "IconOcultar";
            this.IconOcultar.Size = new System.Drawing.Size(26, 21);
            this.IconOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconOcultar.TabIndex = 1;
            this.IconOcultar.TabStop = false;
            this.IconOcultar.Click += new System.EventHandler(this.IconOcultar_Click);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(316, 3);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(26, 21);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 1;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Visible = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(348, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(26, 21);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 0;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextoIntro);
            this.panel1.Controls.Add(this.BtnIngresarAdmin);
            this.panel1.Controls.Add(this.BtnIngresarEmpleado);
            this.panel1.Controls.Add(this.TextoEmpleados);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.IconEmpresa);
            this.panel1.Controls.Add(this.TextoAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(209, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 377);
            this.panel1.TabIndex = 2;
            // 
            // TextoIntro
            // 
            this.TextoIntro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextoIntro.AutoSize = true;
            this.TextoIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoIntro.Location = new System.Drawing.Point(-4, 162);
            this.TextoIntro.Name = "TextoIntro";
            this.TextoIntro.Size = new System.Drawing.Size(384, 51);
            this.TextoIntro.TabIndex = 5;
            this.TextoIntro.Text = " El proyecto Tefra es una aplicación orientada a la gestión \r\nde datos de cliente" +
    "s, y facturado de los pedidos solicitados \r\na la empresa Bollos pabla.";
            // 
            // BtnIngresarAdmin
            // 
            this.BtnIngresarAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresarAdmin.FlatAppearance.BorderSize = 0;
            this.BtnIngresarAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnIngresarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresarAdmin.Image")));
            this.BtnIngresarAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnIngresarAdmin.Location = new System.Drawing.Point(92, 254);
            this.BtnIngresarAdmin.Name = "BtnIngresarAdmin";
            this.BtnIngresarAdmin.Size = new System.Drawing.Size(193, 62);
            this.BtnIngresarAdmin.TabIndex = 4;
            this.BtnIngresarAdmin.Text = "INGRESAR";
            this.BtnIngresarAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnIngresarAdmin.UseVisualStyleBackColor = true;
            this.BtnIngresarAdmin.Visible = false;
            this.BtnIngresarAdmin.Click += new System.EventHandler(this.BtnIngresarAdmin_Click);
            // 
            // BtnIngresarEmpleado
            // 
            this.BtnIngresarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresarEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnIngresarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnIngresarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngresarEmpleado.Image")));
            this.BtnIngresarEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnIngresarEmpleado.Location = new System.Drawing.Point(92, 254);
            this.BtnIngresarEmpleado.Name = "BtnIngresarEmpleado";
            this.BtnIngresarEmpleado.Size = new System.Drawing.Size(193, 62);
            this.BtnIngresarEmpleado.TabIndex = 3;
            this.BtnIngresarEmpleado.Text = "INGRESAR";
            this.BtnIngresarEmpleado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnIngresarEmpleado.UseVisualStyleBackColor = true;
            this.BtnIngresarEmpleado.Visible = false;
            this.BtnIngresarEmpleado.Click += new System.EventHandler(this.BtnIngresarEmpleado_Click);
            // 
            // TextoEmpleados
            // 
            this.TextoEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextoEmpleados.AutoSize = true;
            this.TextoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoEmpleados.Location = new System.Drawing.Point(-16, 162);
            this.TextoEmpleados.Name = "TextoEmpleados";
            this.TextoEmpleados.Size = new System.Drawing.Size(409, 51);
            this.TextoEmpleados.TabIndex = 2;
            this.TextoEmpleados.Text = "Como Empleado Podras gestionar la información de los clientes\r\nrealizar una gesti" +
    "ón de los pedidos y realizar la facturaricion de\r\ncualquier pedido";
            this.TextoEmpleados.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IconEmpresa
            // 
            this.IconEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IconEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.IconEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("IconEmpresa.Image")));
            this.IconEmpresa.Location = new System.Drawing.Point(119, 17);
            this.IconEmpresa.Name = "IconEmpresa";
            this.IconEmpresa.Size = new System.Drawing.Size(140, 142);
            this.IconEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconEmpresa.TabIndex = 1;
            this.IconEmpresa.TabStop = false;
            // 
            // TextoAdmin
            // 
            this.TextoAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextoAdmin.AutoSize = true;
            this.TextoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAdmin.Location = new System.Drawing.Point(-6, 162);
            this.TextoAdmin.Name = "TextoAdmin";
            this.TextoAdmin.Size = new System.Drawing.Size(388, 51);
            this.TextoAdmin.TabIndex = 6;
            this.TextoAdmin.Text = "Como Administrador podras llevar la gestion de la personas \r\nque Acceden a la apl" +
    "icacion y asi asegurar la informacion \r\nde los clientes";
            this.TextoAdmin.Visible = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // InicioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.PnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbTitulo;
        private System.Windows.Forms.PictureBox IconMaximizar;
        private System.Windows.Forms.PictureBox IconOcultar;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IconEmpresa;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Label TextoEmpleados;
        private System.Windows.Forms.Button BtnIngresarEmpleado;
        private System.Windows.Forms.Button BtnIngresarAdmin;
        private System.Windows.Forms.Label TextoIntro;
        private System.Windows.Forms.Label TextoAdmin;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}

