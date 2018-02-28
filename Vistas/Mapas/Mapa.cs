using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Mapas
{
    public partial class Mapa : Form
    {
        Image originalImage;
        Image scaledImage;
        Image zoomedImage;

        BotonBloque activeBloque;
        BotonSeccion activeSeccion;

        private Point previousLocation;
        Point cursorForm;
        Point punto;

        List<Entidades.Lote> listaLotes;
        List<Entidades.Bloque> listaBloques;
        List<Entidades.Seccion> listaSecciones;

        Entidades.Lote lote;
        Entidades.Bloque bloque;
        Entidades.Seccion seccion;

        int zoom;

        public Mapa()
        {
            zoom = 1;
            InitializeComponent();

            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            cargarComboLotes();
            // reduce flickering
            this.DoubleBuffered = true;
        }

        public void cargarComboLotes()
        {
            comboLotes.Items.Clear();
            listaLotes = DAO.Lote.buscarLotes();
            foreach (Entidades.Lote l in listaLotes)
            {
                comboLotes.Items.Add(l.IdLote);
            }
        }
        public void guardarLote(Entidades.Lote lote)
        {
            DAO.Lote.insertar(lote);
            cargarComboLotes();
            comboLotes.Text = lote.IdLote;
        }
        public void editarLote(Entidades.Lote lote) {
            //lote = DAO.Lote.BuscarLote(lote.IdLote);
            if (lote.Imagen == null) { DAO.Lote.modificarNoImagen(lote); }
            else { DAO.Lote.modificar(lote); }
            cargarLote(zoom);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        public void guardarBloque(Entidades.Bloque bloque) {
            DAO.Bloque.insertar(bloque);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        public void editarBloque(Entidades.Bloque bloque)
        {
            DAO.Bloque.modificar(bloque);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
        }
        public void eliminarBloque(Entidades.Bloque bloque)
        {
            DAO.Bloque.eliminar(bloque);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        public void guardarSeccion(Entidades.Seccion seccion) {
            DAO.Seccion.insertar(seccion);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        public void editarSeccion(Entidades.Seccion seccion) {
            DAO.Seccion.modificar(seccion);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        public void eliminarSeccion(Entidades.Seccion seccion)
        {
            DAO.Seccion.eliminar(seccion);
            lote = DAO.Lote.BuscarLote(lote.IdLote);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }


        void mouseDownBloque(object sender, MouseEventArgs e)
        {
            activeBloque = sender as BotonBloque;
            activeBloque.BringToFront();
            previousLocation = e.Location;
            Cursor = Cursors.Hand;
        }
        void mouseMoveBloque(object sender, MouseEventArgs e)
        {
            cursorForm = this.PointToClient(Cursor.Position);
            if (activeBloque == null || activeBloque != sender || !checkEditar.Checked)
            { return; }

            var location = activeBloque.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            if (location.X < 0) { location.X = 0; }
            if (location.X > pictureBox1.Width - activeBloque.Width) { location.X = pictureBox1.Width - activeBloque.Width; }
            if (location.Y < 0) { location.Y = 0; }
            if (location.Y > pictureBox1.Height - activeBloque.Height) { location.Y = pictureBox1.Height - activeBloque.Height; }
            activeBloque.Location = location;

        }
        void mouseUpBloque(object sender, MouseEventArgs e)
        {
            activeBloque = sender as BotonBloque;
            if (activeBloque.Bloque != null || !checkEditar.Checked)
            {
                //activeBloque.Bloque.PosX = activeBloque.Location.X / zoom;
                //activeBloque.Bloque.PosY = activeBloque.Location.Y / zoom;
                Point punto = getOriginalPosition(originalImage, zoomedImage, activeBloque.Location);
                activeBloque.Bloque.PosX = punto.X;
                activeBloque.Bloque.PosY = punto.Y;
                DAO.Bloque.cambiarLocation(activeBloque.Bloque);
                activeBloque.BringToFront();
                activeBloque = null;
                Cursor = Cursors.Default;
            }
        }
        void mouseDownSeccion(object sender, MouseEventArgs e)
        {
            activeSeccion = sender as BotonSeccion;
            activeSeccion.BringToFront();
            previousLocation = e.Location;
            Cursor = Cursors.Hand;
        }
        void mouseMoveSeccion(object sender, MouseEventArgs e)
        {
            cursorForm = this.PointToClient(Cursor.Position);
            if (activeSeccion == null || activeSeccion != sender || !checkEditar.Checked)
            { return; }

            var location = activeSeccion.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            if (location.X < 0) { location.X = 0; }
            if (location.X > pictureBox1.Width - activeSeccion.Width) { location.X = pictureBox1.Width - activeSeccion.Width; }
            if (location.Y < 0) { location.Y = 0; }
            if (location.Y > pictureBox1.Height - activeSeccion.Height) { location.Y = pictureBox1.Height - activeSeccion.Height; }
            activeSeccion.Location = location;

        }
        void mouseUpSeccion(object sender, MouseEventArgs e)
        {
            activeSeccion = sender as BotonSeccion;
            if (activeSeccion.Seccion != null || !checkEditar.Checked)
            //activeSeccion.Seccion.PosX = activeSeccion.Location.X/zoom;
            //activeSeccion.Seccion.PosY = activeSeccion.Location.Y/zoom;
            {
                Point punto = getOriginalPosition(originalImage, zoomedImage, activeSeccion.Location);
                activeSeccion.Seccion.PosX = punto.X;
                activeSeccion.Seccion.PosY = punto.Y;
                DAO.Seccion.cambiarLocation(activeSeccion.Seccion);
                activeSeccion.BringToFront();
                activeSeccion = null;
                Cursor = Cursors.Default;
                
            }
        }
        private void comboLotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoom = 1;
            cargarLote(zoom);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            AddLote al = new AddLote(this);
            al.ShowDialog();
        }
        private void btnEditarLote_Click(object sender, EventArgs e)
        {
            if (lote == null) { return; }
            EditLote el = new EditLote(this, lote);
            el.ShowDialog();
        }

        private void nuevoBloqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lote == null) { return; }
            AddBloque ab = new AddBloque(this, punto, lote);
            ab.ShowDialog();
        }

        private void nuevaSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaBloques == null) { return; }
            if (listaBloques.Count == 0) { return; }
            AddSeccion adds = new AddSeccion(this, punto, lote.IdLote);
            adds.ShowDialog();
        }
        public void reloadMapa()
        {
            cargarLote(zoom);
            cargarBloques(zoom);
            cargarSecciones(zoom);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { //punto = new Point(e.X/zoom, e.Y/zoom); 
                punto = getOriginalPosition(originalImage, zoomedImage, new Point(e.X, e.Y));
            }
            if (e.Button == MouseButtons.Left) {
                pressed = true;
                pos = new Point(e.X, e.Y);
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoom < 4) {
                zoom = zoom + 1;
                reloadMapa();
            }
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 1)
            {
                zoom = zoom - 1;
                reloadMapa();
            }
        }
        void cargarLote(int zoom)
        {
            if (comboLotes.SelectedIndex == -1) return;
            lote = listaLotes[comboLotes.SelectedIndex];
            lote.Imagen = DAO.Lote.getImagen(lote.IdLote);
            pictureBox1.Controls.Clear();
            try
            {
                Size size = new Size(panel1.Width, panel1.Height);
                originalImage = lote.Imagen;
                scaledImage = ScaleImage(originalImage, panel1.Width, panel1.Height);
                zoomedImage = ZoomImage(scaledImage, zoom);
                pictureBox1.Image = zoomedImage;
            }
            catch { pictureBox1.Image = Vistas.Properties.Resources.sergio; }
        }
        public Bitmap ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
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
        Point getOriginalPosition(Image original, Image zoomed, Point p)
        {
            double x = original.Width * p.X / zoomed.Width;
            double y = original.Height * p.Y / zoomed.Height;
            return new Point((int)x, (int)y);
        }
        Point getScaledPosition(Image original, Image zoomed, Point p)
        {
            double x = zoomed.Width * p.X / original.Width;
            double y = zoomed.Height * p.Y / original.Height;
            return new Point((int)x, (int)y);
        }
        void cargarBloques(int zoom)
        {
            if (comboLotes.SelectedIndex == -1) return;
            pictureBox1.Controls.Clear();
            listaBloques = DAO.Bloque.buscarBloqueLista(lote.IdLote);
            foreach (Entidades.Bloque bloque in listaBloques)
            {
                BotonBloque b = new BotonBloque(this, bloque);
                b.MouseDown += new MouseEventHandler(bloqueClick);
                b.MouseDown += new MouseEventHandler(mouseDownBloque);
                b.MouseUp += new MouseEventHandler(mouseUpBloque);
                b.MouseMove += new MouseEventHandler(mouseMoveBloque);

                //Point p = new Point(b.Location.X * zoom, b.Location.Y * zoom);
                Point p = getScaledPosition(originalImage, zoomedImage, b.Location);
                if (p.X < 0) { p.X = 0; }
                if (p.X > pictureBox1.Width - 40) { p.X = pictureBox1.Width - 40; }
                if (p.Y < 0) { p.Y = 0; }
                if (p.Y > pictureBox1.Height - 60) { p.Y = pictureBox1.Height - 60; }
                b.Location = p;
                b.ContextMenuStrip = menuBloque;
                pictureBox1.Controls.Add(b);
            }
        }
        void cargarSecciones(int zoom)
        {
            if (comboLotes.SelectedIndex == -1) return;


            listaSecciones = DAO.Seccion.buscarSeccionLista(lote.IdLote);
            foreach (Entidades.Seccion s in listaSecciones)
            {
                BotonSeccion b = new BotonSeccion(this, s);
                b.MouseDown += new MouseEventHandler(seccionClick);
                b.MouseDown += new MouseEventHandler(mouseDownSeccion);
                b.MouseUp += new MouseEventHandler(mouseUpSeccion);
                b.MouseMove += new MouseEventHandler(mouseMoveSeccion);

                Point p = getScaledPosition(originalImage, zoomedImage, b.Location);
                if (p.X < 0) { p.X = 0; }
                if (p.X > pictureBox1.Width - 40) { p.X = pictureBox1.Width - 40; }
                if (p.Y < 0) { p.Y = 0; }
                if (p.Y > pictureBox1.Height - 60) { p.Y = pictureBox1.Height - 60; }
                b.Location = p;
                b.ContextMenuStrip = menuSeccion;
                pictureBox1.Controls.Add(b);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBloque eb = new EditBloque(this, bloque);
            eb.ShowDialog();
        }
        void bloqueClick(object sender, MouseEventArgs e)
        {
            BotonBloque b = (BotonBloque)sender;
            bloque = b.Bloque;
        }
        void seccionClick(object sender, MouseEventArgs e)
        {
            BotonSeccion b = (BotonSeccion)sender;
            seccion = b.Seccion;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditSeccion es = new EditSeccion(this, seccion);
            es.ShowDialog();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fechaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloqueManager bm = new BloqueManager(lote, bloque);
            bm.ShowDialog();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            if (comboLotes.SelectedIndex == -1) return;
            BloqueManager bm = new BloqueManager(lote, this);
            bm.ShowDialog();
        }

        bool pressed = false;
        Point pos;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            pressed = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                int izquierda = pos.X * zoom - e.X * zoom;
                int derecha = e.X * zoom - pos.X * zoom;
                int arriba = pos.Y * zoom - e.Y * zoom;
                int abajo = e.Y * zoom - pos.Y * zoom;

                if (mayor(izquierda, derecha, arriba, abajo)) { try { panel1.HorizontalScroll.Value += 3; } catch { } }
                if (mayor(derecha, izquierda, arriba, abajo)) { try { panel1.HorizontalScroll.Value -= 3; } catch { } }
                if (mayor(abajo, derecha, arriba, izquierda)) { try { panel1.VerticalScroll.Value += 3; } catch { } }
                if (mayor(arriba, derecha, izquierda, abajo)) { try { panel1.VerticalScroll.Value -= 3; } catch { } }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }
        bool mayor(int a, int b, int c, int d) {
            if (a > b && a > c && a > d) { return true; }
            return false;
        }

        private void Mapa_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width - panel2.Width;
            panel1.Height = this.Height;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Desea eliminar permanentemente este lote?", "Aceptar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DAO.Lote.comprobarLote(lote.IdLote)) { 
                    MessageBox.Show("No se puede eliminar el lote tiene cedulas en proceso");
                    return;
                }
                else
                  DAO.Lote.eliminar(lote);
                lote = null;
                cargarComboLotes();
                zoom = 1;
                pictureBox1.Controls.Clear();
                pictureBox1.Image = null;
            } }
        
        catch{
                MessageBox.Show("Debe seleccionar un lote", "Error");


        }
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            Grupos.Grupos g = new Grupos.Grupos();
            g.ShowDialog();
        }

        private void checkEditar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



