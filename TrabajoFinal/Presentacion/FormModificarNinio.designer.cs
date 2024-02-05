
namespace Presentacion
{
    partial class FormModificarNinio
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
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbBusqueda = new System.Windows.Forms.ComboBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbFechaNa = new System.Windows.Forms.TextBox();
            this.textBoxDocRe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTabla
            // 
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.Location = new System.Drawing.Point(259, 102);
            this.dgTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.RowHeadersWidth = 51;
            this.dgTabla.Size = new System.Drawing.Size(610, 281);
            this.dgTabla.TabIndex = 0;
            this.dgTabla.SelectionChanged += new System.EventHandler(this.dgTabla_SelectionChanged);
            this.dgTabla.Click += new System.EventHandler(this.dgTabla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(945, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(945, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "tipo documento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(947, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(945, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(944, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(944, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "fecha ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(944, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "doc repres";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(753, 59);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(115, 28);
            this.btLimpiar.TabIndex = 26;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(618, 59);
            this.btbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(113, 28);
            this.btbuscar.TabIndex = 25;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(421, 63);
            this.tbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(189, 22);
            this.tbBusqueda.TabIndex = 24;
            this.tbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusqueda_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Buscar Por";
            // 
            // CbBusqueda
            // 
            this.CbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBusqueda.FormattingEnabled = true;
            this.CbBusqueda.Items.AddRange(new object[] {
            "Documento",
            "Nombre",
            "Apellido",
            "Nacimiento"});
            this.CbBusqueda.Location = new System.Drawing.Point(259, 63);
            this.CbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.CbBusqueda.Name = "CbBusqueda";
            this.CbBusqueda.Size = new System.Drawing.Size(154, 24);
            this.CbBusqueda.TabIndex = 22;
            this.CbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CbBusqueda_SelectedIndexChanged);
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Carnet de Extranjeria"});
            this.cbtipo.Location = new System.Drawing.Point(1082, 98);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(131, 24);
            this.cbtipo.TabIndex = 30;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(1082, 189);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(131, 22);
            this.tbApellido.TabIndex = 29;
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(1082, 160);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(131, 22);
            this.tbNombre.TabIndex = 28;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(1082, 130);
            this.tbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(131, 22);
            this.tbDocumento.TabIndex = 27;
            this.tbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDocumento_KeyPress);
            // 
            // tbFechaNa
            // 
            this.tbFechaNa.Location = new System.Drawing.Point(1082, 247);
            this.tbFechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.tbFechaNa.Name = "tbFechaNa";
            this.tbFechaNa.Size = new System.Drawing.Size(131, 22);
            this.tbFechaNa.TabIndex = 32;
            // 
            // textBoxDocRe
            // 
            this.textBoxDocRe.Location = new System.Drawing.Point(1082, 219);
            this.textBoxDocRe.Name = "textBoxDocRe";
            this.textBoxDocRe.Size = new System.Drawing.Size(130, 22);
            this.textBoxDocRe.TabIndex = 33;
            this.textBoxDocRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FormModificarNinio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgModificarNiño;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 439);
            this.Controls.Add(this.textBoxDocRe);
            this.Controls.Add(this.tbFechaNa);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTabla);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModificarNinio";
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbBusqueda;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbFechaNa;
        private System.Windows.Forms.TextBox textBoxDocRe;
    }
}