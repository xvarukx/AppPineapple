using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.PaqueteAplicacion
{
    public partial class AplicacionForm : Form
    {
        int Alto;
        Entidades.Aplicacion aplicacion;
        Entidades.PaqueteProducto paquete;
        string etapa;
        public AplicacionForm()
        {
            InitializeComponent();
            Alto = Height;
            this.Height -= 485;
        }
        public AplicacionForm(Entidades.Aplicacion aplicacion,string etapa)
        {
            this.aplicacion = aplicacion;
            this.etapa = etapa;
            InitializeComponent();
            llenarFormulario(aplicacion);
            configurarForm();
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            conf.evitarOrdenar(ref dataGridView1);

        }
        void configurarForm()
        {
         
            txtAplicacion.ReadOnly = true;
            txtNombre.ReadOnly = true;
     

            resetData();
            dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductosEtapa(aplicacion.IdAplicacion,etapa);
            dataGridView1.ReadOnly = true;
            dataInsect.ReadOnly = true;
            dataFungi.ReadOnly = true;
            dataFert.ReadOnly = true;
            dataHerb.ReadOnly = true;
            dataTodos.ReadOnly = true;
            dataNema.ReadOnly = true;
            dataOtros.ReadOnly = true;

            dataGridView1.AllowUserToAddRows = false;
            dataInsect.AllowUserToAddRows = false;
            dataFungi.AllowUserToAddRows = false;
            dataFert.AllowUserToAddRows = false;
            dataHerb.AllowUserToAddRows = false;
            dataTodos.AllowUserToAddRows = false;
            dataNema.AllowUserToAddRows = false;
            dataOtros.AllowUserToAddRows = false;
        }
        void llenarFormulario(Entidades.Aplicacion a)
        {
            txtAplicacion.Text = a.IdAplicacion.ToString();
            txtNombre.Text = a.Nombre;
            txtEtapa.Text = etapa;
  
        }
        void limpiarSeleccion()
        {
            dataInsect.ClearSelection();
            dataFungi.ClearSelection();
            dataFert.ClearSelection();
            dataHerb.ClearSelection();
            dataNema.ClearSelection();
            dataOtros.ClearSelection();
            dataTodos.ClearSelection();
            dataGridView1.ClearSelection();
        }
        void resetData()
        {
            dataTodos.DataSource = DAO.Producto.mostrarProductos("%", "%");
            dataHerb.DataSource = DAO.Producto.mostrarProductos("%", "Herbicida");
            dataInsect.DataSource = DAO.Producto.mostrarProductos("%", "Insecticida");
            dataFungi.DataSource = DAO.Producto.mostrarProductos("%", "Fungicida");
            dataFert.DataSource = DAO.Producto.mostrarProductos("%", "Fertilizante");
            dataNema.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Nematicida");
            dataOtros.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Otros");
            limpiarSeleccion();
        }
        bool comprobarRepetido()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idProducto"].Value.ToString().Equals(paquete.IdProducto))
                {
                    return true;
                }
            }
            return false;
        }
        void crearPaquete(ref DataGridView data)
        {
            try
            {
                paquete = new Entidades.PaqueteProducto()
                {
                    IdAplicacion = int.Parse(txtAplicacion.Text),
                    IdProducto = data.CurrentRow.Cells["idProducto"].Value.ToString(),
                    Dosis = 0,
                    IdEtapa = txtEtapa.Text,
                    Unidad = (string)data.CurrentRow.Cells["unidad"].Value
                };
            }
            catch { }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength != 0)
            {
                dataTodos.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "%");
                dataHerb.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Herbicida");
                dataInsect.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Insecticida");
                dataFungi.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Fungicida");
                dataFert.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Fertilizante");
                dataNema.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Nematicida");
                dataOtros.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Otros");
                limpiarSeleccion();
            }
            else
            {
                resetData();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            aplicacion = new Entidades.Aplicacion();
            aplicacion.IdAplicacion = int.Parse(txtAplicacion.Text);
            aplicacion.Nombre = txtNombre.Text;
       

            DAO.Aplicacion.insertarAplicacion(aplicacion);
            Height = Alto;   
            configurarForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!paquete.Equals(null) && !comprobarRepetido())
            {
                DAO.PaqueteProducto.insertarAplicacion(paquete);
                dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductosEtapa(int.Parse(txtAplicacion.Text),etapa);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0];
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                DAO.PaqueteProducto.eliminarAplicacion(new Entidades.PaqueteProducto()
                {
                    IdEtapa = txtEtapa.Text,
                    IdAplicacion = int.Parse(txtAplicacion.Text),
                    IdProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString()

                });
                dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductosEtapa(int.Parse(txtAplicacion.Text),etapa);
            }
        }

        private void dataHerb_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataHerb);
        }

        private void dataFert_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataFert);
        }

        private void dataFungi_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataFungi);
        }

        private void dataInsect_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataInsect);
        }

        private void dataTodos_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataTodos);
        }
        private void dataNema_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataNema);
        }

        private void dataOtros_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataOtros);
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnModificarDosis_Click(sender, e);
            }
        }
        
        private void btnModificarDosis_Click(object sender, EventArgs e)
        {
            DAO.PaqueteProducto.modificarDosis(new Entidades.PaqueteProducto()
            {
                IdAplicacion = int.Parse(txtAplicacion.Text),
                IdProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString(),
                IdEtapa = txtEtapa.Text,
                Dosis = double.Parse(textBox1.Text)

            });

            dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductosEtapa(int.Parse(txtAplicacion.Text),etapa);
            textBox1.Text = "";
            resetData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarSeleccion();
        }

        private void txtAplicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Dosis(H)"].Value.ToString();
            textBox1.SelectAll();
            textBox1.Focus();

        }

        private void dataTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AplicacionForm_Load(object sender, EventArgs e)
        {
            dataTodos.DefaultCellStyle.ForeColor = Color.Black;
            dataHerb.DefaultCellStyle.ForeColor = Color.Black;
            dataInsect.DefaultCellStyle.ForeColor = Color.Black;
            dataFungi.DefaultCellStyle.ForeColor = Color.Black;
            dataFert.DefaultCellStyle.ForeColor = Color.Black;
            dataNema.DefaultCellStyle.ForeColor = Color.Black;
            dataOtros.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }
      
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
           
           
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.Image = Vistas.Properties.Resources.Delete;
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.Font = new Font("Ebrima", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            btnCerrar.Image = Vistas.Properties.Resources.Delete2;

        }
    }
}
