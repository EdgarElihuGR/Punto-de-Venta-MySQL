namespace PuntoDeVenta.Forms.OpcionInventario
{
    partial class FormRegistrarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProd));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconoCerrarRegiProd = new System.Windows.Forms.PictureBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxPrecioRegis = new System.Windows.Forms.TextBox();
            this.textBoxStockRegis = new System.Windows.Forms.TextBox();
            this.textBoxDescripRegis = new System.Windows.Forms.TextBox();
            this.botonConfirmarRegisProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarRegiProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.iconoCerrarRegiProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 32);
            this.panel1.TabIndex = 1;
            // 
            // iconoCerrarRegiProd
            // 
            this.iconoCerrarRegiProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrarRegiProd.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoCerrarRegiProd.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrarRegiProd.Image")));
            this.iconoCerrarRegiProd.Location = new System.Drawing.Point(548, 5);
            this.iconoCerrarRegiProd.Name = "iconoCerrarRegiProd";
            this.iconoCerrarRegiProd.Size = new System.Drawing.Size(26, 24);
            this.iconoCerrarRegiProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrarRegiProd.TabIndex = 1;
            this.iconoCerrarRegiProd.TabStop = false;
            this.iconoCerrarRegiProd.Click += new System.EventHandler(this.iconoCerrarRegiProd_Click);
            this.iconoCerrarRegiProd.MouseLeave += new System.EventHandler(this.iconoCerrarRegiProd_MouseLeave);
            this.iconoCerrarRegiProd.MouseHover += new System.EventHandler(this.iconoCerrarRegiProd_MouseHover);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(30, 77);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(58, 17);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(30, 120);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 17);
            this.labelStock.TabIndex = 3;
            this.labelStock.Text = "#Stock:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(30, 161);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(98, 17);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxPrecioRegis
            // 
            this.textBoxPrecioRegis.Location = new System.Drawing.Point(151, 77);
            this.textBoxPrecioRegis.Name = "textBoxPrecioRegis";
            this.textBoxPrecioRegis.Size = new System.Drawing.Size(236, 20);
            this.textBoxPrecioRegis.TabIndex = 5;
            this.textBoxPrecioRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecioRegis_KeyPress);
            // 
            // textBoxStockRegis
            // 
            this.textBoxStockRegis.Location = new System.Drawing.Point(151, 120);
            this.textBoxStockRegis.Name = "textBoxStockRegis";
            this.textBoxStockRegis.Size = new System.Drawing.Size(236, 20);
            this.textBoxStockRegis.TabIndex = 6;
            this.textBoxStockRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockRegis_KeyPress);
            // 
            // textBoxDescripRegis
            // 
            this.textBoxDescripRegis.Location = new System.Drawing.Point(151, 161);
            this.textBoxDescripRegis.MaxLength = 30;
            this.textBoxDescripRegis.Multiline = true;
            this.textBoxDescripRegis.Name = "textBoxDescripRegis";
            this.textBoxDescripRegis.Size = new System.Drawing.Size(236, 68);
            this.textBoxDescripRegis.TabIndex = 7;
            this.textBoxDescripRegis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescripRegis_KeyPress);
            // 
            // botonConfirmarRegisProd
            // 
            this.botonConfirmarRegisProd.BackColor = System.Drawing.Color.LimeGreen;
            this.botonConfirmarRegisProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonConfirmarRegisProd.BackgroundImage")));
            this.botonConfirmarRegisProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonConfirmarRegisProd.FlatAppearance.BorderSize = 0;
            this.botonConfirmarRegisProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.botonConfirmarRegisProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConfirmarRegisProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarRegisProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonConfirmarRegisProd.Location = new System.Drawing.Point(232, 244);
            this.botonConfirmarRegisProd.Name = "botonConfirmarRegisProd";
            this.botonConfirmarRegisProd.Size = new System.Drawing.Size(101, 97);
            this.botonConfirmarRegisProd.TabIndex = 9;
            this.botonConfirmarRegisProd.UseVisualStyleBackColor = false;
            this.botonConfirmarRegisProd.Click += new System.EventHandler(this.botonConfirmarRegisProd_Click_1);
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
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(586, 353);
            this.Controls.Add(this.botonConfirmarRegisProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDescripRegis);
            this.Controls.Add(this.textBoxStockRegis);
            this.Controls.Add(this.textBoxPrecioRegis);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarProd";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistrarProd_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarRegiProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconoCerrarRegiProd;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecioRegis;
        private System.Windows.Forms.TextBox textBoxStockRegis;
        private System.Windows.Forms.TextBox textBoxDescripRegis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonConfirmarRegisProd;
    }
}