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
    public partial class Configuracion : Form
    {
        Entidades.Configuracion config;
        public Configuracion()
        {
            config = DAO.Configuracion.getConfiguracion();
            InitializeComponent();
            dataGridView1.DataSource = DAO.Notificacion.getCorreosTabla();
            txtFCorreo.Text = config.FrecuenciaCorreos.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DAO.Notificacion.insertarCorreo(textBox1.Text);
            dataGridView1.DataSource = DAO.Notificacion.getCorreosTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null) { return; }
            DAO.Notificacion.eliminarCorreo((string)dataGridView1.CurrentRow.Cells["correo"].Value);
            dataGridView1.DataSource = DAO.Notificacion.getCorreosTabla();
        }
        private void validarNumerosCorreos(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnFCorreo.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnFCorreo.Enabled = false;
            }
        }
        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

        private void btnFCorreo_Click(object sender, EventArgs e)
        {
            DAO.Configuracion.setFrecuenciaCorreos(int.Parse(txtFCorreo.Text));
        }
    }

    

    
    

}
