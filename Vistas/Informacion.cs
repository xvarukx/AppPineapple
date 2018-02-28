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
    public partial class Informacion : Form
    {
        Notificaciones n;

        List<Entidades.Notificacion> listaNoti;
        List<Entidades.Notificacion> listaEventos;
        public Informacion()
        {
            InitializeComponent();

            listaNoti = new List<Entidades.Notificacion>();
            listaEventos = new List<Entidades.Notificacion>();
            n = new Notificaciones();
            n.StartPosition = FormStartPosition.Manual;

            // DAO.Notificacion.EnviarCorreosHome();
            cargarTabla();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {

        
        }
        void cargarTabla()
        {
            if (btnEventos.Checked)
            {
               
                dataGridView1.DataSource = DAO.Notificacion.getEventos();
           


            }
            if (btnNotificaciones.Checked) {
                

                dataGridView1.DataSource = DAO.Notificacion.ProductosAgotados();
                foreach (DataGridViewRow r in dataGridView1.Rows) {

                    r.Cells["Causa"].Value = "Cantidad Menor a la Recomendada";

                }
            }


        }

     
    

      
      

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (btnEventos.Checked)
            {

            }
            if (btnNotificaciones.Checked)
            {
              
            }
        }
        private void btnEventos_CheckedChanged(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnNotificaciones_CheckedChanged(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DAO.Notificacion.EnviarCorreos();
        }

        private void btnBorrarNoti_Click(object sender, EventArgs e)
        {

        }
    }
}
