using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Tulpep.NotificationWindow;

namespace Vistas
{
    public partial class MantenimientoAplicacion : Form
    {

        string opcion;
        public MantenimientoAplicacion()
        {
            InitializeComponent();
            actualizarTabla();

        }

        private void MantenimientoAplicacion_Load(object sender, EventArgs e)
        {
            conf.evitarOrdenar(ref dataGridView1);

        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            actualizarTabla();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {


        }
        void actualizarTabla() {
            dataGridView1.DataSource = Aplicacion.buscarTable("%");

        }



        void llenarFormulario() {
            try
            {
                txtEditNombre.Text = (string)dataGridView1.CurrentRow.Cells["Nombre"].Value;
             

            }
            catch {
                MessageBox.Show("No hay datos seleccionados");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lote = "1526";
            string aplicacion1 = "Folear";

            /*
            PopupNotifier popup = new PopupNotifier();
            popup.BorderColor = Color.Gray;
            popup.BodyColor = Color.Honeydew;
            popup.HeaderColor = Color.Green;
            popup.TitleText = "Recordatorio de Aplicacion";
            popup.ContentText = "Lote "+ lote +" se debe aplicar la aplicacion: "+aplicacion1 +" en 15 dias";

            popup.Click += new EventHandler(open);
            popup.Popup();
            */
        }

        void open(object sender, EventArgs e) {

            Mapa l = new Mapa();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) { return; }
                Entidades.Aplicacion aplicacion = new Entidades.Aplicacion();
                aplicacion.IdAplicacion = (int)dataGridView1.CurrentRow.Cells["ID Aplicacion"].Value;
                aplicacion.Nombre = (string)dataGridView1.CurrentRow.Cells["Nombre"].Value;
                //aplicacion.NombreComercial = (string)dataGridView1.CurrentRow.Cells["nombreComercial"].Value;
                //PaqueteAplicacion.AplicacionForm aplicacionForm = new PaqueteAplicacion.AplicacionForm(aplicacion);
                //   aplicacionForm.ShowDialog();
            }
            catch { }

        }

        private void txtBuscarAplicacion_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DAO.Aplicacion.insertarAplicacion(new Entidades.Aplicacion()
            {
                Nombre = txtNombreAdd.Text
              

            });
            actualizarTabla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAO.Aplicacion.modificarAplicacion(new Entidades.Aplicacion()
            {
                IdAplicacion = (int)dataGridView1.CurrentRow.Cells["idAplicacion"].Value,
                Nombre = txtEditNombre.Text
              

                //Tiempo = (int)numTiempo.Value
            });
            actualizarTabla();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DAO.Aplicacion.buscarTable(txtBuscar.Text);
            }
            catch { }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            llenarFormulario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Aplicacion a = new Entidades.Aplicacion();
            
            a.IdAplicacion = (int)dataGridView1.CurrentRow.Cells["idAplicacion"].Value;
            a.Nombre = txtEditNombre.Text;

            if (MessageBox.Show("¿Desea eliminar este componente de forma permanente?", "Eliminar Aplicacion",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
                if (!DAO.Aplicacion.buscarAplicacionEtapa(a)) {

                    DAO.Aplicacion.eliminar(a);
                    MessageBox.Show("Eliminado correctamente", "Eliminar Aplicacion");

                } else {

                    MessageBox.Show("Esta aplicacion esta agregada en alguna etapa", "Eliminar Aplicacion");
                }
              

                    //Tiempo = (int)numTiempo.Value
                
            }
            actualizarTabla();
        }
    } 
    }