/*void cargarBloques()
        {
            listaBloques = DAO.Bloque.buscarBloqueLista(lote.IdLote);
            foreach (Entidades.Bloque bloque in listaBloques)
            {
                BotonBloque b = new BotonBloque(this, bloque);
                b.MouseDown += new MouseEventHandler(mouseDownBloque);
                b.MouseUp += new MouseEventHandler(mouseUpBloque);
                b.MouseMove += new MouseEventHandler(mouseMoveBloque);
                pictureBox1.Controls.Add(b);
            }
        }
        void cargarSecciones()
        {
            listaSecciones = DAO.Seccion.buscarSeccionLista(lote.IdLote);
            foreach (Entidades.Seccion s in listaSecciones)
            {
                BotonSeccion b = new BotonSeccion(this, s);
                b.MouseDown += new MouseEventHandler(mouseDownSeccion);
                b.MouseUp += new MouseEventHandler(mouseUpSeccion);
                b.MouseMove += new MouseEventHandler(mouseMoveSeccion);
                pictureBox1.Controls.Add(b);
            }
        }*/



/*
        lote = listaLotes[comboLotes.SelectedIndex];
        pictureBox1.Controls.Clear();
        try
        {
            pictureBox1.Image = Image.FromFile(lote.Imagen);
        }
        catch { pictureBox1.Image = Vistas.Properties.Resources.sergio; }
        cargarBloques();
        cargarSecciones();*/
