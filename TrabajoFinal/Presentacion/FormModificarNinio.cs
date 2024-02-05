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
    public partial class FormModificarNinio : Form
    {
        nNinio negocioNinio = new nNinio();
        nRepresentante negocioRepresentante = new nRepresentante();
        eNinio ninioSeleccionado = null;

        public FormModificarNinio()
        {
            InitializeComponent();
        }

        private int GetAge(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age))
                age--;

            return age;
        }
        private void limpiar()
        {

            dgTabla.ClearSelection();

            CbBusqueda.SelectedIndex = -1;
            tbDocumento.Text = "";
            cbtipo.SelectedIndex = -1;
            tbNombre.Text = "";
            tbApellido.Text = "";
            textBoxDocRe.Clear();
            tbFechaNa.Text = "";



        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            tbBusqueda.Enabled = false;
            limpiar();

        }

        //private void MostrarNinios()
        //{
        //    dgTabla.DataSource = negocioNinio.ListarNinio();
        //}

        private void ActualizaTexsBox()
        {
            ninioSeleccionado = (eNinio)dgTabla.CurrentRow.DataBoundItem;
        }

        private void dgTabla_SelectionChanged(object sender, EventArgs e)
        {
            ActualizaTexsBox();
        }

        private bool validaciones()
        {

            bool aux = true;
            string s = "";

            if (ninioSeleccionado.documento != tbDocumento.Text && (negocioNinio.ListarNinio().Exists(delegate (eNinio value) { return value.documento == tbDocumento.Text; }) || negocioRepresentante.ListarRepresentantes().Exists(delegate (eRepresentante repre) { return repre.documento == tbDocumento.Text; }))) { MessageBox.Show("El " + cbtipo.Text + " ya existe"); return false; }
            if (cbtipo.Text == "DNI" && tbDocumento.Text.Length != 8) { aux = false; s += " \n El DNI debe tener 8 Numeros"; }
            else if (cbtipo.Text != "DNI" && cbtipo.Text != "" && tbDocumento.Text.Length != 12) { aux = false; s += " \n El Documento debe tener 12 Numeros"; }
            if (GetAge(Convert.ToDateTime(tbFechaNa.Text)) > 18) { aux = false; s += "\n El Niño no debe ser mayor de edad"; }
            if (Convert.ToDateTime(tbFechaNa.Text) == DateTime.Today) { aux = false; s += "\n El Niño no puede haber nacido hoy"; }

            if (!aux) MessageBox.Show(s);

            return aux;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            eRepresentante representante = negocioRepresentante.RepresentateXDNI(textBoxDocRe.Text);
            DateTime temp; //Para verificar que la fecha sea valida 
            if (GetAge(Convert.ToDateTime(tbFechaNa.Text)) < 18)
            {
                if (Convert.ToDateTime(tbFechaNa.Text) != DateTime.Today)
                {
                    if (Convert.ToDateTime(tbFechaNa.Text) <= DateTime.Today)
                    {

                        if (Convert.ToDateTime(tbFechaNa.Text) <= DateTime.Today.AddMonths(-5))
                        {
                            if (representante != null)
                            {
                                if (ninioSeleccionado != null)
                                {
                                    if (tbDocumento.Text != "" && cbtipo.Text != "" && tbNombre.Text != "" && tbApellido.Text != "" && DateTime.TryParse(tbFechaNa.Text, out temp))
                                    {
                                        if (validaciones())
                                        {
                                            MessageBox.Show(negocioNinio.ModificarNinio(tbDocumento.Text, cbtipo.Text, tbNombre.Text, Convert.ToDateTime(tbFechaNa.Text), representante.idRepresentante, tbApellido.Text, ninioSeleccionado.idNinio));
                                            dgTabla.DataSource = negocioNinio.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                                            limpiar();
                                        }
                                    }
                                    else
                                        MessageBox.Show("Inserte Datos Validos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El docuemnto del representante no esta registrado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El niño debe tener más de 5 meses de nacido para ser registrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fecha invalida");
                    }
                }
                else
                {
                    MessageBox.Show("El Niño no puede haber nacido hoy");
                }
            }
            else
            {
                MessageBox.Show("El Niño no debe ser mayor de edad");
            }

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            if (tbBusqueda.Text != "")
            {
                if (CbBusqueda.Text == "Nacimiento")
                {
                    DateTime temp; //Para verificar que la fecha sea valida 
                    if (!DateTime.TryParse(tbFechaNa.Text, out temp) || tbBusqueda.Text == "yyyy-MM-dd")
                        MessageBox.Show("Ingresa una fecha Valida");
                    else
                    {
                        if (negocioNinio.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text).Count != 0)
                            dgTabla.DataSource = negocioNinio.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                        else
                            MessageBox.Show("Hoy hay datos para este criterio");
                    }

                }
                else
                {
                    if (negocioNinio.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text).Count != 0)
                        dgTabla.DataSource = negocioNinio.ListarSeleccionandos(CbBusqueda.Text, tbBusqueda.Text);
                    else
                        MessageBox.Show("Hoy hay datos para este criterio");
                }
            }
            
        }

        private void CbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CbBusqueda.Text == "Nacimiento")
            {
                tbBusqueda.Text = "yyyy-MM-dd";
            }
            else
                tbBusqueda.Clear();

            if (CbBusqueda.SelectedIndex == -1) tbBusqueda.Enabled = false;
            else tbBusqueda.Enabled = true;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            
            limpiar();
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

        private void tbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbBusqueda.Text == "Documento")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            } else if (CbBusqueda.Text == "Nombre" || CbBusqueda.Text == "Apellido") 
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbtipo.Text == "DNI") tbDocumento.MaxLength = 8;
            if (cbtipo.Text == "Pasaporte") tbDocumento.MaxLength = 12;
            if (cbtipo.Text == "Carnet de Extranjeria") tbDocumento.MaxLength = 12;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgTabla_Click(object sender, EventArgs e)
        {
            tbDocumento.Text = ninioSeleccionado.documento;
            cbtipo.Text = ninioSeleccionado.tipoDocumento;
            tbNombre.Text = ninioSeleccionado.Nombre;
            tbApellido.Text = ninioSeleccionado.apellido;
            tbFechaNa.Text = ninioSeleccionado.fechaNacido.ToString("yyyy'-'MM'-'dd");
            textBoxDocRe.Text = negocioNinio.RepresntanteNinio(ninioSeleccionado.idRepresentante).documento;
        }
    }
}
