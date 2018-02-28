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
    public partial class VerGrupo : Form
    {
        DataTable dt;

        Entidades.GrupoForza grupo;
        List<Entidades.Seccion> secciones = new List<Entidades.Seccion> ();
     
        public VerGrupo(Entidades.GrupoForza grupo)


        {
            InitializeComponent();
            this.grupo = grupo;
            dt = DAO.Seccion.buscarSeccionTabla(grupo.IdGrupo, grupo.Lote);
            dataGridView1.DataSource = dt;
            lblLote.Text = grupo.Lote;
            lblNombre.Text = grupo.IdGrupo;
        }
        void cargarLista() {
            secciones.Clear();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                Entidades.Seccion s = new Entidades.Seccion();
                s.IdSeccion  = row.Cells["idSeccion"].Value.ToString();
                s.FechaInicial = Convert.ToDateTime(row.Cells["fechaInicial"].Value.ToString());
                s.IdBloque = row.Cells["idBloque"].Value.ToString();
                s.IdLote = lblLote.Text;
                s.IdSeccion = row.Cells["idSeccion"].Value.ToString();

                secciones.Add(s);
            }

                }
        private void VerGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VerSecciones v = new VerSecciones(lblLote.Text);
            DialogResult res = v.ShowDialog();
            try
            {
                if (res == DialogResult.OK)
                {
                    if (buscarCoincidencia(v.seccion))
                    {
                        dt.Rows.Add(v.seccion.IdSeccion, v.seccion.IdBloque, v.seccion.Posicion,v.seccion.FechaInicial, v.seccion.GrupoForza);
                        dataGridView1.DataSource = dt;
                       // DAO.Seccion.agregarGrupo(DAO.Seccion.buscarSeccion(v.seccion.IdSeccion, lblLote.Text, v.seccion.IdBloque), lblNombre.Text);
                    }
                }
            }
            catch { }
        }
        bool buscarCoincidencia(Entidades.Seccion s)
        {
            try {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {

                    if (row.Cells["idSeccion"].Value.Equals(s.IdSeccion) && row.Cells["idBloque"].Value.Equals(s.IdBloque))
                    {
                        MessageBox.Show("La seccion ya se encuentra en el grupo");
                        return false;
                    }

                } }
            catch{ }
            return true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Seccion s = new Entidades.Seccion();
                s.IdBloque = dataGridView1.CurrentRow.Cells["idBloque"].Value.ToString();
                s.IdSeccion = dataGridView1.CurrentRow.Cells["idSeccion"].Value.ToString();
                s.IdLote = lblLote.Text;
               // DAO.Seccion.limpiarGrupo(s);
                dt.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch { }
        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            bool preguntar = true;

            foreach (Entidades.Seccion s in seccionesEliminadas)
            {
                DAO.Seccion.limpiarGrupo(s);
            }
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (!{
                    MessageBox.Show("El paquete no cuenta con aplicaciones de forza");
                    preguntar = false;
                    break;
                }
            }

            if (preguntar) {

                MessageBox.Show("Guardado correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
        */
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           // DAO.GrupoForza.eliminar(grupo);
            
        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            cargarLista();
               NombreGrupoForza n = new NombreGrupoForza(grupo, secciones);
            n.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}