namespace PuntoDeVenta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraIzquierda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelTipoUsuario = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.barraOpciones = new System.Windows.Forms.Panel();
            this.iconoMultiTab = new System.Windows.Forms.PictureBox();
            botonUsuarios = new System.Windows.Forms.Button();
            botonVentas = new System.Windows.Forms.Button();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.iconoMaximizar = new System.Windows.Forms.PictureBox();
            iconoCerrar = new System.Windows.Forms.PictureBox();
            botonInventario = new System.Windows.Forms.Button();
            panelContenedor = new System.Windows.Forms.Panel();
            this.barraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMultiTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(iconoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // barraIzquierda
            // 
            this.barraIzquierda.BackColor = System.Drawing.Color.DimGray;
            this.barraIzquierda.Controls.Add(this.pictureBox1);
            this.barraIzquierda.Controls.Add(this.labelNombreUsuario);
            this.barraIzquierda.Controls.Add(this.labelTipoUsuario);
            this.barraIzquierda.Controls.Add(button1);
            this.barraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraIzquierda.Location = new System.Drawing.Point(0, 0);
            this.barraIzquierda.Name = "barraIzquierda";
            this.barraIzquierda.Size = new System.Drawing.Size(230, 630);
            this.barraIzquierda.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(44, 607);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(97, 14);
            this.labelNombreUsuario.TabIndex = 2;
            this.labelNombreUsuario.Text = "Nombre usuario";
            // 
            // labelTipoUsuario
            // 
            this.labelTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTipoUsuario.AutoSize = true;
            this.labelTipoUsuario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUsuario.Location = new System.Drawing.Point(72, 574);
            this.labelTipoUsuario.Name = "labelTipoUsuario";
            this.labelTipoUsuario.Size = new System.Drawing.Size(119, 17);
            this.labelTipoUsuario.TabIndex = 1;
            this.labelTipoUsuario.Text = "Tipo de usuario";
            // 
            // button1
            // 
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(149, 461);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 74);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barraOpciones
            // 
            this.barraOpciones.BackColor = System.Drawing.Color.LimeGreen;
            this.barraOpciones.Controls.Add(this.iconoMultiTab);
            this.barraOpciones.Controls.Add(botonUsuarios);
            this.barraOpciones.Controls.Add(botonVentas);
            this.barraOpciones.Controls.Add(this.iconoMinimizar);
            this.barraOpciones.Controls.Add(this.iconoMaximizar);
            this.barraOpciones.Controls.Add(iconoCerrar);
            this.barraOpciones.Controls.Add(botonInventario);
            this.barraOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraOpciones.Location = new System.Drawing.Point(230, 0);
            this.barraOpciones.Name = "barraOpciones";
            this.barraOpciones.Size = new System.Drawing.Size(1020, 110);
            this.barraOpciones.TabIndex = 1;
            this.barraOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraOpciones_MouseDown);
            // 
            // iconoMultiTab
            // 
            this.iconoMultiTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMultiTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoMultiTab.Image = ((System.Drawing.Image)(resources.GetObject("iconoMultiTab.Image")));
            this.iconoMultiTab.Location = new System.Drawing.Point(952, 3);
            this.iconoMultiTab.Name = "iconoMultiTab";
            this.iconoMultiTab.Size = new System.Drawing.Size(33, 24);
            this.iconoMultiTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMultiTab.TabIndex = 0;
            this.iconoMultiTab.TabStop = false;
            this.iconoMultiTab.Visible = false;
            this.iconoMultiTab.Click += new System.EventHandler(this.iconoMultiTab_Click);
            this.iconoMultiTab.MouseLeave += new System.EventHandler(this.iconoMultiTab_MouseLeave);
            this.iconoMultiTab.MouseHover += new System.EventHandler(this.iconoMultiTab_MouseHover);
            // 
            // botonUsuarios
            // 
            botonUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            botonUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonUsuarios.BackgroundImage")));
            botonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            botonUsuarios.Cursor = System.Windows.Forms.Cursors.Arrow;
            botonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            botonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonUsuarios.Location = new System.Drawing.Point(682, 31);
            botonUsuarios.Name = "botonUsuarios";
            botonUsuarios.Size = new System.Drawing.Size(338, 79);
            botonUsuarios.TabIndex = 3;
            botonUsuarios.UseVisualStyleBackColor = true;
            botonUsuarios.Click += new System.EventHandler(this.botonUsuarios_Click);
            // 
            // botonVentas
            // 
            botonVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            botonVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVentas.BackgroundImage")));
            botonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            botonVentas.Cursor = System.Windows.Forms.Cursors.Default;
            botonVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            botonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonVentas.Location = new System.Drawing.Point(312, 31);
            botonVentas.Name = "botonVentas";
            botonVentas.Size = new System.Drawing.Size(373, 79);
            botonVentas.TabIndex = 2;
            botonVentas.UseVisualStyleBackColor = true;
            botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMinimizar.Image")));
            this.iconoMinimizar.Location = new System.Drawing.Point(920, 12);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(29, 18);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 0;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            this.iconoMinimizar.MouseLeave += new System.EventHandler(this.iconoMinimizar_MouseLeave);
            this.iconoMinimizar.MouseHover += new System.EventHandler(this.iconoMinimizar_MouseHover);
            // 
            // iconoMaximizar
            // 
            this.iconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMaximizar.Image")));
            this.iconoMaximizar.Location = new System.Drawing.Point(952, 3);
            this.iconoMaximizar.Name = "iconoMaximizar";
            this.iconoMaximizar.Size = new System.Drawing.Size(30, 24);
            this.iconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaximizar.TabIndex = 0;
            this.iconoMaximizar.TabStop = false;
            this.iconoMaximizar.Click += new System.EventHandler(this.iconoMaximizar_Click);
            this.iconoMaximizar.MouseLeave += new System.EventHandler(this.iconoMaximizar_MouseLeave);
            this.iconoMaximizar.MouseHover += new System.EventHandler(this.iconoMaximizar_MouseHover);
            // 
            // iconoCerrar
            // 
            iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iconoCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            iconoCerrar.Location = new System.Drawing.Point(988, 3);
            iconoCerrar.Name = "iconoCerrar";
            iconoCerrar.Size = new System.Drawing.Size(26, 24);
            iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            iconoCerrar.TabIndex = 0;
            iconoCerrar.TabStop = false;
            iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            iconoCerrar.MouseLeave += new System.EventHandler(this.iconoCerrar_MouseLeave);
            iconoCerrar.MouseHover += new System.EventHandler(this.iconoCerrar_MouseHover);
            // 
            // botonInventario
            // 
            botonInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            botonInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInventario.BackgroundImage")));
            botonInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            botonInventario.Cursor = System.Windows.Forms.Cursors.Default;
            botonInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            botonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonInventario.ForeColor = System.Drawing.Color.LimeGreen;
            botonInventario.Location = new System.Drawing.Point(0, 31);
            botonInventario.Name = "botonInventario";
            botonInventario.Size = new System.Drawing.Size(313, 79);
            botonInventario.TabIndex = 1;
            botonInventario.UseVisualStyleBackColor = true;
            botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.Ivory;
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(230, 110);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(1020, 520);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 630);
            this.Controls.Add(panelContenedor);
            this.Controls.Add(this.barraOpciones);
            this.Controls.Add(this.barraIzquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraIzquierda.ResumeLayout(false);
            this.barraIzquierda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMultiTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(iconoCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraIzquierda;
        private System.Windows.Forms.Panel barraOpciones;
        public static System.Windows.Forms.Button botonUsuarios;
        public static System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox iconoMultiTab;
        private System.Windows.Forms.PictureBox iconoMaximizar;
        public static System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelTipoUsuario;
        public static System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public static System.Windows.Forms.Button botonInventario;
        public static System.Windows.Forms.Panel panelContenedor;
    }
}

