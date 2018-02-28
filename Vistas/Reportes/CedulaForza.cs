using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Reportes
{
    public partial class CedulaForza : Form
    {
        int cedula;
        public CedulaForza(int cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
        }

        private void CedulaForza_Load(object sender, EventArgs e)
        {
            //   this.reportViewer1.LocalReport.ReportPath = "C:/Users/Luis Mora/Desktop/Proyecto-Pi-a/Vistas/Reportes/NuevaCedula.rdlc";
            // TODO: This line of code loads data into the 'pinaDataSet.detallecedulapray' table. You can move, or remove it, as needed.
            this.reportViewer1.LocalReport.DisplayName = "Cedula Numero: " + this.cedula;
            this.detallecedulaprayTableAdapter.FillBy(this.pinaDataSet.detallecedulapray, cedula);
            this.cedulaidentidadTableAdapter.Fill(this.pinaDataSet.cedulaidentidad, cedula);
            this.detallecedulaproductosTableAdapter.FillBy(this.pinaDataSet.detallecedulaproductos, cedula);
            this.detalleseccioncedulaTableAdapter.Fill(this.pinaDataSet.detalleseccioncedula, cedula);

            //

            string cadena = "";
            foreach (DataRow row in pinaDataSet.detalleseccioncedula.Rows)
            {
                string lote = row["lote"].ToString();
                string bloque = row["bloque"].ToString();
                string seccion = row["seccion"].ToString();
                string area = row["area"].ToString();

                cadena += lote + "-" + bloque + "-" + seccion + "(" + area + ")" + ", ";
            }
            bool opc;

            if (cadena.Length > 3) cadena = cadena.Remove(cadena.Length - 2);
            DateTime fechaProgramada = DateTime.Parse(pinaDataSet.cedulaidentidad.Rows[0]["fechaProgramada"].ToString());
            string semana = conf.weekNumber(fechaProgramada).ToString();
            string aplicacion = pinaDataSet.cedulaidentidad.Rows[0]["nombreAplicacion"].ToString() + "(" + pinaDataSet.cedulaidentidad.Rows[0]["etapa"].ToString() + ")";
            ReportParameter[] parametros = new ReportParameter[7];
            Entidades.Empleado c = DAO.Empleado.buscarEmpleado(pinaDataSet.cedulaidentidad.Rows[0]["chofer"].ToString());
            parametros[0] = new ReportParameter("semana", semana);
            opc = Boolean.Parse(pinaDataSet.cedulaidentidad.Rows[0]["muestreo"].ToString());
            parametros[1] = new ReportParameter("muestreo", agregarX(opc));
            opc = Boolean.Parse(pinaDataSet.cedulaidentidad.Rows[0]["programacion"].ToString());
            parametros[2] = new ReportParameter("programacion", agregarX(opc));
            parametros[3] = new ReportParameter("chofer", (c.Nombre + " " + c.Apellido + " " + c.Apellido2));
            double boomH = 2.25; //Double.Parse(pinaDataSet.cedulaidentidad.Rows[0]["ltsRequeridosH"].ToString()) / Double.Parse(this.pinaDataSet.detallecedulapray.Rows[0]["capacidad"].ToString());
            parametros[4] = new ReportParameter("boomH", boomH.ToString());
            parametros[5] = new ReportParameter("cadena", cadena);
            parametros[6] = new ReportParameter("aplicacion", aplicacion);
            try
            {
                this.reportViewer1.LocalReport.SetParameters(parametros);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }





        string agregarX(bool opcion)
        {

            if (opcion)
                return "x";

            else
                return " ";

        }
    }


}
















//   




/*
this.reportViewer1.RefreshReport();


this.reportViewer1.RefreshReport();
this.reportViewer1.RefreshReport();


}   
*/






