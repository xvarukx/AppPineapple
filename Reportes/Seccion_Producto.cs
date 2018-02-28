using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes
{
    public partial class Seccion_Producto : Form
    {
        String lote, bloque, seccion;
        DateTime fromDate, toDate;

        public Seccion_Producto(String lote, String bloque, String seccion, DateTime fromDate, DateTime toDate)
        {
            this.lote = lote;
            this.bloque = bloque;
            this.seccion = seccion;
            this.fromDate = fromDate;
            this.toDate = toDate;
         InitializeComponent();
        }

        private void Seccion_Producto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pinaDataSet.buscarSeccion_Producto' table. You can move, or remove it, as needed.
            this.buscarSeccion_ProductoTableAdapter.Fill(this.pinaDataSet.buscarSeccion_Producto,lote,bloque,seccion,fromDate,toDate);
            this.reportViewer1.RefreshReport();
        }
    }
}
