using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Negocio;
using Entidades;
namespace Presentacion
{
    public partial class HorariosMasFrecuentes : Form
    {
        public HorariosMasFrecuentes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } 

        private void Actualiza_Grafico(DateTime desde, DateTime Hasta)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            nHorario aux = new nHorario();
            nCita cita = new nCita();

            string[] Horas = aux.HorasDistintas().ToArray();

            chart1.Titles.Add("Horas");

            for (int i = 0; i < Horas.Length; i++)
            {
                if (cita.cantidad_CitasxHora(Horas[i], desde, Hasta) > 0)
                {
                    Series serie = chart1.Series.Add(Horas[i]);
                    serie.Points.Add(cita.cantidad_CitasxHora(Horas[i], desde, Hasta));
                    serie.Label = Horas[i];
                }

            }
        }

        private void HorariosMasFrecuentes_Load(object sender, EventArgs e)
        {
            //observacion
            dateTimeDesde.Value = Convert.ToDateTime("2021/01/01");
            dateTimeHasta.Value = Convert.ToDateTime("2022/01/01");

            Actualiza_Grafico(Convert.ToDateTime("2021/01/01"), Convert.ToDateTime("2022/01/01"));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimeDesde.Value == null && dateTimeHasta.Value == null) MessageBox.Show("Ingresa Fechas");
            else if (dateTimeHasta.Value == dateTimeDesde.Value) MessageBox.Show("Las fechas no pueden ser las mismas");
            else if (dateTimeHasta.Value < dateTimeDesde.Value) MessageBox.Show("Intervalo no valido");
            else Actualiza_Grafico(dateTimeDesde.Value, dateTimeHasta.Value);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
