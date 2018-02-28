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
    public partial class LogoEspera : Form
    {
        Timer rotationTimer;
        Form next;
        int cont;
        public LogoEspera()
        {
            InitializeComponent();
            //initializing timer
            rotationTimer = new Timer();
            rotationTimer.Interval = 150;    //you can change it to handle smoothness
            rotationTimer.Tick += rotationTimer_Tick;

            //create pictutrebox events
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
        }

        private void LogoEspera_Load(object sender, EventArgs e)
        {
            rotationTimer.Start();
        }
        void rotationTimer_Tick(object sender, EventArgs e)
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            rotationTimer.Interval = 150;
            pictureBox1.Image = flipImage;
            cont++;
            if (rotationTimer.Interval < cont) {
                rotationTimer.Stop();

            }
           
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
