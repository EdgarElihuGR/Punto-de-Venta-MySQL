namespace PuntoDeVenta.Forms
{
    partial class VentanaBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBase));
            this.tablaHacerVentas = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonVerProductos = new System.Windows.Forms.Button();
            this.botonQuitarProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.botonHacerVenta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.lblCancelarVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHacerVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaHacerVentas
            // 
            this.tablaHacerVentas.AllowUserToAddRows = false;
            this.tablaHacerVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaHacerVentas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.tablaHacerVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaHacerVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaHacerVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaHacerVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHacerVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.stock,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaHacerVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaHacerVentas.Location = new System.Drawing.Point(21, 83);
            this.tablaHacerVentas.MultiSelect = false;
            this.tablaHacerVentas.Name = "tablaHacerVentas";
            this.tablaHacerVentas.ReadOnly = true;
            this.tablaHacerVentas.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tablaHacerVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaHacerVentas.Size = new System.Drawing.Size(585, 410);
            this.tablaHacerVentas.TabIndex = 2;
            this.tablaHacerVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaHacerVentas_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // botonVerProductos
            // 
            this.botonVerProductos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonVerProductos.BackColor = System.Drawing.Color.LimeGreen;
            this.botonVerProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonVerProductos.BackgroundImage")));
            this.botonVerProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonVerProductos.FlatAppearance.BorderSize = 0;
            this.botonVerProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.botonVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonVerProductos.Location = new System.Drawing.Point(647, 100);
            this.botonVerProductos.Name = "botonVerProductos";
            this.botonVerProductos.Size = new System.Drawing.Size(101, 97);
            this.botonVerProductos.TabIndex = 3;
            this.botonVerProductos.UseVisualStyleBackColor = false;
            this.botonVerProductos.Click += new System.EventHandler(this.botonVerProductos_Click);
            // 
            // botonQuitarProductos
            // 
            this.botonQuitarProductos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonQuitarProductos.BackColor = System.Drawing.Color.LimeGreen;
            this.botonQuitarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonQuitarProductos.BackgroundImage")));
            this.botonQuitarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonQuitarProductos.FlatAppearance.BorderSize = 0;
            this.botonQuitarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.botonQuitarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonQuitarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonQuitarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonQuitarProductos.Location = new System.Drawing.Point(647, 234);
            this.botonQuitarProductos.Name = "botonQuitarProductos";
            this.botonQuitarProductos.Size = new System.Drawing.Size(101, 97);
            this.botonQuitarProductos.TabIndex = 4;
            this.botonQuitarProductos.UseVisualStyleBackColor = false;
            this.botonQuitarProductos.Click += new System.EventHandler(this.botonQuitarProductos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SUB TOTAL:";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(730, 369);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(54, 20);
            this.labelSubtotal.TabIndex = 8;
            this.labelSubtotal.Text = "00.00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "IVA:";
            // 
            // labelIVA
            // 
            this.labelIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIVA.AutoSize = true;
            this.labelIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIVA.Location = new System.Drawing.Point(730, 407);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(54, 20);
            this.labelIVA.TabIndex = 10;
            this.labelIVA.Text = "00.00";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL:";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(730, 453);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(60, 24);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "00.00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(830, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // botonHacerVenta
            // 
            this.botonHacerVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonHacerVenta.BackColor = System.Drawing.Color.LimeGreen;
            this.botonHacerVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonHacerVenta.BackgroundImage")));
            this.botonHacerVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonHacerVenta.FlatAppearance.BorderSize = 0;
            this.botonHacerVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.botonHacerVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonHacerVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHacerVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonHacerVenta.Location = new System.Drawing.Point(874, 396);
            this.botonHacerVenta.Name = "botonHacerVenta";
            this.botonHacerVenta.Size = new System.Drawing.Size(101, 97);
            this.botonHacerVenta.TabIndex = 14;
            this.botonHacerVenta.UseVisualStyleBackColor = false;
            this.botonHacerVenta.Click += new System.EventHandler(this.botonHacerVenta_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Registrar Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(827, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarVenta.BackgroundImage")));
            this.btnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarVenta.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarVenta.Location = new System.Drawing.Point(21, 38);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(38, 36);
            this.btnCancelarVenta.TabIndex = 17;
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Visible = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // lblCancelarVenta
            // 
            this.lblCancelarVenta.AutoSize = true;
            this.lblCancelarVenta.Location = new System.Drawing.Point(65, 61);
            this.lblCancelarVenta.Name = "lblCancelarVenta";
            this.lblCancelarVenta.Size = new System.Drawing.Size(146, 13);
            this.lblCancelarVenta.TabIndex = 18;
            this.lblCancelarVenta.Text = "Presiona para cancelar venta";
            this.lblCancelarVenta.Visible = false;
            // 
            // VentanaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.lblCancelarVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonHacerVenta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIVA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonQuitarProductos);
            this.Controls.Add(this.botonVerProductos);
            this.Controls.Add(this.tablaHacerVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaBase";
            this.Text = "VentanaBaseAdmin";
            this.Load += new System.EventHandler(this.VentanaBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHacerVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonVerProductos;
        private System.Windows.Forms.Button botonQuitarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button botonHacerVenta;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView tablaHacerVentas;
        public System.Windows.Forms.Label labelSubtotal;
        public System.Windows.Forms.Label labelIVA;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label lblCancelarVenta;
    }
}