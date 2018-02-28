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
    public partial class SelectorSecciones : Form
    {
        string idLote, idBloque, idSeccion, grupo;
        string paquete;
        int posicion;

        int NO_ERROR = 0;
        int ERROR_01 = 1;
        int ERROR_02 = 2;
        int ERROR_03 = 3;
        int ERROR_04 = 4;

        List<Entidades.Seccion> listaB;

        public SelectorSecciones()
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
            idLote = txtLoteA.Text;
            idBloque = txtBloqueA.Text;
            idSeccion = txtSeccionA.Text;
            grupo = comboBox1.Text;
            if (grupo == "Todos") { grupo = "%"; }
            if (idLote == "") { idLote = "%"; }
            if (idBloque == "") { idBloque = "%"; }
            if (idSeccion == "") { idSeccion = "%"; }

            DataTable dtDatos = DAO.Seccion.buscarSeccionGrupo2(grupo);
            DataColumn dc = new DataColumn("Seleccion", typeof(bool));
            dtDatos.Columns.Add(dc);
            dataGridView1.DataSource = dtDatos;
            dataGridView1.Columns["Seleccion"].ReadOnly = false;
            dataGridView1.Columns["Lote"].ReadOnly = true;
            dataGridView1.Columns["Bloque"].ReadOnly = true;
            dataGridView1.Columns["Seccion"].ReadOnly = true;
            dataGridView1.Columns["Grupo"].ReadOnly = true;
            dataGridView1.Columns["Paquete"].ReadOnly = true;
            dataGridView1.Columns["Posicion"].ReadOnly = true;
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView2.Rows[j].Cells[0].Value.ToString()
                            && dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView2.Rows[j].Cells[1].Value.ToString()
                            && dataGridView1.Rows[i].Cells[2].Value.ToString() == dataGridView2.Rows[j].Cells[2].Value.ToString())
                        { dataGridView1.Rows.RemoveAt(i); i--; break; }
                    }
                }
            }

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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Seleccion"].Value = checkBox1.Checked;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            agregar();
            cargarSeccionA();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remover();
            cargarSeccionA();
        }

        private void txtBloqueA_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        private void txtSeccionA_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
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
        List<Entidades.Seccion> leerB()
        { List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Entidades.Seccion s = new Entidades.Seccion();
                s.IdLote = dataGridView2.Rows[i].Cells[0].Value.ToString();
                s.IdBloque = dataGridView2.Rows[i].Cells[1].Value.ToString();
                s.IdSeccion = dataGridView2.Rows[i].Cells[2].Value.ToString();
                s.GrupoForza = dataGridView2.Rows[i].Cells[3].Value.ToString();
                s.Paquete = dataGridView2.Rows[i].Cells[4].Value.ToString();
                s.Posicion = (int)dataGridView2.Rows[i].Cells[5].Value;

                lista.Add(s);
            }
                return lista;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells[6].Value = checkBox2.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Entidades.Seccion> lista = DAO.Seccion.buscarSeccion(grupo);
            try
            {
                CrearCedulaIdentidad m = new CrearCedulaIdentidad(DAO.DetalleAplicacion.getDetallePaquetePosicion(lista[0].Paquete, lista[0].Posicion + 1), lista, false, this);

                m.ShowDialog();

            }
            catch { }
        }

        private void SelectorSecciones_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i].Paquete != paquete) { return ERROR_02; }
                    if (lista[i].Posicion != posicion) { return ERROR_04; }
                }
            }
            return NO_ERROR;
        }
        void agregar()
        {
            List<Entidades.Seccion> lista = leerA();
            if (lista.Count == 0)
            { MessageBox.Show("Debe seleccionar alguna seccion"); return; }
            if (dataGridView2.Rows.Count > 0)
            {
                paquete = dataGridView2.Rows[0].Cells[4].Value.ToString();
                posicion = (int)dataGridView2.Rows[0].Cells[5].Value;
            }
            else
            {
                paquete = lista[0].Paquete;
                posicion = lista[0].Posicion;
            }
            int ERROR = buscarErrores(lista);
            if (ERROR == ERROR_01)
            { MessageBox.Show("Las secciones seleccionadas presentan distintos paquetes entre ellas"); return; }
            if (ERROR == ERROR_02)
            { MessageBox.Show("Las secciones seleccionadas presentan distintos paquetes a las ya incluidas"); return; }
            if (ERROR == ERROR_03)
            { MessageBox.Show("Las secciones seleccionadas presentan distintas posiciones entre ellas"); return; }
            if (ERROR == ERROR_04)
            { MessageBox.Show("Las secciones seleccionadas presentan distintas posiciones a las ya incluidas"); return; }
            if (ERROR == NO_ERROR)
            {
                foreach (Entidades.Seccion s in lista)
                {
                    dataGridView2.Rows.Add(s.IdLote, s.IdBloque, s.IdSeccion, s.GrupoForza, s.Paquete, s.Posicion, false);
                }
            }
        }
        void remover()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (getValue(dataGridView2.Rows[i]))
                {
                    dataGridView2.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
