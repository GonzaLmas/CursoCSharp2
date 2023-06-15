namespace WinForms_Ejemplo_2
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.numNumeroFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(144, 9);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(205, 36);
            this.lblPerfil.TabIndex = 10;
            this.lblPerfil.Text = "Perfil Persona";
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTipo.Controls.Add(this.rbtWizard);
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Location = new System.Drawing.Point(102, 165);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(296, 52);
            this.gbxTipo.TabIndex = 4;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // rbtWizard
            // 
            this.rbtWizard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Location = new System.Drawing.Point(28, 19);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 0;
            this.rbtWizard.TabStop = true;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(119, 19);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 0;
            this.rbtMuggle.TabStop = true;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(210, 19);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 0;
            this.rbtSquibs.TabStop = true;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(99, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 110);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(169, 142);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 3;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(74, 383);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(348, 122);
            this.lwElementos.TabIndex = 8;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Location = new System.Drawing.Point(149, 104);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.Value = new System.DateTime(2022, 5, 8, 0, 0, 0, 0);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNombre.Location = new System.Drawing.Point(149, 72);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(200, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(50, 542);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(71, 253);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 13);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color Favorito:";
            // 
            // cbxColor
            // 
            this.cbxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(149, 250);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 21);
            this.cbxColor.TabIndex = 5;
            // 
            // numNumeroFav
            // 
            this.numNumeroFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFav.Location = new System.Drawing.Point(150, 298);
            this.numNumeroFav.Name = "numNumeroFav";
            this.numNumeroFav.Size = new System.Drawing.Size(121, 20);
            this.numNumeroFav.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(58, 300);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(88, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Número Favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(210, 336);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 7;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 577);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numNumeroFav);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblPerfil);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 687);
            this.MinimumSize = new System.Drawing.Size(521, 616);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.NumericUpDown numNumeroFav;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

