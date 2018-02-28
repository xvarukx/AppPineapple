using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Reportes
{
    public partial class ReporteCedula : Form
    {
        int cedula;
        public ReporteCedula(int cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
        }

        

        private void ReporteCedula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pinaDataSet.detallecedulaproductos' Puede moverla o quitarla según sea necesario.
          
            // TODO: esta línea de código carga datos en la tabla 'pinaDataSet.detalleseccioncedula' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'pinaDataSet.sprayboom' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'pinaDataSet.cedulaidentidad' Puede moverla o quitarla según sea necesario.
     
            this.cedulaidentidadTableAdapter.llenarCedula(pinaDataSet.cedulaidentidad,cedula);
            this.sprayboomTableAdapter.FillBy(this.pinaDataSet.sprayboom, pinaDataSet.cedulaidentidad.Rows[0]["numSpray"].ToString());
            this.detalleseccioncedulaTableAdapter.FillBy(this.pinaDataSet.detalleseccioncedula, cedula);
            this.detallecedulaproductosTableAdapter.FillBy(this.pinaDataSet.detallecedulaproductos, cedula);
            bool opc;
            string semana =  System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(DateTime.Today, CalendarWeekRule.FirstDay, DateTime.Today.DayOfWeek).ToString();
            DateTime fechaProgramada  = DateTime.Parse(pinaDataSet.cedulaidentidad.Rows[0]["fechaProgramada"].ToString());
            ReportParameter[] parametros = new ReportParameter[5];
            Entidades.Chofer c = DAO.Chofer.buscarChofer(pinaDataSet.cedulaidentidad.Rows[0]["chofer"].ToString());
            parametros[0] = new ReportParameter("semana", semana);
            opc = Boolean.Parse(pinaDataSet.cedulaidentidad.Rows[0]["muestreo"].ToString());
            parametros[1] = new ReportParameter("muestreo", agregarX(opc));
            opc = Boolean.Parse(pinaDataSet.cedulaidentidad.Rows[0]["programacion"].ToString());
            parametros[2] = new ReportParameter("programacion", agregarX(opc));
            parametros[3] = new ReportParameter("chofer", (c.Nombre+" " + c.Apellido + " " + c.Apellido2));
            double boomH = Double.Parse(pinaDataSet.cedulaidentidad.Rows[0]["ltsRequeridosH"].ToString())/ Double.Parse(this.pinaDataSet.sprayboom.Rows[0]["capacidad"].ToString());
            parametros[4] = new ReportParameter("boomH", boomH.ToString());
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();

          
            this.reportViewer1.RefreshReport();
        }


        string agregarX(bool opcion) {

            if (opcion)
                return "x";

            else
                return " ";

        }
    }
}
