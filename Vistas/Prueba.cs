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
    public partial class Prueba : Form
    {
        Point a;
        Point b;
        Point c;

        int x1, x2, x3, y1, y2,y3;

        Point sobrante;
        public Prueba()
        {
            InitializeComponent();
           
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void colorButtonEnter(object sender, EventArgs e)
        {

        }
        private void colorButtonLeave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Seccion_Producto s = new Seccion_Producto();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prueba p = new Prueba();
            p.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Inventario inventario = new Inventario();
            inventario.FormBorderStyle = FormBorderStyle.None;
            inventario.TopLevel = false;
            inventario.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(inventario);
            inventario.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Mapas.Mapa mapas = new Mapas.Mapa();
            mapas.Parent = this.panel1; 
            mapas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Prueba_MouseMove(object sender, MouseEventArgs e)
        {

        }

        void calcularArea() {
        }
    }
}
