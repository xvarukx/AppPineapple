using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Mapas
{
    public partial class EditBloque : Form
    {
        Mapa padreForm;
        Entidades.Bloque bloque;

        public EditBloque(Mapa padreForm, Entidades.Bloque bloque)
        {
            this.padreForm = padreForm;
            this.bloque = bloque;
            InitializeComponent();
            txtArea.Text = bloque.Area.ToString();
            txtCantidad.Text = bloque.NumPlantas.ToString();
            txtDetalles.Text = bloque.Detalles;
            txtAreaUtilizada.Text = bloque.AreaUtilizada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bloque.Area = double.Parse(txtArea.Text);
            bloque.Detalles = txtDetalles.Text;
            padreForm.editarBloque(bloque);
            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtArea.ReadOnly = false;
                txtDetalles.ReadOnly = false;
                button1.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                txtArea.ReadOnly = true;
                txtDetalles.ReadOnly = true;
                button1.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DAO.Bloque.eliminable(bloque))
            {
                padreForm.eliminarBloque(bloque);
                Dispose();
            }
            else { MessageBox.Show("El bloque actual esta enlazado a secciones que tienen procesos activos. No se puede eliminar"); }
            
        }
    }
}
