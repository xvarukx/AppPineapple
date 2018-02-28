using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas
{
    public class BotonMapa : Button 
    {

     //   public DetalleSeccion detalleSeccion;
       // public DetalleBloque detalleBloque;
        public Entidades.Seccion seccion;
        public Entidades.Bloque bloque;
      

    /*    public BotonMapa(Entidades.Seccion s)
        {
           // padreForm = padre;
            DoubleClick += new EventHandler(DClickSeccion);
            Seccion = s;

            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            Name = "S" + s.IdSeccion;
            Text = "S" + s.IdBloque + "." + s.IdSeccion;
            Location = new Point(s.PosX, s.PosY);
            Width = 60;
            Height = 60;
            ForeColor = Color.White;
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
            Image = Vistas.Properties.Resources.pineappleicon;
            ImageAlign = ContentAlignment.TopCenter;
            TextAlign = ContentAlignment.BottomCenter;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;

        }*/
        public BotonMapa(Entidades.Seccion s)
        {
            DoubleClick += new EventHandler(DClickSeccion);
            Seccion = s;
            Bloque = new Bloque();
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            Text = "S" + Seccion.IdBloque + "." + Seccion.IdSeccion;
            Location = new Point(Seccion.PosX, Seccion.PosY);
            //Width = 120;
            //Height = 60;
            AutoSize = true;//
            AutoSizeMode = AutoSizeMode.GrowAndShrink;//
            AutoEllipsis = false;//
           
          
           ForeColor = Color.Black;//

            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
            Image = Vistas.Properties.Resources.pineappleicon4;
            ImageAlign = ContentAlignment.TopLeft;
            TextAlign = ContentAlignment.BottomLeft;
            TextImageRelation = TextImageRelation.ImageBeforeText;//
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
         

        }
        public BotonMapa(Entidades.Bloque b)
        {
            DoubleClick += new EventHandler(DClickBloque);
            Bloque = b;
            Seccion = new Seccion();
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            Name = "B." + Bloque.IdBloque;
            Text = "B" + Bloque.IdBloque;
            //ForeColor = Color.OrangeRed;
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
            TextAlign = ContentAlignment.BottomLeft;
            Location = new Point(Bloque.PosX, Bloque.PosY);
            //Width = 40;
            //Height = 60;
            AutoSize = true;//
            AutoSizeMode = AutoSizeMode.GrowAndShrink;//
            AutoEllipsis = false;//
            ForeColor = Color.Black;//

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Image = Vistas.Properties.Resources.flag__4_;
            ImageAlign = ContentAlignment.TopLeft;
            BackColor = Color.Transparent;

            TextImageRelation = TextImageRelation.ImageBeforeText;//

 
        }
    
  /*  public BotonMapa(Entidades.Bloque b, MapDesigner padre)
    {
        padreForm = padre;
        DoubleClick += new EventHandler(DClickBloque);
        Bloque = b;

        FlatAppearance.MouseOverBackColor = Color.Transparent;
        FlatAppearance.MouseDownBackColor = Color.Transparent;
        Name = "B" + b.IdBloque;
        Text = "B" + b.IdBloque;
        ForeColor = Color.OrangeRed;
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
            TextAlign = ContentAlignment.BottomCenter;
        Location = new Point(b.PosX, b.PosY);
        Width = 40;
        Height = 60;
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Image = Vistas.Properties.Resources.flag__4_;
        ImageAlign = ContentAlignment.TopCenter;
        BackColor = Color.Transparent;
    }*/

        private void DClickSeccion(object o, EventArgs e)
        {
            /*
            detalleSeccion = new DetalleSeccion(Seccion, this);
            detalleSeccion.Location = Cursor.Position;
            detalleSeccion.Show();*/
        }
    private void DClickBloque(object o, EventArgs e)
        {
        /*    detalleBloque = new DetalleBloque(Bloque, this);
            detalleBloque.Location = Cursor.Position;
            detalleBloque.Show();
    */    
    }

        public void prueba() { MessageBox.Show("boton"); }


        /// <summary>
        /// //////////////////////////////////////////////////////7
        /// </summary>

        int previousClick = SystemInformation.DoubleClickTime;


        public new event EventHandler DoubleClick;

        protected override void OnClick(EventArgs e)
        {
            int now = System.Environment.TickCount;

            // A double-click is detected if the the time elapsed
            // since the last click is within DoubleClickTime.
            if (now - previousClick <= SystemInformation.DoubleClickTime)
            {
                // Raise the DoubleClick event.
                if (DoubleClick != null)
                    DoubleClick(this, EventArgs.Empty);
            }

            // Set previousClick to now so that 
            // subsequent double-clicks can be detected.
            previousClick = now;

            // Allow the base class to raise the regular Click event.
            base.OnClick(e);
        }

        // Event handling code for the DoubleClick event.
        protected new virtual void OnDoubleClick(EventArgs e)
        {
            if (this.DoubleClick != null)
                this.DoubleClick(this, e);
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

