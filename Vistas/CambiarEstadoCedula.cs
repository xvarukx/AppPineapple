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
    public partial class CambiarEstadoCedula : Form
    {
        int cedula;
        string estado;
        public CambiarEstadoCedula(int idCedula, string estado)
        {
            InitializeComponent();
            cedula = idCedula;
            groupBox1.Text = "Cedula: " + cedula;
            this.estado = estado;
        }

        private void chkActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNula.Checked)
                chkNula.Checked = false;

        }

        private void chkNula_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                List<Entidades.Producto> p = DAO.CedulaIdentidad.obtenerProductosCedula(cedula);
                if (chkNula.Checked)
                {
                    DAO.CedulaIdentidad.cambiarEstadoCedula("Anulada", cedula);
                    recorrerLista(p);

                }
                MessageBox.Show("Cambio efectuado correctamente");
            }
            catch { }
        }



        void recorrerLista(List<Entidades.Producto> p) {

            foreach (Entidades.Producto producto in p) {
              
                    DAO.Producto.supply(producto.IdProducto, producto.Cantidad);
                }
            
            
        }

    }
}
