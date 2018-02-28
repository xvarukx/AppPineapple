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
    public partial class Vehiculos : Form
    {
        int ancho;

        void esconder() { Width = ancho - 360; }
        void mostrar() { Width = ancho; }

        public Vehiculos()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            resetData();
            conf.evitarOrdenar(ref dataGridView1);
        }

        Entidades.Tractor tractorAgregar()
        {
            Entidades.Tractor t = new Entidades.Tractor();
            t.IdTractor = txtAddCodigo.Text;
            t.Marca = txtAddMarca.Text;
            t.Descripcion = txtAddDescripcion.Text;
            return t;
        }

        Entidades.Tractor tractorDetalles() {
            Entidades.Tractor t = new Entidades.Tractor();
            t.IdTractor = txtEditCodigo.Text;
            t.Marca = txtEditMarca.Text;
            t.Descripcion = txtEditDescripcion.Text;
            return t;
        }

        Entidades.Tractor tractorTabla(DataGridView data) {
            return DAO.Tractor.buscarTractor((string)data.CurrentRow.Cells["ID Tractor"].Value);
        }

        void llenarDetalles(Entidades.Tractor t) {
            txtEditCodigo.Text = t.IdTractor;
            txtEditDescripcion.Text = t.Descripcion;
            txtEditMarca.Text = t.Marca;
        } 

        void resetData()
        {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.Tractor.buscarTractorTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.Tractor.buscarTractorTabla("%");
            }
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(tractorTabla(dataGridView1));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Tractor",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
                {
                    DAO.Tractor.eliminar(tractorDetalles());
                txtEditCodigo.Text = "";
                txtEditDescripcion.Text = "";
                txtEditMarca.Text = "";
                resetData();
                }
                    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.Tractor.modificar(tractorDetalles());
            resetData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtAddCodigo.Text.Equals(""))
                    DAO.Tractor.insertar(tractorAgregar());
                txtAddCodigo.Text = "";
                txtAddMarca.Text = "";
                txtAddDescripcion.Text = "";
                resetData();
            }
            catch
            {
                MessageBox.Show("Ya existe un vehiculo con ese codigo");
                DAO.Conexion.CloseConnection();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            mostrar();
            tabControl1.SelectTab("tabDetalles");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mostrar();
            tabControl1.SelectTab("tabAgregar");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            esconder();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnDetails_Click(sender, e);
        }
    }
}
