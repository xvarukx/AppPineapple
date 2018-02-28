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
    public partial class VerSecciones : Form
    {

        public Entidades.Seccion seccion;
        public VerSecciones(string lote)
        {
            InitializeComponent();
      
            dataGridView1.DataSource = DAO.Seccion.buscarSeccionTabla(lote);
        }

        private void VerSecciones_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["grupoForza"].Value.Equals("Sin Grupo"))
            {
                seccion = new Entidades.Seccion()
                {

                    IdBloque = dataGridView1.CurrentRow.Cells["idBloque"].Value.ToString(),
                    IdLote = dataGridView1.CurrentRow.Cells["idLote"].Value.ToString(),
                    IdSeccion = dataGridView1.CurrentRow.Cells["idSeccion"].Value.ToString(),
                    Posicion = (int)dataGridView1.CurrentRow.Cells["posicion"].Value,
                    GrupoForza = dataGridView1.CurrentRow.Cells["grupoForza"].Value.ToString()


                };
            }
            else {

                MessageBox.Show("La seccion seleccionada ya pertenece a un grupo");
            }
        }
    }
}
