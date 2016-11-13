namespace Presentacion
{
    partial class frmRegistrarCurso
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
            this.lblEntidad = new System.Windows.Forms.Label();
            this.cmbEntidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblMaxAsistentes = new System.Windows.Forms.Label();
            this.txtMaxAsistentes = new System.Windows.Forms.TextBox();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.lblTipoHorario = new System.Windows.Forms.Label();
            this.cmbTipoHorario = new System.Windows.Forms.ComboBox();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(38, 39);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(46, 13);
            this.lblEntidad.TabIndex = 0;
            this.lblEntidad.Text = "Entidad:";
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.Location = new System.Drawing.Point(113, 36);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEntidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(35, 102);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(113, 99);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblMaxAsistentes
            // 
            this.lblMaxAsistentes.AutoSize = true;
            this.lblMaxAsistentes.Location = new System.Drawing.Point(20, 135);
            this.lblMaxAsistentes.Name = "lblMaxAsistentes";
            this.lblMaxAsistentes.Size = new System.Drawing.Size(81, 13);
            this.lblMaxAsistentes.TabIndex = 6;
            this.lblMaxAsistentes.Text = "Max Asistentes:";
            // 
            // txtMaxAsistentes
            // 
            this.txtMaxAsistentes.Location = new System.Drawing.Point(113, 132);
            this.txtMaxAsistentes.Name = "txtMaxAsistentes";
            this.txtMaxAsistentes.Size = new System.Drawing.Size(121, 20);
            this.txtMaxAsistentes.TabIndex = 7;
            this.txtMaxAsistentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAsistentes_KeyPress);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(31, 173);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicial.TabIndex = 8;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(113, 167);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaInicial.TabIndex = 9;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(31, 208);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(113, 202);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaFinal.TabIndex = 11;
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Location = new System.Drawing.Point(101, 387);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(96, 23);
            this.btnRegistrarCurso.TabIndex = 12;
            this.btnRegistrarCurso.Text = "Registrar Curso";
            this.btnRegistrarCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // lblTipoHorario
            // 
            this.lblTipoHorario.AutoSize = true;
            this.lblTipoHorario.Location = new System.Drawing.Point(31, 248);
            this.lblTipoHorario.Name = "lblTipoHorario";
            this.lblTipoHorario.Size = new System.Drawing.Size(68, 13);
            this.lblTipoHorario.TabIndex = 13;
            this.lblTipoHorario.Text = "Tipo Horario:";
            // 
            // cmbTipoHorario
            // 
            this.cmbTipoHorario.FormattingEnabled = true;
            this.cmbTipoHorario.Location = new System.Drawing.Point(113, 245);
            this.cmbTipoHorario.Name = "cmbTipoHorario";
            this.cmbTipoHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoHorario.TabIndex = 14;
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Location = new System.Drawing.Point(23, 278);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(78, 13);
            this.lblHoraInicial.TabIndex = 15;
            this.lblHoraInicial.Text = "Hora De Inicio:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm:ss";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(113, 278);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(121, 20);
            this.dtpHoraInicio.TabIndex = 16;
            this.dtpHoraInicio.Value = new System.DateTime(2016, 11, 11, 0, 0, 0, 0);
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.CustomFormat = "HH:mm:ss";
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal.Location = new System.Drawing.Point(111, 310);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(121, 20);
            this.dtpHoraFinal.TabIndex = 18;
            this.dtpHoraFinal.Value = new System.DateTime(2016, 11, 11, 0, 0, 0, 0);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(21, 310);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(58, 13);
            this.lblHoraFinal.TabIndex = 17;
            this.lblHoraFinal.Text = "Hora Final:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 344);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad Horas:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(113, 344);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(119, 20);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // frmRegistrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 445);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtpHoraFinal);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.lblHoraInicial);
            this.Controls.Add(this.cmbTipoHorario);
            this.Controls.Add(this.lblTipoHorario);
            this.Controls.Add(this.btnRegistrarCurso);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.txtMaxAsistentes);
            this.Controls.Add(this.lblMaxAsistentes);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEntidad);
            this.Controls.Add(this.lblEntidad);
            this.Name = "frmRegistrarCurso";
            this.Text = "Registrar Curso";
            this.Load += new System.EventHandler(this.frmRegistrarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.ComboBox cmbEntidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblMaxAsistentes;
        private System.Windows.Forms.TextBox txtMaxAsistentes;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Label lblTipoHorario;
        private System.Windows.Forms.ComboBox cmbTipoHorario;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}