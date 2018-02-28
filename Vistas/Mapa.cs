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
using Vistas.Mapas;

namespace Vistas
{
    public partial class Mapa : Form
    {
        List<Entidades.Lote> lotes;
        List<BotonMapa> botones = new List<BotonMapa>();
        List<Entidades.Seccion> secciones = new List<Entidades.Seccion>();
        List<Entidades.Bloque> bloques = new List<Entidades.Bloque>();
        static public List<Entidades.Seccion> listActual = new List<Entidades.Seccion>();
        Entidades.Lote loteActual;
        ToolTip toolTip1 = new ToolTip();
       
        Image originalImage;
        Image scaledImage;
        Image zoomedImage;
        bool errorAgregando = false;
      

        static public List<Entidades.Seccion> seccionesSeleccionadas = new List<Entidades.Seccion>();

        int zoom;
        public Mapa()
        {
            InitializeComponent();
            try
            {
                lotes = DAO.Lote.buscarLotes();
            }
            catch { }
            cargarCombo(lotes);
            zoom = 1;
            this.DoubleBuffered = true;

        }
        void cargarCombo(List<Entidades.Lote> lista)
        {
            foreach (Entidades.Lote l in lista)
            {
                cmbLote.Items.Add(l.IdLote);
            }
        }
        private void borraControles()
        {
            // NOTE: The code below uses the instance of 
            // the button (newPanelButton) from the previous example.
            foreach (BotonMapa b in botones)
            {
                if (pictureBox1.Controls.Contains(b))
                {
                    pictureBox1.Controls.Remove(b);

                }

            }

        }
        void cargarBloques(string lote)
        {

            bloques = DAO.Bloque.buscarBloqueLista(lote);
            BotonMapa b;
            foreach (Entidades.Bloque bloque in bloques)
            {
                b = new BotonMapa(bloque);
                b.Click += new EventHandler(clickBloque);
                toolTip1.SetToolTip(b, " Area: " + bloque.Area + "\n Numero de Plantas: " + bloque.NumPlantas);
                //b.Location = calcularTamaño(b);
                Point p = getScaledPosition(originalImage, zoomedImage, b.Location);
                if (p.X < 0) { p.X = 0; }
                if (p.X > pictureBox1.Width - 40) { p.X = pictureBox1.Width - 40; }
                if (p.Y < 0) { p.Y = 0; }
                if (p.Y > pictureBox1.Height - 60) { p.Y = pictureBox1.Height - 60; }
                b.Location = p;
                pictureBox1.Controls.Add(b);
                b.BringToFront();
                b.Font = new Font(b.Font, FontStyle.Underline); botones.Add(b);
                //agregarBloqueTabla(b, true);

            }
        }


        public Bitmap ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxWidth / image.Height;//maxheight
            var ratio = Math.Min(ratioX, ratioY);
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            Bitmap bmp = new Bitmap(newImage);

            return bmp;
        }
        public Bitmap ZoomImage(Image image, int zoom)
        {
            var newWidth = (int)(image.Width * zoom);
            var newHeight = (int)(image.Height * zoom);
            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            Bitmap bmp = new Bitmap(newImage);

            return bmp;
        }
       
        void cargarSeccion(string lote)
        {
            secciones = DAO.Seccion.buscarSeccionPorLote(lote);
            BotonMapa b;
            foreach (Entidades.Seccion nombre in secciones)
            {

                b = new BotonMapa(nombre);
                b.Name = nombre.IdBloque + "." + nombre.IdSeccion;
                b.Click += new EventHandler(clickSeccion);
                toolTip1.SetToolTip(b, " Area: " + nombre.Area + "\n Numero de Plantas: " + nombre.NumPlantas);
                //b.Location = calcularTamaño(b);
                Point p = getScaledPosition(originalImage, zoomedImage, b.Location);
                if (p.X < 0) { p.X = 0; }
                if (p.X > pictureBox1.Width - 40) { p.X = pictureBox1.Width - 40; }
                if (p.Y < 0) { p.Y = 0; }
                if (p.Y > pictureBox1.Height - 60) { p.Y = pictureBox1.Height - 60; }
                b.Location = p;
                pictureBox1.Controls.Add(b);
                b.BringToFront();
                generarFechaSiguiente(b);
                botones.Add(b);
            }
        }
       
