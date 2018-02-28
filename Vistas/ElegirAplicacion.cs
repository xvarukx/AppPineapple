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
    public partial class ElegirAplicacion : Form
    {

        public Entidades.Aplicacion aplicacion;
        public ElegirAplicacion()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.Aplicacion.buscarTable("%");
        }

        private void ElegirAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aplicacion = new Entidades.Aplicacion()
            {
                IdAplicacion = (int) dataGridView1.CurrentRow.Cells["idAplicacion"].Value,
                Nombre = (dataGridView1.CurrentRow.Cells["nombre"].Value).ToString(),
                //NombreComercial = (dataGridView1.CurrentRow.Cells["nombreComercial"].Value).ToString(),
        
            };
        }

        private void txtBuscarAplicacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DAO.Aplicacion.buscarTable(txtBuscarAplicacion.Text);
            }
            catch { }
        }
    }
}
