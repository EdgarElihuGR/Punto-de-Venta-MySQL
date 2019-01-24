namespace PuntoDeVenta.Forms.OpcionUsuarios
{
    partial class MainMenuUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            tablaUsuariosGenerales = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscarUsuariosGen = new System.Windows.Forms.TextBox();
            this.btnRegresarVentanaBase = new System.Windows.Forms.Button();
            this.btnEliminarUsuariosGen = new System.Windows.Forms.Button();
            this.btnAgregarUsuariosGen = new System.Windows.Forms.Button();
            this.btnModificarUsuariosGen = new System.Windows.Forms.Button();
            this.btnBuscarUsuariosGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(tablaUsuariosGenerales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // tablaUsuariosGenerales
            // 
            tablaUsuariosGenerales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tablaUsuariosGenerales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            tablaUsuariosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaUsuariosGenerales.Location = new System.Drawing.Point(26, 96);
            tablaUsuariosGenerales.Name = "tablaUsuariosGenerales";
            tablaUsuariosGenerales.Size = new System.Drawing.Size(736, 395);
            tablaUsuariosGenerales.TabIndex = 5;
            // 
            // txtBoxBuscarUsuariosGen
            // 
            this.txtBoxBuscarUsuariosGen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBuscarUsuariosGen.Location = new System.Drawing.Point(26, 60);
            this.txtBoxBuscarUsuariosGen.Name = "txtBoxBuscarUsuariosGen";
            this.txtBoxBuscarUsuariosGen.ShortcutsEnabled = false;
            this.txtBoxBuscarUsuariosGen.Size = new System.Drawing.Size(698, 20);
            this.txtBoxBuscarUsuariosGen.TabIndex = 6;
            this.txtBoxBuscarUsuariosGen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBuscarUsuariosGen_KeyPress);
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
            this.btnRegresarVentanaBase.TabIndex = 11;
            this.btnRegresarVentanaBase.UseVisualStyleBackColor = true;
            this.btnRegresarVentanaBase.Click += new System.EventHandler(this.btnRegresarVentanaBase_Click);
            // 
            // btnEliminarUsuariosGen
            // 
            this.btnEliminarUsuariosGen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarUsuariosGen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEliminarUsuariosGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuariosGen.BackgroundImage")));
            this.btnEliminarUsuariosGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarUsuariosGen.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuariosGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarUsuariosGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuariosGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuariosGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuariosGen.Location = new System.Drawing.Point(841, 339);
            this.btnEliminarUsuariosGen.Name = "btnEliminarUsuariosGen";
            this.btnEliminarUsuariosGen.Size = new System.Drawing.Size(101, 97);
            this.btnEliminarUsuariosGen.TabIndex = 10;
            this.btnEliminarUsuariosGen.UseVisualStyleBackColor = false;
            this.btnEliminarUsuariosGen.Click += new System.EventHandler(this.btnEliminarUsuariosGen_Click);
            // 
            // btnAgregarUsuariosGen
            // 
            this.btnAgregarUsuariosGen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregarUsuariosGen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarUsuariosGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuariosGen.BackgroundImage")));
            this.btnAgregarUsuariosGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarUsuariosGen.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuariosGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAgregarUsuariosGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuariosGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuariosGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarUsuariosGen.Location = new System.Drawing.Point(841, 96);
            this.btnAgregarUsuariosGen.Name = "btnAgregarUsuariosGen";
            this.btnAgregarUsuariosGen.Size = new System.Drawing.Size(101, 97);
            this.btnAgregarUsuariosGen.TabIndex = 9;
            this.btnAgregarUsuariosGen.UseVisualStyleBackColor = false;
            this.btnAgregarUsuariosGen.Click += new System.EventHandler(this.btnAgregarUsuariosGen_Click);
            // 
            // btnModificarUsuariosGen
            // 
            this.btnModificarUsuariosGen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificarUsuariosGen.BackColor = System.Drawing.Color.LimeGreen;
            this.btnModificarUsuariosGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarUsuariosGen.BackgroundImage")));
            this.btnModificarUsuariosGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarUsuariosGen.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuariosGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModificarUsuariosGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuariosGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuariosGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarUsuariosGen.Location = new System.Drawing.Point(841, 218);
            this.btnModificarUsuariosGen.Name = "btnModificarUsuariosGen";
            this.btnModificarUsuariosGen.Size = new System.Drawing.Size(101, 97);
            this.btnModificarUsuariosGen.TabIndex = 8;
            this.btnModificarUsuariosGen.UseVisualStyleBackColor = false;
            this.btnModificarUsuariosGen.Click += new System.EventHandler(this.btnModificarUsuariosGen_Click);
            // 
            // btnBuscarUsuariosGen
            // 
            this.btnBuscarUsuariosGen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarUsuariosGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuariosGen.BackgroundImage")));
            this.btnBuscarUsuariosGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarUsuariosGen.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuariosGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnBuscarUsuariosGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuariosGen.Location = new System.Drawing.Point(725, 60);
            this.btnBuscarUsuariosGen.Name = "btnBuscarUsuariosGen";
            this.btnBuscarUsuariosGen.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarUsuariosGen.TabIndex = 7;
            this.btnBuscarUsuariosGen.UseVisualStyleBackColor = true;
            this.btnBuscarUsuariosGen.Click += new System.EventHandler(this.btnBuscarUsuariosGen_Click);
            // 
            // MainMenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.btnRegresarVentanaBase);
            this.Controls.Add(this.btnEliminarUsuariosGen);
            this.Controls.Add(this.btnAgregarUsuariosGen);
            this.Controls.Add(this.btnModificarUsuariosGen);
            this.Controls.Add(this.btnBuscarUsuariosGen);
            this.Controls.Add(this.txtBoxBuscarUsuariosGen);
            this.Controls.Add(tablaUsuariosGenerales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuUsuarios";
            this.Text = "MainMenuUsuarios";
            this.Load += new System.EventHandler(this.MainMenuUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(tablaUsuariosGenerales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscarUsuariosGen;
        private System.Windows.Forms.Button btnBuscarUsuariosGen;
        private System.Windows.Forms.Button btnModificarUsuariosGen;
        private System.Windows.Forms.Button btnAgregarUsuariosGen;
        private System.Windows.Forms.Button btnEliminarUsuariosGen;
        private System.Windows.Forms.Button btnRegresarVentanaBase;
        public static System.Windows.Forms.DataGridView tablaUsuariosGenerales;
    }
}