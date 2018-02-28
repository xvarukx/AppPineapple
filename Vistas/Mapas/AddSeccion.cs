using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas.Mapas
{
    public partial class AddSeccion : Form
    {
        Mapa padreForm;
        Point punto;
        List<Entidades.Bloque> listaBloques;
        List<Entidades.Seccion> listaSecciones;
        Entidades.Seccion seccion;
        string idLote;
        string idBloque;

        int contadorSecciones;
        public AddSeccion(Mapa padreForm, Point punto, string idLote)
        {
            this.padreForm = padreForm;
            this.punto = punto;
            this.idLote = idLote;
            InitializeComponent();
            cargarCombo();
            comboBox1.SelectedIndex = 0;
        }
        public AddSeccion(Mapa padreForm, Point punto, string idLote, string idBloque)
        {
            this.padreForm = padreForm;
            this.punto = punto;
            this.idLote = idLote;
            this.idBloque = idBloque;
            InitializeComponent();
            cargarCombo();
            comboBox1.Text = idBloque;
        }
        void cargarCombo() {
            listaBloques = DAO.Bloque.buscarBloqueLista(idLote);
            foreach (Entidades.Bloque b in listaBloques) {
                comboBox1.Items.Add(b.IdBloque);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Seccion = new Seccion();
            Seccion.IdSeccion = nextSeccion();
            Seccion.Area = double.Parse(txtArea.Text);
            Seccion.Detalle = txtDetalle.Text;
            Seccion.FechaSiembra = txtFSiembra.Value;
            Seccion.IdBloque = idBloque;
            Seccion.IdLote = idLote;
            Seccion.NumPlantas = int.Parse(txtCantidad.Text);
            Seccion.PesoSemilla = txtPeso.Text;
            Seccion.TipoSemilla = txtTipo.Text;
            Seccion.PosX = punto.X;
            Seccion.PosY = punto.Y;
            padreForm.guardarSeccion(Seccion);
            Dispose();
        }
        public string nextSeccion()
        {
            listaSecciones = DAO.Seccion.buscarSeccionLista(idLote, idBloque);
            contadorSecciones = 1;
            for (int i = 0; i < listaSecciones.Count; i++)
            {
                if (int.Parse(listaSecciones[i].IdSeccion) == contadorSecciones && idBloque == listaSecciones[i].IdBloque)
                {
                    contadorSecciones++;
                    i = 0;
                }
            }

            return contadorSecciones++.ToString(); ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBloque = comboBox1.Text;
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

        public Seccion Seccion
        {
            get
            {
                return seccion;
            }

            set
            {
                seccion = value;
            }
        }
    }
}
