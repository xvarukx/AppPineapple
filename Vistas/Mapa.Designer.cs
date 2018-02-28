namespace Vistas
{
    partial class Mapa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLote = new System.Windows.Forms.ComboBox();
            this.chkItemsLote = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarLote = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelCosas = new System.Windows.Forms.Panel();
            this.dataSecciones = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoForza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProgramada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panelZoom = new System.Windows.Forms.Panel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCosas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSecciones)).BeginInit();
            this.panelZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Ebrima", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.otraAplicacionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 56);
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.holaToolStripMenuItem.Text = "Generar Cedula";
            this.holaToolStripMenuItem.Click += new System.EventHandler(this.holaToolStripMenuItem_Click);
            // 
            // otraAplicacionToolStripMenuItem
            // 
            this.otraAplicacionToolStripMenuItem.Name = "otraAplicacionToolStripMenuItem";
            this.otraAplicacionToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.otraAplicacionToolStripMenuItem.Text = "Generar otra Aplicacion";
            this.otraAplicacionToolStripMenuItem.Click += new System.EventHandler(this.otraAplicacionToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(57, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 479);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1074, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lote:";
            // 
            // cmbLote
            // 
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.Location = new System.Drawing.Point(53, 13);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.Size = new System.Drawing.Size(135, 21);
            this.cmbLote.TabIndex = 20;
            this.cmbLote.SelectedValueChanged += new System.EventHandler(this.cmbLote_SelectedValueChanged);
            // 
            // chkItemsLote
            // 
            this.chkItemsLote.AutoSize = true;
            this.chkItemsLote.Checked = true;
            this.chkItemsLote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkItemsLote.Location = new System.Drawing.Point(53, 42);
            this.chkItemsLote.Name = "chkItemsLote";
            this.chkItemsLote.Size = new System.Drawing.Size(123, 17);
            this.chkItemsLote.TabIndex = 21;
            this.chkItemsLote.Text = "Todas las secciones";
            this.chkItemsLote.UseVisualStyleBackColor = true;
            this.chkItemsLote.CheckedChanged += new System.EventHandler(this.chkItemsLote_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEditarLote);
            this.panel1.Controls.Add(this.chkItemsLote);
            this.panel1.Controls.Add(this.cmbLote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 160);
            this.panel1.TabIndex = 9;
            // 
            // btnEditarLote
            // 
            this.btnEditarLote.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLote.Image = global::Vistas.Properties.Resources.View_Details_WF;
            this.btnEditarLote.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarLote.Location = new System.Drawing.Point(52, 66);
            this.btnEditarLote.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarLote.Name = "btnEditarLote";
            this.btnEditarLote.Size = new System.Drawing.Size(135, 75);
            this.btnEditarLote.TabIndex = 22;
            this.btnEditarLote.Text = "Ver Detalles";
            this.btnEditarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarLote.UseVisualStyleBackColor = true;
            this.btnEditarLote.Click += new System.EventHandler(this.btnEditarLote_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Location = new System.Drawing.Point(-32, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(993, 14);
            this.progressBar1.TabIndex = 17;
            // 
            // panelCosas
            // 
            this.panelCosas.Controls.Add(this.dataSecciones);
            this.panelCosas.Controls.Add(this.panel1);
            this.panelCosas.Controls.Add(this.btnAplicar);
            this.panelCosas.Controls.Add(this.progressBar1);
            this.panelCosas.Location = new System.Drawing.Point(0, 0);
            this.panelCosas.Name = "panelCosas";
            this.panelCosas.Size = new System.Drawing.Size(1156, 190);
            this.panelCosas.TabIndex = 27;
            // 
            // dataSecciones
            // 
            this.dataSecciones.AllowUserToAddRows = false;
            this.dataSecciones.AllowUserToDeleteRows = false;
            this.dataSecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSecciones.BackgroundColor = System.Drawing.Color.White;
            this.dataSecciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.Seccion,
            this.Bloque,
            this.grupoForza,
            this.Etapa,
            this.Posicion,
            this.NombreAplicacion,
            this.fechaProgramada});
            this.dataSecciones.EnableHeadersVisualStyles = false;
            this.dataSecciones.Location = new System.Drawing.Point(213, 7);
            this.dataSecciones.MultiSelect = false;
            this.dataSecciones.Name = "dataSecciones";
            this.dataSecciones.ReadOnly = true;
            this.dataSecciones.RowHeadersVisible = false;
            this.dataSecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSecciones.Size = new System.Drawing.Size(748, 160);
            this.dataSecciones.TabIndex = 18;
            this.dataSecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSecciones_CellContentClick);
            // 
            // Semana
            // 
            this.Semana.HeaderText = "Semana";
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Bloque
            // 
            this.Bloque.HeaderText = "Bloque";
            this.Bloque.Name = "Bloque";
            this.Bloque.ReadOnly = true;
            // 
            // grupoForza
            // 
            this.grupoForza.HeaderText = "Grupo";
            this.grupoForza.Name = "grupoForza";
            this.grupoForza.ReadOnly = true;
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // NombreAplicacion
            // 
            this.NombreAplicacion.HeaderText = "Nombre de Aplicacion";
            this.NombreAplicacion.Name = "NombreAplicacion";
            this.NombreAplicacion.ReadOnly = true;
            // 
            // fechaProgramada
            // 
            this.fechaProgramada.HeaderText = "Fecha Programada";
            this.fechaProgramada.Name = "fechaProgramada";
            this.fechaProgramada.ReadOnly = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Image = global::Vistas.Properties.Resources.Navigation_Right_WF;
            this.btnAplicar.Location = new System.Drawing.Point(959, 110);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(82, 57);
            this.btnAplicar.TabIndex = 15;
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // panelZoom
            // 
            this.panelZoom.Controls.Add(this.btnZoomIn);
            this.panelZoom.Controls.Add(this.btnZoomOut);
            this.panelZoom.Location = new System.Drawing.Point(0, 197);
            this.panelZoom.Name = "panelZoom";
            this.panelZoom.Size = new System.Drawing.Size(52, 209);
            this.panelZoom.TabIndex = 2;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::Vistas.Properties.Resources.zoom_in__3_;
            this.btnZoomIn.Location = new System.Drawing.Point(4, 4);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(45, 44);
            this.btnZoomIn.TabIndex = 24;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::Vistas.Properties.Resources.zoom_out__1_;
            this.btnZoomOut.Location = new System.Drawing.Point(4, 56);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(45, 44);
            this.btnZoomOut.TabIndex = 25;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1036, 726);
            this.Controls.Add(this.panelZoom);
            this.Controls.Add(this.panelCosas);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.SizeChanged += new System.EventHandler(this.Mapa_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCosas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSecciones)).EndInit();
            this.panelZoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraAplicacionToolStripMenuItem;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLote;
        private System.Windows.Forms.CheckBox chkItemsLote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panelCosas;
        private System.Windows.Forms.Panel panelZoom;
        private System.Windows.Forms.DataGridView dataSecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoForza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProgramada;
        private System.Windows.Forms.Button btnEditarLote;
    }
}