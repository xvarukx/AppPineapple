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
    public partial class EditorMapa : Form
    {
        bool presionado = false;
        int posMouseFormX, posMouseFormY, posMouseBotonX, posMouseBotonY, posActBotonX, posActBotonY;
        bool opcion = false;



        Entidades.Mapa mapa;
        public EditorMapa(Entidades.Lote lote)
        {
            InitializeComponent();
           
            ToolTip toolTip1 = new ToolTip();
            mapa = new Entidades.Mapa(lote);
            lblLote.Text = lote.IdLote;
            txtAreaLote.Text = lote.Area.ToString();
            txtAreaLote.Enabled = false;
            pictureBox1.Image = Image.FromFile(lote.Imagen);
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
          
            // Set up the ToolTip text for the Button and Checkbox.
       


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Controls.Add(btnBorrar);
            btnBorrar.Location = new Point(pictureBox1.Right - btnBorrar.Width-20, 35);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = e.Location.X;
            posMouseFormY = e.Location.Y;
        }


        void mouseMove(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            posMouseFormX = b.Location.X + e.Location.X;
            posMouseFormY = b.Location.Y + e.Location.Y;
            if (presionado) mover(b,e);

        }

        void mover(Button b, MouseEventArgs e)
        {
            b.Location = new Point(posMouseFormX - posMouseBotonX, posMouseFormY - posMouseBotonY);
           
            b.BackColor = Color.Transparent;
            buscarPosicion(b,e);
            b.BringToFront();
  
           
        



        }
        void buscarPosicion(Button b, MouseEventArgs e)
        {

            if ((b.Location.X + pictureBox1.Left) > pictureBox1.Left && (b.Location.X + pictureBox1.Left) < pictureBox1.Right && b.Location.Y + pictureBox1.Top > pictureBox1.Top && b.Location.Y + pictureBox1.Top < pictureBox1.Bottom)
            {

            }
        }

        

        void mouseUp(object sender, MouseEventArgs e) {
            mapa.buscarPosicion((Button)sender);
            Button b = (Button)sender;
            presionado = false;

            string letra = b.Name[0].ToString();
            if (b.Location.X > btnBorrar.Left && b.Location.X < btnBorrar.Right && b.Location.Y + btnBorrar.Top > btnBorrar.Top && b.Location.Y < btnBorrar.Bottom)
            {
                b.BringToFront();
                if (letra.Equals("B")) { 
                    mapa.borrarBloque(b.Name[1].ToString());
                cmbBloque.Items.Clear();
                    cmbBloque.SelectedItem = "";

                }
            else
                mapa.borrarSeccion(b.Text[3].ToString(), b.Text[1].ToString());
                    b.Dispose();

            }
            else
            {
                
            }

        }
        void mouseDown(object sender, MouseEventArgs e) {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            presionado = true;
        }
     
        void presionar(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            presionado = true;




        }
        void no(object sender, MouseEventArgs e) {

            presionado = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

           
            button3.Visible = false;
            panelSeccion.Visible = true;
           

        }
    
        void crearButtonBloque(Entidades.Bloque bloque) {
            BotonMapa b = new BotonMapa(bloque);
            b.MouseDown += new MouseEventHandler(mouseDown);
            b.MouseUp += new MouseEventHandler(mouseUp);
            b.MouseMove += new MouseEventHandler(mouseMove);
            toolTip1.SetToolTip(b, " Area: "+bloque.Area+"\n Numero de Plantas: "+bloque.NumPlantas);
            this.pictureBox1.Controls.Add(b);
            b.BringToFront();
            cargarCombo();
        }


        void crearButtonSeccion(Entidades.Seccion s)
        {
            BotonMapa b = new BotonMapa(s);
            b.MouseDown += new MouseEventHandler(mouseDown);
            b.MouseUp += new MouseEventHandler(mouseUp);
            b.MouseMove += new MouseEventHandler(mouseMove);           
            //b.BackColor = pictureBox1.BackColor;/////
            toolTip1.SetToolTip(b, " Area: " + s.Area + "\n Numero de Plantas: " + s.NumPlantas);
            this.pictureBox1.Controls.Add(b);
            b.BringToFront();
        }

        void cargarCombo() {
            cmbBloque.Items.Clear();
            foreach (Entidades.Bloque a in Entidades.Bloque.bloques) {
                cmbBloque.Items.Add(a.IdBloque);
            }
            cmbBloque.SelectedIndex = 0;
        }
   

   

      
       
        private void btnAceptarSeccion_Click(object sender, EventArgs e)
        {
            crearButtonSeccion(mapa.crearSeccion(cmbBloque.SelectedItem.ToString(), txtArea.Text, (int)numPlantas.Value, dateSiembra.Value.Date));
            panelSeccion.Visible = false;
            button3.Visible = true;
        }

        private void btnCancelarSeccion_Click(object sender, EventArgs e)
        {
            panelSeccion.Visible = false;
            button3.Visible = true;
        }

        private void btnAceptarBloque_Click(object sender, EventArgs e)
        {
            crearButtonBloque(mapa.crearBloque(txtAreaBloque.Text, (int)numPlantasBloque.Value));
            panelBloque.Visible = false;
            button4.Visible = true;
        }

        private void btnBorrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = Vistas.Properties.Resources.Garbage_Open;
        }

        private void btnCancelarBloque_Click(object sender, EventArgs e)
        {
            panelBloque.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelBloque.Visible = true;
            button4.Visible = false;    
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnBorrar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            btnBorrar.BackgroundImage = Vistas.Properties.Resources.Garbage2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DAO.Lote.insertar(mapa.l);
            foreach (Entidades.Bloque b in Entidades.Bloque.bloques)
                DAO.Bloque.insertar(b);
            foreach (Entidades.Seccion s in Entidades.Seccion.secciones)
                DAO.Seccion.insertar(s);

            Entidades.Seccion.secciones.Clear();
            Entidades.Bloque.bloques.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = e.Location.X;
            posMouseFormY = e.Location.Y;
        }

        private void EditorMapa_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

        private void panelSeccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            presionado = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

     
      

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

       
        void moverBoton() {

        


        }
        private void button1_Click(object sender, EventArgs e)
        {
           

        }



       

      
    }
}
