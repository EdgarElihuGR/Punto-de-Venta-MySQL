namespace PuntoDeVenta.Forms.VentanasBase
{
    partial class FormMostrarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarProductos));
            this.label4 = new System.Windows.Forms.Label();
            this.tablaMostrarProductos = new System.Windows.Forms.DataGridView();
            this.botonAgregarProdAVender = new System.Windows.Forms.Button();
            this.iconoCerrarProductosAVender = new System.Windows.Forms.PictureBox();
            this.txtBoxBuscarVenta = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProdV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMostrarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarProductosAVender)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Productos";
            // 
            // tablaMostrarProductos
            // 
            this.tablaMostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMostrarProductos.Location = new System.Drawing.Point(12, 99);
            this.tablaMostrarProductos.Name = "tablaMostrarProductos";
            this.tablaMostrarProductos.ReadOnly = true;
            this.tablaMostrarProductos.Size = new System.Drawing.Size(550, 196);
            this.tablaMostrarProductos.TabIndex = 17;
            // 
            // botonAgregarProdAVender
            // 
            this.botonAgregarProdAVender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonAgregarProdAVender.BackColor = System.Drawing.Color.LimeGreen;
            this.botonAgregarProdAVender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAgregarProdAVender.BackgroundImage")));
            this.botonAgregarProdAVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAgregarProdAVender.FlatAppearance.BorderSize = 0;
            this.botonAgregarProdAVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.botonAgregarProdAVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregarProdAVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProdAVender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAgregarProdAVender.Location = new System.Drawing.Point(0, 353);
            this.botonAgregarProdAVender.Name = "botonAgregarProdAVender";
            this.botonAgregarProdAVender.Size = new System.Drawing.Size(574, 46);
            this.botonAgregarProdAVender.TabIndex = 18;
            this.botonAgregarProdAVender.UseVisualStyleBackColor = false;
            this.botonAgregarProdAVender.Click += new System.EventHandler(this.botonAgregarProdAVender_Click);
            // 
            // iconoCerrarProductosAVender
            // 
            this.iconoCerrarProductosAVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrarProductosAVender.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoCerrarProductosAVender.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrarProductosAVender.Image")));
            this.iconoCerrarProductosAVender.Location = new System.Drawing.Point(536, 9);
            this.iconoCerrarProductosAVender.Name = "iconoCerrarProductosAVender";
            this.iconoCerrarProductosAVender.Size = new System.Drawing.Size(26, 24);
            this.iconoCerrarProductosAVender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrarProductosAVender.TabIndex = 19;
            this.iconoCerrarProductosAVender.TabStop = false;
            this.iconoCerrarProductosAVender.Click += new System.EventHandler(this.iconoCerrarProductosAVender_Click);
            this.iconoCerrarProductosAVender.MouseLeave += new System.EventHandler(this.iconoCerrarProductosAVender_MouseLeave);
            this.iconoCerrarProductosAVender.MouseHover += new System.EventHandler(this.iconoCerrarProductosAVender_MouseHover);
            // 
            // txtBoxBuscarVenta
            // 
            this.txtBoxBuscarVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBuscarVenta.Location = new System.Drawing.Point(70, 60);
            this.txtBoxBuscarVenta.Name = "txtBoxBuscarVenta";
            this.txtBoxBuscarVenta.ShortcutsEnabled = false;
            this.txtBoxBuscarVenta.Size = new System.Drawing.Size(407, 20);
            this.txtBoxBuscarVenta.TabIndex = 20;
            this.txtBoxBuscarVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscarVenta_KeyPress);
            // 
            // Cantidad
            // 
            this.Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cantidad.Location = new System.Drawing.Point(117, 314);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ShortcutsEnabled = false;
            this.Cantidad.Size = new System.Drawing.Size(407, 20);
            this.Cantidad.TabIndex = 21;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad";
            // 
            // btnBuscarProdV
            // 
            this.btnBuscarProdV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProdV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProdV.BackgroundImage")));
            this.btnBuscarProdV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProdV.FlatAppearance.BorderSize = 0;
            this.btnBuscarProdV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarProdV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProdV.Location = new System.Drawing.Point(483, 58);
            this.btnBuscarProdV.Name = "btnBuscarProdV";
            this.btnBuscarProdV.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarProdV.TabIndex = 23;
            this.btnBuscarProdV.UseVisualStyleBackColor = true;
            this.btnBuscarProdV.Click += new System.EventHandler(this.btnBuscarProdV_Click);
            // 
            // FormMostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(574, 400);
            this.Controls.Add(this.btnBuscarProdV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.txtBoxBuscarVenta);
            this.Controls.Add(this.iconoCerrarProductosAVender);
            this.Controls.Add(this.botonAgregarProdAVender);
            this.Controls.Add(this.tablaMostrarProductos);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMostrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMostrarProductos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMostrarProductos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMostrarProductos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMostrarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarProductosAVender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaMostrarProductos;
        private System.Windows.Forms.Button botonAgregarProdAVender;
        private System.Windows.Forms.PictureBox iconoCerrarProductosAVender;
        private System.Windows.Forms.TextBox txtBoxBuscarVenta;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProdV;
    }
}