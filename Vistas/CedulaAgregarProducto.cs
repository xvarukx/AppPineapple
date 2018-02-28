using Entidades;
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
    public partial class CedulaAgregarProducto : Form
    {
        public Producto p;
        string idActual;
        public CedulaAgregarProducto()
        {
            InitializeComponent();
            ajustarDataGrid();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        void resetData()
        {
            dataTodos.DataSource = DAO.Producto.buscarProductoTabla("%", "%");
            dataHerb.DataSource = DAO.Producto.buscarProductoTabla("%", "Herbicida");
            dataInsect.DataSource = DAO.Producto.buscarProductoTabla("%", "Insecticida");
            dataFert.DataSource = DAO.Producto.buscarProductoTabla("%", "Fertilizante");
            dataFungi.DataSource = DAO.Producto.buscarProductoTabla("%", "Fungicida");
            dataOtros.DataSource = DAO.Producto.buscarProductoTabla("%", "Otros");
            dataNema.DataSource = DAO.Producto.buscarProductoTabla("%", "Nematicida");
        }
        private void dataTodos_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
           
        }
        void obtenerID(object tabla){
            DataGridView t = (DataGridView)tabla;
            try
            {
                idActual = (string)t.CurrentRow.Cells["Codigo"].Value;
            }
            catch { }
        }
        private void dataHerb_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }


        private void dataInsect_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }
        private void dataOtros_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
           
        }

        private void dataTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
           
        }

        private void dataHerb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
           
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataPlag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataPest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataInsect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataOtros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }
        private void CedulaAgregarProducto_Load(object sender, EventArgs e)
        {
            resetData();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
           
        }
       
        void ajustarDataGrid()
        {

            foreach (Control c in tabControl1.Controls)
            {
                foreach (Control controlChild in c.Controls)
                {
                    if (controlChild is DataGridView)
                    {
                      
                        controlChild.Size = dataTodos.Size;
                        controlChild.Location = dataTodos.Location;
                    }


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = DAO.Producto.buscarProducto(idActual);
            




        }

        private void txtBuscar_TextChanged_2(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength != 0)
            {
                dataTodos.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "%");
                dataHerb.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Herbicida");
                dataInsect.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Insecticida");
                dataFert.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Pesticida");
                dataFungi.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Plaguicida");
                dataOtros.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Otros");
            }
            else
            {
                resetData();
            }
        }

        private void dataFert_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataFert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataInsect.ClearSelection();
            dataHerb.ClearSelection();
           
            dataFungi.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataFungi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataNema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataFungi_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }

        private void dataNema_SelectionChanged(object sender, EventArgs e)
        {
            obtenerID(sender);
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataFungi.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
        }
    }
    
}
