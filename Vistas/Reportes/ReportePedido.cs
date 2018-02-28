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
    public partial class ReportePedido : Form
    {
        BindingSource bs;
        DataGridView dt;
        public ReportePedido(DataGridView data)
        {
             dt = data;
        }

        private void ReportePedido_Load(object sender, EventArgs e)
        {
        
            
        }




    }
}
