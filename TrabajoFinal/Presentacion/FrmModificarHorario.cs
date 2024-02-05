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
    public partial class FrmModificarHorario : Form
    {
        nHorario negocioHorario = new nHorario();
        eHorario horarioSeleccionado = null;
        //bool general = true;

        public FrmModificarHorario()
        {
            InitializeComponent();
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            horarioSeleccionado = (eHorario)dgHorarios.CurrentRow.DataBoundItem;
            
            if (cmbEstado.SelectedIndex != -1&& textBoxCant.Text!="")
            {
                if (horarioSeleccionado.cuposDisponibles < Convert.ToInt32(textBoxCant.Text))
                {
                    MessageBox.Show(negocioHorario.ModificarHorario(cmbEstado.Text, horarioSeleccionado.idHorario, Convert.ToInt32(textBoxCant.Text)));
                    MostrarHorarios(dateTimePickerFecha.Value);
                }
                else
                {

                    MessageBox.Show("La cantidad de cupos maximos debe ser mayor a la cantidad\n" +
                        " de cupos ocupados que es "+ horarioSeleccionado.cuposDisponibles.ToString());
                }
            }
            else
            {
                MessageBox.Show("LLene correctamente los casilleros");
            }
        }
        private void MostrarHorarios(DateTime fecha)
        {
            if (negocioHorario.ListarHorarioFcha(dateTimePickerFecha.Value).Count() > 0)
            {
                dgHorarios.DataSource = negocioHorario.ListarHorarioFcha(fecha);
            }
            else
            {
                MessageBox.Show("No hay horarios registrados en esta fecha");
            }
        }

        private void dgHorarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgHorarios.ClearSelection();
        }

        private void dgHorarios_SelectionChanged(object sender, EventArgs e)
        {
  
            horarioSeleccionado = (eHorario)dgHorarios.CurrentRow.DataBoundItem;
            cmbEstado.Text = horarioSeleccionado.estado;
            textBoxCant.Text = Convert.ToString(horarioSeleccionado.cantidadCuposMax);
            
            
            //general = true;
        }

        private void FrmModificarHorario_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MostrarHorarios(dateTimePickerFecha.Value);
            textBoxCant.Clear();
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
