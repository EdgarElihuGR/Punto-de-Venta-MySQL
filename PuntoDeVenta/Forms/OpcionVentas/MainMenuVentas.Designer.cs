namespace PuntoDeVenta.Forms.OpcionVentas
{
    partial class MainMenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBuscarVentas = new System.Windows.Forms.TextBox();
            tablaVentas = new System.Windows.Forms.DataGridView();
            this.btnRegresarVentanaBase = new System.Windows.Forms.Button();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnModificarVentas = new System.Windows.Forms.Button();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // txtBoxBuscarVentas
            // 
            this.txtBoxBuscarVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBuscarVentas.Location = new System.Drawing.Point(26, 61);
            this.txtBoxBuscarVentas.Name = "txtBoxBuscarVentas";
            this.txtBoxBuscarVentas.ShortcutsEnabled = false;
            this.txtBoxBuscarVentas.Size = new System.Drawing.Size(698, 20);
            this.txtBoxBuscarVentas.TabIndex = 3;
            this.txtBoxBuscarVentas.TextChanged += new System.EventHandler(this.txtBoxBuscarVentas_TextChanged);
            this.txtBoxBuscarVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscarVentas_KeyPress);
            // 
            // tablaVentas
            // 
            tablaVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            tablaVentas.Location = new System.Drawing.Point(26, 96);
            tablaVentas.Name = "tablaVentas";
            tablaVentas.Size = new System.Drawing.Size(736, 395);
            tablaVentas.TabIndex = 4;
            tablaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVentas_CellContentClick);
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
            this.btnRegresarVentanaBase.TabIndex = 9;
            this.btnRegresarVentanaBase.UseVisualStyleBackColor = true;
            this.btnRegresarVentanaBase.Click += new System.EventHandler(this.btnRegresarVentanaBase_Click);
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarVentas.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEliminarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarVentas.BackgroundImage")));
            this.btnEliminarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarVentas.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarVentas.Location = new System.Drawing.Point(841, 321);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(101, 97);
            this.btnEliminarVentas.TabIndex = 8;
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // btnModificarVentas
            // 
            this.btnModificarVentas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarVentas.BackColor = System.Drawing.Color.LimeGreen;
            this.btnModificarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarVentas.BackgroundImage")));
            this.btnModificarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarVentas.FlatAppearance.BorderSize = 0;
            this.btnModificarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModificarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarVentas.Location = new System.Drawing.Point(841, 146);
            this.btnModificarVentas.Name = "btnModificarVentas";
            this.btnModificarVentas.Size = new System.Drawing.Size(101, 97);
            this.btnModificarVentas.TabIndex = 7;
            this.btnModificarVentas.UseVisualStyleBackColor = false;
            this.btnModificarVentas.Click += new System.EventHandler(this.btnModificarVentas_Click);
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarVentas.BackgroundImage")));
            this.btnBuscarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarVentas.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentas.Location = new System.Drawing.Point(725, 61);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarVentas.TabIndex = 5;
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // MainMenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.btnRegresarVentanaBase);
            this.Controls.Add(this.btnEliminarVentas);
            this.Controls.Add(this.btnModificarVentas);
            this.Controls.Add(this.btnBuscarVentas);
            this.Controls.Add(tablaVentas);
            this.Controls.Add(this.txtBoxBuscarVentas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuVentas";
            this.Text = "MainMenuVentas";
            this.Load += new System.EventHandler(this.MainMenuVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(tablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscarVentas;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.Button btnModificarVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnRegresarVentanaBase;
        public static System.Windows.Forms.DataGridView tablaVentas;
    }
}