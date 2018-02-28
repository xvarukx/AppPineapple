using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas.Mapas
{
    class BotonSeccion:Button
    {
        Mapa padreForm;
        Entidades.Seccion seccion;

        public BotonSeccion(Mapa padreForm, Entidades.Seccion seccion)
        {
            this.padreForm = padreForm;
            this.Seccion = seccion;
            Configuracion();
        }



        void Configuracion()
        {
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            Name = "S" + Seccion.IdSeccion;

            Text = "S" + Seccion.IdBloque + "." + Seccion.IdSeccion;
            Location = new Point(Seccion.PosX, Seccion.PosY);
          
            AutoSize = true;//
            AutoSizeMode = AutoSizeMode.GrowAndShrink;//
            AutoEllipsis = false;//
            ForeColor = Color.Black;//
            
            Font = new Font("Agency FB", 11, FontStyle.Bold);
            //Image = Vistas.Properties.Resources.locaSeccion;
            //ImageAlign = ContentAlignment.MiddleRight;
            TextAlign = ContentAlignment.MiddleRight;
           // TextImageRelation = TextImageRelation.ImageBeforeText;//
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
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
