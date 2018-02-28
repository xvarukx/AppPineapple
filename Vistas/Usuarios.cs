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
    public partial class Usuarios : Form
    {
        int ancho;

        void esconder() { Width = ancho - 410; }
        void mostrar() { Width = ancho; }

        public Usuarios()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            resetData();
            conf.evitarOrdenar(ref dataGridView1);
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnDetails_Click(sender, e);
        }
        void resetData()
        {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.Usuario.buscarUsuarioTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.Usuario.buscarUsuarioTabla(txtBuscar.Text);
            }
            dataGridView1.ClearSelection();

        }

        void llenarDetalles(Entidades.Usuario u) {
            txtEditId.Text = u.IdUsuario;
            txtEditPass.Text = u.Pass;
        }

        Entidades.Usuario usuarioTabla(DataGridView data)
        {
            return DAO.Usuario.buscarUsuario((string)data.CurrentRow.Cells["ID Usuario"].Value);
        }

        Entidades.Usuario usuarioDetalles() {
            Entidades.Usuario u = new Entidades.Usuario();
            u.IdUsuario = txtEditId.Text;
            u.Pass = txtEditPass.Text;
            return u;
        }

        Entidades.Usuario usuarioAgregar()
        {
            Entidades.Usuario u = new Entidades.Usuario();
            u.IdUsuario = txtAddId.Text;
            u.Tipo = comboBox1.Text;
            u.Pass = txtAddPass.Text;
            return u;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Usuario",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                DAO.Usuario.eliminar(usuarioDetalles());
                txtEditId.Text = "";
                txtEditPass.Text = "";
                resetData();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.Usuario.modificar(usuarioDetalles());
            resetData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.Usuario.insertar(usuarioAgregar());
                txtAddId.Text = "";
                txtAddPass.Text = "";
                resetData();
            }
            catch {
                MessageBox.Show("Ya existe un usuario con ese id");
                DAO.Conexion.CloseConnection();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            resetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(usuarioTabla(dataGridView1));
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
