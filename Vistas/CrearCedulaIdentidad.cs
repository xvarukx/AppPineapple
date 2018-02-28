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

namespace Vistas
{
    public partial class CrearCedulaIdentidad : Form
    {
        List<Entidades.Seccion> secciones;
        double AreaTotal;
        List<string> listaTractor;
        List<string> listaChoferes;
        List<string> listaSprayBoom;
        DataTable dt;
        Form anterior;
        bool aplicacionExtra;
        int id;

        public CrearCedulaIdentidad(Entidades.DetalleAplicacion aplicacion, List<Entidades.Seccion> secciones, bool aplicacionExtra, Form f)
        {
            InitializeComponent();
                  
            anterior = f;
            id = aplicacion.IdAplicacion;
            this.aplicacionExtra = aplicacionExtra;
            this.secciones = secciones;
           
            etapa.Text = secciones[0].Paquete;
            lblSemanaProgramada.Text = conf.weekNumber(secciones[0].FechaProgramada).ToString(); 
            lblGrupo.Text = secciones[0].GrupoForza;
            lblAplicacion.Text = aplicacion.NombreAplicacion;
            lblFechaProgramada.Text = secciones[0].FechaProgramada.ToString("dd/MM/yyyy");
            lblCiclo.Text = aplicacion.Posicion.ToString();
            lblAplicacion.Text = (DAO.Aplicacion.buscarAplicacion(aplicacion.IdAplicacion)).Nombre;
            dt = DAO.PaqueteProducto.mostrarProductos(aplicacion.IdAplicacion,secciones[0].Paquete);
            dt.Columns.Add("Dosis Total");
            dt.Columns.Add("Costo Total");
            dataProductos.DataSource = dt;
            cargarTablaSeccion();
            lblAreaTotal.Text = AreaTotal.ToString();
            cargarTotalProducto();
            lblCedula.Text = DAO.CedulaIdentidad.obtenerSiguiente();
            listaTractor = DAO.Tractor.listaId("%");
            comboTractor.DataSource = listaTractor;
            listaChoferes = DAO.Empleado.listaId("%");
            comboChofer.DataSource = listaChoferes;
            listaSprayBoom = DAO.SprayBoom.listaId("%");
            comboSpray.DataSource = listaSprayBoom;
            lblTotalLitros.Text = (Double.Parse(txtAguaRequerida.Text) * Double.Parse(lblAreaTotal.Text)).ToString();
            this.Width = primerPanel.Width +50;
            lblLote.Text = secciones[0].IdLote.ToString();
            lblTotalboones.Text = (Double.Parse(lblTotalLitros.Text) / Double.Parse(lblCapacidad.Text)).ToString();
            calcularCostoTotal();
            segundoPanel.Size = primerPanel.Size;
            segundoPanel.Location = primerPanel.Location;

 
        }
    


        void cargarInformacion() {
           
        }


        public CrearCedulaIdentidad(Entidades.Aplicacion aplicacion, List<Entidades.Seccion> secciones, bool aplicacionExtra, Form f)
        {
            InitializeComponent();
            anterior = f;
            id = aplicacion.IdAplicacion;
            this.aplicacionExtra = aplicacionExtra;
            this.secciones = secciones;
            //  segundoPanel.Visible = false;
            lblGrupo.Text = "Sin Grupo";
            lblAplicacion.Text = aplicacion.Nombre;
            lblCiclo.Text = "0";
            etapa.Text = "Sin Etapa";
            lblSemanaProgramada.Text = conf.weekNumber(secciones[0].FechaProgramada).ToString();
            lblAplicacion.Text = (DAO.Aplicacion.buscarAplicacion(aplicacion.IdAplicacion)).Nombre;
            dt = DAO.PaqueteProducto.mostrarProductos(aplicacion.IdAplicacion,"Sin Paquete");
            dt.Columns.Add("Dosis Total");
            dt.Columns.Add("Costo Total");
            dataProductos.DataSource = dt;
            cargarTablaSeccion();
            lblAreaTotal.Text = AreaTotal.ToString();
            cargarTotalProducto();
            lblCedula.Text = DAO.CedulaIdentidad.obtenerSiguiente();
            listaTractor = DAO.Tractor.listaId("%");
            comboTractor.DataSource = listaTractor;
            listaChoferes = DAO.Empleado.listaId("%");
            comboChofer.DataSource = listaChoferes;
            listaSprayBoom = DAO.SprayBoom.listaId("%");
            comboSpray.DataSource = listaSprayBoom;
            lblTotalLitros.Text = (Double.Parse(txtAguaRequerida.Text) * Double.Parse(lblAreaTotal.Text)).ToString();
            this.Width = primerPanel.Width+50; 
            lblLote.Text = secciones[0].IdLote.ToString();
            lblFechaProgramada.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
         
            lblTotalboones.Text = (Double.Parse(lblTotalLitros.Text) / Double.Parse(lblCapacidad.Text)).ToString();
            calcularCostoTotal();

            segundoPanel.Size = primerPanel.Size;
            segundoPanel.Location = primerPanel.Location;
        }
     
