namespace Ejercicio
{
    partial class frmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.btnBoton = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.Location = new System.Drawing.Point(300, 103);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Boton";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.Red;
            this.lblEtiqueta.Location = new System.Drawing.Point(262, 235);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(77, 33);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Leéme";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // tbxApellido
            // 
            this.tbxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxApellido.Location = new System.Drawing.Point(300, 289);
            this.tbxApellido.MaxLength = 30000;
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(100, 20);
            this.tbxApellido.TabIndex = 2;
            this.tbxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxApellido_KeyPress);
            // 
            // tbxNuevo
            // 
            this.tbxNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNuevo.Location = new System.Drawing.Point(300, 335);
            this.tbxNuevo.MaxLength = 30000;
            this.tbxNuevo.Multiline = true;
            this.tbxNuevo.Name = "tbxNuevo";
            this.tbxNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxNuevo.Size = new System.Drawing.Size(100, 20);
            this.tbxNuevo.TabIndex = 3;
            this.tbxNuevo.Leave += new System.EventHandler(this.tbxNuevo_Leave);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNuevo);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBoton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForm";
            this.Opacity = 0.87D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer App";
            this.MaximumSizeChanged += new System.EventHandler(this.App_Load);
            this.MinimumSizeChanged += new System.EventHandler(this.App_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.App_FormClosed);
            this.Load += new System.EventHandler(this.App_Load);
            this.Click += new System.EventHandler(this.Frm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNuevo;
    }
}

