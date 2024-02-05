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
    public partial class FrmRegistrarCita : Form
    {
        nServicio negocioServicio = new nServicio();
        nHorario negocioHorario = new nHorario();
        nNinio negocioNinio = new nNinio();
        nCita negocioCita = new nCita();
        nDetalleCita negocioDetalle = new nDetalleCita();
        
        eNinio ninioSeleccionado = new eNinio();
        eHorario horarioSeleccionado = new eHorario();
        List<eServicio> ls = new List<eServicio>();

        public FrmRegistrarCita()
        {
            InitializeComponent();
            MostrarServicios();
            MostrarAños();
        }
        

        private void FrmRegistrarCita_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            cmbAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnio.SelectedIndex = -1;
            lsServicios.ClearSelected();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (negocioNinio.ExisteNinio(textBoxDocu.Text))
            {
                if (comboBoxTipo.SelectedIndex != -1 && cmbAnio.SelectedIndex != -1 && cmbMes.SelectedIndex != -1
                    && cmbDia.SelectedIndex != -1)
                {
                    decimal moneda = Convert.ToDecimal(lbTotal.Text);
                    if (moneda != 0)
                    {
                        ninioSeleccionado = negocioNinio.getNinio(textBoxDocu.Text);
                        horarioSeleccionado = (eHorario)lsHora.SelectedItem;

                        if (negocioCita.ExisteCitaxIDNinioYIdHorario(ninioSeleccionado.idNinio, horarioSeleccionado.idHorario) == null)
                        {
                            MessageBox.Show(negocioCita.RegistrarCita(ninioSeleccionado.idNinio, horarioSeleccionado.idHorario,
                                Convert.ToDecimal(lbTotal.Text), "Activo"));

                            int codigo = negocioCita.RegresarCodigo();
                            foreach (eServicio valor in ls)
                            {
                                negocioDetalle.RegistrarDetalleCita(valor.id, valor.precio, codigo);
                            }
                            negocioHorario.DisminuiorCupo(horarioSeleccionado.idHorario);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("El niño ya registró una cita en este mismo horario " +
                                "Porfavor eliga otro horario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe eligir elegir al menos un servicio");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los casilleros");
                }
            }
            else
            {
                MessageBox.Show("El documento del ninio no esta registrado");
            }
        }
        private void Limpiar()
        {
            comboBoxTipo.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAnio.SelectedIndex = -1;
            cmbDia.SelectedIndex = -1;
            textBoxDocu.Clear();
            lsHora.ClearSelected();
            lsServicios.ClearSelected();
            dgDatos.DataSource = null;
            ls.Clear();

        }

        private void MostrarServicios()
        {
            lsServicios.DisplayMember = "nombreServicio";
            lsServicios.ValueMember = "codigo";
            lsServicios.DataSource = negocioServicio.ListarServicio().FindAll(delegate (eServicio valor)
            {
                return valor.estado == "Activo";
            });
        }

        private void MostrarAños()
        {
            cmbAnio.DataSource = ListarAños();
        }

        private void MostrarMeses()
        {
            cmbMes.DataSource = ListarMeses();
        }

        private void MostrarDias()
        {
            cmbDia.DataSource = ListarDias();
        }

        private void MostrarHoras()
        {
            lsHora.DisplayMember = "hora";
            lsHora.ValueMember = "idHorario";
            lsHora.DataSource = ListarHoras();
        }

        private void MostrarTotal()
        {
            
            decimal total = 0;
            foreach (eServicio valor in ls)
            {
                total += valor.precio;
            }

            lbTotal.Text = Convert.ToString(total);
            
        }

        private List<int> ListarAños()
        {
            List<int> aux = new List<int>();
            List<eHorario> ls = negocioHorario.ListarHorarioDisponibles();
            foreach (eHorario x in ls)
            {
                if (!aux.Exists(delegate (int valor)
                {
                    return valor == x.anio;
                }))
                {
                    aux.Add(x.anio);
                    
                }
            }
            aux.Sort();
            
            return aux;
        }

        private List<int> ListarMeses()
        {
            if (cmbAnio.Text != "")
            {
                List<eHorario> listaMeses = negocioHorario.ListarHorarioDisponibles().FindAll(delegate (eHorario valor)
            {
                return valor.anio == Convert.ToInt32(cmbAnio.Text);
            });

                List<int> aux = new List<int>();

                foreach (eHorario x in listaMeses)
                {
                    if (!aux.Exists(delegate (int valor)
                    {
                        return valor == x.mes;
                    }))
                    {
                        aux.Add(x.mes);
                    }
                }
                aux.Sort();
                return aux;
            }
            else
            {
                return null;
            }
        }

        private List<int> ListarDias()
        {
            if (cmbMes.Text != "")
            {
                List<eHorario> listaMeses = negocioHorario.ListarHorarioDisponibles().FindAll(delegate (eHorario valor)
                {
                    return valor.anio == Convert.ToInt32(cmbAnio.Text);
                });
                
                List<eHorario> listaDias = listaMeses.FindAll(delegate (eHorario valor)
                {
                    return valor.mes == Convert.ToInt32(cmbMes.Text);
                });

                List<int> aux = new List<int>();

                foreach (eHorario x in listaDias)
                {
                    if (!aux.Exists(delegate (int valor)
                    {
                        return valor == x.dia;
                    }))
                    {
                        aux.Add(x.dia);
                    }
                }
                aux.Sort();
                return aux;
            }
            else
            {
                return null;
            }
        }

        private List<eHorario> ListarHoras()
        {
            if (cmbDia.Text != "")
            {
                List<eHorario> listaMeses = negocioHorario.ListarHorarioDisponibles().FindAll(delegate (eHorario valor)
            {
                return valor.anio == Convert.ToInt32(cmbAnio.Text);
            });

                List<eHorario> listaDias = listaMeses.FindAll(delegate (eHorario valor)
                {
                    return valor.mes == Convert.ToInt32(cmbMes.Text);
                });

                List<eHorario> listaHoras = listaDias.FindAll(delegate (eHorario valor)
                {
                    return valor.dia == Convert.ToInt32(cmbDia.Text);
                });
                return listaHoras;
            }
            else
            {
                return null;
            }
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHoras();
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMeses();
            cmbMes.SelectedIndex = -1;
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDias();
            cmbDia.SelectedIndex = -1;
        }

        private void lsServicios_MouseClick(object sender, MouseEventArgs e)
        {
            MostrarTotal();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.Text == "DNI") textBoxDocu.MaxLength = 8;
            if (comboBoxTipo.Text == "Pasaporte") textBoxDocu.MaxLength = 12;
            if (comboBoxTipo.Text == "Carnet de Extranjeria") textBoxDocu.MaxLength = 12;
            textBoxDocu.Enabled = true;
        }

        private void textBoxDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonAniadir_Click(object sender, EventArgs e)
        {
            eServicio nuevo = null;

            if (lsServicios.SelectedIndex != -1)
            {
                foreach (eServicio valor in lsServicios.SelectedItems)
                {
                    nuevo = valor;
                }
                if (!ls.Exists(delegate (eServicio valor)
                 {
                     return valor == nuevo;
                 }))
                {
                    ls.Add(nuevo);
                }
                else
                {
                    MessageBox.Show("Este servicio ya fue añadido");
                }
                dgDatos.DataSource = null;
                dgDatos.DataSource = ls;
                MostrarTotal();
            }
            else
                MessageBox.Show("Selecione un servicio");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eServicio nuevo = null;

            if (lsServicios.SelectedIndex != -1)
            {
                foreach (eServicio valor in lsServicios.SelectedItems)
                {
                    nuevo = valor;
                }
                if (ls.Exists(delegate (eServicio valor)
                {
                    return valor == nuevo;
                }))
                {
                    ls.Remove(nuevo);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar un servicio que no ha añadido");
                }
                dgDatos.DataSource = null;
                dgDatos.DataSource = ls;
                MostrarTotal();
            }
            else
                MessageBox.Show("Selecione un servicio");

        }
    }
}
