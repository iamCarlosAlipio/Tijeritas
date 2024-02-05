
namespace Presentacion
{
    partial class FrmDemanda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtDemanda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtkInicial = new System.Windows.Forms.DateTimePicker();
            this.dtkFinal = new System.Windows.Forms.DateTimePicker();
            this.BtComparar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMasRt = new System.Windows.Forms.Label();
            this.labelMenosRt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtDemanda)).BeginInit();
            this.SuspendLayout();
            // 
            // chtDemanda
            // 
            this.chtDemanda.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.chtDemanda.BackColor = System.Drawing.Color.Transparent;
            this.chtDemanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chtDemanda.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chtDemanda.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtDemanda.Legends.Add(legend2);
            this.chtDemanda.Location = new System.Drawing.Point(627, 24);
            this.chtDemanda.Name = "chtDemanda";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtDemanda.Series.Add(series2);
            this.chtDemanda.Size = new System.Drawing.Size(479, 363);
            this.chtDemanda.TabIndex = 0;
            this.chtDemanda.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(242, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // dtkInicial
            // 
            this.dtkInicial.Location = new System.Drawing.Point(315, 24);
            this.dtkInicial.Name = "dtkInicial";
            this.dtkInicial.Size = new System.Drawing.Size(253, 22);
            this.dtkInicial.TabIndex = 3;
            // 
            // dtkFinal
            // 
            this.dtkFinal.Location = new System.Drawing.Point(315, 64);
            this.dtkFinal.Name = "dtkFinal";
            this.dtkFinal.Size = new System.Drawing.Size(253, 22);
            this.dtkFinal.TabIndex = 4;
            // 
            // BtComparar
            // 
            this.BtComparar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtComparar.Location = new System.Drawing.Point(245, 106);
            this.BtComparar.Name = "BtComparar";
            this.BtComparar.Size = new System.Drawing.Size(323, 62);
            this.BtComparar.TabIndex = 5;
            this.BtComparar.Text = "Comparar";
            this.BtComparar.UseVisualStyleBackColor = true;
            this.BtComparar.Click += new System.EventHandler(this.BtComparar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(254, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SERVICIO MÁS DEMANDADO";
            // 
            // labelMasRt
            // 
            this.labelMasRt.AutoSize = true;
            this.labelMasRt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMasRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasRt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMasRt.Location = new System.Drawing.Point(261, 269);
            this.labelMasRt.Name = "labelMasRt";
            this.labelMasRt.Size = new System.Drawing.Size(0, 17);
            this.labelMasRt.TabIndex = 7;
            // 
            // labelMenosRt
            // 
            this.labelMenosRt.AutoSize = true;
            this.labelMenosRt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMenosRt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMenosRt.Location = new System.Drawing.Point(262, 390);
            this.labelMenosRt.Name = "labelMenosRt";
            this.labelMenosRt.Size = new System.Drawing.Size(0, 17);
            this.labelMenosRt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(254, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "SERVICIO MENOS DEMANDADO";
            // 
            // FrmDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.imgDemanda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMenosRt);
            this.Controls.Add(this.labelMasRt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtComparar);
            this.Controls.Add(this.dtkFinal);
            this.Controls.Add(this.dtkInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chtDemanda);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmDemanda";
            this.ShowInTaskbar = false;
            this.Text = "FrmDemanda";
            this.Load += new System.EventHandler(this.FrmDemanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDemanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtDemanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtkInicial;
        private System.Windows.Forms.DateTimePicker dtkFinal;
        private System.Windows.Forms.Button BtComparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMasRt;
        private System.Windows.Forms.Label labelMenosRt;
        private System.Windows.Forms.Label label6;
    }
}