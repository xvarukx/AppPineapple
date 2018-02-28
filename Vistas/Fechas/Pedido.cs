using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Fechas
{
    public partial class Pedido : Form
    {
        List<Entidades.Fecha> fechas;
        List<Entidades.DetallePedido> detallePedido = new List<Entidades.DetallePedido> ();
        double todalDosis, costoTotal;
        DateTime fechaInicial, fechaFinal;
        public Pedido(List<Entidades.Fecha> fechas)
        {
            InitializeComponent();
            this.fechas = fechas;

            try
            {
                this.fechaFinal = this.fechaInicial = fechas[0].FechaProgramada;
            }
            catch {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteProductos  rp = new Reportes.ReporteProductos(dataGridView1);
          
            rp.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reportes.DGVPrinter printer = new Reportes.DGVPrinter();
            printer.Title = "Lista Productos";
            printer.SubTitle = string.Format("Fecha Inicial:{0} - Fecha Final:{1}", fechaInicial.ToString("dd/MM/yyyy"),fechaFinal.ToString("dd/MM/yyyy"));
            printer.PrintFooter = true;
            dataGridView1.Rows.Add("", "", "", "", "", "", "$"+txtCosto.Text);
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point);
            printer.Footer = "Piña Alegre -- A-M";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            printer.HeaderCellAlignment = StringAlignment.Near; 
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            this.Dispose();    

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            foreach (Entidades.Fecha p in fechas)
            {
                if (p.FechaProgramada < fechaInicial)
                    fechaInicial = p.FechaProgramada;
                if (p.FechaProgramada > fechaFinal)
                    fechaFinal = p.FechaProgramada;
                DAO.Pedido.getPedido(p.Area, p.IdAplicacion, p.Paquete, ref detallePedido);
            }

            foreach (Entidades.DetallePedido d in detallePedido) {

                dataGridView1.Rows.Add(d.IProducto, d.Nombre, d.Unidad,d.Area, d.CostoH, d.DosisTotal, d.CostoTotal);
                todalDosis += d.DosisTotal;
                costoTotal += d.CostoTotal;

            }

            txtCosto.Text = costoTotal.ToString();
            txtDosis.Text = todalDosis.ToString();
        }

    }
}
