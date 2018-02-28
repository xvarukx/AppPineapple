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
    public partial class Empleados : Form
    {
        int ancho;

        void esconder() { Width = ancho - 410; }
        void mostrar() { Width = ancho; }

        public Empleados()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
        }

        private void Choferes_Load(object sender, EventArgs e)
        {
            conf.evitarOrdenar(ref dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
          
            resetData();
        }
        void resetData() {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.Empleado.buscarEmpleadoTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.Empleado.buscarEmpleadoTabla("%");
            }
            dataGridView1.CurrentCell= null;

        }
        void llenarDetalles(Entidades.Empleado c) {
            txtEditApellido.Text = c.Apellido;
            txtEditApellido2.Text = c.Apellido2;
            txtEditCedula.Text = c.Celuda;
            txtEditNombre.Text = c.Nombre;
            txtEditTelefono.Text = c.Telefono;
            txtEditPuesto.Text = c.Puesto;
            if (c.FechaContratacion <= dtEditFecha.MinDate) { dtEditFecha.Value = DateTime.Today; }
            else { dtEditFecha.Value = c.FechaContratacion; }

        }

        Entidades.Empleado choferTabla(DataGridView data) {
            return DAO.Empleado.buscarEmpleado((string)data.CurrentRow.Cells["cedula"].Value);
        }


        Entidades.Empleado choferDetalles() {
            Entidades.Empleado c = new Entidades.Empleado();
            c.Apellido = txtEditApellido.Text;
            c.Apellido2 = txtEditApellido2.Text;
            c.Celuda = txtEditCedula.Text;
            c.Nombre = txtEditNombre.Text;
            c.Telefono = txtEditTelefono.Text;
            c.Puesto = txtEditPuesto.Text;
            c.FechaContratacion = dtEditFecha.Value;
            return c;
        }

        Entidades.Empleado choferAgregar()
        {
            Entidades.Empleado c = new Entidades.Empleado();
            c.Apellido = txtAddApellido.Text;
            c.Apellido2 = txtAddApellido2.Text;
            c.Celuda = txtAddCedula.Text;
            c.Nombre = txtAddNombre.Text;
            c.Telefono = txtAddTelefono.Text;
            c.Puesto = txtAddPuesto.Text;
            c.FechaContratacion = dtAddFecha.Value;
            return c;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DAO.Empleado.modificar(choferDetalles());
            resetData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Chofer",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes)
            {
                DAO.Empleado.eliminar(choferDetalles());
                txtEditApellido.Text = "";
                txtEditApellido2.Text = "";
                txtEditCedula.Text = "";
                txtEditNombre.Text = "";
                txtEditTelefono.Text = "";
                txtEditPuesto.Text = "";
                dtEditFecha.Value = DateTime.Today;
                resetData();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.Empleado.insertar(choferAgregar());
                txtAddApellido.Text = "";
                txtAddApellido2.Text = "";
                txtAddCedula.Text = "";
                txtAddNombre.Text = "";
                txtAddTelefono.Text = "";
                txtAddPuesto.Text = "";
                dtAddFecha.Value = DateTime.Today;
                resetData();
            }
            catch
            {
                MessageBox.Show("Ya existe un empleado con esa cedula");
                DAO.Conexion.CloseConnection();
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

        private void cbEditando_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        private void validarNumeros(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

        private void tabAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
