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
    public partial class NombreGrupoForza : Form
    {
        public Entidades.GrupoForza grupo = new  Entidades.GrupoForza(); List<Entidades.Seccion> seccion;

        bool modificar = false;
        public NombreGrupoForza()
        {
            InitializeComponent();
        }
        public NombreGrupoForza(Entidades.GrupoForza g,List<Entidades.Seccion> seccion)
        {
            InitializeComponent();
           
            modificar = true;
            btnGuardar.Text = "Modificar";
            txtGrupo.Text = g.IdGrupo;
            txtGrupo.Enabled = false;
            comboPaquetes.Text = g.Paquete;
            grupo.Lote = g.Lote;
            //dateTimePicker1.Value = g.Fecha;
            this.seccion = seccion;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            grupo = new Entidades.GrupoForza()
            {
                IdGrupo = txtGrupo.Text,
                Fecha = dateTimePicker1.Value.Date,
                Paquete = comboPaquetes.Text
                
            };
            if (modificar) {

                DAO.GrupoForza.actualizarGrupo(grupo);
                foreach (Entidades.Seccion s in seccion) {
                    DAO.Seccion.agregarGrupo(s, grupo.IdGrupo, grupo.Paquete, -1,grupo.Fecha);
                        }
            }
        }



        private void NombreGrupoForza_Load(object sender, EventArgs e)
        {
            cargarComboPaquetes();
        }
        public void cargarComboPaquetes()
        {
            comboPaquetes.Items.Clear();
            List<Entidades.Paquete> paquetes = DAO.Paquete.lista("%");
            foreach (Entidades.Paquete p in paquetes)
            {
                comboPaquetes.Items.Add(p.IdPaquete);
            }
        }
    }
}
