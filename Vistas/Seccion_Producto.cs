using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Seccion_Producto : Form
    {
        String lote, bloque, seccion;
        DateTime fromDate, toDate;
       

        public Seccion_Producto(String lote, String bloque, String seccion, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            cargarComboLotes(DAO.Lote.buscarLotes());
            comboLotes.Text = lote;
            comboBloques.Text = bloque;
            comboSecciones.Text = seccion;
            dtFrom.Value = fromDate;
            dtTo.Value = toDate;
          //  dataGridView1.DataSource = DAO.Seccion.historialProductos(lote, bloque, seccion, fromDate, toDate);
        }

        public Seccion_Producto()
        {
            lote = "%";
            bloque = "%";
            seccion = "%";
            InitializeComponent();
            fromDate = dtFrom.Value;
            toDate = dtTo.Value;
            cargarComboLotes(DAO.Lote.buscarLotes());
            //dataGridView1.DataSource = DAO.Seccion.historialProductos(lote, bloque, seccion, fromDate, toDate);
        }

        private void comboLotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLotes.SelectedIndex != -1)
            {
                if (comboLotes.Text == "Todos") { lote = "%"; }
                else{ lote = comboLotes.Text; }
                cargarComboBloques(DAO.Bloque.buscarBloqueLista(lote));
            }
        }

        private void comboBloques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBloques.SelectedIndex != -1)
            {
                if (comboLotes.Text == "Todos") { bloque = "%"; }
                else { bloque = comboBloques.Text; }
            //    cargarComboSecciones(DAO.Seccion.buscarSeccionLista(lote, bloque, false));
            }
        }

        private void comboSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSecciones.SelectedIndex != -1)
            {
                if (comboSecciones.Text == "Todos") { seccion = "%"; }
                else { seccion = comboSecciones.Text; }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = DAO.Seccion.historialProductos(lote, bloque, seccion, fromDate, toDate);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          //  reporte = new Reportes.Seccion_Producto(lote, bloque, seccion, fromDate, toDate);
          //  reporte.Show(this);
        }

        void cargarComboLotes(List<Entidades.Lote> lista)
        {
            comboLotes.Items.Clear();
            comboLotes.Items.Add("Todos");
            foreach (Entidades.Lote l in lista)
            {
                comboLotes.Items.Add(l.IdLote);
            }
            
        }
        void cargarComboBloques(List<Entidades.Bloque> lista)
        {
            comboBloques.Items.Clear();
            comboBloques.Items.Add("Todos");
            if (lote != "%")
            {
                foreach (Entidades.Bloque b in lista)
                {
                    comboBloques.Items.Add(b.IdBloque);
                }
            }
        }
        void cargarComboSecciones(List<Entidades.Seccion> lista)
        {
            comboSecciones.Items.Clear();
            comboSecciones.Items.Add("Todos");
            if (bloque != "%")
            {
                foreach (Entidades.Seccion l in lista)
                {
                    comboSecciones.Items.Add(l.IdSeccion);
                }
            }
        }
    }
}
