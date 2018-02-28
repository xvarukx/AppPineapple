using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Mapas
{
    public partial class BloqueManager : Form
    {
        Entidades.Bloque bloque;
        Entidades.Lote lote;
        Mapas.Mapa mapa;

        public BloqueManager(Entidades.Lote lote, Entidades.Bloque bloque)
        {
            this.lote = lote;
            this.bloque = bloque;
            InitializeComponent();
            cargarTabla();
            cargarComboPaquetes();
            cargarComboPosicion(comboPaquete.Text);
            cargarComboBloque();
            comboBloque.Text = bloque.IdBloque;
        }
        public BloqueManager(Entidades.Lote lote)
        {
            this.lote = lote;
            this.bloque = new Entidades.Bloque();
            InitializeComponent();
            cargarTabla();
            cargarComboPaquetes();
            cargarComboPosicion(comboPaquete.Text);
            cargarComboBloque();
            comboBloque.Text = "Todos";
        }
        public BloqueManager(Entidades.Lote lote, Mapas.Mapa mapa)
        {
            this.mapa = mapa;
            this.lote = lote;
            this.bloque = new Entidades.Bloque();
            InitializeComponent();
            cargarTabla();
            cargarComboPaquetes();
            cargarComboPosicion(comboPaquete.Text);
            cargarComboBloque();
            comboBloque.Text = "Todos";
        }
        void cargarTabla()
        {
            DataTable dtDatos = DAO.Seccion.TablaSecciones(lote.IdLote, bloque.IdBloque);
            DataColumn dc = new DataColumn("Seleccion", typeof(bool));
            dtDatos.Columns.Add(dc);
            dataGridView1.DataSource = dtDatos;
            dataGridView1.Columns["idSeccion"].ReadOnly = true;
            dataGridView1.Columns["idPaquete"].ReadOnly = true;
            dataGridView1.Columns["posicion"].ReadOnly = true;
            dataGridView1.Columns["grupoForza"].ReadOnly = true;
            dataGridView1.Columns["fechaInicial"].ReadOnly = true;
            dataGridView1.Columns["Seleccion"].ReadOnly = false;
        }
        void cargarComboPaquetes()
        {
            comboPaquete.Items.Clear();
            List<Entidades.Paquete> paquetes = DAO.Paquete.lista("%");
            foreach (Entidades.Paquete p in paquetes)
            {
                comboPaquete.Items.Add(p.IdPaquete);
            }
            if (comboPaquete.Items.Count == 0)
            {
                comboPaquete.Enabled = false;
                btnPaquete.Enabled = false;
                comboPosicion.Enabled = false;
            
            }
            else
            {
                comboPaquete.Enabled = true;
                btnPaquete.Enabled = true;
                comboPaquete.SelectedIndex = 0;
            }

        }
        void cargarComboPosicion(string paquete)
        {
            comboPosicion.Items.Clear();
            List<Entidades.DetalleAplicacion> lista = DAO.DetalleAplicacion.lista(paquete);
            comboPosicion.Items.Add("-1");
            foreach (Entidades.DetalleAplicacion da in lista)
            {
                comboPosicion.Items.Add(da.Posicion.ToString());
            }
            if (comboPosicion.Items.Count == 0)
            {
                comboPosicion.Enabled = false;
               
            }
            else
            {
                comboPosicion.Enabled = true;
               
                comboPosicion.SelectedIndex = 0;
            }
        }
        void cargarComboBloque()
        {
            comboBloque.Items.Clear();
            comboBloque.Items.Add("Todos");
            List<Entidades.Bloque> listaBloques = DAO.Bloque.buscarBloqueLista(lote.IdLote);
            foreach (Entidades.Bloque b in listaBloques)
            {
                comboBloque.Items.Add(b.IdBloque);
            }
        }
        private void btnDate_Click(object sender, EventArgs e)
        {
            List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["idSeccion"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["idBloque"].Value.ToString();
                    s.IdLote = lote.IdLote;
                    s.FechaInicial = dateTimePicker1.Value;
                    DAO.Seccion.editFechaInicial(s);
                }
                
            }
            cargarTabla();
            checkBox1.Checked = false;
        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["idSeccion"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["idBloque"].Value.ToString();
                    s.IdLote = lote.IdLote;
                    s.Paquete = comboPaquete.Text;
                    if (comprobarSeccion(s))
                        return;
                    else
                        DAO.Seccion.editPaquete(s);
                    
                }

            }

            cambiarCiclo();
            cargarTabla();
            checkBox1.Checked = false;
        }
        bool comprobarSeccion(Entidades.Seccion s ) {
            List<string> cedulas = DAO.Seccion.comprobarSeccion(s);
            string cadena = "Cedulas:";

            foreach (var item in cedulas)
            {
                cadena += item + ",";
            }

            if (cadena.Equals("Cedulas:")) return false;
            else
                MessageBox.Show("La seccion #:"+s.IdSeccion+"Bloque:"+s.IdBloque+" No se puede eliminar o editar tiene cedulas en proceso: " +cadena);

            return true;


        }
        void cambiarCiclo()
        {
            List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["idSeccion"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["idBloque"].Value.ToString();
                    s.IdLote = lote.IdLote;
                    s.Paquete = comboPaquete.Text;
                    s.Posicion = int.Parse(comboPosicion.Text);
                    DAO.Seccion.editPosicion(s);

                }

            }
           
        }
        private void btnPosicion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        bool getValue(DataGridViewRow row)
        {
            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["Seleccion"];

            return (bool)checkbox.EditedFormattedValue;
        }

        private void comboPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboPosicion(comboPaquete.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Seleccion"].Value = true;
                }
            }
            else {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Seleccion"].Value = false;
                }
            }
        }

        private void comboBloque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBloque.Text == "Todos")
            {
                bloque.IdBloque = "%";
                cargarTabla();
            }
            else
            {
                bloque.IdBloque = comboBloque.Text;
                cargarTabla();
            }
            
        }

        private void comboPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloqueManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BloqueManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mapa != null) { mapa.reloadMapa(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BloqueManager_Load(object sender, EventArgs e)
        {
            conf.evitarOrdenar(ref dataGridView1);
        }

        private void btnLimpiarGrupo_Click(object sender, EventArgs e)
        {
            List<Entidades.Seccion> lista = new List<Entidades.Seccion>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (getValue(dataGridView1.Rows[i]))
                {
                    Entidades.Seccion s = new Entidades.Seccion();
                    s.IdSeccion = dataGridView1.Rows[i].Cells["idSeccion"].Value.ToString();
                    s.IdBloque = dataGridView1.Rows[i].Cells["idBloque"].Value.ToString();
                    s.IdLote = lote.IdLote;
                    if (comprobarSeccion(s))
                        return;
                    else
                        DAO.Seccion.quitarGrupo(s);
                }

            }
            cargarTabla();
            checkBox1.Checked = false;
        }
    }
}

