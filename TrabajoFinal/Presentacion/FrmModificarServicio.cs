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
    public partial class FrmModificarServicio : Form
    {
        nServicio negocioServicio = new nServicio();
        eServicio servicioSeleccionado = null;

        public FrmModificarServicio()
        {
            InitializeComponent();
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmModificarServicio_Load(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void MostrarServicios()
        {
            List<eServicio> nuevo = new List<eServicio>();
            nuevo.Add(servicioSeleccionado);
            dgServicios.DataSource = nuevo;
        }

        private void dgServicios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgServicios.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex != -1 && txtNombre.Text != "" && txtPrecio.Text != "")
            {
                MessageBox.Show(negocioServicio.ModificarServicio(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text),
                    (string)cmbEstado.SelectedItem,servicioSeleccionado.id));
                //servicioSeleccionado.estado = (string)cmbEstado.SelectedItem;
                //servicioSeleccionado.precio = Convert.ToDecimal(txtPrecio.Text);
                servicioSeleccionado = negocioServicio.ListarServicio().Find(delegate (eServicio valor)
                {
                    return valor.nombreServicio == txtNombre.Text;
                });
                MostrarServicios();

            }
            else
            {
                MessageBox.Show("LLene correctamento los casilleros");
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (negocioServicio.ListarServicio().Exists(delegate (eServicio valor)
             {
                 return valor.nombreServicio == txtNombre.Text;
             }))
            {
                txtPrecio.Enabled = true;
                cmbEstado.Enabled = true;
                button1.Enabled = true;
                txtNombre.Enabled =false ;
                servicioSeleccionado = negocioServicio.ListarServicio().Find(delegate(eServicio valor)
                {
                    return valor.nombreServicio == txtNombre.Text;
                });
                txtPrecio.Text = Convert.ToString(servicioSeleccionado.precio);
                cmbEstado.Text = servicioSeleccionado.estado;
                MostrarServicios();
                buttonBuscar.Enabled = false;
            }
            else {

                MessageBox.Show("el Servicio no esta registrado");
                txtNombre.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgServicios.DataSource = null;
            txtNombre.Clear();
            txtPrecio.Clear();
            cmbEstado.SelectedIndex = -1;
            txtPrecio.Enabled = false;
            cmbEstado.Enabled = false;
            button1.Enabled = false;
            buttonBuscar.Enabled = true;
            txtNombre.Enabled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo para un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
