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
    public partial class Form1 : Form
    {
        nHorario negocioHorario = new nHorario();
        
        public Form1()
        {
            InitializeComponent();
            List<eHorario> lis = negocioHorario.ListarHorario();
            negocioHorario.InhabilitarHorarios();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void registrarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarServicio servicio = new FrmRegistrarServicio();
            servicio.Show();
            
        }

        private void modificarInformacionServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarServicio modifocarServicio = new FrmModificarServicio();
            modifocarServicio.Show();
        }

        private void registrarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCita cita = new FrmRegistrarCita();
            cita.Show();
        }

        private void cancelarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarCita nuuevo = new FrmModificarCita();
            nuuevo.Show();
        }

        private void registrarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarHorario horario = new FrmRegistrarHorario();
            horario.Show();
        }

        private void modificarInformacionHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarHorario modifocarHorario = new FrmModificarHorario();
            modifocarHorario.Show();
        }

        private void modificarInformacionRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarRepresentante nuevo = new ActualizarRepresentante();
            nuevo.Show();
        }

        private void registrarRepresentanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarRepresentante nuevo = new FormRegistrarRepresentante();
            nuevo.Show();
        }

        private void registrarNinioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarNinio nuevo = new FormRegistrarNinio();
            nuevo.Show();
        }

        private void modificarInformacionNinioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarNinio modificarNinio = new FormModificarNinio();
            modificarNinio.Show();
        }

        private void historialDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDemanda demanda = new FrmDemanda();
            demanda.Show();
        }

        private void cumpleañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCumpleanios cumple = new FrmCumpleanios();
            cumple.Show();
        }

        private void horariosDeDemandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorariosMasFrecuentes horario = new HorariosMasFrecuentes();
            horario.Show();
        }

        private void historialDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialClientes historial = new FormHistorialClientes();
            historial.Show();
        }

        private void colsultarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmxdia xdias = new Frmxdia();
            xdias.Show();
        }
    }
}
