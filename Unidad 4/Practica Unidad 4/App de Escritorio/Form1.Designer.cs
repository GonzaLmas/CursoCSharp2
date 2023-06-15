namespace App_de_Escritorio
{
    partial class frmApp
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxEdad = new System.Windows.Forms.TextBox();
            this.tbxDirec = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 29);
            this.lblApellido.MaximumSize = new System.Drawing.Size(60, 35);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 100);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "EDAD";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Location = new System.Drawing.Point(12, 138);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(66, 13);
            this.lblDirec.TabIndex = 3;
            this.lblDirec.Text = "DIRECCIÓN";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 194);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(73, 13);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "RESULTADO\r\n";
            // 
            // tbxApellido
            // 
            this.tbxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxApellido.Location = new System.Drawing.Point(84, 29);
            this.tbxApellido.MaxLength = 20;
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(368, 20);
            this.tbxApellido.TabIndex = 5;
            // 
            // tbxNombre
            // 
            this.tbxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNombre.Location = new System.Drawing.Point(84, 63);
            this.tbxNombre.MaxLength = 20;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(368, 20);
            this.tbxNombre.TabIndex = 6;
            // 
            // tbxEdad
            // 
            this.tbxEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxEdad.Location = new System.Drawing.Point(84, 97);
            this.tbxEdad.MaxLength = 3;
            this.tbxEdad.Name = "tbxEdad";
            this.tbxEdad.Size = new System.Drawing.Size(54, 20);
            this.tbxEdad.TabIndex = 7;
            this.tbxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEdad_KeyPress);
            // 
            // tbxDirec
            // 
            this.tbxDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDirec.Location = new System.Drawing.Point(84, 135);
            this.tbxDirec.MaxLength = 60;
            this.tbxDirec.Name = "tbxDirec";
            this.tbxDirec.Size = new System.Drawing.Size(368, 20);
            this.tbxDirec.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Location = new System.Drawing.Point(120, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(245, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbxRes
            // 
            this.tbxRes.Location = new System.Drawing.Point(12, 222);
            this.tbxRes.Multiline = true;
            this.tbxRes.Name = "tbxRes";
            this.tbxRes.Size = new System.Drawing.Size(440, 141);
            this.tbxRes.TabIndex = 12;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(466, 404);
            this.Controls.Add(this.tbxRes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxDirec);
            this.Controls.Add(this.tbxEdad);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxEdad;
        private System.Windows.Forms.TextBox tbxDirec;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbxRes;
    }
}