        void acomodarPosicion()
        {

            foreach (BotonMapa b in botones)
            {
                if (pictureBox1.Controls.Contains(b)) { pictureBox1.Controls.Remove(b); }
                Point p;
                if (b.Bloque != null) { p = getScaledPosition(originalImage, zoomedImage, new Point(b.Bloque.PosX, b.Bloque.PosY)); }
                else { p = getScaledPosition(originalImage, zoomedImage, new Point(b.Seccion.PosX, b.Seccion.PosY)); }
                if (p.X < 0) { p.X = 0; }
                if (p.X > pictureBox1.Width - 40) { p.X = pictureBox1.Width - 40; }
                if (p.Y < 0) { p.Y = 0; }
                if (p.Y > pictureBox1.Height - 60) { p.Y = pictureBox1.Height - 60; }
                b.Location = p;
                pictureBox1.Controls.Add(b);
                b.BringToFront();
                //  agregarSeccionTabla(b, true);      
            }
        }
        void agregarSeccionesTabla()
        {
            dataSecciones.Rows.Clear();
            DataGridViewRow r = new DataGridViewRow();

            foreach (Entidades.Seccion s in listActual)
            {

                dataSecciones.Rows.Add(conf.weekNumber(s.FechaProgramada), s.IdSeccion, s.IdBloque, s.GrupoForza, s.Paquete, s.Posicion + 1, s.Aplicacion, s.FechaProgramada);
                if (s.Bloqueo == true)
                    dataSecciones.Rows[dataSecciones.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            }
            }
        
        private void Mapa_Load(object sender, EventArgs e)
        {
            conf.evitarOrdenar(ref dataSecciones);
        }
       
     
        void agregarBloqueTabla(BotonMapa b)
        {
            quitarBloqueTabla(b);
            foreach (var button in botones.Where(bo => bo.Seccion.IdBloque == b.Bloque.IdBloque))
            {
                try
                {
                    listActual.Add(DAO.Fechas.obtenerFechaSiguiente(button.seccion));
                    button.Font = new Font(button.Font, FontStyle.Underline);
                }
                catch { }
                }
            b.Font = new Font(b.Font, FontStyle.Underline);
        }
       
        void quitarBloqueTabla(BotonMapa b)
        {
            foreach (var button in botones.Where(bo => bo.Seccion.IdBloque == b.Bloque.IdBloque))
            {
                button.Font = new Font(button.Font, FontStyle.Regular);
            }
            listActual = listActual.Where(bo => bo.IdBloque != b.Bloque.IdBloque).ToList();
        }

      void generarFechaSiguiente(BotonMapa b)
        {
            try
            {
                listActual.Add(DAO.Fechas.obtenerFechaSiguiente(b.seccion));
                agregarSeccionesTabla();
                b.Font = new Font(b.Font, FontStyle.Underline);

            }
            catch {
                b.ForeColor = Color.Red;
                return;
            }
        }
       
        void limpiarUnderLine()
        {
            foreach (BotonMapa boton in botones)
            {
                boton.Font = new Font(boton.Font, FontStyle.Regular);

            }
        }
        void cargarLote(int zoom)
        {

            pictureBox1.Controls.Clear();
            try
            {
                Size size = new Size(panel2.Width, panel2.Height);
                originalImage = loteActual.Imagen;
                scaledImage = ScaleImage(originalImage, panel2.Width, panel2.Height);
                zoomedImage = ZoomImage(scaledImage, zoom);
                pictureBox1.Image = zoomedImage;
            }
            catch { }
        }
        
        void clickSeccion(object sender, EventArgs e)
        {
            BotonMapa b = (BotonMapa)sender;
            
            if (!b.Font.Underline)
            {
                try
                {
                    listActual.Add(DAO.Fechas.obtenerFechaSiguiente(b.seccion));
                    b.Font = new Font(b.Font, FontStyle.Underline);
                    agregarSeccionesTabla();
                }
                catch { MessageBox.Show("Esta seccion no puede ser aplicada"); }
            }
            else
            {
                
                Entidades.Seccion s = listActual.Where(se => se.IdBloque == b.seccion.IdBloque && se.IdSeccion == b.seccion.IdSeccion).First();
                listActual.Remove(s);
                b.Font = new Font(b.Font, FontStyle.Regular);
                agregarSeccionesTabla();

            }
        }
        void clickBloque(object sender, EventArgs e)
        {
            BotonMapa b = (BotonMapa)sender;

            if (!b.Font.Underline)
            {
                agregarBloqueTabla(b);
                agregarSeccionesTabla();
            }
            else
            {

                quitarBloqueTabla(b);
                b.Font = new Font(b.Font, FontStyle.Regular);
                agregarSeccionesTabla();
            }
        }
        
        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (buscarCoincidencia())
            {
                try
                {
                    CrearCedulaIdentidad m = new CrearCedulaIdentidad(DAO.DetalleAplicacion.getDetallePaquetePosicion(listActual[0].Paquete, listActual[0].Posicion+1), listActual, false, this);
                    m.ShowDialog();
                }
                catch
                {

                    MessageBox.Show(this, "Informacion incompleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, "Las secciones deben de tener la misma posicion, grupo y etapa o puede que esten bloqueadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }
        bool buscarCoincidencia()
        {
            if (listActual.Count == 0) return false;
            int posicion = listActual[0].Posicion;
            string grupoForza = listActual[0].GrupoForza;
            string paquete = listActual[0].Paquete;

            foreach (Entidades.Seccion s in listActual)
            {
                if (s.Bloqueo == true)
                    return false;
                if (posicion == s.Posicion)
                    posicion = s.Posicion;
                else
                    return false;
                if (grupoForza.Equals(s.GrupoForza))
                    grupoForza = s.GrupoForza;
                else
                    return false;
                if (paquete.Equals(s.Paquete))
                    paquete = s.Paquete;
                else
                    return false;

            }
            return true;

        }
     
        private void cmbLote_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarMapa();


        }
        private void otraAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listActual.Count == 0) return;
            Entidades.Aplicacion a = cargarNuevaAplicacion();
            if (a != null)
            {
                CrearCedulaIdentidad m = new CrearCedulaIdentidad(a, listActual, true, this);
                m.ShowDialog();
            }
            else {
                MessageBox.Show(this, "Informacion incompleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        Entidades.Aplicacion cargarNuevaAplicacion()
        {

            ElegirAplicacion c = new ElegirAplicacion();
            DialogResult res = c.ShowDialog();
            if (res == DialogResult.OK)
            {

                return c.aplicacion;
            }
            return null;
        }


        void actualizarMapa()
        {

            try
            {
                secciones.Clear();
                bloques.Clear();
                listActual.Clear();
                seccionesSeleccionadas.Clear();
                dataSecciones.Rows.Clear();
                progressBar1.Value = 0;
                borraControles();
                botones.Clear();

                loteActual = lotes.Where(l => l.IdLote == cmbLote.SelectedItem.ToString()).First();
                loteActual.Imagen = DAO.Lote.getImagen(loteActual.IdLote);
                progressBar1.Value += 10;
                cargarLote(zoom);
                //  ChangePictureBoxImage(opcMapa.l.Imagen);
                cargarSeccion(loteActual.IdLote);
                progressBar1.Value += 40;
                cargarBloques(loteActual.IdLote);
                progressBar1.Value += 50;
                toolTip1.AutoPopDelay = 0;
                toolTip1.InitialDelay = 0;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;

                if (errorAgregando == true)
                {
                    MessageBox.Show(this, "Algunas secciones cuentan con algun problema: \n 1.Debe de agregar un paquete. \n 2.Ya termino el paquete.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorAgregando = false;
                }

            }
            catch (Exception ex)
            {


            }


        }
        
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoom < 4)
            {
                try
                {
                    //borraControles();
                    zoom = zoom + 1;
                    cargarLote(zoom);
                    acomodarPosicion();



                }
                catch
                {

                    zoom = zoom - 1;
                }
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 1)
            {
                try
                {
                    zoom = zoom - 1;
                    //borraControles();

                    cargarLote(zoom);
                    acomodarPosicion();
                }
                catch
                {

                    zoom = zoom + 1;
                }
            }
        }

        private void chkItemsLote_CheckedChanged(object sender, EventArgs e)
        {

            if (chkItemsLote.Checked == true)
            {
                
                actualizarMapa();

            }
            else
            {

                dataSecciones.Rows.Clear();
                limpiarUnderLine();
                listActual.Clear();
            }
        }
        
        Point getScaledPosition(Image original, Image zoomed, Point p)
        {
            double x = zoomed.Width * p.X / original.Width;
            double y = zoomed.Height * p.Y / original.Height;
            return new Point((int)x, (int)y);
        }

        private void Mapa_SizeChanged(object sender, EventArgs e)
        {
            panel2.Width = this.Width - panelZoom.Width;
            panel2.Height = this.Height - panelCosas.Height;
        }

       
       

        private void btnEditarLote_Click(object sender, EventArgs e)
        {
            try
            {
                DetallesLote l = new DetallesLote(loteActual);
                l.ShowDialog();
            }
            catch {
                MessageBox.Show("Debe seleccionar un lote");
            }

        }

        private void dataSecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
