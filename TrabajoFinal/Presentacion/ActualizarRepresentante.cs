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
    public partial class ActualizarRepresentante : Form
    {
        private nRepresentante grepresentante = new nRepresentante();
        eRepresentante RepresentanteSelecc = null;

        public ActualizarRepresentante()
        {
            InitializeComponent();
        }

        private void ActualizarRepresentante_Load(object sender, EventArgs e)
        {
            DgTabla.ClearSelection();
            tbNumero.MaxLength = 9;
            CbBusqueda.SelectedIndex = -1;
            tbBusqueda.Enabled = false;
            limpiar_seleccion();
        }
        
        private void ActualizaTexsBox()
        {
            RepresentanteSelecc = (eRepresentante)DgTabla.CurrentRow.DataBoundItem;
            tbDocumento.Text = RepresentanteSelecc.documento;
            cbtipo.Text = RepresentanteSelecc.tipoDocumento;
            tbNombre.Text = RepresentanteSelecc.nombre;
            tbApellido.Text = RepresentanteSelecc.apellido;
            tbEmail.Text = RepresentanteSelecc.email;
            tbNumero.Text = RepresentanteSelecc.numeroCel;
            tbFechaNa.Text = RepresentanteSelecc.fechaNacimiento.ToString("yyyy'-'MM'-'dd");
        }

        private void limpiar_seleccion()
        {
            DgTabla.ClearSelection();
            tbDocumento.Text = "";
            cbtipo.SelectedIndex = -1;
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEmail.Text = "";
            tbNumero.Text = "";
            tbFechaNa.Text = "";
        }
       

        private void DgTabla_SelectionChanged(object sender, EventArgs e)
        {
            ActualizaTexsBox();
        }
        private bool EmailValido(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; 
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

            if (RepresentanteSelecc.documento != tbDocumento.Text && grepresentante.ListarRepresentantes().Exists(delegate (eRepresentante repre) { return repre.documento == tbDocumento.Text; })) { MessageBox.Show("El " + cbtipo.Text + " ya existe"); return false; }
            if (!EmailValido(tbEmail.Text)) { aux = false; s += " El email no es valido"; }
            if (tbNumero.Text.Length != 9) { aux = false; s += "\n El Numero no es valido"; }
            if (cbtipo.Text == "DNI" && tbDocumento.Text.Length != 8) { aux = false; s += " \n El DNI debe tener 8 Numeros"; }
            else if (cbtipo.Text != "DNI" && cbtipo.Text != "" && tbDocumento.Text.Length != 12) { aux = false; s += " \n El Documento debe tener 12 Numeros"; }
            if (GetAge(Convert.ToDateTime(tbFechaNa.Text)) < 18) { aux = false; s += "\n El Representate debe ser mayor de edad"; }

            if (!aux) MessageBox.Show(s);
            return aux;
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            DateTime temp; //Para verificar que la fecha sea valida 
            if (RepresentanteSelecc != null)
            {
                RepresentanteSelecc = (eRepresentante)DgTabla.CurrentRow.DataBoundItem;

                if (tbDocumento.Text != "" && cbtipo.Text != "" && tbNombre.Text != "" && tbApellido.Text != "" && tbEmail.Text != "" && tbNumero.Text != "" && tbFechaNa.Text != "" && DateTime.TryParse(tbFechaNa.Text, out temp))
                {
                    if (Validaciones())
                    {
                         MessageBox.Show(grepresentante.ModificarRepresentate(cbtipo.Text, tbDocumento.Text, tbNombre.Text, tbApellido.Text,
                             tbEmail.Text, tbNumero.Text, Convert.ToDateTime(tbFechaNa.Text),RepresentanteSelecc.idRepresentante));
                         //btLimpiar_Click(sender,e);
                        DgTabla.DataSource = grepresentante.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                    }
                }
                else
                    MessageBox.Show("Inserte Datos Validos");
            }
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            if (tbBusqueda.Text != "")
            {
                if (CbBusqueda.Text == "Nacimiento")
                {
                    DateTime temp; //Para verificar que la fecha sea valida 
                    if (!DateTime.TryParse(tbFechaNa.Text, out temp))
                        MessageBox.Show("Ingresa una fecha Valida");
                    else
                    {
                        if (grepresentante.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text).Count == 0)
                            MessageBox.Show("No se encontró ninguna instancia con los dots introducidos");
                        else
                            DgTabla.DataSource = grepresentante.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                    }
                }
                else
                {
                    if (grepresentante.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text).Count == 0)
                        MessageBox.Show("No se encontró ninguna instancia con los dots introducidos");
                    else
                        DgTabla.DataSource = grepresentante.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                }
            }
            else {

                DgTabla.DataSource = null;
            }

            limpiar_seleccion();
        }

        private void CbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBusqueda.Text == "Nacimiento")
            {
                tbBusqueda.Text = "yyyy-MM-dd";
            }
            if (CbBusqueda.SelectedIndex != -1) tbBusqueda.Enabled = true;

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            DgTabla.DataSource = null;
            CbBusqueda.SelectedIndex = -1;
            tbBusqueda.Enabled = false;
            tbBusqueda.Text = "";
            limpiar_seleccion();

        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtipo.Text == "DNI") tbDocumento.MaxLength = 8;
            if (cbtipo.Text == "Pasaporte") tbDocumento.MaxLength = 12;
            if (cbtipo.Text == "Carnet de Extranjeria") tbDocumento.MaxLength = 12;
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

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
