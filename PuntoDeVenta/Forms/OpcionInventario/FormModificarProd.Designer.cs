namespace PuntoDeVenta.Forms.OpcionInventario
{
    partial class FormModificarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconoCerrarModiProd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.txtBoxDescripModif = new System.Windows.Forms.TextBox();
            this.txtBoxStockModif = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioModif = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmarModifProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarModiProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.iconoCerrarModiProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 32);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconoCerrarModiProd
            // 
            this.iconoCerrarModiProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrarModiProd.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoCerrarModiProd.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrarModiProd.Image")));
            this.iconoCerrarModiProd.Location = new System.Drawing.Point(548, 5);
            this.iconoCerrarModiProd.Name = "iconoCerrarModiProd";
            this.iconoCerrarModiProd.Size = new System.Drawing.Size(26, 24);
            this.iconoCerrarModiProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrarModiProd.TabIndex = 1;
            this.iconoCerrarModiProd.TabStop = false;
            this.iconoCerrarModiProd.Click += new System.EventHandler(this.iconoCerrarModiProd_Click);
            this.iconoCerrarModiProd.MouseLeave += new System.EventHandler(this.iconoCerrarModiProd_MouseLeave);
            this.iconoCerrarModiProd.MouseHover += new System.EventHandler(this.iconoCerrarModiProd_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Productos";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(30, 161);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(98, 17);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(30, 120);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 17);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "#Stock:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(30, 77);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(58, 17);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "Precio:";
            // 
            // txtBoxDescripModif
            // 
            this.txtBoxDescripModif.Location = new System.Drawing.Point(151, 161);
            this.txtBoxDescripModif.MaxLength = 30;
            this.txtBoxDescripModif.Multiline = true;
            this.txtBoxDescripModif.Name = "txtBoxDescripModif";
            this.txtBoxDescripModif.Size = new System.Drawing.Size(236, 68);
            this.txtBoxDescripModif.TabIndex = 10;
            this.txtBoxDescripModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDescripModif_KeyPress);
            // 
            // txtBoxStockModif
            // 
            this.txtBoxStockModif.Location = new System.Drawing.Point(151, 120);
            this.txtBoxStockModif.Name = "txtBoxStockModif";
            this.txtBoxStockModif.Size = new System.Drawing.Size(236, 20);
            this.txtBoxStockModif.TabIndex = 9;
            this.txtBoxStockModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStockModif_KeyPress);
            // 
            // txtBoxPrecioModif
            // 
            this.txtBoxPrecioModif.Location = new System.Drawing.Point(151, 77);
            this.txtBoxPrecioModif.Name = "txtBoxPrecioModif";
            this.txtBoxPrecioModif.Size = new System.Drawing.Size(236, 20);
            this.txtBoxPrecioModif.TabIndex = 8;
            this.txtBoxPrecioModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrecioModif_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnConfirmarModifProd
            // 
            this.btnConfirmarModifProd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarModifProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarModifProd.BackgroundImage")));
            this.btnConfirmarModifProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarModifProd.FlatAppearance.BorderSize = 0;
            this.btnConfirmarModifProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnConfirmarModifProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarModifProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarModifProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarModifProd.Location = new System.Drawing.Point(232, 244);
            this.btnConfirmarModifProd.Name = "btnConfirmarModifProd";
            this.btnConfirmarModifProd.Size = new System.Drawing.Size(101, 97);
            this.btnConfirmarModifProd.TabIndex = 12;
            this.btnConfirmarModifProd.UseVisualStyleBackColor = false;
            this.btnConfirmarModifProd.Click += new System.EventHandler(this.btnConfirmarModifProd_Click);
            // 
            // FormModificarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(586, 353);
            this.Controls.Add(this.btnConfirmarModifProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxDescripModif);
            this.Controls.Add(this.txtBoxStockModif);
            this.Controls.Add(this.txtBoxPrecioModif);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModificarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarProd";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormModificarProd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormModificarProd_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarModiProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconoCerrarModiProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmarModifProd;
        public System.Windows.Forms.TextBox txtBoxDescripModif;
        public System.Windows.Forms.TextBox txtBoxStockModif;
        public System.Windows.Forms.TextBox txtBoxPrecioModif;
    }
}