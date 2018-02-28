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
    public partial class PaqueteForm : Form
    {
        Entidades.Paquete paquete;
        Entidades.DetalleAplicacion detalleAplicacion;
        List<Entidades.Paquete> paquetes;
        List<Entidades.DetalleAplicacion> detalles;
        List<Entidades.Aplicacion> aplicaciones;
        Entidades.DetalleAplicacion detalleDerecha;
        Entidades.DetalleAplicacion detalle;//auxiliar
        CrearPaquete crearPaquete;
        int indexActual;

        public PaqueteForm()
        {
            InitializeComponent();
            cargarCombo();
            aplicaciones = DAO.Aplicacion.lista();
            dataGridView2.DataSource = DAO.Aplicacion.buscarTable("%");
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnEditar_Click(sender, e);
            }
        }
        public void cargarCombo()
        {
            comboBox1.Items.Clear();
            paquetes = DAO.Paquete.lista("%");
            foreach (Entidades.Paquete p in paquetes)
            {
                comboBox1.Items.Add(p.IdPaquete);
            }
        }
        void cargarData()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                paquete = paquetes[comboBox1.SelectedIndex];
                detalles = DAO.DetalleAplicacion.lista(paquete.IdPaquete);
                dataGridView1.DataSource = DAO.DetalleAplicacion.listaTable(paquete.IdPaquete);        
            }
        }

        private void MoveUp()
        {

            try
            {
                indexActual = dataGridView1.CurrentCell.RowIndex - 1;
                if (dataGridView1.CurrentRow == null) { return; }
                int index = dataGridView1.CurrentRow.Index;
                if (index == 0) { return; }
                detalle = detalles[index];
                detalles.RemoveAt(index);
                detalles.Insert(index - 1, detalle);
                DAO.DetalleAplicacion.Actualizar(paquete.IdPaquete, detalles);
                dataGridView1.DataSource = DAO.DetalleAplicacion.listaTable(paquete.IdPaquete);
                detalles = DAO.DetalleAplicacion.lista(paquete.IdPaquete);
            }
            catch {

            }
         
        }

        private void MoveDown()
        {
            try
            {
                indexActual = dataGridView1.CurrentCell.RowIndex + 1;
                if (dataGridView1.CurrentRow == null) { return; }
                int index = dataGridView1.CurrentRow.Index;
                if (index == dataGridView1.RowCount - 1) { return; }
                detalle = detalles[index];
                detalles.RemoveAt(index);
                detalles.Insert(index + 1, detalle);
                DAO.DetalleAplicacion.Actualizar(paquete.IdPaquete, detalles);
                dataGridView1.DataSource = DAO.DetalleAplicacion.listaTable(paquete.IdPaquete);
                detalles = DAO.DetalleAplicacion.lista(paquete.IdPaquete);
            }
            catch { }

        }

        private void btnNuevoPaquete_Click(object sender, EventArgs e)
        {
            crearPaquete = new CrearPaquete(this);
            crearPaquete.ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarData();
            conf.evitarOrdenar(ref dataGridView1);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
            dataGridView1.ClearSelection();
           
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[indexActual].Cells[0];
            }
            catch {

                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[indexActual].Cells[0];
            }
            catch
            {
               
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Esta seguro en cambiar la cantidad de dias?", "Cambiar dias", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                detalleAplicacion.Tiempo = int.Parse(txtTiempo.Text);
                DAO.DetalleAplicacion.editar(detalleAplicacion);
                dataGridView1.DataSource = DAO.DetalleAplicacion.listaTable(paquete.IdPaquete);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) { return; }
            detalles.RemoveAt(dataGridView1.CurrentRow.Index);
            DAO.DetalleAplicacion.Actualizar(paquete.IdPaquete, detalles);
            dataGridView1.DataSource = DAO.DetalleAplicacion.listaTable(paquete.IdPaquete);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        
            if (dataGridView1.CurrentRow== null) { return; }
            if (dataGridView1.CurrentRow.Index == -1) { return; }
            try
            {
                detalleAplicacion = detalles[dataGridView1.CurrentRow.Index];
                txtAplicacion.Text = detalleAplicacion.IdAplicacion.ToString();
                txtTiempo.Text = detalleAplicacion.Tiempo.ToString();
            }
            catch { }
            txtTiempo.Focus();
            txtTiempo.SelectAll();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }
        bool existencia(int idAplicacion)
        {
            foreach (Entidades.DetalleAplicacion d in detalles)
            {
                if (d.IdAplicacion == idAplicacion) { return true; }
            }
            return false;
        } 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) { return; }
            if (comboBox1.SelectedIndex == -1) { return; }
            int idAplicacion = (int)dataGridView2.CurrentRow.Cells["idAplicacion"].Value;
            //aplicacion = aplicaciones[dataGridView2.CurrentRow.Index];
            if (existencia(idAplicacion)) { return; }
            detalleDerecha = new Entidades.DetalleAplicacion();
            detalleDerecha.IdPaquete = paquete.IdPaquete;
            detalleDerecha.IdAplicacion = idAplicacion;
            detalleDerecha.Tiempo = 0;
            detalleDerecha.Posicion = dataGridView1.RowCount;

            DAO.DetalleAplicacion.insertar(detalleDerecha);
         
            cargarData();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnEditar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnEditar.Enabled = false;
            }
        }

        private void txtTiempoAdd_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnAdd.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnAdd.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            if (txtBuscar.Text == "") { busqueda = "%"; }
            dataGridView2.DataSource = DAO.Aplicacion.buscarTable(busqueda);
        }

        private void btnNuevaAplicacion_Click(object sender, EventArgs e)
        {
            AplicacionForm aplicacionForm = new AplicacionForm();
            aplicacionForm.ShowDialog();
        }

        private void btnAplicacion(object sender, EventArgs e)
        {
            try
            {
                MantenimientoAplicacion m = new MantenimientoAplicacion();
                m.ShowDialog();
                dataGridView2.DataSource = DAO.Aplicacion.buscarTable("%");
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaqueteForm_Load(object sender, EventArgs e)
        {
           
        }
        void evitarOrdenar(ref DataGridView dt) {



            foreach (DataGridViewColumn column in dt.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }



        }
        void pintarBorde(object sender, PaintEventArgs e ) {

            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(-10, -10);
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
            Border3DStyle.Raised);
        }
        private void btnEditarAplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) { return; }
                Entidades.Aplicacion aplicacion = new Entidades.Aplicacion();
                aplicacion.IdAplicacion = (int)dataGridView1.CurrentRow.Cells["idAplicacion"].Value;
                aplicacion.Nombre = (string)dataGridView1.CurrentRow.Cells["Aplicacion"].Value;
                
                AplicacionForm aplicacionForm = new AplicacionForm(aplicacion, (string)dataGridView1.CurrentRow.Cells["Etapa"].Value);
                aplicacionForm.ShowDialog();
            }
            catch { }
        }

        private void PaqueteForm_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta etapa?", "Eliminar Etapa", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                try
                {

                    DAO.Paquete.eliminar(comboBox1.Text);
                    cargarCombo();
                    aplicaciones = DAO.Aplicacion.lista();
                    dataGridView1.Rows.Clear();
                    this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);

                }
                catch { }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
