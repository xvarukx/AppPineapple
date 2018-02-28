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
    public partial class Choferes : Form
    {
        int ancho;

        void esconder() { Width = ancho - 410; }
        void mostrar() { Width = ancho; }

        public Choferes()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
        }

        private void Choferes_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            resetData();
        }
        void resetData() {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.Chofer.buscarChoferTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.Chofer.buscarChoferTabla("%");
            }
            dataGridView1.CurrentCell= null;

        }
        void llenarDetalles(Entidades.Chofer c) {
            txtEditApellido.Text = c.Apellido;
            txtEditApellido2.Text = c.Apellido2;
            txtEditCedula.Text = c.Celuda;
            txtEditNombre.Text = c.Nombre;
            txtEditTelefono.Text = c.Telefono;

        }

        Entidades.Chofer choferTabla(DataGridView data) {
            return DAO.Chofer.buscarChofer((string)data.CurrentRow.Cells["cedula"].Value);
        }


        Entidades.Chofer choferDetalles() {
            Entidades.Chofer c = new Entidades.Chofer();
            c.Apellido = txtEditApellido.Text;
            c.Apellido2 = txtEditApellido2.Text;
            c.Celuda = txtEditCedula.Text;
            c.Nombre = txtEditNombre.Text;
            c.Telefono = txtEditTelefono.Text;
            return c;
        }

        Entidades.Chofer choferAgregar()
        {
            Entidades.Chofer c = new Entidades.Chofer();
            c.Apellido = txtAddApellido.Text;
            c.Apellido2 = txtAddApellido2.Text;
            c.Celuda = txtAddCedula.Text;
            c.Nombre = txtAddNombre.Text;
            c.Telefono = txtAddTelefono.Text;
            return c;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DAO.Chofer.modificar(choferDetalles());
            resetData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Chofer",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
                DAO.Chofer.eliminar(choferDetalles());
                txtEditApellido.Text = "";
                txtEditApellido2.Text = "";
                txtEditCedula.Text = "";
                txtEditNombre.Text = "";
                txtEditTelefono.Text = "";
                resetData();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.Chofer.insertar(choferAgregar());
                txtAddApellido.Text = "";
                txtAddApellido2.Text = "";
                txtAddCedula.Text = "";
                txtAddNombre.Text = "";
                txtAddTelefono.Text = "";
                resetData();
            }
            catch
            {
                MessageBox.Show("Ya existe un chofer con esa cedula");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            resetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(choferTabla(dataGridView1));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mostrar();
            tabControl1.SelectTab("tabAgregar");
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            mostrar();
            tabControl1.SelectTab("tabDetalles");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            esconder();
        }
    }
}
