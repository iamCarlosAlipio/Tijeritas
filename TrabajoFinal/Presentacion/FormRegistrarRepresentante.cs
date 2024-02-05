using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
namespace Presentacion
{
    public partial class FormRegistrarRepresentante : Form
    {
        nRepresentante negocioRepresentante = new nRepresentante();

        public FormRegistrarRepresentante()
        {
            InitializeComponent();

        }
  
        private void FormRegistrarRepresentante_Load(object sender, EventArgs e)
        {
            //para desavilitar el tex
            CbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tbTelefono.MaxLength = 9;
            Limpiar();

        }

        private void btregistrar_Click_1(object sender, EventArgs e)
        {

            if (tbDocumento.Text != "" && CbTipo.SelectedIndex != -1 && tbNombre.Text != "" && tbApellido.Text != "" && tbEmail.Text != "" && tbTelefono.Text != "" && datePickerNacimiento.Value != null)
            {
               MessageBox.Show(negocioRepresentante.RegistrarRepresentante(
               CbTipo.Text,
               tbDocumento.Text,
               tbNombre.Text,
               tbApellido.Text,
               tbEmail.Text,
               tbTelefono.Text,
               datePickerNacimiento.Value
               ));

            }
            else
                MessageBox.Show("Rellena Todos los datos");
        }

        private bool EmailValido(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        private bool Validaciones()
        {
            bool aux = true;
            string s = "";
            nNinio negoninio = new nNinio();

            if (negoninio.ListarNinio().Exists(delegate (eNinio ninio) { return ninio.documento == tbDocumento.Text; })) { MessageBox.Show("El " + CbTipo.Text + " ya existe"); return false; }
            if (negocioRepresentante.ListarRepresentantes().Exists(delegate (eRepresentante repre) { return repre.documento == tbDocumento.Text; })) { MessageBox.Show("El " + CbTipo.Text + " ya existe"); return false; }
            if (!EmailValido(tbEmail.Text)) { aux = false; s += " El email no es valido"; }
            if (tbTelefono.Text.Length != 9) { aux = false; s += "\n El Numero no es valido"; }
            if (CbTipo.Text == "DNI" && tbDocumento.Text.Length != 8){ aux = false; s += " \n El DNI debe tener 8 Numeros"; }
            else if (CbTipo.Text != "DNI" && CbTipo.Text != "" && tbDocumento.Text.Length != 12) {aux = false; s += " \n El Documento debe tener 12 Numeros"; }
            if(GetAge(datePickerNacimiento.Value) < 18) { aux = false; s += "\n El Representate debe ser mayor de edad"; }


            if (!aux) MessageBox.Show(s); 
            return aux ;
        }
        private void Limpiar()
        {
            tbApellido.Text = "";
            tbDocumento.Text = "";
            CbTipo.SelectedIndex = -1; 
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEmail.Text = "";
            tbTelefono.Text = "";
            tbDocumento.Enabled = false;
            datePickerNacimiento.Value = DateTime.Today;
        }

        private void btregistrar_Click(object sender, EventArgs e)
        {
            if (tbDocumento.Text != "" && CbTipo.SelectedIndex != -1 && tbNombre.Text != "" && tbApellido.Text != "" && tbEmail.Text != "" && tbTelefono.Text != "" && datePickerNacimiento.Value != null)
            {
                if (Validaciones())
                {
                    MessageBox.Show(negocioRepresentante.RegistrarRepresentante(
                        CbTipo.Text,
                        tbDocumento.Text,
                        tbNombre.Text,
                        tbApellido.Text,
                        tbEmail.Text,
                        tbTelefono.Text,
                        datePickerNacimiento.Value
                        ));
                    Limpiar();
                }
            }
            else
                MessageBox.Show("Rellena Todos los datos");

            //MostrarRepresentantes();
        }

        private void tbDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTipo.Text == "DNI") tbDocumento.MaxLength = 8;
            if (CbTipo.Text == "Pasaporte") tbDocumento.MaxLength = 12;
            if (CbTipo.Text == "Carnet de Extranjeria") tbDocumento.MaxLength = 12;
            tbDocumento.Enabled = true;

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
