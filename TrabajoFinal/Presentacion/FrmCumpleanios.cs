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
    public partial class FrmCumpleanios : Form
    {
        nNinio negocioNinio = new nNinio();
        nRepresentante negocioRepresentante = new nRepresentante();
        bool general = false;
        public FrmCumpleanios()
           
        {
            InitializeComponent();
        }

        private void FrmCumpleanios_Load(object sender, EventArgs e)
        {
            cmbTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btBuscarCumple_Click(object sender, EventArgs e)
        {
            if (cmbTipoBusqueda.SelectedIndex != -1)
            {
                int mesInicial = Convert.ToInt32(mCalFecha.SelectionStart.ToString("MM"));
                int diaInicial = Convert.ToInt32(mCalFecha.SelectionStart.ToString("dd"));
                int mesFinal = Convert.ToInt32(mCalFecha.SelectionEnd.ToString("MM"));
                int diaFinal = Convert.ToInt32(mCalFecha.SelectionEnd.ToString("dd"));

                if (cmbTipoBusqueda.Text == "Ninio")
                {
                    if (negocioNinio.ListarSegunFecha(diaInicial, mesInicial, diaFinal, mesFinal).Count != 0)
                    {
                        dtTabla.DataSource = negocioNinio.ListarSegunFecha(diaInicial, mesInicial, diaFinal, mesFinal);
                    }
                    else
                    {
                        MessageBox.Show("No hay niños que cumplan años\n" +
                            "en este intervalo de tiempo");
                    }
                }
                if (cmbTipoBusqueda.Text == "Representante")
                {
                    if (negocioRepresentante.ListarSegunFecha(diaInicial, mesInicial, diaFinal, mesFinal).Count != 0)
                    {
                        dtTabla.DataSource = negocioRepresentante.ListarSegunFecha(diaInicial, mesInicial, diaFinal, mesFinal);
                    }
                    else
                    {
                        MessageBox.Show("No hay representantes que cumplan años\n" +
                            "en este intervalo de tiempo");
                    }
                }
            }
            else
            {
                MessageBox.Show("seleccione el tipo de busqueda");
            }
            general = false;
        }

        private void dtTabla_SelectionChanged(object sender, EventArgs e)
        {

        }
        private int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }

        private void dtTabla_DoubleClick(object sender, EventArgs e)
        {
            if ((string)cmbTipoBusqueda.SelectedItem == "Representante")
            {
                eRepresentante seleccionado = (eRepresentante)dtTabla.CurrentRow.DataBoundItem;
                MessageBox.Show((GetAge(seleccionado.fechaNacimiento) + 1).ToString()+" años");
            }
            else
            {
                eNinio seleccionado = (eNinio)dtTabla.CurrentRow.DataBoundItem;
                MessageBox.Show((GetAge(seleccionado.fechaNacido) + 1).ToString() + " años");
            }
        }
    }
}
