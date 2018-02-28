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
    public partial class Notificaciones : Form
    {

        private int estado = 0;

        public int Estado
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

        public Notificaciones()
        {          
            InitializeComponent();
        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {

        }

        private void Notificaciones_Leave(object sender, EventArgs e)
        {
            Hide();
        }

        private void Notificaciones_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }

        private void Notificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
