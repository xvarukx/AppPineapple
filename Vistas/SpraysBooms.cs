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
    public partial class SpraysBooms : Form
    {
        int ancho;

        void esconder() { Width = ancho - 400; }
        void mostrar() { Width = ancho; }

        public SpraysBooms()
        {
            InitializeComponent();
            ancho = Width;
        }

        private void SpraysBooms_Load(object sender, EventArgs e)
        {
            resetData();
            conf.evitarOrdenar(ref dataGridView1);
            esconder();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnDetails_Click(sender, e);
        }
        void resetData() {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.SprayBoom.buscarSprayBoomTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.SprayBoom.buscarSprayBoomTabla("%");
            }
            dataGridView1.ClearSelection();
        }

        Entidades.SprayBoom SprayBoomAgregar() {
            Entidades.SprayBoom s = new Entidades.SprayBoom();
            s.Boquilla = txtAddBoquilla.Text;
            s.Capacidad = Double.Parse(txtAddCapacidad.Text);
            s.IdSprayBoom = txtAddCodigo.Text;
            s.Km = txtAddKm.Text;
            s.Marcha = txtAddMarcha.Text;
            s.Metodo= txtAddMetodo.Text;
            s.Psi = Double.Parse(txtAddPSI.Text);
            s.Rpm = Double.Parse(txtAddRPM.Text);
            return s;
        }

        Entidades.SprayBoom SprayBoomDetalles() {
            Entidades.SprayBoom s = new Entidades.SprayBoom();
            s.Boquilla = txtEditBoquilla.Text;
            s.Capacidad = Double.Parse(txtEditCapacidad.Text);
            s.IdSprayBoom = txtEditCodigo.Text;
            s.Km = txtEditKm.Text;
            s.Marcha = txtEditMarcha.Text;
            s.Metodo = txtEditMetodo.Text;
            s.Psi = Double.Parse(txtEditPsi.Text);
            s.Rpm = Double.Parse(txtEditRpm.Text);
            return s;
        }

        Entidades.SprayBoom SprayBoomTabla(DataGridView data) {
            return DAO.SprayBoom.buscarSprayBoom((string)data.CurrentRow.Cells["ID Spray"].Value);
        }

        void llenarDetalles(Entidades.SprayBoom s) {

            txtEditBoquilla.Text = s.Boquilla;
            txtEditCapacidad.Text = s.Capacidad.ToString();
            txtEditCodigo.Text = s.IdSprayBoom;
            txtEditKm.Text = s.Km;
            txtEditMarcha.Text = s.Marcha;
            txtEditMetodo.Text = s.Metodo;
            txtEditPsi.Text = s.Psi.ToString();
            txtEditRpm.Text = s.Rpm.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar SprayBoom",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
              == DialogResult.Yes)
            {
                DAO.SprayBoom.eliminar(SprayBoomDetalles());
                resetData();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.SprayBoom.modificar(SprayBoomDetalles());
            resetData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtAddCodigo.Text.Equals(""))
                    DAO.SprayBoom.insertar(SprayBoomAgregar());
                resetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"Ya existe un SprayBoom con ese codigo");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            resetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(SprayBoomTabla(dataGridView1));
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            esconder();
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

        private void tabAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
