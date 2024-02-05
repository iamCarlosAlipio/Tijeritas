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
    public partial class FrmRegistrarServicio : Form
    {
        nServicio negocioServicio = new nServicio();
        public FrmRegistrarServicio()
        {
            InitializeComponent();
        }

        private void FrmRegistrarServicio_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!negocioServicio.ListarServicio().Exists(delegate (eServicio valor)
             {
                 return valor.nombreServicio == txtNombre.Text;
             }))
            {
                if (txtNombre.Text != "" && txtPrecio.Text != "")
                {
                    MessageBox.Show(negocioServicio.RegistrarServicio(txtNombre.Text, Convert.ToDecimal(txtPrecio.Text),
                        "Activo"));

                    txtNombre.Clear();
                    txtPrecio.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor llene correctamente" +
                        " los casilleros");
                }
            }
            else
            {
                MessageBox.Show("El servicio ya existe");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para usar solo letras sin signos especiales
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            //para el separador
            if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para numeros de venta
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
