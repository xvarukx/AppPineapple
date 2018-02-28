using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Mapas;

namespace Vistas.Mapas
{
    public partial class DetalleLote : Form
    {
        Mapa padre;
        Entidades.Lote lote;

        public DetalleLote(Mapa padre)
        {
            this.padre = padre;
            InitializeComponent();
            button1.Click += new EventHandler(crear);
            cbEditando.Visible = false;
        }
        public DetalleLote(Entidades.Lote l, Mapa padre)
        {
            lote = l;
            this.padre = padre;
            InitializeComponent();
            txtCodigo.Text = l.IdLote;
            txtArea.Text = l.Area.ToString();
            //txtImagen.Text = l.Imagen;
            
            button1.Click += new EventHandler(editar);

            txtCodigo.ReadOnly = true;
            txtArea.ReadOnly = true;
            btnMapa.Enabled = false;
            button1.Enabled = false;
            cbEditando.Visible = true;
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;

                    txtImagen.Text = imagen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
        private void crear(object sender, EventArgs e)
        {
            lote = new Entidades.Lote();
            lote.Area = double.Parse(txtArea.Text);
            //lote.Imagen = txtImagen.Text;
            lote.IdLote = txtCodigo.Text;

            padre.guardarLote(lote);
            Dispose();

        }

        private void editar(object sender, EventArgs e)
        {
            lote.Area = double.Parse(txtArea.Text);
            //lote.Imagen = txtImagen.Text;
            lote.IdLote = txtCodigo.Text;
            DAO.Lote.modificar(lote);
            //this.padre.Lote = lote;
            //this.padre.panelMapa.Image = Image.FromFile(lote.Imagen);
            Dispose();
        }

        private void validarNumeros(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (isNumber(tb.Text))
            {
                tb.BackColor = SystemColors.Window;
                button1.Enabled = true;
            }
            else
            {
                tb.BackColor = Color.Tomato;
                button1.Enabled = false;
            }
        }

        bool isNumber(string entrada)
        {
            double d;
            return double.TryParse(entrada, out d);
        }

        private void cbEditando_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditando.Checked)
            {
                txtArea.ReadOnly = false;
                btnMapa.Enabled = true;
                button1.Enabled = true;
            }
            else {
                txtArea.ReadOnly = true;
                btnMapa.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleLote_Load(object sender, EventArgs e)
        {

        }
    }
}
