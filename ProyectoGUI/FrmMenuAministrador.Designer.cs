namespace ProyectoGUI
{
    partial class FrmMenuAministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 731);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(57, 506);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
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
            this.BtnCerrarSesion.Location = new System.Drawing.Point(96, 501);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(159, 41);
            this.BtnCerrarSesion.TabIndex = 6;
            this.BtnCerrarSesion.Text = "Cerrar sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Location = new System.Drawing.Point(-1, 160);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(300, 49);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "USUARIOS";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnAdministradores_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(53, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 1);
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
            this.lblFecha.Location = new System.Drawing.Point(868, 623);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.lblHora.Location = new System.Drawing.Point(911, 592);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 20);
            this.lblHora.TabIndex = 12;
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
            this.PnlTitulo.Size = new System.Drawing.Size(1067, 50);
            this.PnlTitulo.TabIndex = 1;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
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
            this.IconOcultar.Location = new System.Drawing.Point(965, 12);
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
            this.IconMinimizar.Location = new System.Drawing.Point(997, 12);
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
            this.IconMaximizar.Location = new System.Drawing.Point(997, 12);
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
            this.IconCerrar.Location = new System.Drawing.Point(1029, 12);
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
            this.PnlContenedor.Size = new System.Drawing.Size(1067, 681);
            this.PnlContenedor.TabIndex = 2;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmMenuAministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 731);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuAministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuEmpleado";
            this.Load += new System.EventHandler(this.FrmMenuAministrador_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox IconMaximizar;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconOcultar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
    }
}