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
    public partial class ReporteProductos : Form
    {
        DataGridView dt;
        public ReporteProductos(DataGridView e)
        {
            InitializeComponent();
            dt = e;

        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
          
        

        }
    }
}
