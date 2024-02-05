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
    public partial class FrmModificarCita : Form
    {
        nNinio negocioNinio = new nNinio();
        nCita negocioCita = new nCita();
        eCita citaSeleccionado = null;
        eNinio entidadNinio = new eNinio();
        nHorario negocioHorario = new nHorario();
        eHorario entidadHorario = new eHorario();
        List<eCita> ls = new List<eCita>();
        

        public FrmModificarCita()
        {
            InitializeComponent();
            CbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHoras.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Mostar()
        {
            dtCitas.DataSource = ls.FindAll(delegate (eCita valor)
            {
                return valor.estado == "Activo";
            });
                
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtCitas.DataSource = null;
            if(txtCod.Text != "")
            {
                if (negocioNinio.getNinio(txtCod.Text)!=null)
                {
                    //cmbHoras.Enabled = true;
                    //dtFecha.Enabled = true;
                    //txtCod.Enabled = false;
                    entidadNinio = negocioNinio.getNinio(txtCod.Text);
                    entidadHorario = negocioHorario.DarHorario(dtFecha.Value,(string)cmbHoras.SelectedItem);
                    if (entidadHorario != null)
                    {
                        if (negocioCita.ExisteCitaxIDNinioYIdHorario(entidadNinio.idNinio, entidadHorario.idHorario)!=null){
                            ls.Add(negocioCita.ExisteCitaxIDNinioYIdHorario(entidadNinio.idNinio, entidadHorario.idHorario));
                            Mostar();
                            if (ls.Count != 0)
                            {
                                button1.Enabled = true;
                                btBuscar.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No tiene citas en este horario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("el horario ingresado no esta registrado");
                    }
                }
                else
                {
                    MessageBox.Show("el Niño ingresado no existe");
                }
            }
            else
            {
                MessageBox.Show("Llene el campo de documento");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            MessageBox.Show(negocioCita.ModificarCita(citaSeleccionado.idNinio,
                citaSeleccionado.idHorario, citaSeleccionado.total, "Inactivo",citaSeleccionado.codigo));
            negocioHorario.AumentarCupo(entidadHorario.idHorario);
            btBuscar.Enabled = true;
            dtCitas.DataSource = null;

        }

        private void dtCitas_SelectionChanged(object sender, EventArgs e)
        {
            citaSeleccionado = (eCita)dtCitas.CurrentRow.DataBoundItem;
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbTipo.Text == "DNI") txtCod.MaxLength = 8;
            if (CbTipo.Text == "Pasaporte") txtCod.MaxLength = 12;
            if (CbTipo.Text == "Carnet de Extranjeria") txtCod.MaxLength = 12;
            txtCod.Enabled = true;
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
