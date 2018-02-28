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
    public partial class AgregarInformacionCedula : Form
    {
        int idCedula;
        public AgregarInformacionCedula(int cedula)
        {
            InitializeComponent();
            this.idCedula = cedula;
            InitializeTimePicker();
        }
        private DateTimePicker time;
        private void InitializeTimePicker()
        {
           
            horaInicio.Format = DateTimePickerFormat.Time;
            horaInicio.ShowUpDown = true;
            horaInicio.Width = 100;
            horaFinal.Format = DateTimePickerFormat.Time;
            horaFinal.ShowUpDown = true;
            horaFinal.Width = 100;


        }
        private void AgregarInformacionCedula_Load(object sender, EventArgs e)
        {
            lblCedula.Text = idCedula.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.CedulaIdentidad c = new Entidades.CedulaIdentidad();
            c.IdCedula = int.Parse(lblCedula.Text);
            c.HoraInicio = horaInicio.Value;
            c.HoraFinal = horaFinal.Value;
            c.FechaReal = fechaReal.Value;
            c.Clima = comboBox1.Text;
            DAO.CedulaIdentidad.agregarInformacionAdicionalCedula(c);
            MessageBox.Show(this,"Informacion agregada correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
