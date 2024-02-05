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
    public partial class FormHistorialClientes : Form
    {
        nRepresentante negocioRepre = new nRepresentante();
        nCita negocioCita = new nCita();
        List<eServicio> servicios = new List<eServicio>();
        nServicio negocioServicio = new nServicio();
        eCita citaelegida = new eCita();
        nDetalleCita ndetalle = new nDetalleCita();

        public FormHistorialClientes()
        {
            InitializeComponent();
            MostrarHistorial();

        }

        private void MostrarHistorial()
        {
            
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (negocioRepre.ListarRepresentantes().Exists(delegate (eRepresentante value) { return value.documento == textBox1.Text; }))
                    {
                        dataGridView1.DataSource = negocioCita.CitasXdniRepre(textBox1.Text);

                    }
                    else
                    {
                        MessageBox.Show("El representante no esta registrado");
                        dataGridView1.DataSource = null;
                        listBox1.DataSource = null;
                        servicios = null;

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de documento");
                }
            }
            else
            {
                MessageBox.Show("Llene el casillero de documento");
            }
            dataGridView1.ClearSelection();
            //istBox1.Clear();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "DNI") textBox1.MaxLength = 8;

            if (comboBox1.Text == "Pasaporte") textBox1.MaxLength = 12;

            if (comboBox1.Text == "Carnet de Extranjeria") textBox1.MaxLength = 12;

            textBox1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void FormHistorialClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            comboBox1.SelectedIndex = -1;
            textBox1.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            servicios = new List<eServicio>();
            citaelegida = (eCita)dataGridView1.CurrentRow.DataBoundItem;
            List<eDetalleCita> detalleaux = new List<eDetalleCita>();
            detalleaux = ndetalle.DetalleXCita(citaelegida.codigo);

            foreach (eDetalleCita valor in detalleaux)
            {
                servicios.Add(negocioServicio.DevolverServicioXDetalleID(valor.idServicio));
            }

            listBox1.DisplayMember = "nombreServicio";
            listBox1.DataSource = servicios;
        }
    }
}
