using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Vistas
{
    public partial class ProductosAplicacion : Form
    {

        Entidades.PaqueteProducto paquete;
        string etapa;
        public ProductosAplicacion(Entidades.Aplicacion aplicacion,string etapa)
        {
            InitializeComponent();
            this.etapa = etapa;
            llenarFormulario(aplicacion);
        }

        private void ProductosAplicacion_Load(object sender, EventArgs e)
        {
            resetData();
            dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductos(int.Parse(txtAplicacion.Text),etapa);
            dataGridView1.ReadOnly = true;
            dataInsect.ReadOnly = true;
         //   dataPest.ReadOnly = true;
         //   dataPlag.ReadOnly = true;
            dataHerb.ReadOnly = true;
            dataTodos.ReadOnly = true;

            dataGridView1.AllowUserToAddRows = false;
            dataInsect.AllowUserToAddRows = false;
         //   dataPest.AllowUserToAddRows = false;
          //  dataPlag.AllowUserToAddRows = false;
            dataHerb.AllowUserToAddRows = false;
            dataTodos.AllowUserToAddRows = false;
            
           
        }
        void llenarFormulario(Entidades.Aplicacion a)
        {
            txtAplicacion.Text = a.IdAplicacion.ToString();
            txtNombre.Text = a.Nombre;
            txtNombreC.Text = a.NombreComercial;
            //numTiempo.Value = a.Tiempo;
           // numPosicion.Value = a.Posicion;

        }

        void limpiarSeleccion()
        {
            dataInsect.ClearSelection();
           // dataPest.ClearSelection();
          //  dataPlag.ClearSelection();
            dataHerb.ClearSelection();
            dataTodos.ClearSelection();
            dataGridView1.ClearSelection();
        }

        void resetData() {
            dataTodos.DataSource = DAO.Producto.mostrarProductos("%", "%");
            dataHerb.DataSource = DAO.Producto.mostrarProductos("%", "Herbicida");
            dataInsect.DataSource = DAO.Producto.mostrarProductos("%", "Insecticida");
           // dataPest.DataSource = DAO.Producto.mostrarProductos("%", "Pesticida");
          //  dataPlag.DataSource = DAO.Producto.mostrarProductos("%", "Plaguicida");
            limpiarSeleccion();
        }
        bool comprobarRepetido() {
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells["idProducto"].Value.ToString().Equals(paquete.IdProducto)) {
                    return true;
                }
            }
            return false;
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            limpiarSeleccion();
        }

        private void btnMeter_Click(object sender, EventArgs e)
        {
            if (!paquete.Equals(null) && !comprobarRepetido())
            {
                DAO.PaqueteProducto.insertarAplicacion(paquete);
                dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductos(int.Parse(txtAplicacion.Text),etapa);
            }
 
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                DAO.PaqueteProducto.eliminarAplicacion(new Entidades.PaqueteProducto()
                {
                    IdEtapa = etapa,
                    IdAplicacion = int.Parse(txtAplicacion.Text),
                    IdProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString()

                });
                dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductos(int.Parse(txtAplicacion.Text),etapa);
            }

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
                    Unidad = (string)data.CurrentRow.Cells["unidad"].Value
                };
            }
            catch { }
        }
        private void dataHerb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crearPaquete(ref dataHerb);
        }
        private void dataPlag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     //       crearPaquete(ref dataPlag);
        }

        private void dataPest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        //    crearPaquete(ref dataPest);
        }

        private void dataInsect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crearPaquete(ref dataInsect);
        }

        private void btnModificarDosis_Click(object sender, EventArgs e)
        {
            
            DAO.PaqueteProducto.modificarDosis(new Entidades.PaqueteProducto()
            {
                IdAplicacion = int.Parse(txtAplicacion.Text),
                IdProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString(),
                Dosis = int.Parse(textBox1.Text)
                
            });

            dataGridView1.DataSource = DAO.PaqueteProducto.mostrarProductos(int.Parse(txtAplicacion.Text),etapa);
            textBox1.Text = "";
            resetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            textBox1.Text = dataGridView1.CurrentRow.Cells["dosis"].Value.ToString();
   
        }

        private void dataTodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            crearPaquete(ref dataTodos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength != 0)
            {
                dataTodos.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "%");
                dataHerb.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Herbicida");
                dataInsect.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Insecticida");
           //     dataPest.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Pesticida");
       //         dataPlag.DataSource = DAO.Producto.mostrarProductos(txtBuscar.Text, "Plaguicida");
                limpiarSeleccion();
            }
            else
            {
                resetData();
            }
        }

        private void dataHerb_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataHerb);
        }

        private void dataPlag_SelectionChanged(object sender, EventArgs e)
        {
        //    crearPaquete(ref dataPlag);
        }

        private void dataPest_SelectionChanged(object sender, EventArgs e)
        {
            //crearPaquete(ref dataPest);
        }

        private void dataInsect_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataInsect);
        }

        private void dataTodos_SelectionChanged(object sender, EventArgs e)
        {
            crearPaquete(ref dataTodos);
        }

        private void dataTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}