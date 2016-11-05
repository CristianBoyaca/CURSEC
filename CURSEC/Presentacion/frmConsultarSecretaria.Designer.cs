namespace Presentacion
{
    partial class frmConsultarSecretaria
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
            this.dgvSecretarias = new System.Windows.Forms.DataGridView();
            this.cmbSecretario = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreSecretaria = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreSecretario = new System.Windows.Forms.Label();
            this.lblNombreSecretaria = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretarias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSecretarias
            // 
            this.dgvSecretarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecretarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecretarias.Location = new System.Drawing.Point(30, 100);
            this.dgvSecretarias.Name = "dgvSecretarias";
            this.dgvSecretarias.Size = new System.Drawing.Size(673, 150);
            this.dgvSecretarias.TabIndex = 0;
            this.dgvSecretarias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecretarias_CellClick);
            // 
            // cmbSecretario
            // 
            this.cmbSecretario.FormattingEnabled = true;
            this.cmbSecretario.Location = new System.Drawing.Point(456, 26);
            this.cmbSecretario.Name = "cmbSecretario";
            this.cmbSecretario.Size = new System.Drawing.Size(121, 21);
            this.cmbSecretario.TabIndex = 17;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(456, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(172, 60);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtNombreSecretaria
            // 
            this.txtNombreSecretaria.Location = new System.Drawing.Point(172, 26);
            this.txtNombreSecretaria.Name = "txtNombreSecretaria";
            this.txtNombreSecretaria.Size = new System.Drawing.Size(121, 20);
            this.txtNombreSecretaria.TabIndex = 14;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(322, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(38, 67);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombreSecretario
            // 
            this.lblNombreSecretario.AutoSize = true;
            this.lblNombreSecretario.Location = new System.Drawing.Point(322, 29);
            this.lblNombreSecretario.Name = "lblNombreSecretario";
            this.lblNombreSecretario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreSecretario.TabIndex = 11;
            this.lblNombreSecretario.Text = "Nombre Secretario:";
            // 
            // lblNombreSecretaria
            // 
            this.lblNombreSecretaria.AutoSize = true;
            this.lblNombreSecretaria.Location = new System.Drawing.Point(38, 29);
            this.lblNombreSecretaria.Name = "lblNombreSecretaria";
            this.lblNombreSecretaria.Size = new System.Drawing.Size(98, 13);
            this.lblNombreSecretaria.TabIndex = 10;
            this.lblNombreSecretaria.Text = "Nombre Secretaria:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(606, 21);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(606, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Location = new System.Drawing.Point(93, 260);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdentidad.TabIndex = 20;
            this.txtIdentidad.Visible = false;
            // 
            // frmConsultarSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 292);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbSecretario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreSecretaria);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreSecretario);
            this.Controls.Add(this.lblNombreSecretaria);
            this.Controls.Add(this.dgvSecretarias);
            this.Name = "frmConsultarSecretaria";
            this.Text = "Consultar Secretaria";
            this.Load += new System.EventHandler(this.frmConsultarSecretaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSecretarias;
        private System.Windows.Forms.ComboBox cmbSecretario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreSecretaria;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreSecretario;
        private System.Windows.Forms.Label lblNombreSecretaria;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdentidad;
    }
}