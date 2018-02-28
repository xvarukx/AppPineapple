using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Fechas
{
    public partial class Calendario : Form
    {

        List<Button> botones = new List<Button>();
        List<Entidades.Fecha> listActual = new List<Entidades.Fecha>();
        List<Entidades.Pedido> pedido = new List<Entidades.Pedido>();
        List<Entidades.DetalleAplicacion> detalles = new List<Entidades.DetalleAplicacion>();
        int mesActual, anoActual;
        List<Entidades.Seccion> secciones;
        enum dias
        {
            Lunes = 0,
            Martes = 75,
            Miercoles = 150,
            Jueves = 225,
            Viernes = 300,
            Sabado = 375,
            Domingo = 450
        };
        public Calendario()
        {
            InitializeComponent();
            
            conf.evitarOrdenar(ref dataGridView1);
            mesActual = DateTime.Now.Month;
            cmbMes.SelectedIndex = mesActual-1;
            anoActual = DateTime.Now.Year;      

            // cmbLote.SelectedIndex = 0;

            /*DateTime prueba = new DateTime(int.Parse(cmbAno.Text), 12, 31);
            int x = conf.weekNumber(prueba);
            cargarSemanas(x);
            cmbSemanas.SelectedIndex = 0;*/

        }
        bool pintarHoy()
        {
            if (mesActual == DateTime.Today.Month && anoActual == DateTime.Today.Year) {
                return true;
            }
            return false;

        }
       
        void cargarSemanas() {
            cmbSemanas.Items.Clear();
            for (int x = 1; x <= 52; x++) {

                cmbSemanas.Items.Add(x);
            }

        }
        void cargarLotes()
        {
            List<Entidades.Lote> lotes = new List<Entidades.Lote>();
            cmbLote.Items.Add("Todos");
            try
            {
                lotes = DAO.Lote.buscarLotes();
            }
            catch { }
            foreach (Entidades.Lote l in lotes)
            {
                cmbLote.Items.Add(l.IdLote);
            }
            cmbLote.SelectedIndex = 0;
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
     
            cargarLotes();
            secciones = DAO.Fechas.obtenerSeccionesConPaquete();
            Entidades.Fecha.fechas = DAO.Fechas.obtenerFechas(secciones);
            listActual = Entidades.Fecha.busquedaPorMes(new DateTime(anoActual, mesActual, DateTime.DaysInMonth(anoActual, mesActual)), new DateTime(anoActual, mesActual, 1));
            cargarTabla(listActual);
           
            cargarSemanas();
            cmbSemanas.SelectedIndex = 0;
           
            cmbAno.SelectedText = DateTime.Now.Year.ToString();
            crearBotones();
        }

        void cargarTabla(List<Entidades.Fecha> fechas) {
            dataGridView1.Rows.Clear();
            foreach (Entidades.Fecha f in fechas)
            {
                dataGridView1.Rows.Add(f.Semana, f.Lote, f.Bloque, f.Seccion, f.Paquete, f.Posicion, f.IdAplicacion, f.Aplicacion, f.FechaProgramada);
                if (f.Bloqueo == true)
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
                if (f.Siguiente == true)
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.Font = new Font("", 8,FontStyle.Bold);
            }
            }

        Color pintarBoton(Button b)
        {
            foreach (Entidades.Fecha f in listActual)
            {
                if (b.Name.Equals(f.FechaProgramada.Day.ToString()))
                {
                    if (f.FechaProgramada > DateTime.Today.Date)
                    {
                        return Color.Green;

                    }
                    if (f.FechaProgramada < DateTime.Today.Date)
                    {
                        return Color.Yellow;

                    }
                }
                if (b.Name == DateTime.Today.Day.ToString() && pintarHoy()) {
                    return Color.Blue;
                }
            }
            return Color.White;
        }

        int calcularNumeroMes(string mes)
        {

            switch (mes) {
                case "Enero": return 1;
                case "Febrero":return 2;
                case "Marzo": return 3;
                case "Abril": return 4;
                case "Mayo": return 5;
                case "Junio": return 6;
                case "Julio": return 7;
                case "Agosto": return 8;
                case "Setiembre": return 9;
                case "Octubre": return 10;
                case "Noviembre": return 11;
                case "Diciembre": return 12;
                default:return 0;
            }
            

        }
        int encontrarDias(string dia) {
            switch (dia)
            {
                case "Monday": return (int)dias.Lunes;
                case "Tuesday": return (int)dias.Martes;
                case "Wednesday": return (int)dias.Miercoles;
                case "Thursday": return (int)dias.Jueves;
                case "Friday": return (int)dias.Viernes;
                case "Saturday": return (int)dias.Sabado;
                case "Sunday": return (int)dias.Domingo;

                default: return 0;
            }

        }
        void crearBotones()
        {
            panel1.Controls.Clear();
            botones.Clear();
            int X = 0, Y = 0;
            int cont=0;
            int semana=0;
            try
            {

                int mes = calcularNumeroMes(cmbMes.Text);
                DateTime dt2;
                DateTime dt;
                if (checkBox1.Checked)
                {
                    dt2 = Entidades.conf.GetMonthOfWeek(int.Parse(cmbAno.Text), int.Parse(cmbSemanas.Text));
                    dt = new DateTime(dt2.Year, dt2.Month, 1);
                    mesActual = dt2.Month;
                }
                else
                    dt = new DateTime(int.Parse(cmbAno.Text), mes, 1);
             
                X = encontrarDias(dt.DayOfWeek.ToString());
                cont = DateTime.DaysInMonth(dt.Year,dt.Month);
            }
            catch { }
            for (int x = 1; x <= cont ; x++)
            {
                if (X + 75 > ((panel1.Size.Width)))
                {
                    X = 0;
                    Y += 75;
                  
                }

                semana = conf.weekNumber(new DateTime(anoActual, mesActual, x));
                addSemana(X, Y, semana);
                Button b = new Button();

                b.Location = new Point(X, Y);
                b.Height = 75;
                b.Width = 75;
                b.Text = x.ToString();
                b.Name = x.ToString();
                b.Click += new EventHandler(click);
                X += 75;
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = pintarBoton(b);
                b.FlatAppearance.BorderSize = 1;
                b.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
                this.panel1.Controls.Add(b);
                botones.Add(b);
            }

        }

        void addSemana(int x,int y,int semana) {

            if (y == 0)
            {
                b1.Text = semana.ToString();
                b1.Visible = true;
            }
                if (y == 75) 
            { b2.Text = semana.ToString(); b2.Visible = true; }
            if (y == 150) { b3.Text = semana.ToString(); b3.Visible = true; }

            if (y == 225) { b4.Text = semana.ToString(); b4.Visible = true; }

            if (y == 300) { b5.Text = semana.ToString(); b5.Visible = true; }
        }
       

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            mesActual = calcularNumeroMes(cmbMes.Text);
    }
      
        void click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
           
            listActual = Entidades.Fecha.busquedaPorDia(new DateTime(anoActual, mesActual, int.Parse(b.Text)));
            cargarTabla(listActual);
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Pedido p = new Pedido(listActual);
            p.ShowDialog();

            
        }
      
       

        private void cmbLote_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semana = -1;
            if (checkBox1.Checked)

                semana = int.Parse(cmbSemanas.Text);
            if (!cmbLote.Text.Equals("Todos"))
            {
              

                listActual = Entidades.Fecha.busquedaPorLote(cmbLote.Text, new DateTime(anoActual, mesActual, DateTime.DaysInMonth(anoActual, mesActual)), new DateTime(anoActual, mesActual, 1), semana);



            }
            else {
                listActual = Entidades.Fecha.busquedaPorLoteTodos(new DateTime(anoActual, mesActual, DateTime.DaysInMonth(anoActual, mesActual)), new DateTime(anoActual, mesActual, 1), semana);
            }
                      
            cargarTabla(listActual);
            crearBotones();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            anoActual = int.Parse(cmbAno.Text);
            mesActual = calcularNumeroMes(cmbMes.Text);
            if (checkBox1.Checked)
                listActual = Entidades.Fecha.busquedaPorSemana(int.Parse(cmbSemanas.Text),anoActual);
            else
                listActual = Entidades.Fecha.busquedaPorMes(new DateTime(anoActual, mesActual, DateTime.DaysInMonth(anoActual, mesActual)), new DateTime(anoActual, mesActual, 1));
            cargarTabla(listActual);
            crearBotones();
      
        }

        private void cmbSemanas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        void generarFechaGrupos() {
            List<Entidades.Fecha> fechaGrupo= new List<Entidades.Fecha>();
            fechaGrupo = listActual.Where(f => f.Siguiente == true && f.Bloqueo == false && f.grupoForza != "Sin Grupo").ToList();
            if (fechaGrupo.Count == 0) return;
            List<string> grupos = fechaGrupo.Select(f => f.grupoForza).Distinct().ToList();
            List<int> posiciones = fechaGrupo.Select(f => f.Posicion).Distinct().ToList();
            List<string> paquetes = fechaGrupo.Select(f => f.Paquete).Distinct().ToList();
            foreach (var g in grupos) {
                foreach (var pa in paquetes)
                {
                    foreach (var p in posiciones)
                    {
                        imprimir(fechaGrupo.Where(fe => fe.grupoForza == g && fe.Posicion == p && fe.Paquete == pa).ToList());
                    }
                }
        }
        }
        void generarFechaSinGrupo()
        {
            List<Entidades.Fecha> fechaGrupo = new List<Entidades.Fecha>();
            fechaGrupo = listActual.Where(f => f.Siguiente == true && f.Bloqueo == false && f.grupoForza == "Sin Grupo").ToList();
            if (fechaGrupo.Count == 0) return;
            List<string> lotes = fechaGrupo.Select(f => f.Lote).Distinct().ToList();
            List<int> posiciones = fechaGrupo.Select(f => f.Posicion).Distinct().ToList();
            List<string> paquetes = fechaGrupo.Select(f => f.Paquete).Distinct().ToList();
            foreach (var l in lotes)
            {
                foreach (var pa in paquetes)
                {
                    foreach (var p in posiciones)
                    {
                        imprimir(fechaGrupo.Where(fe => fe.Lote == l && fe.Posicion == p && fe.Paquete == pa).ToList());
                    }
                }
            }
        }
     
        void imprimir(List<Entidades.Fecha> fechas) {
            string paquete = fechas[0].Paquete;
            int pos = fechas[0].Posicion;
            List<Entidades.Seccion> se = new List<Entidades.Seccion>();
            foreach (var f in fechas) {
                Entidades.Seccion s = new Entidades.Seccion();
                s.Aplicacion = f.Aplicacion;
                s.Area = f.Area;
                s.FechaProgramada = f.FechaProgramada;
                s.IdLote = f.Lote;
                s.IdBloque = f.Bloque;
                s.IdSeccion = f.Seccion;
                s.Posicion = f.Posicion;
                s.Paquete = f.Paquete;
                s.GrupoForza = f.grupoForza ;
                s.Bloqueo = f.Bloqueo;
                se.Add(s);

            }
            CrearCedulaIdentidad c = new CrearCedulaIdentidad(DAO.DetalleAplicacion.getDetallePaquetePosicion(paquete, pos),se, false, this);
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generarFechaGrupos();
            generarFechaSinGrupo();
        }
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
        void clickSemana(object sender) {

            Button l = (Button)sender;
          
                listActual = Entidades.Fecha.busquedaPorSemana(int.Parse(l.Text),anoActual);
                cargarTabla(listActual);
            
            }


        private void lblSegunda_Click(object sender, EventArgs e)
        {
           
        }

        private void lblTercera_Click(object sender, EventArgs e)
        {
          
        }

        private void lblCuarta_Click(object sender, EventArgs e)
        {
            
        }

        private void lblQuinto_Click(object sender, EventArgs e)
        {
          
        }

        private void b1_Click(object sender, EventArgs e)
        {
            clickSemana(sender);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            clickSemana(sender);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            clickSemana(sender);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            clickSemana(sender);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            clickSemana(sender);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                cmbMes.Enabled = false;
                cmbSemanas.Enabled = true;

            }
            else {

                cmbMes.Enabled = true;
                cmbSemanas.Enabled = false;
            }
        }
    }
}
