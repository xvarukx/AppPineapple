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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddFormInPanel(Form form)
        {

           
            if (this.panel1.Controls.Count != 0)
                this.panel1.Controls.RemoveAt(0);
            form.Width = panel1.Width-500;
            form.Height = panel1.Height;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
             form.BackColor = this.panel1.BackColor;
           
             // form.StartPosition = FormStartPosition.CenterParent;
             this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mapa m = new Mapa();
            AddFormInPanel(m);
            // panel1.Controls.Clear();
            

        }
        void acomododarPanel() {

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size s = Screen.PrimaryScreen.WorkingArea.Size;
            this.Size = new Size(s.Width-150, s.Height-150);
            panel1.Height = this.Height - panelMenu.Height;
            menu.Height = this.Height;
            panel1.Width = this.Width-menu.Width;
            
            panelMenu.Width = this.Width;





        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            label2.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            acomododarPanel();
            Informacion i = new Informacion();
            AddFormInPanel(i);
          
          
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            Mapas.Mapa m = new Mapas.Mapa();
            AddFormInPanel(m);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Fechas.Calendario c = new Fechas.Calendario();
            AddFormInPanel(c);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaquete_Click(object sender, EventArgs e)
        {
            PaqueteAplicacion.PaqueteForm p = new PaqueteAplicacion.PaqueteForm();
            AddFormInPanel(p);
        }

        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            MantenimientoAplicacion m = new MantenimientoAplicacion();
            AddFormInPanel(m);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            AddFormInPanel(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerCedulasIdentidad s = new VerCedulasIdentidad();
                         AddFormInPanel(s);
        }

        private void btnSpray_Click(object sender, EventArgs e)
        {
            SpraysBooms s = new SpraysBooms();
            AddFormInPanel(s);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados s = new Empleados();
            AddFormInPanel(s);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos s = new Vehiculos();
            AddFormInPanel(s);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

            Configuracion s = new Configuracion();
            AddFormInPanel(s);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            acomododarPanel();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores p = new Proveedores();
            AddFormInPanel(p);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
       
            acomododarPanel();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            acomododarPanel();
        }
        void leave(object sender,EventArgs e) {

            Button b = (Button)sender;
            b.Font = new Font("Ebrima", 19, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        void Move(object sender, MouseEventArgs e) {

            Button b = (Button)sender;
            b.Font = new Font("Ebrima", 23, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Informacion i = new Informacion();
            AddFormInPanel(i);
        }
    }
}
