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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void Logo_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
            label2.ForeColor = Color.FromArgb(192, 255, 54);
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          
            if (timer1.Interval== 2000) {
             
                this.Dispose();
                timer1.Stop();
                }
          
              
         
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
