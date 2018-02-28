using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Grupos
{
    public partial class Grupos : Form
    {
        string idLote, idBloque, idSeccion;
        public Grupos()
        {
            InitializeComponent();
            cargarComboGrupos();
            cargarSeccionA();
            cargarSeccionB();
            
        }
        void cargarComboGrupos()
        {
            comboBox1.DataSource = DAO.GrupoForza.listaId(true);
        }
        public void crearGrupo(Entidades.GrupoForza g)
        {
            DAO.GrupoForza.insertarGrupo(g);
            cargarComboGrupos();
        }
        public void editarGrupo(Entidades.GrupoForza g)
        {
            DAO.GrupoForza.actualizarGrupo(g);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            { 
                Entidades.Seccion s = new Entidades.Seccion();
                s.IdSeccion = dataGridView2.Rows[i].Cells["Seccion"].Value.ToString();
                s.IdBloque = dataGridView2.Rows[i].Cells["Bloque"].Value.ToString();
                s.IdLote = dataGridView2.Rows[i].Cells["Lote"].Value.ToString();

                DAO.Seccion.agregarGrupo(s, g);
            }
            cargarComboGrupos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearGrupo cg = new CrearGrupo(this);
            cg.ShowDialog();
        }


        private void txtLoteA_TextChanged(object sender, EventArgs e)
        {
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

        private void txtLoteB_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionB();
        }

        private void txtBloqueB_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionB();
        }

        private void txtSeccionB_TextChanged(object sender, EventArgs e)
        {
            cargarSeccionB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sin Grupo") { return; }
            agregar();
            cargarSeccionA();
            cargarSeccionB();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sin Grupo") { return; }
            quitar();
            cargarSeccionA();
            cargarSeccionB();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cargarSeccionA();
        }

        void cargarSeccionA()
        {
            idLote = txtLoteA.Text;
            idBloque = txtBloqueA.Text;
            idSeccion = txtSeccionA.Text;
            string grupoA = "Sin Grupo";
            if (checkBox1.Checked) { grupoA = "%"; }
            if (idLote == "") { idLote ="%"; }
            if (idBloque == "") { idBloque = "%"; }
            if (idSeccion == "") { idSeccion = "%"; }

            DataTable dtDatos = DAO.Seccion.buscarSeccionGrupo(idLote, idBloque, idSeccion, grupoA);
            DataColumn dc = new DataColumn("Seleccion", typeof(bool));
            dtDatos.Columns.Add(dc);
            dataGridView1.DataSource = dtDatos;
            dataGridView1.Columns["Seleccion"].ReadOnly = false;
            dataGridView1.Columns["Lote"].ReadOnly = true;
            dataGridView1.Columns["Bloque"].ReadOnly = true;
            dataGridView1.Columns["Seccion"].ReadOnly = true;
            dataGridView1.Columns["Grupo"].ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSeccionB();
        }

        void cargarSeccionB()
        {
            idLote = txtLoteB.Text;
            idBloque = txtBloqueB.Text;
            idSeccion = txtSeccionB.Text;
            if (idLote == "") { idLote = "%"; }
            if (idBloque == "") { idBloque = "%"; }
            if (idSeccion == "") { idSeccion = "%"; }

            DataTable dtDatos = DAO.Seccion.buscarSeccionGrupo(idLote, idBloque, idSeccion, comboBox1.Text);
            DataColumn dc = new DataColumn("Seleccion", typeof(bool));
            dtDatos.Columns.Add(dc);
            dataGridView2.DataSource = dtDatos;
            dataGridView2.Columns["Seleccion"].ReadOnly = false;
            dataGridView2.Columns["Lote"].ReadOnly = true;
            dataGridView2.Columns["Bloque"].ReadOnly = true;
            dataGridView2.Columns["Seccion"].ReadOnly = true;
            dataGridView2.Columns["Grupo"].ReadOnly = true;
        }
        void agregar()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["Seccion"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["Bloque"].Value.ToString();
                    s.IdLote = dataGridView1.Rows[i].Cells["Lote"].Value.ToString();
                    try
                    {
                        DAO.Seccion.agregarGrupo(s, DAO.GrupoForza.getGrupo(comboBox1.Text));

                    }
                    catch { }
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sin Grupo") { return; }
            EditarGrupo cg = new EditarGrupo(this, comboBox1.Text);
            cg.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedValue.ToString().Equals("Sin Grupo")) {

                DAO.GrupoForza.eliminar(comboBox1.SelectedValue.ToString());
            }
            cargarComboGrupos();
            cargarSeccionB();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void quitar()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (getValue(dataGridView2.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView2.Rows[i].Cells["Seccion"].Value.ToString();
                    s.IdBloque = dataGridView2.Rows[i].Cells["Bloque"].Value.ToString();
                    s.IdLote = dataGridView2.Rows[i].Cells["Lote"].Value.ToString();
                    DAO.Seccion.quitarGrupo(s);
                }

            }
        }
        bool getValue(DataGridViewRow row)
        {
            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["Seleccion"];

            return (bool)checkbox.EditedFormattedValue;
        }
    }
}
