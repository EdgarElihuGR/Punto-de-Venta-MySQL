namespace PuntoDeVenta.Forms.OpcionInventario
{
    partial class MainMenuInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuInventario));
            this.label1 = new System.Windows.Forms.Label();
            tablaProductos = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscarProd = new System.Windows.Forms.TextBox();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnModificarProd = new System.Windows.Forms.Button();
            this.btnRegresarVentanaBase = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnNuevoProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // tablaProductos
            // 
            tablaProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProductos.Location = new System.Drawing.Point(26, 96);
            tablaProductos.Name = "tablaProductos";
            tablaProductos.Size = new System.Drawing.Size(736, 372);
            tablaProductos.TabIndex = 1;
            tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // txtBoxBuscarProd
            // 
            this.txtBoxBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBuscarProd.Location = new System.Drawing.Point(26, 61);
            this.txtBoxBuscarProd.Name = "txtBoxBuscarProd";
            this.txtBoxBuscarProd.Size = new System.Drawing.Size(698, 20);
            this.txtBoxBuscarProd.TabIndex = 2;
            this.txtBoxBuscarProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscarProd_KeyPress);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarProd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEliminarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarProd.BackgroundImage")));
            this.btnEliminarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProd.Location = new System.Drawing.Point(841, 371);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(101, 97);
            this.btnEliminarProd.TabIndex = 7;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.botonEliminarProd_Click);
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarProd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnModificarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarProd.BackgroundImage")));
            this.btnModificarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarProd.FlatAppearance.BorderSize = 0;
            this.btnModificarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModificarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarProd.Location = new System.Drawing.Point(841, 239);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(101, 97);
            this.btnModificarProd.TabIndex = 6;
            this.btnModificarProd.UseVisualStyleBackColor = false;
            this.btnModificarProd.Click += new System.EventHandler(this.botonModificarProd_Click);
            // 
            // btnRegresarVentanaBase
            // 
            this.btnRegresarVentanaBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresarVentanaBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresarVentanaBase.BackgroundImage")));
            this.btnRegresarVentanaBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegresarVentanaBase.FlatAppearance.BorderSize = 0;
            this.btnRegresarVentanaBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnRegresarVentanaBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarVentanaBase.Location = new System.Drawing.Point(970, 12);
            this.btnRegresarVentanaBase.Name = "btnRegresarVentanaBase";
            this.btnRegresarVentanaBase.Size = new System.Drawing.Size(38, 33);
            this.btnRegresarVentanaBase.TabIndex = 4;
            this.btnRegresarVentanaBase.UseVisualStyleBackColor = true;
            this.btnRegresarVentanaBase.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.BackgroundImage")));
            this.btnBuscarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProd.FlatAppearance.BorderSize = 0;
            this.btnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Location = new System.Drawing.Point(725, 61);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarProd.TabIndex = 3;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnNuevoProd
            // 
            this.btnNuevoProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevoProd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevoProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoProd.BackgroundImage")));
            this.btnNuevoProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevoProd.FlatAppearance.BorderSize = 0;
            this.btnNuevoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnNuevoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoProd.Location = new System.Drawing.Point(841, 118);
            this.btnNuevoProd.Name = "btnNuevoProd";
            this.btnNuevoProd.Size = new System.Drawing.Size(101, 97);
            this.btnNuevoProd.TabIndex = 5;
            this.btnNuevoProd.UseVisualStyleBackColor = false;
            this.btnNuevoProd.Click += new System.EventHandler(this.botonNuevoProd_Click);
            // 
            // MainMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnModificarProd);
            this.Controls.Add(this.btnNuevoProd);
            this.Controls.Add(this.btnRegresarVentanaBase);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtBoxBuscarProd);
            this.Controls.Add(tablaProductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuInventario";
            this.Text = "MainMenuInventario";
            this.Load += new System.EventHandler(this.MainMenuInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscarProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnRegresarVentanaBase;
        private System.Windows.Forms.Button btnModificarProd;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnNuevoProd;
        public static System.Windows.Forms.DataGridView tablaProductos;
    }
}