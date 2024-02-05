
namespace Presentacion
{
    partial class FrmCumpleanios
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
            this.mCalFecha = new System.Windows.Forms.MonthCalendar();
            this.btBuscarCumple = new System.Windows.Forms.Button();
            this.dtTabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // mCalFecha
            // 
            this.mCalFecha.Location = new System.Drawing.Point(261, 163);
            this.mCalFecha.MaxSelectionCount = 20;
            this.mCalFecha.Name = "mCalFecha";
            this.mCalFecha.TabIndex = 0;
            // 
            // btBuscarCumple
            // 
            this.btBuscarCumple.Location = new System.Drawing.Point(261, 382);
            this.btBuscarCumple.Name = "btBuscarCumple";
            this.btBuscarCumple.Size = new System.Drawing.Size(290, 35);
            this.btBuscarCumple.TabIndex = 1;
            this.btBuscarCumple.Text = "Buscar";
            this.btBuscarCumple.UseVisualStyleBackColor = true;
            this.btBuscarCumple.Click += new System.EventHandler(this.btBuscarCumple_Click);
            // 
            // dtTabla
            // 
            this.dtTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtTabla.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTabla.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtTabla.Location = new System.Drawing.Point(611, 134);
            this.dtTabla.Name = "dtTabla";
            this.dtTabla.RowHeadersWidth = 51;
            this.dtTabla.RowTemplate.Height = 24;
            this.dtTabla.Size = new System.Drawing.Size(661, 294);
            this.dtTabla.TabIndex = 2;
            this.dtTabla.SelectionChanged += new System.EventHandler(this.dtTabla_SelectionChanged);
            this.dtTabla.DoubleClick += new System.EventHandler(this.dtTabla_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el tipo de busqueda";
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "Representante",
            "Ninio"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(261, 127);
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(290, 24);
            this.cmbTipoBusqueda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de los niños o representantes que cumplen años";
            // 
            // FrmCumpleanios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgCumpleaños1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTabla);
            this.Controls.Add(this.btBuscarCumple);
            this.Controls.Add(this.mCalFecha);
            this.Name = "FrmCumpleanios";
            this.Text = "FrmCumpleanios";
            this.Load += new System.EventHandler(this.FrmCumpleanios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalFecha;
        private System.Windows.Forms.Button btBuscarCumple;
        private System.Windows.Forms.DataGridView dtTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label label2;
    }
}