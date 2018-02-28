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
    public partial class AddBloque : Form
    {
        Mapa padreForm;
        Point punto;
        Entidades.Lote lote;
        Entidades.Bloque bloque;

        int contadorBloques;

        public AddBloque(Mapa padreForm, Point punto, Entidades.Lote lote)
        {
            this.padreForm = padreForm;
            this.punto = punto;
            this.lote = lote;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloque = new Bloque();
            Bloque.Area = double.Parse(txtArea.Text);
            Bloque.Detalles = txtDetalles.Text;
            Bloque.IdBloque = nextBloque();
            Bloque.IdLote = lote.IdLote;
            Bloque.PosX = punto.X;
            Bloque.PosY = punto.Y;
            padreForm.guardarBloque(Bloque);
            Dispose();
        }
        public string nextBloque()
        {
            List<Entidades.Bloque> listaBloques = DAO.Bloque.buscarBloqueLista(lote.IdLote);
            contadorBloques = 1;
            for (int i = 0; i < listaBloques.Count; i++)
            {
                if (int.Parse(listaBloques[i].IdBloque) == contadorBloques)
                {
                    contadorBloques++;
                    i = 0;
                }
            }

            return contadorBloques++.ToString(); ;
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

        public Bloque Bloque
        {
            get
            {
                return bloque;
            }

            set
            {
                bloque = value;
            }
        }
    }
}
