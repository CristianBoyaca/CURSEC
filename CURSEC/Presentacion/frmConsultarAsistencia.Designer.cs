namespace Presentacion
{
    partial class frmConsultarAsistencia
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
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.cmbAsistio = new System.Windows.Forms.ComboBox();
            this.lblAsistio = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtIdAsistencia = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(35, 139);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.Size = new System.Drawing.Size(461, 150);
            this.dgvAsistencias.TabIndex = 0;
            this.dgvAsistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencias_CellClick);
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(115, 55);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbHorario.TabIndex = 3;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(32, 58);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario:";
            // 
            // cmbIdentificacion
            // 
            this.cmbIdentificacion.FormattingEnabled = true;
            this.cmbIdentificacion.Location = new System.Drawing.Point(364, 58);
            this.cmbIdentificacion.Name = "cmbIdentificacion";
            this.cmbIdentificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbIdentificacion.TabIndex = 11;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(281, 58);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion.TabIndex = 10;
            this.lblIdentificacion.Text = "Identificacion:";
            // 
            // cmbAsistio
            // 
            this.cmbAsistio.FormattingEnabled = true;
            this.cmbAsistio.Items.AddRange(new object[] {
            "A",
            "F"});
            this.cmbAsistio.Location = new System.Drawing.Point(364, 97);
            this.cmbAsistio.Name = "cmbAsistio";
            this.cmbAsistio.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistio.TabIndex = 15;
            // 
            // lblAsistio
            // 
            this.lblAsistio.AutoSize = true;
            this.lblAsistio.Location = new System.Drawing.Point(281, 100);
            this.lblAsistio.Name = "lblAsistio";
            this.lblAsistio.Size = new System.Drawing.Size(40, 13);
            this.lblAsistio.TabIndex = 14;
            this.lblAsistio.Text = "Asistio:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(119, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtIdAsistencia
            // 
            this.txtIdAsistencia.Enabled = false;
            this.txtIdAsistencia.Location = new System.Drawing.Point(35, 306);
            this.txtIdAsistencia.Name = "txtIdAsistencia";
            this.txtIdAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtIdAsistencia.TabIndex = 16;
            this.txtIdAsistencia.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(246, 306);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(115, 18);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 19;
            this.cmbCurso.SelectionChangeCommitted += new System.EventHandler(this.cmbCurso_SelectionChangeCommitted);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(32, 18);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 18;
            this.lblCurso.Text = "Curso:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(384, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmConsultarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 348);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtIdAsistencia);
            this.Controls.Add(this.cmbAsistio);
            this.Controls.Add(this.lblAsistio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.dgvAsistencias);
            this.Name = "frmConsultarAsistencia";
            this.Text = "Consultar Asistencia";
            this.Load += new System.EventHandler(this.frmConsultarAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ComboBox cmbAsistio;
        private System.Windows.Forms.Label lblAsistio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtIdAsistencia;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnEliminar;
    }
}