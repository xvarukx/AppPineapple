namespace Vistas.Mapas
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
            this.comboLotes = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoBloqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBloque = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeccion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkEditar = new System.Windows.Forms.CheckBox();
            this.btnEditarLote = new System.Windows.Forms.Button();
            this.btnLote = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuBloque.SuspendLayout();
            this.menuSeccion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboLotes
            // 
            this.comboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLotes.Location = new System.Drawing.Point(4, 15);
            this.comboLotes.Margin = new System.Windows.Forms.Padding(4);
            this.comboLotes.Name = "comboLotes";
            this.comboLotes.Size = new System.Drawing.Size(121, 24);
            this.comboLotes.TabIndex = 18;
            this.comboLotes.SelectedIndexChanged += new System.EventHandler(this.comboLotes_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoBloqueToolStripMenuItem,
            this.nuevaSeccionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // nuevoBloqueToolStripMenuItem
            // 
            this.nuevoBloqueToolStripMenuItem.Name = "nuevoBloqueToolStripMenuItem";
            this.nuevoBloqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoBloqueToolStripMenuItem.Text = "Nuevo Bloque";
            this.nuevoBloqueToolStripMenuItem.Click += new System.EventHandler(this.nuevoBloqueToolStripMenuItem_Click);
            // 
            // nuevaSeccionToolStripMenuItem
            // 
            this.nuevaSeccionToolStripMenuItem.Name = "nuevaSeccionToolStripMenuItem";
            this.nuevaSeccionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaSeccionToolStripMenuItem.Text = "Nueva Seccion";
            this.nuevaSeccionToolStripMenuItem.Click += new System.EventHandler(this.nuevaSeccionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(128, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 528);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuBloque
            // 
            this.menuBloque.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem,
            this.fechaInicialToolStripMenuItem});
            this.menuBloque.Name = "menuBloque";
            this.menuBloque.Size = new System.Drawing.Size(135, 48);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.verDetallesToolStripMenuItem.Text = "Ver Detalles";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // fechaInicialToolStripMenuItem
            // 
            this.fechaInicialToolStripMenuItem.Name = "fechaInicialToolStripMenuItem";
            this.fechaInicialToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fechaInicialToolStripMenuItem.Text = "Configurar";
            this.fechaInicialToolStripMenuItem.Click += new System.EventHandler(this.fechaInicialToolStripMenuItem_Click);
            // 
            // menuSeccion
            // 
            this.menuSeccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuSeccion.Name = "menuBloque";
            this.menuSeccion.Size = new System.Drawing.Size(135, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem1.Text = "Ver Detalles";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGrupos);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.checkEditar);
            this.panel2.Controls.Add(this.btnEditarLote);
            this.panel2.Controls.Add(this.btnLote);
            this.panel2.Controls.Add(this.btnZoomIn);
            this.panel2.Controls.Add(this.btnZoomOut);
            this.panel2.Controls.Add(this.btnPaquetes);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 496);
            this.panel2.TabIndex = 26;
            // 
            // btnGrupos
            // 
            this.btnGrupos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupos.Image = global::Vistas.Properties.Resources.Calendar_Date_02;
            this.btnGrupos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupos.Location = new System.Drawing.Point(4, 260);
            this.btnGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(116, 75);
            this.btnGrupos.TabIndex = 28;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Vistas.Properties.Resources.garbage3;
            this.btnEliminar.Location = new System.Drawing.Point(4, 396);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 43);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // checkEditar
            // 
            this.checkEditar.Image = global::Vistas.Properties.Resources.pencil;
            this.checkEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEditar.Location = new System.Drawing.Point(11, 446);
            this.checkEditar.Name = "checkEditar";
            this.checkEditar.Size = new System.Drawing.Size(105, 42);
            this.checkEditar.TabIndex = 26;
            this.checkEditar.Text = "Editar";
            this.checkEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkEditar.UseVisualStyleBackColor = true;
            this.checkEditar.CheckedChanged += new System.EventHandler(this.checkEditar_CheckedChanged);
            // 
            // btnEditarLote
            // 
            this.btnEditarLote.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLote.Image = global::Vistas.Properties.Resources.View_Details_WF;
            this.btnEditarLote.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarLote.Location = new System.Drawing.Point(4, 6);
            this.btnEditarLote.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarLote.Name = "btnEditarLote";
            this.btnEditarLote.Size = new System.Drawing.Size(116, 75);
            this.btnEditarLote.TabIndex = 20;
            this.btnEditarLote.Text = "Ver Detalles";
            this.btnEditarLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarLote.UseVisualStyleBackColor = true;
            this.btnEditarLote.Click += new System.EventHandler(this.btnEditarLote_Click);
            // 
            // btnLote
            // 
            this.btnLote.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLote.Image = global::Vistas.Properties.Resources.Map1;
            this.btnLote.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLote.Location = new System.Drawing.Point(4, 94);
            this.btnLote.Margin = new System.Windows.Forms.Padding(4);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(116, 75);
            this.btnLote.TabIndex = 19;
            this.btnLote.Text = "Crear Lote";
            this.btnLote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLote.UseVisualStyleBackColor = true;
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Image = global::Vistas.Properties.Resources.zoom_in__3_;
            this.btnZoomIn.Location = new System.Drawing.Point(67, 339);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(52, 44);
            this.btnZoomIn.TabIndex = 22;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Image = global::Vistas.Properties.Resources.zoom_out__1_;
            this.btnZoomOut.Location = new System.Drawing.Point(7, 339);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(52, 44);
            this.btnZoomOut.TabIndex = 23;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquetes.Image = global::Vistas.Properties.Resources.Calendar_Date_02;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaquetes.Location = new System.Drawing.Point(5, 177);
            this.btnPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Size = new System.Drawing.Size(116, 75);
            this.btnPaquetes.TabIndex = 25;
            this.btnPaquetes.Text = "Etapas";
            this.btnPaquetes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaquetes.UseVisualStyleBackColor = true;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(793, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboLotes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.SizeChanged += new System.EventHandler(this.Mapa_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuBloque.ResumeLayout(false);
            this.menuSeccion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditarLote;
        private System.Windows.Forms.Button btnLote;
        private System.Windows.Forms.ComboBox comboLotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoBloqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSeccionToolStripMenuItem;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip menuBloque;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuSeccion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fechaInicialToolStripMenuItem;
        private System.Windows.Forms.Button btnPaquetes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrupos;
    }
}