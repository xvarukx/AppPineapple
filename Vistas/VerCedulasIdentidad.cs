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
    public partial class VerCedulasIdentidad : Form
    {
        List<Entidades.Lote> lotes;
        List<Entidades.GrupoForza> grupos;
        string estadoAplicacion;
        public VerCedulasIdentidad()
        {
            InitializeComponent();
            try
            {
                lotes = DAO.CedulaIdentidad.buscarLotes();
                grupos = DAO.CedulaIdentidad.buscarGrupo();
            }
            catch { }
            cargarCombo(lotes);
            cargarGrupoForza(grupos);
            cmbEstado.SelectedIndex = 0;

        }
        void cargarCombo(List<Entidades.Lote> lista)
        {
            comboBox1.Items.Add("Todos");
            foreach (Entidades.Lote l in lista)
            {
                comboBox1.Items.Add(l.IdLote);


            }
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch
            {

            }

        }
        void cargarGrupoForza(List<Entidades.GrupoForza> lista)
        {
            comboBox2.Items.Add("Todos");
            foreach (Entidades.GrupoForza l in lista)
            {
                comboBox2.Items.Add(l.IdGrupo);


            }
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch
            {

            }

        }
        private void VerCedulasIdentidad_Load(object sender, EventArgs e)
        {
            conf.evitarOrdenar(ref dataGridView1);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarInformacionCedula a = new AgregarInformacionCedula((int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value);
                a.Show();
            }
            catch { }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.Text.Equals("Activo"))
                {

                    VerInformacionCedula a = new VerInformacionCedula((int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value, cmbEstado.Text);
                    a.ShowDialog();
                }
                else {
                    MessageBox.Show("Las cedulas deben de estar activadas para poder ser modificadas");
                }
               
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGridView1.CurrentRow.Cells["Grupo"].Value.ToString().Equals("Sin Grupo"))
                {
                    Reportes.CedulaReporte r = new Reportes.CedulaReporte((int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value);
                    r.ShowDialog();
                }
                else
                {
                    Reportes.CedulaForza r = new Reportes.CedulaForza((int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value);
                    r.ShowDialog();
                }
                
            }
            catch { }
        }

        private void txtBuscarCedula_TextChanged(object sender, EventArgs e)
        {
            loadCedula();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCedula();

        }
        void loadCedula() {
            string txtLote;
            if (comboBox1.Text == "Todos") { txtLote = "%"; } else { txtLote = comboBox1.Text; }
            dataGridView1.DataSource = DAO.CedulaIdentidad.buscarCedula(txtBuscarCedula.Text, txtLote, obtenerGrupo(), cmbEstado.Text);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadCedula();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string txtLote;
             
                if (comboBox1.Text == "Todos") { txtLote = "%"; } else { txtLote = comboBox1.Text; }
             
                dataGridView1.DataSource = DAO.CedulaIdentidad.buscarCedula(txtBuscarCedula.Text, txtLote, obtenerGrupo(), cmbEstado.Text);

            }
            catch { }
        }

        string obtenerGrupo() {
            string grupo;
            if (comboBox2.Text == "Todos") { grupo = "%"; } else { grupo = comboBox2.Text; }
            return grupo;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CambiarEstadoCedula c = new CambiarEstadoCedula((int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value, cmbEstado.Text);
            DialogResult res = c.ShowDialog();
            if (res == DialogResult.OK)
            {
                dataGridView1.DataSource = DAO.CedulaIdentidad.mostrarCedula(cmbEstado.Text.ToString());
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            int cedula = (int)dataGridView1.CurrentRow.Cells["ID Cedula"].Value;
            List<Entidades.DetalleProductos> productos = DAO.CedulaIdentidad.ListProductosCedula(cedula);
            List<Entidades.Seccion> secciones = DAO.CedulaIdentidad.ListSeccionesCedula(cedula);

            if (estado.Equals("No Aplicada"))
            {
                DialogResult result = MessageBox.Show("Esta seguro de aplicar esta cedula?", "Aplicar Cedula", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    foreach (Entidades.DetalleProductos d in productos)
                    {
                        DAO.Producto.restarInventario(d.Codigo, d.TotalDosis);
                        DAO.Producto.limpiarCantidadBloqueada(d.Codigo.ToString());
                    }
                    foreach (Entidades.Seccion s in secciones)
                        DAO.Seccion.aumentarPosicion(s);
                    DAO.CedulaIdentidad.cambiarEstadoAplicacion(cedula, true);
                    loadCedula();
                    MessageBox.Show("La cedula de identidad:#" + cedula + " se aplico correctamente");
                }
            }
            else
                MessageBox.Show("La cedula de identidad:#"+cedula+ " ya se ha aplicado");
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
