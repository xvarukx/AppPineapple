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
    public partial class Login : Form
    {
        public Entidades.Usuario u = new Entidades.Usuario() {
            IdUsuario ="",
            Tipo =""
        };

        public Login()
        {
            InitializeComponent();
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            u = new Entidades.Usuario();
            u.IdUsuario = txtUser.Text;
            u.Pass = txtPass.Text;
            u.Tipo = "";
            
            if (DAO.Usuario.Validar(u))
            {
                u = DAO.Usuario.buscarUsuario(u.IdUsuario);
                MessageBox.Show("Bienvenido "+u.IdUsuario,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Combinacion de Usuario/Contraseña no valida");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btbIngresar_Click(sender, e);
            }
        }
    }
}
