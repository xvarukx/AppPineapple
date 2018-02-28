using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    static public class ManagerMenu
    {


        static public Button lastButton;
        static public void setLast(ref Button b) {

            LastButton = b;
        }

       
        static public Button LastButton
        {
            get
            {
                return lastButton;
            }

            set
            {
                lastButton = value;
            }
        }


      
        static public bool verificarTamaño(Button b) {
            if ((b.ForeColor == Color.FromArgb(192, 255, 54)))
                return true;
            return false;
        }

        static public void click(Button b) {

         

        }


    }

    public class ButtonMenu : Button{

        private Button b;
        private bool estado = false;


        public ButtonMenu(Button b) {
            this.b = b;
            this.estado = false;
        }
        public Button B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }


        
        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
