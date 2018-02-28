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
    public partial class AplicarGrupo : Form
    {
        string idLote, idBloque, idSeccion, grupo;
        string paquete;
        int posicion;

        int NO_ERROR = 0;
        int ERROR_01 = 1;
        int ERROR_02 = 2;
        int ERROR_03 = 3;
        int ERROR_04 = 4;
        List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
        List<Entidades.Seccion> listaB;

        public AplicarGrupo()
        {
            InitializeComponent();
            cargarComboGrupos();
            cargarSeccionA();
            listaB = new List<Entidades.Seccion>();
        }

        void cargarComboGrupos()
        {
            //comboBox1.Items.Add("Todos");
            foreach (string s in DAO.GrupoForza.listaId(false)) { comboBox1.Items.Add(s); }
            // comboBox1.Text = "Todos";
        }
        void cargarSeccionA()
        {
            grupo = comboBox1.Text;
            if (grupo == "Todos") { grupo = "%"; }
            if (idLote == "") { idLote = "%"; }
            if (idBloque == "") { idBloque = "%"; }
            if (idSeccion == "") { idSeccion = "%"; }

            DataTable dtDatos = DAO.Seccion.buscarSeccionGrupo2(grupo);
            dataGridView1.DataSource = dtDatos;
           
            dataGridView1.Columns["Lote"].ReadOnly = true;
            dataGridView1.Columns["Bloque"].ReadOnly = true;
            dataGridView1.Columns["Seccion"].ReadOnly = true;
            dataGridView1.Columns["Grupo"].ReadOnly = true;
            dataGridView1.Columns["Paquete"].ReadOnly = true;
            dataGridView1.Columns["Posicion"].ReadOnly = true;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSeccionA();

        }

        private void txtLoteA_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            cargarSeccionA();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        private void txtBloqueA_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        private void AplicarGrupo_Load(object sender, EventArgs e)
        {

        }
        int buscarErrores(List<Entidades.Seccion> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i].Paquete != lista[j].Paquete) { return ERROR_01; }
                    if (lista[i].Posicion != lista[j].Posicion) { return ERROR_03; }
                }
            }
        
            
            return NO_ERROR;
        }
        private void txtSeccionA_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Entidades.Seccion> lista = DAO.Seccion.buscarSeccion(grupo);
            int ERROR = buscarErrores(lista);
            if (ERROR == ERROR_01)
            { MessageBox.Show("Las secciones seleccionadas presentan distintos paquetes entre ellas"); return; }
            if (ERROR == ERROR_02)
            { MessageBox.Show("Las secciones seleccionadas presentan distintos paquetes a las ya incluidas"); return; }
            if (ERROR == ERROR_03)
            { MessageBox.Show("Las secciones seleccionadas presentan distintas posiciones entre ellas"); return; }
            if (ERROR == ERROR_04)
            { MessageBox.Show("Las secciones seleccionadas presentan distintas posiciones a las ya incluidas"); return; }

       

            try
            {
                CrearCedulaIdentidad m = new CrearCedulaIdentidad(DAO.DetalleAplicacion.getDetallePaquetePosicion(lista[0].Paquete, lista[0].Posicion + 1), lista, false, this);
          //      dataGridView1.Rows.Clear();
                m.ShowDialog();

            }
            catch { }
        }

        bool getValue(DataGridViewRow row)
        {
            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[6];

            return (bool)checkbox.EditedFormattedValue;
        }
        List<Entidades.Seccion> leerA()
        {
            List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdLote = dataGridView1.Rows[i].Cells["Lote"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["Bloque"].Value.ToString();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["Seccion"].Value.ToString();
                    s.GrupoForza = dataGridView1.Rows[i].Cells["Grupo"].Value.ToString();
                    s.Paquete = dataGridView1.Rows[i].Cells["Paquete"].Value.ToString();
                    s.Posicion = (int)dataGridView1.Rows[i].Cells["Posicion"].Value;

                    lista.Add(s);
                }
            }
            return lista;
        }





        private void button1_Click(object sender, EventArgs e)
        {
        }




    }
}

