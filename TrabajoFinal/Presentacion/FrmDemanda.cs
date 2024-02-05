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
    public partial class FrmDemanda : Form
    {
        nCita negocioCita = new nCita();
        nHorario negocioHorario = new nHorario();
        nServicio negocioServicio = new nServicio();
        nDetalleCita negocioDetalle = new nDetalleCita();
        int mayor = 0;
        int menor = 0;
        public FrmDemanda()
        {
            InitializeComponent();
        }

        private void FrmDemanda_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            dtkInicial.Value = fecha.AddYears(-1);
            dtkFinal.Value = fecha.AddYears(1);
        }

        private void BtComparar_Click(object sender, EventArgs e)
        {
            if (dtkInicial.Value == null && dtkFinal.Value == null) MessageBox.Show("Ingresa Fechas");
            else if (dtkFinal.Value == dtkInicial.Value) MessageBox.Show("Las fechas no pueden ser las mismas");
            else if (dtkFinal.Value < dtkInicial.Value) MessageBox.Show("Intervalo no valido");
            else
            {

                chtDemanda.Series[0].Points.Clear();
                labelMasRt.Text = "";
                labelMenosRt.Text = "";

                List<eCita> listCitas = negocioCita.ListarCitas();
                List<eServicio> listServicios = new List<eServicio>();
                List<eDetalleCita> listdetalles = new List<eDetalleCita>();
                List<string> nombresServicios = new List<string>();
                eHorario horario = null;
                eServicio servicio = null;
                DateTime inicial = dtkInicial.Value;
                DateTime final = dtkFinal.Value;


                foreach (eCita valor in listCitas)
                {
                    horario = negocioHorario.DevolverHorario(valor.idHorario);
                    DateTime nuevo = new DateTime(horario.anio, horario.mes, horario.dia);
                    //comparo las fechas de la cita con los intervalos
                    if (nuevo >= inicial && nuevo <= final)
                    {
                        //solo las citas que pertenescan a la condicion les pido su detalle de cita para obtener los servicios que se citaron
                        listdetalles = negocioDetalle.listarDetalle(valor.codigo);


                        foreach (eDetalleCita detallito in listdetalles)
                        {
                            servicio = negocioServicio.DevolverServicio(detallito.idServicio);
                            listServicios.Add(servicio);

                            if (!nombresServicios.Exists(delegate (string palabra)
                             {
                                 return palabra == servicio.nombreServicio;
                             })) nombresServicios.Add(servicio.nombreServicio);
                        }


                    }
                }
                if (nombresServicios.Count() != 0)
                {
                    foreach (string valor in nombresServicios)
                    {
                        chtDemanda.Series[0].Points.AddXY(valor, CalcularMontoServicios(valor, listServicios));
                    }
                    MayorServicio(nombresServicios, listServicios);
                    MenorServicio(nombresServicios, listServicios);
                }
                else
                    MessageBox.Show("no hay servicio contratados en este intervalo de tiempo");
            }
        
        }
        private int CalcularMontoServicios(string palabra, List<eServicio> aux)
        {
            int cont = 0;
            foreach (eServicio valor in aux)
            {
                if (valor.nombreServicio == palabra) cont++;
            }
            return cont;
        }
        private void MayorServicio(List<string> lsNombres, List<eServicio> aux)
        {
            mayor = 0;
            string nombre = "";
            int comparador = 0;
            foreach (string palabra in lsNombres)
            {
                if (mayor < CalcularMontoServicios(palabra,aux)) {
                    //nombre = palabra;
                    mayor = CalcularMontoServicios(palabra, aux);
                }
            }

            foreach (string palabra in lsNombres)
            {
                if (mayor == CalcularMontoServicios(palabra, aux))
                {   
                    nombre = palabra;
                    comparador++;
                }
            }

            if (comparador == 1)
            {
                labelMasRt.Text = nombre;
            }
            else
            {
                labelMasRt.Text = "No hay más demandado porque \n" +
                    "hay dos o más servicicios que tienen la misma cantidad";
            }
        }
        private void MenorServicio(List<string> lsNombres, List<eServicio> aux)
        {
            int comparador = 0;
            menor = mayor;
            string nombre = "";
            foreach (string palabra in lsNombres)
            {
                if (menor > CalcularMontoServicios(palabra, aux))
                {
                    menor = CalcularMontoServicios(palabra, aux);
                }
            }

            foreach (string palabra in lsNombres)
            {
                if (menor == CalcularMontoServicios(palabra, aux))
                {
                    nombre = palabra;
                    comparador++;
                }
            }
            if (comparador == 1)
            {
                labelMenosRt.Text = nombre;
            }
            else
            {
                labelMenosRt.Text = "No hay menos demandado porque\n" +
                    "hay dos o más servicicios que tienen la misma cantidad";
            }

        }
    }
}
