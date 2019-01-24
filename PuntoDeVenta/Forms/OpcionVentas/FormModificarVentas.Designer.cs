using System;

namespace PuntoDeVenta.Forms.OpcionVentas
{
    partial class FormModificarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBuscarProdEnVentas = new System.Windows.Forms.TextBox();
            tabladetalle = new System.Windows.Forms.DataGridView();
            this.iconoCerrarModifVentas = new System.Windows.Forms.PictureBox();
            this.btnEliminarProdEnVenta = new System.Windows.Forms.Button();
            this.btnBuscarProdEnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(tabladetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarModifVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos en Venta";
            // 
            // txtBoxBuscarProdEnVentas
            // 
            this.txtBoxBuscarProdEnVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBuscarProdEnVentas.Location = new System.Drawing.Point(21, 78);
            this.txtBoxBuscarProdEnVentas.Name = "txtBoxBuscarProdEnVentas";
            this.txtBoxBuscarProdEnVentas.ShortcutsEnabled = false;
            this.txtBoxBuscarProdEnVentas.Size = new System.Drawing.Size(496, 20);
            this.txtBoxBuscarProdEnVentas.TabIndex = 4;
            this.txtBoxBuscarProdEnVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscarProdEnVentas_KeyPress);
            // 
            // tabladetalle
            // 
            tabladetalle.AllowUserToAddRows = false;
            tabladetalle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tabladetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            tabladetalle.Location = new System.Drawing.Point(21, 114);
            tabladetalle.Name = "tabladetalle";
            tabladetalle.Size = new System.Drawing.Size(643, 324);
            tabladetalle.TabIndex = 7;
            tabladetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabladetalle_CellContentClick);
            // 
            // iconoCerrarModifVentas
            // 
            this.iconoCerrarModifVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrarModifVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconoCerrarModifVentas.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrarModifVentas.Image")));
            this.iconoCerrarModifVentas.Location = new System.Drawing.Point(773, 12);
            this.iconoCerrarModifVentas.Name = "iconoCerrarModifVentas";
            this.iconoCerrarModifVentas.Size = new System.Drawing.Size(26, 24);
            this.iconoCerrarModifVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrarModifVentas.TabIndex = 16;
            this.iconoCerrarModifVentas.TabStop = false;
            this.iconoCerrarModifVentas.Click += new System.EventHandler(this.iconoCerrarModifVentas_Click);
            this.iconoCerrarModifVentas.MouseLeave += new System.EventHandler(this.iconoCerrarModifVentas_MouseLeave);
            this.iconoCerrarModifVentas.MouseHover += new System.EventHandler(this.iconoCerrarModifVentas_MouseHover);
            // 
            // btnEliminarProdEnVenta
            // 
            this.btnEliminarProdEnVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarProdEnVenta.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEliminarProdEnVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProdEnVenta.BackgroundImage")));
            this.btnEliminarProdEnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarProdEnVenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarProdEnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarProdEnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProdEnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProdEnVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProdEnVenta.Location = new System.Drawing.Point(688, 312);
            this.btnEliminarProdEnVenta.Name = "btnEliminarProdEnVenta";
            this.btnEliminarProdEnVenta.Size = new System.Drawing.Size(101, 97);
            this.btnEliminarProdEnVenta.TabIndex = 9;
            this.btnEliminarProdEnVenta.UseVisualStyleBackColor = false;
            this.btnEliminarProdEnVenta.Click += new System.EventHandler(this.btnEliminarProdEnVenta_Click);
            // 
            // btnBuscarProdEnVentas
            // 
            this.btnBuscarProdEnVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProdEnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProdEnVentas.BackgroundImage")));
            this.btnBuscarProdEnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProdEnVentas.FlatAppearance.BorderSize = 0;
            this.btnBuscarProdEnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarProdEnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProdEnVentas.Location = new System.Drawing.Point(523, 78);
            this.btnBuscarProdEnVentas.Name = "btnBuscarProdEnVentas";
            this.btnBuscarProdEnVentas.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarProdEnVentas.TabIndex = 6;
            this.btnBuscarProdEnVentas.UseVisualStyleBackColor = true;
            this.btnBuscarProdEnVentas.Click += new System.EventHandler(this.btnBuscarProdEnVentas_Click);
            // 
            // FormModificarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.iconoCerrarModifVentas);
            this.Controls.Add(this.btnEliminarProdEnVenta);
            this.Controls.Add(tabladetalle);
            this.Controls.Add(this.btnBuscarProdEnVentas);
            this.Controls.Add(this.txtBoxBuscarProdEnVentas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModificarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarVentas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormModificarVentas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormModificarVentas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(tabladetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrarModifVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscarProdEnVentas;
        private System.Windows.Forms.Button btnBuscarProdEnVentas;
        private System.Windows.Forms.Button btnEliminarProdEnVenta;
        private System.Windows.Forms.PictureBox iconoCerrarModifVentas;
        public static System.Windows.Forms.DataGridView tabladetalle;
    }
}