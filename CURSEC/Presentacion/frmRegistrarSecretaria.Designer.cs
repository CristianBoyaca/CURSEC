namespace Presentacion
{
    partial class frmRegistrarSecretaria
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
            this.lblNombreSecretaria = new System.Windows.Forms.Label();
            this.lblNombreSecretario = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreSecretaria = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbSecretario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreSecretaria
            // 
            this.lblNombreSecretaria.AutoSize = true;
            this.lblNombreSecretaria.Location = new System.Drawing.Point(43, 34);
            this.lblNombreSecretaria.Name = "lblNombreSecretaria";
            this.lblNombreSecretaria.Size = new System.Drawing.Size(98, 13);
            this.lblNombreSecretaria.TabIndex = 0;
            this.lblNombreSecretaria.Text = "Nombre Secretaria:";
            // 
            // lblNombreSecretario
            // 
            this.lblNombreSecretario.AutoSize = true;
            this.lblNombreSecretario.Location = new System.Drawing.Point(43, 86);
            this.lblNombreSecretario.Name = "lblNombreSecretario";
            this.lblNombreSecretario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreSecretario.TabIndex = 1;
            this.lblNombreSecretario.Text = "Nombre Secretario:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(43, 127);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(43, 174);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNombreSecretaria
            // 
            this.txtNombreSecretaria.Location = new System.Drawing.Point(177, 31);
            this.txtNombreSecretaria.Name = "txtNombreSecretaria";
            this.txtNombreSecretaria.Size = new System.Drawing.Size(121, 20);
            this.txtNombreSecretaria.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(177, 120);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(177, 167);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(126, 215);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbSecretario
            // 
            this.cmbSecretario.FormattingEnabled = true;
            this.cmbSecretario.Location = new System.Drawing.Point(177, 83);
            this.cmbSecretario.Name = "cmbSecretario";
            this.cmbSecretario.Size = new System.Drawing.Size(121, 21);
            this.cmbSecretario.TabIndex = 9;
            // 
            // frmRegistrarSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.cmbSecretario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreSecretaria);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreSecretario);
            this.Controls.Add(this.lblNombreSecretaria);
            this.Name = "frmRegistrarSecretaria";
            this.Text = "Registrar Secretaria";
            this.Load += new System.EventHandler(this.frmRegistrarSecretaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSecretaria;
        private System.Windows.Forms.Label lblNombreSecretario;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreSecretaria;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbSecretario;
    }
}