        void calcularCostoTotal() {
            lblCosto.Text = "0";
            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {

                try
                {
                    lblCosto.Text = (Convert.ToDouble(row.Cells["Costo Total"].Value) + double.Parse(lblCosto.Text)).ToString();
                }
                catch { }
             
            }


        }
        public CrearCedulaIdentidad(Entidades.CedulaIdentidad c)
        {
            InitializeComponent();
            dataProductos.DataSource = DAO.CedulaIdentidad.mostrarProductosCedula(c);
            dataGridView2.DataSource = DAO.CedulaIdentidad.mostrarSeccionesCedula(c);
            
        }


        void cargarTotalProducto()
        {

            DataGridViewRow dr = null;
            for (int x = dataProductos.RowCount - 1; 0 <= x; x--)
            {

                dr = dataProductos.Rows[x];

                double dosis = Convert.ToDouble(dr.Cells["Dosis(H)"].Value);
                dr.Cells["Dosis Total"].Value = AreaTotal * dosis;
                dr.Cells["Costo Total"].Value = Convert.ToDouble(dr.Cells["Dosis Total"].Value) * Convert.ToDouble(dr.Cells["Costo(UM)"].Value);


            }

        }
        void cargarTablaSeccion()
        {

            foreach (Entidades.Seccion s in secciones)
            {
                dataGridView2.Rows.Add(s.IdLote, s.IdBloque, s.IdSeccion, s.Area);
                AreaTotal += s.Area;
            }





        }
        private void CrearCedulaIdentidad_Load(object sender, EventArgs e)
        {
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            DateTime fecha = DateTime.Today.Date;
            lblFechaActual.Text = fecha.ToString("dd/MM/yyyy");
            lblSemana.Text = conf.weekNumber(fecha).ToString();

            try
            {
                cmbCultivo.SelectedIndex = 0;
            }
            catch
            {
            
            }
        }

      
        private void label10_Click(object sender, EventArgs e)
        {

        }
        bool buscarCoincidencia(string id)
        {

            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {

                if (row.Cells["idProducto"].Value.Equals(id))
                {
                    MessageBox.Show("El Producto ya se encuentra en la tabla");
                    return false;
                }

            }
            return true;

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (segundoPanel.Visible == true)
            {
                DialogResult result = MessageBox.Show("Desea Crear esta cedula de Aplicacion", "Crear Cedula", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {

                    try {
                        DAO.CedulaIdentidad.insertarCedula(new Entidades.CedulaIdentidad()
                        {

                            FechaProgramada = DateTime.Parse(lblFechaProgramada.Text),
                            JustMuestreo = chkMuestreo.Checked,
                            JustProgramacion = chkJustificacion.Checked,
                            LtsRequeridos = Double.Parse(txtAguaRequerida.Text),
                            TotalLtsRequeridos = Double.Parse(lblTotalLitros.Text),
                            TotalBoonesRequeridos = Double.Parse(lblTotalboones.Text),
                            Cultivo = cmbCultivo.Text,
                            Chofer = comboChofer.Text,
                            NumSpray = comboSpray.Text,
                            NumTractor = comboTractor.Text,
                            NombreAplicacion = lblAplicacion.Text,
                            Posicion = int.Parse(lblCiclo.Text),
                            AreaTotal = Double.Parse(lblAreaTotal.Text),
                            FechaCreacion = DateTime.Today.Date,
                            Lote = lblLote.Text,
                            IdAplicacion = id,
                            CostoTotal = double.Parse(lblCosto.Text),
                            GrupoForza = lblGrupo.Text,
                            Etapa = etapa.Text,
                            PeriodoReingreso = obtenerMayor("P.Reing(H)"),
                            InterCosecha1 = obtenerMayor("InterCosecha"),
                            PeriodoCosecha = getPeriodoCosecha()


                        });
                        guardarDetalleProductos();
                        guardarDetalleSeccion();
                        guardarDetalleSpray();
                        MessageBox.Show("Cedula Creada Correctamente");
                        if (lblGrupo.Text.Equals("Sin Grupo"))
                        {
                            Reportes.CedulaReporte r = new Reportes.CedulaReporte(DAO.CedulaIdentidad.obtenerUltimoDato());
                            r.ShowDialog();
                        }
                        else {

                            Reportes.CedulaForza r = new Reportes.CedulaForza(DAO.CedulaIdentidad.obtenerUltimoDato());
                            r.ShowDialog();
                        }


                 
                  
                        this.anterior.Dispose();
                        this.Dispose();

                    }


                    catch (Exception ex) {
                    }
                }
            }
            if (primerPanel.Visible == true)
            {

                if (segundoPanel.Visible == true) {

                    DAO.CedulaIdentidad.insertarCedula(new Entidades.CedulaIdentidad() {
                        FechaProgramada = DateTime.Parse(lblFechaProgramada.Text),
                        JustMuestreo = chkMuestreo.Checked,
                        JustProgramacion = chkJustificacion.Checked,
                        Cultivo = cmbCultivo.Text,
                        Chofer = comboChofer.Text,
                        NumSpray = comboSpray.Text,
                        NumTractor = comboTractor.Text,
                        NombreAplicacion = lblAplicacion.Text,
                        Posicion = int.Parse(lblCiclo.Text)
                    });
                    guardarDetalleProductos();
                    guardarDetalleSeccion();
                }
                if (primerPanel.Visible == true) {


                    segundoPanel.Visible = true;
                    primerPanel.Visible = false;

                }
            }
        }
        DateTime getPeriodoCosecha() {
            if (lblGrupo.Text.Equals("Sin Grupo"))
            {
                return default(DateTime);

            }
            else {

                return DAO.GrupoForza.fechaPeriodoCosecha(lblGrupo.Text);

            }

          
        }
        int obtenerMayor(string columna) {

            int mayor = int.Parse(dataProductos.Rows[0].Cells[columna].Value.ToString());
            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {
                int num = int.Parse(row.Cells[columna].Value.ToString());
                if (num> mayor) {

                    mayor = num;
                }

            }

            return mayor;

            }
            void guardarDetalleSeccion()
        {


            foreach (Entidades.Seccion seccion in secciones)

            { 
                    DAO.CedulaIdentidad.insertarDetalleSeccion(new Entidades.DetalleSecciones()
                    {
                        Cedula = DAO.CedulaIdentidad.obtenerUltimoDato(),

                        Lote = seccion.IdLote,
                        Bloque = seccion.IdBloque,
                        Seccion = seccion.IdSeccion,
                        AreaTotal = seccion.Area



                    });
                DAO.Seccion.cambiarBloqueo(seccion, true);
                    if (aplicacionExtra == false)
                    {
                        /*DAO.Seccion.aumentarPosicion(new Entidades.Seccion
                        {
                            IdLote = seccion.IdLote,
                            IdBloque = seccion.IdBloque,
                            IdSeccion = seccion.IdSeccion,
                            FechaInicial = seccion.FechaInicial,
                            Posicion = seccion.Posicion,

                        });*/

                    }

                    //    Lote = row.Cells["Lote"].Value.ToString(),
                    //   Bloque = row.Cells["Bloque"].Value.ToString(),
                    //   Seccion = row.Cells["Seccion"].Value.ToString(),
                    //  AreaTotal = double.Parse(row.Cells["Area"].Value.ToString())




                }
        

            }


        void guardarDetalleSpray() {
            string spray = comboSpray.Text.ToString();

            DAO.CedulaIdentidad.insertarDetalleSpray(DAO.SprayBoom.buscarSprayBoom(spray), DAO.CedulaIdentidad.obtenerUltimoDato());


        }
        void guardarDetalleProductos()
        {

            foreach (DataGridViewRow row in this.dataProductos.Rows)
            {
            

                DAO.CedulaIdentidad.insertarDetalleProductos(new Entidades.DetalleProductos()
                {
                    Cedula = DAO.CedulaIdentidad.obtenerUltimoDato(),

                    IngredienteActivo = row.Cells["ingredienteActivo"].Value.ToString(),
                    NombreComercial = row.Cells["nombre"].Value.ToString(),
                    Codigo = int.Parse(row.Cells["idProducto"].Value.ToString()),
                    Costo = double.Parse(row.Cells["Costo Total"].Value.ToString()),
                    DosisH = double.Parse(row.Cells["Dosis(H)"].Value.ToString()),
                    TotalDosis = double.Parse(row.Cells["Dosis Total"].Value.ToString()),
                    CostoH = double.Parse(row.Cells["Costo(UM)"].Value.ToString()),
                    PeriodoReingreso = int.Parse(row.Cells["P.Reing(H)"].Value.ToString()),
                    Tipo = row.Cells["Clasificacion"].Value.ToString(),
                    UM1 = row.Cells["UM"].Value.ToString(),
                    NumRegistro = row.Cells["# Registro"].Value.ToString(),
                    Intervalo = int.Parse(row.Cells["InterCosecha"].Value.ToString()
                  )
                   
                    
                });
                DAO.Producto.aumentarCantidadBloqueada(row.Cells["idProducto"].Value.ToString(), Convert.ToDouble(row.Cells["Dosis Total"].Value));
                

            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (segundoPanel.Visible == true)
            {
                primerPanel.Visible = true;

                segundoPanel.Visible = false;

            }

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void primerPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CedulaAgregarProducto c = new CedulaAgregarProducto();
            DialogResult res = c.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (buscarCoincidencia(c.p.IdProducto))
                {
                    dt.Rows.Add(c.p.IdProducto, c.p.Nombre, c.p.IngredienteActivo,0,c.p.Costo,c.p.Unidad,c.p.Tipo,c.p.NumRegistro,c.p.PeriodoReingreso,c.p.Dias, 0,0);
                    dataProductos.DataSource = dt;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.RemoveAt(dataProductos.CurrentRow.Index);
            }
            catch { }
            }

        private void dataProductos_SelectionChanged(object sender, EventArgs e)
        {
            txtDosis.Focus();
            txtDosis.SelectAll();
            try
            {
                double dosis = (double)dataProductos.CurrentRow.Cells["Dosis(H)"].Value;
                txtDosis.Text = dosis.ToString();
            }
            catch {
                txtDosis.Text ="0";

            }
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCambiarDosis_Click(sender, e);
            }
        }
        private void btnCambiarDosis_Click(object sender, EventArgs e)
        {
            try
            {
                dataProductos.CurrentRow.Cells["Dosis(H)"].Value = txtDosis.Text;
                double dosis = Convert.ToDouble(dataProductos.CurrentRow.Cells["Dosis(H)"].Value);
                dataProductos.CurrentRow.Cells["Dosis Total"].Value = AreaTotal * dosis;
                dataProductos.CurrentRow.Cells["Costo Total"].Value = Convert.ToDouble(dataProductos.CurrentRow.Cells["Dosis Total"].Value) * Convert.ToDouble(dataProductos.CurrentRow.Cells["Costo(UM)"].Value);
                calcularCostoTotal();
            }
            catch { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboSpray_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidades.SprayBoom s = DAO.SprayBoom.buscarSprayBoom(comboSpray.SelectedValue.ToString());
            lblCapacidad.Text = s.Capacidad.ToString();
            lblTotalboones.Text = (Double.Parse(lblTotalLitros.Text) / Double.Parse(lblCapacidad.Text)).ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtAguaRequerida_TextChanged(object sender, EventArgs e)
        {
            if (!txtAguaRequerida.Text.Equals("")) { 
            lblTotalLitros.Text = (Double.Parse(txtAguaRequerida.Text) * Double.Parse(lblAreaTotal.Text)).ToString();
            lblTotalboones.Text = (Double.Parse(lblTotalLitros.Text) / Double.Parse(lblCapacidad.Text)).ToString();
        } }

        private void chkJustificacion_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void CrearCedulaIdentidad_Leave(object sender, EventArgs e)
        {
           
        }

        private void CrearCedulaIdentidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mapa.seccionesSeleccionadas.Clear();
        }

        private void dataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidades.Empleado empleado = DAO.Empleado.buscarEmpleado(comboChofer.Text);
            txtNombre.Text = empleado.Nombre +" " + empleado.Apellido;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
             btnCerrar.Font = new Font("Ebrima", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            btnCerrar.Image = Vistas.Properties.Resources.Delete2;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.Image = Vistas.Properties.Resources.Delete;
        }
    }
}
