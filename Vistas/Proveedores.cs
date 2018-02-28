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
    public partial class Proveedores : Form
    {
        int ancho;

        void esconder() { Width = ancho - 310; }
        void mostrar() { Width = ancho; }

        public Proveedores()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            resetData();
            conf.evitarOrdenar(ref dataGridView1);
        }

        void resetData()
        {
            if (txtBuscar.TextLength != 0)
            {
                dataGridView1.DataSource = DAO.Proveedor.buscarProveedorTabla(txtBuscar.Text);
            }
            else
            {
                dataGridView1.DataSource = DAO.Proveedor.buscarProveedorTabla("%");
            }
            dataGridView1.ClearSelection();

        }

        void llenarDetalles(Entidades.Proveedor p)
        {
            txtEditCodigo.Text = p.IdProvedor;
            txtEditCorreo.Text = p.Correo;
            txtEditDescripcion.Text = p.Descripcion;
            txtEditDireccion.Text = p.Direccion;
            txtEditNombre.Text = p.Nombre;
            txtEditTelefono.Text = p.Telefono;
        }

        Entidades.Proveedor proveedorTabla(DataGridView data) {
            return DAO.Proveedor.buscarProveedor((string)data.CurrentRow.Cells["ID Proveedor"].Value);
        }

        Entidades.Proveedor proveedorAgregar() {
            Entidades.Proveedor p = new Entidades.Proveedor();
            p.Correo = txtAddCorreo.Text;
            p.Descripcion = txtAddDescripcion.Text;
            p.Direccion = txtAddDireccion.Text;
            p.IdProvedor = txtAddCodigo.Text;
            p.Nombre = txtAddNombre.Text;
            p.Telefono = txtAddTelefono.Text;
            return p;
        }

        Entidades.Proveedor proveedorDetalles()
        {
            Entidades.Proveedor p = new Entidades.Proveedor();
            p.Correo = txtEditCorreo.Text;
            p.Descripcion = txtEditDescripcion.Text;
            p.Direccion = txtEditDireccion.Text;
            p.IdProvedor = txtEditCodigo.Text;
            p.Nombre = txtEditNombre.Text;
            p.Telefono = txtEditTelefono.Text;
            return p;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if(!txtAddCodigo.Text.Equals(""))
                       DAO.Proveedor.insertar(proveedorAgregar());
                txtAddCodigo.Text = "";
                txtAddCorreo.Text = "";
                txtAddDescripcion.Text = "";
                txtAddDireccion.Text = "";
                txtAddNombre.Text = "";
                txtAddTelefono.Text = "";
                resetData();
            }
            catch
            {
                MessageBox.Show("Ya existe un Proveedor con ese codigo");
                DAO.Conexion.CloseConnection();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Proveedor",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
           == DialogResult.Yes)
            {
                DAO.Proveedor.eliminar(proveedorDetalles());
                resetData();
            }
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.Proveedor.modificar(proveedorDetalles());
            resetData();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            resetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(proveedorTabla(dataGridView1));
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

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Aplicacion",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                {
                    DAO.Proveedor.eliminar(proveedorDetalles());
                    resetData();
                }
            
        }
    }
}
