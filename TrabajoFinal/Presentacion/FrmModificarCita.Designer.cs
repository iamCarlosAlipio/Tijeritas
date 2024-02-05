
namespace Presentacion
{
    partial class FrmModificarCita
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
            this.dtCitas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHoras = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCitas
            // 
            this.dtCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCitas.Location = new System.Drawing.Point(50, 344);
            this.dtCitas.Name = "dtCitas";
            this.dtCitas.RowHeadersWidth = 51;
            this.dtCitas.RowTemplate.Height = 24;
            this.dtCitas.Size = new System.Drawing.Size(519, 206);
            this.dtCitas.TabIndex = 0;
            this.dtCitas.SelectionChanged += new System.EventHandler(this.dtCitas_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(50, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar Cita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(452, 206);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(117, 122);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Documento";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(188, 241);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(244, 22);
            this.txtCod.TabIndex = 10;
            // 
            // CbTipo
            // 
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Carnet de Extranjeria"});
            this.CbTipo.Location = new System.Drawing.Point(188, 206);
            this.CbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(244, 24);
            this.CbTipo.TabIndex = 30;
            this.CbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de\r\nDocumento ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fecha";
            // 
            // cmbHoras
            // 
            this.cmbHoras.FormattingEnabled = true;
            this.cmbHoras.Items.AddRange(new object[] {
            "06:00 a 07:00",
            "07:00 a 08:00",
            "08:00 a 09:00",
            "09:00 a 10:00",
            "10:00 a 11:00",
            "11:00 a 12:00",
            "12:00 a 13:00",
            "13:00 a 14:00",
            "14:00 a 15:00",
            "15:00 a 16:00",
            "16:00 a 17:00",
            "17:00 a 18:00",
            "18:00 a 19:00",
            "19:00 a 20:00",
            "20:00 a 21:00"});
            this.cmbHoras.Location = new System.Drawing.Point(188, 304);
            this.cmbHoras.Name = "cmbHoras";
            this.cmbHoras.Size = new System.Drawing.Size(244, 24);
            this.cmbHoras.TabIndex = 32;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(188, 273);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(244, 22);
            this.dtFecha.TabIndex = 33;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(51, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Horario";
            // 
            // FrmModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgCancelarCita;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cmbHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtCitas);
            this.Name = "FrmModificarCita";
            this.Text = "FrmModificarCita";
            ((System.ComponentModel.ISupportInitialize)(this.dtCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCitas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHoras;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
    }
}