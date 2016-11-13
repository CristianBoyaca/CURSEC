namespace Presentacion
{
    partial class frmSecretaria
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.asistenciaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCursoToolStripMenuItem,
            this.consultarCursoToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursosToolStripMenuItem.Text = "Curso";
            // 
            // crearCursoToolStripMenuItem
            // 
            this.crearCursoToolStripMenuItem.Name = "crearCursoToolStripMenuItem";
            this.crearCursoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.crearCursoToolStripMenuItem.Text = "Crear Curso";
            this.crearCursoToolStripMenuItem.Click += new System.EventHandler(this.crearCursoToolStripMenuItem_Click);
            // 
            // consultarCursoToolStripMenuItem
            // 
            this.consultarCursoToolStripMenuItem.Name = "consultarCursoToolStripMenuItem";
            this.consultarCursoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarCursoToolStripMenuItem.Text = "Consultar Curso";
            this.consultarCursoToolStripMenuItem.Click += new System.EventHandler(this.consultarCursoToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAsistenciaToolStripMenuItem1,
            this.consultarAsistenciaToolStripMenuItem});
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // registrarAsistenciaToolStripMenuItem1
            // 
            this.registrarAsistenciaToolStripMenuItem1.Name = "registrarAsistenciaToolStripMenuItem1";
            this.registrarAsistenciaToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.registrarAsistenciaToolStripMenuItem1.Text = "Registrar Asistencia";
            this.registrarAsistenciaToolStripMenuItem1.Click += new System.EventHandler(this.registrarAsistenciaToolStripMenuItem1_Click);
            // 
            // consultarAsistenciaToolStripMenuItem
            // 
            this.consultarAsistenciaToolStripMenuItem.Name = "consultarAsistenciaToolStripMenuItem";
            this.consultarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarAsistenciaToolStripMenuItem.Text = "Consultar Asistencia";
            this.consultarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.consultarAsistenciaToolStripMenuItem_Click);
            // 
            // frmSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSecretaria";
            this.Text = "Secretaria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAsistenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarAsistenciaToolStripMenuItem;
    }
}