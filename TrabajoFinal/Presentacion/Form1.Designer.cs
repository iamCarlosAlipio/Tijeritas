
namespace Presentacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarRepresentanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNinioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionRepresentanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionNinioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInformacionHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosDeDemandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumpleañosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colsultarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarRepresentanteToolStripMenuItem,
            this.registrarNinioToolStripMenuItem,
            this.registrarServicioToolStripMenuItem,
            this.registrarHorarioToolStripMenuItem,
            this.registrarCitaToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // registrarRepresentanteToolStripMenuItem
            // 
            this.registrarRepresentanteToolStripMenuItem.Name = "registrarRepresentanteToolStripMenuItem";
            this.registrarRepresentanteToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.registrarRepresentanteToolStripMenuItem.Text = "Registrar Representante";
            this.registrarRepresentanteToolStripMenuItem.Click += new System.EventHandler(this.registrarRepresentanteToolStripMenuItem_Click);
            // 
            // registrarNinioToolStripMenuItem
            // 
            this.registrarNinioToolStripMenuItem.Name = "registrarNinioToolStripMenuItem";
            this.registrarNinioToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.registrarNinioToolStripMenuItem.Text = "Registrar Ninio";
            this.registrarNinioToolStripMenuItem.Click += new System.EventHandler(this.registrarNinioToolStripMenuItem_Click);
            // 
            // registrarServicioToolStripMenuItem
            // 
            this.registrarServicioToolStripMenuItem.Name = "registrarServicioToolStripMenuItem";
            this.registrarServicioToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.registrarServicioToolStripMenuItem.Text = "Registrar Servicio";
            this.registrarServicioToolStripMenuItem.Click += new System.EventHandler(this.registrarServicioToolStripMenuItem_Click);
            // 
            // registrarHorarioToolStripMenuItem
            // 
            this.registrarHorarioToolStripMenuItem.Name = "registrarHorarioToolStripMenuItem";
            this.registrarHorarioToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.registrarHorarioToolStripMenuItem.Text = "Registrar Horario";
            this.registrarHorarioToolStripMenuItem.Click += new System.EventHandler(this.registrarHorarioToolStripMenuItem_Click);
            // 
            // registrarCitaToolStripMenuItem
            // 
            this.registrarCitaToolStripMenuItem.Name = "registrarCitaToolStripMenuItem";
            this.registrarCitaToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.registrarCitaToolStripMenuItem.Text = "Registrar Cita";
            this.registrarCitaToolStripMenuItem.Click += new System.EventHandler(this.registrarCitaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarInformacionRepresentanteToolStripMenuItem,
            this.modificarInformacionNinioToolStripMenuItem,
            this.modificarInformacionServicioToolStripMenuItem,
            this.modificarInformacionHorarioToolStripMenuItem,
            this.cancelarCitaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // modificarInformacionRepresentanteToolStripMenuItem
            // 
            this.modificarInformacionRepresentanteToolStripMenuItem.Name = "modificarInformacionRepresentanteToolStripMenuItem";
            this.modificarInformacionRepresentanteToolStripMenuItem.Size = new System.Drawing.Size(432, 30);
            this.modificarInformacionRepresentanteToolStripMenuItem.Text = "Modificar Informacion Representante";
            this.modificarInformacionRepresentanteToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionRepresentanteToolStripMenuItem_Click);
            // 
            // modificarInformacionNinioToolStripMenuItem
            // 
            this.modificarInformacionNinioToolStripMenuItem.Name = "modificarInformacionNinioToolStripMenuItem";
            this.modificarInformacionNinioToolStripMenuItem.Size = new System.Drawing.Size(432, 30);
            this.modificarInformacionNinioToolStripMenuItem.Text = "Modificar Informacion Ninio";
            this.modificarInformacionNinioToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionNinioToolStripMenuItem_Click);
            // 
            // modificarInformacionServicioToolStripMenuItem
            // 
            this.modificarInformacionServicioToolStripMenuItem.Name = "modificarInformacionServicioToolStripMenuItem";
            this.modificarInformacionServicioToolStripMenuItem.Size = new System.Drawing.Size(432, 30);
            this.modificarInformacionServicioToolStripMenuItem.Text = "Modificar Servicio";
            this.modificarInformacionServicioToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionServicioToolStripMenuItem_Click);
            // 
            // modificarInformacionHorarioToolStripMenuItem
            // 
            this.modificarInformacionHorarioToolStripMenuItem.Name = "modificarInformacionHorarioToolStripMenuItem";
            this.modificarInformacionHorarioToolStripMenuItem.Size = new System.Drawing.Size(432, 30);
            this.modificarInformacionHorarioToolStripMenuItem.Text = "Inhabilitar Horario";
            this.modificarInformacionHorarioToolStripMenuItem.Click += new System.EventHandler(this.modificarInformacionHorarioToolStripMenuItem_Click);
            // 
            // cancelarCitaToolStripMenuItem
            // 
            this.cancelarCitaToolStripMenuItem.Name = "cancelarCitaToolStripMenuItem";
            this.cancelarCitaToolStripMenuItem.Size = new System.Drawing.Size(432, 30);
            this.cancelarCitaToolStripMenuItem.Text = "Cancelar cita";
            this.cancelarCitaToolStripMenuItem.Click += new System.EventHandler(this.cancelarCitaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.AutoToolTip = true;
            this.consultasToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.consultasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horariosDeDemandaToolStripMenuItem,
            this.cumpleañosToolStripMenuItem,
            this.historialDeToolStripMenuItem,
            this.historialDeToolStripMenuItem1,
            this.colsultarCitasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // horariosDeDemandaToolStripMenuItem
            // 
            this.horariosDeDemandaToolStripMenuItem.Name = "horariosDeDemandaToolStripMenuItem";
            this.horariosDeDemandaToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.horariosDeDemandaToolStripMenuItem.Text = "Horarios frecuentes";
            this.horariosDeDemandaToolStripMenuItem.Click += new System.EventHandler(this.horariosDeDemandaToolStripMenuItem_Click);
            // 
            // cumpleañosToolStripMenuItem
            // 
            this.cumpleañosToolStripMenuItem.Name = "cumpleañosToolStripMenuItem";
            this.cumpleañosToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.cumpleañosToolStripMenuItem.Text = "Cumpleaños";
            this.cumpleañosToolStripMenuItem.Click += new System.EventHandler(this.cumpleañosToolStripMenuItem_Click);
            // 
            // historialDeToolStripMenuItem
            // 
            this.historialDeToolStripMenuItem.Name = "historialDeToolStripMenuItem";
            this.historialDeToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.historialDeToolStripMenuItem.Text = "Historial de Representante";
            this.historialDeToolStripMenuItem.Click += new System.EventHandler(this.historialDeToolStripMenuItem_Click);
            // 
            // historialDeToolStripMenuItem1
            // 
            this.historialDeToolStripMenuItem1.Name = "historialDeToolStripMenuItem1";
            this.historialDeToolStripMenuItem1.Size = new System.Drawing.Size(333, 30);
            this.historialDeToolStripMenuItem1.Text = "Demanda de servicios";
            this.historialDeToolStripMenuItem1.Click += new System.EventHandler(this.historialDeToolStripMenuItem1_Click);
            // 
            // colsultarCitasToolStripMenuItem
            // 
            this.colsultarCitasToolStripMenuItem.Name = "colsultarCitasToolStripMenuItem";
            this.colsultarCitasToolStripMenuItem.Size = new System.Drawing.Size(333, 30);
            this.colsultarCitasToolStripMenuItem.Text = "Colsultar citas";
            this.colsultarCitasToolStripMenuItem.Click += new System.EventHandler(this.colsultarCitasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgMenu;
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarRepresentanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNinioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionRepresentanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionNinioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarInformacionHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosDeDemandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumpleañosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colsultarCitasToolStripMenuItem;
    }
}

