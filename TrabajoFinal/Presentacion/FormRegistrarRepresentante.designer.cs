
namespace Presentacion
{
    partial class FormRegistrarRepresentante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.datePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(381, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(381, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo de\r\nDocumento ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(381, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb4.Location = new System.Drawing.Point(381, 352);
            this.lb4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(58, 17);
            this.lb4.TabIndex = 19;
            this.lb4.Text = "Apellido";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lb5.Location = new System.Drawing.Point(381, 380);
            this.lb5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(42, 17);
            this.lb5.TabIndex = 20;
            this.lb5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(379, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "Numero de \r\nTelefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(379, 449);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha de \r\nNacimiento \r\n";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(501, 290);
            this.tbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(255, 22);
            this.tbDocumento.TabIndex = 23;
            this.tbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDocumento_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(501, 412);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(255, 22);
            this.tbTelefono.TabIndex = 24;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(501, 382);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 22);
            this.tbEmail.TabIndex = 25;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(501, 351);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(255, 22);
            this.tbApellido.TabIndex = 26;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(501, 320);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(255, 22);
            this.tbNombre.TabIndex = 27;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // CbTipo
            // 
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Carnet de Extranjeria"});
            this.CbTipo.Location = new System.Drawing.Point(501, 248);
            this.CbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(255, 24);
            this.CbTipo.TabIndex = 28;
            this.CbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // datePickerNacimiento
            // 
            this.datePickerNacimiento.Location = new System.Drawing.Point(501, 449);
            this.datePickerNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerNacimiento.Name = "datePickerNacimiento";
            this.datePickerNacimiento.Size = new System.Drawing.Size(255, 22);
            this.datePickerNacimiento.TabIndex = 30;
            // 
            // btregistrar
            // 
            this.btregistrar.Location = new System.Drawing.Point(428, 502);
            this.btregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btregistrar.Name = "btregistrar";
            this.btregistrar.Size = new System.Drawing.Size(277, 38);
            this.btregistrar.TabIndex = 31;
            this.btregistrar.Text = "Registrar";
            this.btregistrar.UseVisualStyleBackColor = true;
            this.btregistrar.Click += new System.EventHandler(this.btregistrar_Click);
            // 
            // FormRegistrarRepresentante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgRegistrarRepresentante;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.btregistrar);
            this.Controls.Add(this.datePickerNacimiento);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistrarRepresentante";
            this.Text = "FormRegistrarRepresentante";
            this.Load += new System.EventHandler(this.FormRegistrarRepresentante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.DateTimePicker datePickerNacimiento;
        private System.Windows.Forms.Button btregistrar;
    }
}