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
    public partial class FormRegistrarNinio : Form
    {
        nNinio negocioNinio = new nNinio();
        nRepresentante negocioRepresentante = new nRepresentante();
        public FormRegistrarNinio()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDocRepre.Clear();
            textBoxDocumento.Clear();
            comboBoxTipoDoc.SelectedIndex = -1;
          
            dateTimePicker1.Value=DateTime.Today;
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

            if (!negocioRepresentante.ListarRepresentantes().Exists(delegate (eRepresentante value) { return value.documento == textBoxDocRepre.Text; })) { aux = false; s += " \n El representante no se encuentra registrado"; }
            if (negocioNinio.ListarNinio().Exists(delegate (eNinio value) { return value.documento == textBoxDocumento.Text; }) || negocioRepresentante.ListarRepresentantes().Exists(delegate (eRepresentante repre) { return repre.documento == textBoxDocumento.Text; })) { MessageBox.Show("El " + comboBoxTipoDoc.Text + " ya esta registrado"); return false; }
            if (comboBoxTipoDoc.Text == "DNI" && textBoxDocumento.Text.Length != 8) { aux = false; s += " \n El DNI debe tener 8 Numeros"; }
            else if (comboBoxTipoDoc.Text != "DNI" && textBoxDocumento.Text != "" && textBoxDocumento.Text.Length != 12) { aux = false; s += " \n El Documento debe tener 12 Numeros"; }
            if (GetAge(dateTimePicker1.Value) > 18) { aux = false; s += "\n El Niño no debe ser mayor de edad"; }
            if (dateTimePicker1.Value == DateTime.Today) { aux = false; s += "\n El Niño no puede haber nacido hoy"; }
            if (dateTimePicker1.Value >= DateTime.Today) { aux = false; s += "\n Fecha invalida"; }
            if (dateTimePicker1.Value >= DateTime.Today.AddMonths(-5)) { aux = false; s += "\n El niño debe tener más de 5 meses de nacido para ser registrado"; }
            if (!aux) MessageBox.Show(s);

            return aux;
        }
        
      
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
            if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && comboBoxTipoDoc.SelectedIndex != -1 && textBoxDocumento.Text != "" && dateTimePicker1.Value != null && textBoxDocRepre.Text != "" )
            {
                if (Validaciones()) 
                {
                    MessageBox.Show(negocioNinio.RegistrarNinio(textBoxDocumento.Text, comboBoxTipoDoc.Text, textBoxNombre.Text, dateTimePicker1.Value, negocioRepresentante.RepresentateXDNI(textBoxDocRepre.Text).idRepresentante, textBoxApellido.Text));
                    
                    LimpiarCampos();

                }
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }

        }

        private void FormRegistrarNinio_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void comboBoxTipoRep_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            textBoxDocRepre.Enabled = true;
        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoDoc.Text == "DNI") textBoxDocumento.MaxLength = 8;
            if (comboBoxTipoDoc.Text == "Pasaporte") textBoxDocumento.MaxLength = 12;
            if (comboBoxTipoDoc.Text == "Carnet de Extranjeria") textBoxDocumento.MaxLength = 12;
            textBoxDocumento.Enabled = true;
        }

        private void textBoxDocRepre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
