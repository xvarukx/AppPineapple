using MySql.Data.MySqlClient;
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
    public partial class Inventario : Form
    {
        int ancho;

        void esconder() { Width = ancho - 520; }
        void mostrar() { Width = ancho; }

        public Inventario()
        {
            InitializeComponent();
            ancho = Width;
            esconder();
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSupply_Click(sender, e);
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            resetData();
            conf.evitarOrdenar(ref dataFert);
            conf.evitarOrdenar(ref dataFungi);
            conf.evitarOrdenar(ref dataNema);
            conf.evitarOrdenar(ref dataInsect);
            conf.evitarOrdenar(ref dataHerb);
            conf.evitarOrdenar(ref dataTodos);
            conf.evitarOrdenar(ref dataOtros);
        }

        void resetData()
        {
            dataTodos.DataSource = DAO.Producto.buscarProductoTabla("%", "%");
            dataHerb.DataSource = DAO.Producto.buscarProductoTabla("%", "Herbicida");
            dataInsect.DataSource = DAO.Producto.buscarProductoTabla("%", "Insecticida");
            dataFert.DataSource = DAO.Producto.buscarProductoTabla("%", "Fertilizante");
            dataFungi.DataSource = DAO.Producto.buscarProductoTabla("%", "Fungicida");
            dataOtros.DataSource = DAO.Producto.buscarProductoTabla("%", "Otros");
            dataNema.DataSource = DAO.Producto.buscarProductoTabla("%", "Nematicida");
        }

        void limpiarSeleccion() {
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
        }

        Entidades.Producto getProductoTabla(DataGridView data) {
            try
            {
                return DAO.Producto.buscarProducto((string)data.CurrentRow.Cells["Codigo"].Value);
            }
            catch
            {
                return null;
            }
            }

        Entidades.Producto productoDetalles()
        {
            Entidades.Producto p = new Entidades.Producto();
            p.Cantidad = Double.Parse(txtEditCantidad.Text);
            p.Costo = Double.Parse(txtEditCosto.Text);
            p.IdProducto = txtEditCodigo.Text;
            p.IngredienteActivo = txtEditIngrediente.Text;
            p.Maximo = Double.Parse(txtEditMaxima.Text);
            p.Minimo = Double.Parse(txtEditMinima.Text);
            p.Nombre = txtEditNombre.Text;
            p.Tipo = txtEditTipo.Text;
            p.Unidad = txtEditUnidad.Text;
            p.Dias = int.Parse(txtEditDias.Text);
            p.NumRegistro = txtNumRegistro.Text;
            p.PeriodoReingreso = (int)editHorasReingreso.Value;
            return p;
        }
        Entidades.Producto productoAgregar()
        {
            Entidades.Producto p = new Entidades.Producto();
            p.Cantidad = Double.Parse(txtAddCantidad.Text);
            p.Costo = Double.Parse(txtAddCosto.Text);
            p.IdProducto = txtAddCodigo.Text;
            p.IngredienteActivo = txtAddIngrediente.Text;
            p.Maximo = Double.Parse(txtAddMaximo.Text);
            p.Minimo = Double.Parse(txtAddMinimo.Text);
            p.Nombre = txtAddNombre.Text;
            p.Tipo = txtAddTipo.Text;
            p.Unidad = txtAddUnidad.Text;
            p.Dias = int.Parse(txtAddDias.Text);
            p.NumRegistro = txtAddNumRegistro.Text;
            p.PeriodoReingreso = (int)addHorasReingreso.Value;
            return p;
        }

        void llenarDetalles(Entidades.Producto p) {

            txtEditCodigo.Text = p.IdProducto;
            txtEditCosto.Text = p.Costo.ToString();
            txtEditCantidad.Text = p.Cantidad.ToString();
            txtEditIngrediente.Text = p.IngredienteActivo;
            txtEditMaxima.Text = p.Maximo.ToString();
            txtEditMinima.Text = p.Minimo.ToString();
            txtEditNombre.Text = p.Nombre;
            txtEditTipo.Text = p.Tipo;
            txtEditUnidad.Text = p.Unidad;
            txtEditDias.Text = p.Dias.ToString();
            txtNumRegistro.Text = p.NumRegistro;
            txtCodigo.Text = p.IdProducto;
            txtDescripcion.Text = p.Nombre;
            editHorasReingreso.Value = (decimal) p.PeriodoReingreso;

        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength != 0)
            {
                dataTodos.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "%");
                dataHerb.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Herbicida");
                dataInsect.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Insecticida");
                dataFert.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Pesticida");
                dataFungi.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Plaguicida");
                dataOtros.DataSource = DAO.Producto.buscarProductoTabla(txtBuscar.Text, "Otros");
            }
            else {
                resetData();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO.Producto.modificar(productoDetalles());
                resetData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe poner solo numeros en los espacios que requieren una cantidad");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DAO.Producto.eliminar(productoDetalles());
            txtEditCodigo.Text = "";
            txtEditCosto.Text = "";
            txtEditCantidad.Text = "";
            txtEditIngrediente.Text = "";
            txtEditMaxima.Text = "";
            txtEditMinima.Text = "";
            txtEditNombre.Text = "";
            txtEditTipo.Text = "";
            txtEditUnidad.Text = "";
            txtEditDias.Text = "";
            txtNumRegistro.Text = "";
            resetData();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtAddCodigo.Text.Equals(""))
                    DAO.Producto.insertar(productoAgregar());
                txtAddCodigo.Text = "";
                txtAddCosto.Text = "0";
                txtAddCantidad.Text = "0";
                txtAddIngrediente.Text = "";
                txtAddMaximo.Text = "0";
                txtAddMinimo.Text = "0";
                txtAddNombre.Text = "";
                txtAddTipo.Text = "";
                txtAddUnidad.Text = "";
                txtAddDias.Text = "0";
                txtAddNumRegistro.Text = "";
                resetData();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe un producto con ese codigo");
            }
            catch (FormatException) {
                MessageBox.Show("Debe poner solo numeros en los espacios que requieren una cantidad");
            }
        }

       
        private void btnDetails_Click(object sender, EventArgs e)
        {
            mostrar();
            tabControl2.SelectTab("tabDetalles");
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            esconder();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("tabAgregar");
            mostrar();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            try
            {
                double u = double.Parse(txtCantidad.Text);
                DAO.Producto.supply(txtCodigo.Text, u);
                txtCantidad.Text = "0";
                resetData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe poner solo numeros en los espacios que requieren una cantidad");
            }
        }

        private void dataTodos_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataTodos));
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataHerb_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataHerb));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataFungi_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataFungi));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataFert_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataFert));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataInsect_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataInsect));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }
        private void dataNema_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataNema));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataOtros.ClearSelection();
        }
        private void dataOtros_SelectionChanged(object sender, EventArgs e)
        {
            llenarDetalles(getProductoTabla(dataOtros));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataInsect.ClearSelection();
            dataNema.ClearSelection();
        }
        private void dataTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataTodos));
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataHerb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataHerb));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataFungi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataFungi));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataFert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataFert));
            dataTodos.ClearSelection();
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }

        private void dataInsect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataInsect));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
        }
        private void dataNema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataNema));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataOtros.ClearSelection();
            dataInsect.ClearSelection();
        }

        private void dataOtros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarDetalles(getProductoTabla(dataOtros));
            dataTodos.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataInsect.ClearSelection();
        }

        private void validarNumerosAgregar(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnAgregar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnAgregar.Enabled = false;
            }

        }
        private void validarNumerosEditar(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnModificar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnModificar.Enabled = false;
            }
        }

        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnSupply.Enabled = true;
                
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnSupply.Enabled = false;
               
            }
        }

        private void tabAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
