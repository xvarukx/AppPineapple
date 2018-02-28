using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form2 : Form
    {
     
        Entidades.Usuario usuario;
        public Form2()
        {
            InitializeComponent();
            this.Size= Screen.PrimaryScreen.WorkingArea.Size;
            lblDia.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            loadPanel();
          
            //addLogo();

        }

        void loadPanel()
        {
            panelMenu2.Width = this.Width - panelMenu1.Width-25;
            panelForm.Width = this.Width - panelMenu1.Width-50;
            panelForm.Height = this.Height - panelMenu2.Height - 50;
      
        }
         void AddFormInPanel(Form form)
        {
            panelForm.Controls.Clear();
            form.TopLevel = false;
            form.BackColor = panelForm.BackColor;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Parent = this.panelForm;
            form.AutoScroll = true; 
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            form.Dock = DockStyle.Fill;
            form.Font = new Font("", 8);
            
            form.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Informacion i = new Informacion();

            defecto();
            color(sender);
            AddFormInPanel(i);
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            loadPanel();
        }

        void ButtonLeave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if(!(ManagerMenu.verificarTamaño(b)))
                b.Font = new Font("Ebrima", 16, FontStyle.Bold, GraphicsUnit.Pixel);
           
          
        }

      
        void ButtonMove(object sender, MouseEventArgs e)
        {

            Button btnSender = (Button)sender;
          

            btnSender.Font = new Font("Ebrima", 20, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        private void addLogin()
        {
            Login i = new Login();
            DialogResult res = i.ShowDialog();
            usuario = i.u;
            try
            {
            


            }
            catch { }
            restringir(usuario);
        }

        void addLogo() {
            Logo i = new Logo();
             i.ShowDialog();
           
        }


        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Te");
        }
        void restringir(Entidades.Usuario usuario)
        {
            panelForm.Controls.Clear();
          
            foreach (Control b in panelMenu1.Controls)
            {
                if (b is Button)
                {

                    b.Enabled = false;
                 
                        if (usuario.Tipo.Equals("Administrador"))
                        {
                        lblUsuario.Text = usuario.IdUsuario;
                        lblTipo.Text = usuario.Tipo;
                        Informacion info = new Informacion();
                            AddFormInPanel(info);
                            b.Enabled = true;
                        }
                        if (usuario.Tipo.Equals("Bodega"))
                        {
                        lblUsuario.Text = usuario.IdUsuario;
                        lblTipo.Text = usuario.Tipo;
                        if (b.Text.Equals("Inventario"))
                            {

                                b.Enabled = true;
                            }
                        }
                        if (usuario.Tipo.Equals("Ventas"))
                        {

                        }
                    }
                  

                }
            
        

        }
        private void btnMapa_Click(object sender, EventArgs e)
        {
            Mapas.Mapa m = new Mapas.Mapa();
            defecto();
            color(sender);
            AddFormInPanel(m);
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(btnSender.Width / 2, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                contextMenuStrip1.Show(ptLowerLeft);
            
            //  
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Fechas.Calendario c = new Fechas.Calendario();
            defecto();
            color(sender);
            AddFormInPanel(c);
        }

        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            MantenimientoAplicacion m = new MantenimientoAplicacion();
            defecto();
            color(sender);
            AddFormInPanel(m);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            defecto();
            color(sender);
            AddFormInPanel(i);
        }

        private void btnSpray_Click(object sender, EventArgs e)
        {
            SpraysBooms s = new SpraysBooms();
            defecto();
            color(sender);
            AddFormInPanel(s);
        }

        void defecto() {
            foreach (Control c in panelMenu1.Controls) {
                if (c is Button)
                {
                    Button b = (Button)c;
                    if (ManagerMenu.verificarTamaño(b))
                    {
                        b.Image = ChangeColor((Bitmap)b.Image,false);
                        b.Font = b.Font = new Font("Ebrima", 16, FontStyle.Bold, GraphicsUnit.Pixel);
                        b.ForeColor = Color.White;
                    }
                }
            }

        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados s = new Empleados();
            defecto();
            color(sender);
            AddFormInPanel(s);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos s = new Vehiculos();
            defecto();
            color(sender);
            AddFormInPanel(s);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores p = new Proveedores();
            defecto();
            color(sender);
            AddFormInPanel(p);
        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            PaqueteAplicacion.PaqueteForm p = new PaqueteAplicacion.PaqueteForm();
            defecto();
            color(sender);
            AddFormInPanel(p);
        }
        void espera() {

            AddFormInPanel(new LogoEspera());
          
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion s = new Configuracion();
            defecto();
            color(sender);
            AddFormInPanel(s);
            
      
        }

        private void btnCedulas_Click(object sender, EventArgs e)
        {
            VerCedulasIdentidad s = new VerCedulasIdentidad();
            defecto();
            color(sender);
            AddFormInPanel(s);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
         //addLogin();
        }


        void color(object sender) {
            if (!(ManagerMenu.LastButton == null))
            {
               
                ManagerMenu.lastButton.Font  = new Font("Ebrima", 16, FontStyle.Bold, GraphicsUnit.Pixel);

            }
            Button b = (Button)sender;
            b.ForeColor = Color.FromArgb(192, 255, 54);
            Bitmap bmp = null;
            //The Source Directory in debug\bin\Big\
            bmp = (Bitmap)b.Image;
            bmp = ChangeColor(bmp,true);
            b.Image = bmp;

            ManagerMenu.setLast(ref b);
            }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            defecto();
            color(sender);
            AddFormInPanel(u);
           
        }
        public static Bitmap ChangeColor(Bitmap scrBitmap,bool estado)
        {
            Color newColor;
            //You can change your new color here. Red,Green,LawnGreen any..
            if (estado)
            {
                 newColor = Color.FromArgb(192, 255, 54);
            }
            else {

                newColor = Color.White;
            }
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            addLogin();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectorSecciones ss = new SelectorSecciones();
            ss.Show();
        }
        private void aplicarLote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");

        }
        private void aplicarGrupo_Click(object sender, EventArgs e)
        {


        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Aplicar Lote"))
            {
                Mapa m = new Mapa();
                AddFormInPanel(m);
            }
            else {

                AplicarGrupo m = new AplicarGrupo();
                AddFormInPanel(m);
            }

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMenu1.BackgroundImage = Vistas.Properties.Resources.fondo2;
            panelMenu2.BackgroundImage = Vistas.Properties.Resources.fondo2;
            panelMenu2.BackgroundImageLayout = ImageLayout.Stretch;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {

      
        
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
