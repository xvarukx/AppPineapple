using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Drawing;

namespace Vistas.Mapas
{
    class BotonBloque:Button
    {
        Mapa padreForm;
        Bloque bloque;

        public BotonBloque(Mapa padreForm, Bloque bloque)
        {
            this.padreForm = padreForm;
            this.Bloque = bloque;
            Configuracion();
        }

        void Configuracion() {
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            Name = "B" + Bloque.IdBloque;
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
