using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.PaqueteAplicacion
{
    public partial class CrearPaquete : Form
    {
        Entidades.Paquete paquete;
        PaqueteForm padreForm;
        public CrearPaquete(PaqueteForm padre)
        {
            padreForm = padre;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdPaquete.Text == "")
            {

                MessageBox.Show(this, "Debe de suministrar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    paquete = new Entidades.Paquete();
                    paquete.IdPaquete = txtIdPaquete.Text;
                    paquete.Descripcion = txtDescripcion.Text;
                    DAO.Paquete.insertar(paquete);
                    padreForm.cargarCombo();
                    MessageBox.Show(this, "Paquete Creado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                catch
                {
                    MessageBox.Show(this, "Existe un paquete con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DAO.Conexion.CloseConnection();
                    txtIdPaquete.Focus();
                }

            }
        }
    }
}
