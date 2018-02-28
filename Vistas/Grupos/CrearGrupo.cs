using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Grupos
{
    public partial class CrearGrupo : Form
    {
        Grupos padre;
        public CrearGrupo(Grupos padre)
        {
            this.padre = padre;
            InitializeComponent();
            cargarPaquetes();
            label2.Text = "Nombre no disponible";
            label2.ForeColor = Color.DarkRed;
            txtIdGrupo.BackColor = Color.Red;
            btnAceptar.Enabled = false;
        }
        void cargarPaquetes()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Sin Paquete");
            foreach (Entidades.Paquete p in DAO.Paquete.lista("%")) { comboBox1.Items.Add(p.IdPaquete); }
            comboBox1.Text = "Sin Paquete";
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.GrupoForza g = new Entidades.GrupoForza();
            g.IdGrupo = txtIdGrupo.Text;
            g.Paquete = comboBox1.Text;
            g.Fecha = dateTimePicker1.Value;
            g.PeriodoCosecha = dateTimePicker2.Value;
            this.padre.crearGrupo(g);
            this.Close();
        }

        private void txtIdGrupo_TextChanged(object sender, EventArgs e)
        {
            Entidades.GrupoForza g = new Entidades.GrupoForza { IdGrupo = txtIdGrupo.Text };
            if (txtIdGrupo.Text == "" || DAO.GrupoForza.comprobarGrupo(g))
            {
                txtIdGrupo.BackColor = Color.Red;
                btnAceptar.Enabled = false;
                label2.Text = "Nombre no diponible";
                label2.ForeColor = Color.DarkRed;
            }
            else
            {
                label2.Text = "Nombre disponible";
                label2.ForeColor = Color.Green;
                txtIdGrupo.BackColor = SystemColors.Window;
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(147);
        }

        private void CrearGrupo_Load(object sender, EventArgs e)
        {

        }
    }
}
