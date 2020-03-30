namespace ProyectoGUI
{
    partial class FrmMenuEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconOcultar = new System.Windows.Forms.PictureBox();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Controls.Add(this.BtnProductos);
            this.panel1.Controls.Add(this.BtnFacturas);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 731);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(44, 539);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(82, 530);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(159, 41);
            this.BtnCerrarSesion.TabIndex = 16;
            this.BtnCerrarSesion.Text = "Cerrar sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductos.Image")));
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(-1, 197);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(300, 49);
            this.BtnProductos.TabIndex = 5;
            this.BtnProductos.Text = "PRODUCTOS";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.White;
            this.BtnFacturas.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacturas.Image")));
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(-1, 154);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(300, 49);
            this.BtnFacturas.TabIndex = 4;
            this.BtnFacturas.Text = "FACTURAS";
            this.BtnFacturas.UseVisualStyleBackColor = true;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(-1, 109);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(300, 49);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "CLIENTES";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(82, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(98, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.lblFecha.Location = new System.Drawing.Point(874, 623);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.lblHora.Location = new System.Drawing.Point(917, 592);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 20);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "label1";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.pictureBox1);
            this.PnlTitulo.Controls.Add(this.IconOcultar);
            this.PnlTitulo.Controls.Add(this.IconMinimizar);
            this.PnlTitulo.Controls.Add(this.IconMaximizar);
            this.PnlTitulo.Controls.Add(this.IconCerrar);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(300, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1079, 50);
            this.PnlTitulo.TabIndex = 1;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // IconOcultar
            // 
            this.IconOcultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconOcultar.Image = ((System.Drawing.Image)(resources.GetObject("IconOcultar.Image")));
            this.IconOcultar.Location = new System.Drawing.Point(977, 12);
            this.IconOcultar.Name = "IconOcultar";
            this.IconOcultar.Size = new System.Drawing.Size(26, 21);
            this.IconOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconOcultar.TabIndex = 4;
            this.IconOcultar.TabStop = false;
            this.IconOcultar.Click += new System.EventHandler(this.IconOcultar_Click);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(1009, 12);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(26, 21);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 3;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Visible = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximizar.Image")));
            this.IconMaximizar.Location = new System.Drawing.Point(1009, 12);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(26, 21);
            this.IconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMaximizar.TabIndex = 2;
            this.IconMaximizar.TabStop = false;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(1041, 12);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(26, 21);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.lblFecha);
            this.PnlContenedor.Controls.Add(this.lblHora);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(300, 50);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1079, 681);
            this.PnlContenedor.TabIndex = 3;
            this.PnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContenedor_Paint);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 731);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuEmpleado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox IconMaximizar;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconOcultar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}