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
    public partial class EditSeccion : Form
    {
        Mapa padreForm;
        Entidades.Seccion seccion;



        public EditSeccion(Mapa padreForm, Entidades.Seccion seccion)
        {
            this.padreForm = padreForm;
            this.seccion = seccion;
            InitializeComponent();
            txtBloque.Text = seccion.IdBloque;
            txtArea.Text = seccion.Area.ToString();
            txtCantidad.Text = seccion.NumPlantas.ToString();
            txtDetalle.Text = seccion.Detalle;
      
            txtFSiembra.Value = seccion.FechaSiembra;
         
            txtPeso.Text = seccion.PesoSemilla.ToString();
            txtTipo.Text = seccion.TipoSemilla;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            seccion.NumPlantas = int.Parse(txtCantidad.Text);
            seccion.Area = double.Parse(txtArea.Text);
            seccion.Detalle = txtDetalle.Text;
            seccion.PesoSemilla = txtPeso.Text;
            seccion.TipoSemilla = txtTipo.Text;
            seccion.FechaSiembra = txtFSiembra.Value;
            //seccion.FechaProgramada = txtFProgramada.Value;
            //seccion.FechaInicial = txtFInicial.Value;
            //seccion.Paquete = comboPaquetes.Text;
            //seccion.Posicion = int.Parse(comboPosicion.Text);


            padreForm.editarSeccion(seccion);
            Dispose();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comprobarSeccion(seccion))
                return;
            else
                padreForm.eliminarSeccion(seccion);
            Dispose();
        }
        bool comprobarSeccion(Entidades.Seccion s)
        {
            List<string> cedulas = DAO.Seccion.comprobarSeccion(s);
            string cadena = "Cedulas:";

            foreach (var item in cedulas)
            {
                cadena += item + ",";
            }

            if (cadena.Equals("Cedulas:")) return false;
            else
                MessageBox.Show("La seccion #:" + s.IdSeccion + "Bloque:" + s.IdBloque + " No se puede eliminar o editar tiene cedulas en proceso: " + cadena);

            return true;


        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtCantidad.ReadOnly = false;
                txtArea.ReadOnly = false;
                txtDetalle.ReadOnly = false;
                txtPeso.ReadOnly = false;
                txtTipo.ReadOnly = false;
                //comboPaquetes.Enabled = true;
                //comboPosicion.Enabled = true;
                txtFSiembra.Enabled = true;
                //txtFInicial.Enabled = true;
                //txtFProgramada.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                txtCantidad.ReadOnly = true;
                txtArea.ReadOnly = true;
                txtDetalle.ReadOnly = true;
                txtPeso.ReadOnly = true;
                txtTipo.ReadOnly = true;
                //comboPaquetes.Enabled = false;
                //comboPosicion.Enabled = false;
                txtFSiembra.Enabled = false;
                //txtFInicial.Enabled = false;
                //txtFProgramada.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }
        private void validarNumeros(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                btnGuardar.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                btnGuardar.Enabled = false;
            }
        }
        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

 

        private void txtFSiembra_ValueChanged(object sender, EventArgs e)
        {


        }
        private void txtFInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditSeccion_Load(object sender, EventArgs e)
        {

        }
    }
}
