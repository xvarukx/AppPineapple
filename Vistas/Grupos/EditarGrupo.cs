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
    public partial class EditarGrupo : Form
    {
        Grupos padre;
        Entidades.GrupoForza grupo;
        public EditarGrupo(Grupos padre, string g)
        {
            this.padre = padre;
            grupo = DAO.GrupoForza.getGrupo(g);
            InitializeComponent();

            cargarPaquetes();

            txtIdGrupo.Text = grupo.IdGrupo;
            comboBox1.Text = grupo.Paquete;
            dateTimePicker1.Value = grupo.Fecha;
            dateTimePicker2.Value = grupo.PeriodoCosecha;
        }
        void cargarPaquetes()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Sin Paquete");
            foreach (Entidades.Paquete p in DAO.Paquete.lista("%")) { comboBox1.Items.Add(p.IdPaquete); }
            comboBox1.Text = "Sin Paquete";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { comboBox1.Enabled = true;  dateTimePicker1.Enabled = true; dateTimePicker2.Enabled = true; }
            if (!checkBox1.Checked) { comboBox1.Enabled = false;  dateTimePicker1.Enabled = false; dateTimePicker2.Enabled = true; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) { this.Close(); }
            grupo.Fecha = dateTimePicker1.Value;
            grupo.Paquete = comboBox1.Text;
            grupo.PeriodoCosecha = dateTimePicker2.Value;
            padre.editarGrupo(grupo);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(147);
        }
    }
}
