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
    public partial class VerInformacionCedula : Form
    {
        double areaTotal;
        Entidades.CedulaIdentidad cedula;
        DataTable dt = new DataTable();
        List<Entidades.Producto> listaViejos;
        List<Entidades.Producto> listaNuevos;
        string estado;
        public VerInformacionCedula(int c,string estado)
        {
            InitializeComponent();
            this.estado = estado;
            cedula = DAO.CedulaIdentidad.obtenerCedula(c);
            cargarDatos();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerInformacionCedula_Load(object sender, EventArgs e)
        {
            horaInicio.Format = DateTimePickerFormat.Time;
            horaFinal.Format = DateTimePickerFormat.Time;


        }

        void cargarDatos()
        {

            txtCedula.Text = cedula.IdCedula.ToString();
            txtChofer.Text = cedula.Chofer.ToString();
            txtSpray.Text = cedula.NumSpray.ToString();
            txtTractor.Text = cedula.NumTractor;
            lblAreaTotal.Text = cedula.AreaTotal.ToString();
            areaTotal = double.Parse(lblAreaTotal.Text);
            lblTotalboones.Text = cedula.TotalBoonesRequeridos.ToString();
            lblTotalLitros.Text = cedula.TotalLtsRequeridos.ToString();
            lblCapacidad.Text = cedula.LtsRequeridos.ToString();
            txtIdAplicacion.Text = cedula.IdAplicacion.ToString();
            txtNombreAplicacion.Text = cedula.NombreAplicacion;
            lblCosto.Text = cedula.CostoTotal.ToString();
            try
            {
                horaInicio.Text = cedula.HoraInicio.ToString();
                horaFinal.Text = cedula.HoraFinal.ToString();
            }
            catch
            {
                horaInicio.Text = "00:00:00";
                horaFinal.Text = "00:00:00";
            }
            txtReal.Text = cedula.FechaReal.Date.ToString("dd/MM/yyyy");
            txtProgramada.Text = cedula.FechaProgramada.Date.ToString("dd/MM/yyyy");
            dt = DAO.CedulaIdentidad.mostrarProductosCedula(cedula);
          
            dataProductos.DataSource = dt;
            dataSecciones.DataSource = DAO.CedulaIdentidad.mostrarSeccionesCedula(cedula);
            chkJustificacion.Checked = cedula.JustProgramacion;
            chkMuestreo.Checked = cedula.JustMuestreo;
            txtCultivo.Text = cedula.Cultivo;
            cargarProductosViejos();
        }
        void cargarProductosViejos()
        {
            try
            {
                listaViejos = new List<Entidades.Producto>();
                for (int i = 0; i < dataProductos.Rows.Count; i++)
                {
                    Entidades.Producto p = new Entidades.Producto();
                    p.IdProducto = dataProductos.Rows[i].Cells["idProducto"].Value.ToString();
                    p.Cantidad = double.Parse(dataProductos.Rows[i].Cells["DosisTotal"].Value.ToString());
                    listaViejos.Add(p);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString());


            }
           

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CedulaAgregarProducto c = new CedulaAgregarProducto();
            DialogResult res = c.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (buscarCoincidencia(c.p.IdProducto))
                {
                    dt.Rows.Add(c.p.IdProducto, c.p.Nombre, c.p.IngredienteActivo, 0, c.p.Costo, c.p.Unidad, c.p.Tipo, c.p.NumRegistro, c.p.Dias, 0, 0);
                    dataProductos.DataSource = dt;
                }

            }
        }
        bool buscarCoincidencia(string id)
        {

            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {

                if (row.Cells["idProducto"].Value.ToString().Equals(id))
                {
                    MessageBox.Show("El Producto ya se encuentra en la tabla");
                    return false;
                }

            }
            return true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.RemoveAt(dataProductos.CurrentRow.Index);
            }
            catch { }
        }

        private void btnCambiarDosis_Click(object sender, EventArgs e)
        {
            try
            {
                dataProductos.CurrentRow.Cells["Dosis(H)"].Value = txtDosis.Text;
                double dosis = Convert.ToDouble(dataProductos.CurrentRow.Cells["Dosis(H)"].Value);
                dataProductos.CurrentRow.Cells["DosisTotal"].Value = areaTotal * dosis;
                dataProductos.CurrentRow.Cells["CostoTotal"].Value = Convert.ToDouble(dataProductos.CurrentRow.Cells["DosisTotal"].Value) * Convert.ToDouble(dataProductos.CurrentRow.Cells["Costo(UM)"].Value);
                calcularCostoTotal();

            }
            catch { }
        }
        void calcularCostoTotal()
        {
            lblCosto.Text = "0";
            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {

                try
                {
                    lblCosto.Text = (Convert.ToDouble(row.Cells["CostoTotal"].Value) + double.Parse(lblCosto.Text)).ToString();
                }
                catch { }

            }


        }

        private void dataProductos_SelectionChanged(object sender, EventArgs e)
        {
            txtDosis.Text = dataProductos.CurrentRow.Cells["Dosis(H)"].Value.ToString();
            txtDosis.Focus();
            txtDosis.SelectAll();
         
        }

        private void VerInformacionCedula_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                DAO.CedulaIdentidad.actualizarCedula(int.Parse(txtCedula.Text), double.Parse(lblCosto.Text));
                foreach (Entidades.Producto p in listaViejos)
                {
                    DAO.Producto.supply(p.IdProducto, p.Cantidad);

                }
                guardarDetalleProductos();
            }
           
        }
        void guardarDetalleProductos()
        {

            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {


                DAO.CedulaIdentidad.insertarDetalleProductos(new Entidades.DetalleProductos()
                {
                    Cedula = int.Parse(txtCedula.Text),

                    IngredienteActivo = row.Cells["ingredienteActivo"].Value.ToString(),
                    NombreComercial = row.Cells["nombreComercial"].Value.ToString(),
                    Codigo = int.Parse(row.Cells["idProducto"].Value.ToString()),
                    Costo = double.Parse(row.Cells["CostoTotal"].Value.ToString()),
                    DosisH = double.Parse(row.Cells["Dosis(H)"].Value.ToString()),
                    TotalDosis = double.Parse(row.Cells["DosisTotal"].Value.ToString()),
                    CostoH = double.Parse(row.Cells["Costo(UM)"].Value.ToString()),
                    Tipo = row.Cells["Clasificacion"].Value.ToString(),
                    UM1 = row.Cells["UM"].Value.ToString(),
                    NumRegistro = row.Cells["# Registro"].Value.ToString(),
                    Intervalo = int.Parse(row.Cells["InterCosecha"].Value.ToString()),

                });


            }
        }
    }
}
    
