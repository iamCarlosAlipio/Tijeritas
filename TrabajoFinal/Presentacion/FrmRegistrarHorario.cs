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
    public partial class FrmRegistrarHorario : Form
    {
        nHorario negocioHorario = new nHorario();
       
        public FrmRegistrarHorario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarHorario_Load(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Registrados = false;
            DateTime neuvo = DateTime.Today;
            string mensaje = "";
            List<eHorario> ls = negocioHorario.ListarHorario();

            if (mclCalendario.SelectionStart != null && mclCalendario.SelectionStart >= neuvo)
            {
                DateTime fecha = mclCalendario.SelectionStart;

                if (listBox1.SelectedIndex != -1 && textBoxCant.Text != "")
                {
                    foreach (string y in listBox1.SelectedItems)
                    {
                        if (!negocioHorario.ExisteHorario(fecha, y)) { 
                        
                            negocioHorario.RegistrarHorario(Convert.ToInt32(fecha.ToString("dd")), Convert.ToInt32(fecha.ToString("MM")),
                            Convert.ToInt32(fecha.ToString("yyyy")), y,"Activo", Convert.ToInt32(textBoxCant.Text));

                            Registrados = true;
                        }
                        else
                        {
                            mensaje = y;
                            MessageBox.Show("El horaio de " + mensaje + " ya existe\n" +
                                "por ello no se registró");
                        }
                        
                    }
                    listBox1.ClearSelected();
                    textBoxCant.Clear();
                }
                else
                {
                    MessageBox.Show("No deje ningun casillero vacio");
                }
            }
            else
            {
                MessageBox.Show("Elija una fecha mayor o igual a la de hoy día");
            }
            
            if(Registrados) MessageBox.Show("Los horarios fueron correctamente registrados");
        }

        private void textBoxCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
