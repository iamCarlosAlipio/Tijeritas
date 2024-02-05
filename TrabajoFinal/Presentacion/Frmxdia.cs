using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Frmxdia : Form
    {
        nCita negocioCita = new nCita();
        nHorario negociohoraio = new nHorario();
        public Frmxdia()
        {
            InitializeComponent();
            //negocioCita = new nCita();
        }

        private void Frmxdia_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negocioCita.ListarCitas().FindAll(delegate (eCita value)
            {
                eHorario dia = negociohoraio.ListarHorario().Find(delegate (eHorario ite) { return ite.idHorario == value.idHorario; });

                DateTime fecha = new DateTime(dia.anio, dia.mes, dia.dia);
                return (fecha.ToShortDateString() == dateTimePicker1.Value.ToShortDateString() && value.estado == "Activo");

            });
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            label1.Visible = true;
            eCita seleccionada = (eCita)dataGridView1.CurrentRow.DataBoundItem;
            label1.Text = "La hora de la cita en esta fecha es: " + negociohoraio.ListarHorario().Find(delegate (eHorario ite) { return ite.idHorario == seleccionada.idHorario; }).hora;
        }
    }
}
