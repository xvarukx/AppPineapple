namespace Vistas.PaqueteAplicacion
{
    partial class AplicacionForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.dataTodos = new System.Windows.Forms.DataGridView();
            this.tabHerbicida = new System.Windows.Forms.TabPage();
            this.dataHerb = new System.Windows.Forms.DataGridView();
            this.tabFertilizante = new System.Windows.Forms.TabPage();
            this.dataFert = new System.Windows.Forms.DataGridView();
            this.tabFungicida = new System.Windows.Forms.TabPage();
            this.dataFungi = new System.Windows.Forms.DataGridView();
            this.tabInsecticida = new System.Windows.Forms.TabPage();
            this.dataInsect = new System.Windows.Forms.DataGridView();
            this.tabNematicida = new System.Windows.Forms.TabPage();
            this.dataNema = new System.Windows.Forms.DataGridView();
            this.tabOtros = new System.Windows.Forms.TabPage();
            this.dataOtros = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnModificarDosis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAplicacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTodos)).BeginInit();
            this.tabHerbicida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHerb)).BeginInit();
            this.tabFertilizante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFert)).BeginInit();
            this.tabFungicida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFungi)).BeginInit();
            this.tabInsecticida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInsect)).BeginInit();
            this.tabNematicida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNema)).BeginInit();
            this.tabOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(598, 162);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(474, 469);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(73, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(293, 22);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTodos);
            this.tabControl1.Controls.Add(this.tabHerbicida);
            this.tabControl1.Controls.Add(this.tabFertilizante);
            this.tabControl1.Controls.Add(this.tabFungicida);
            this.tabControl1.Controls.Add(this.tabInsecticida);
            this.tabControl1.Controls.Add(this.tabNematicida);
            this.tabControl1.Controls.Add(this.tabOtros);
            this.tabControl1.Location = new System.Drawing.Point(8, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 409);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTodos
            // 
            this.tabTodos.Controls.Add(this.dataTodos);
            this.tabTodos.Location = new System.Drawing.Point(4, 25);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Size = new System.Drawing.Size(448, 380);
            this.tabTodos.TabIndex = 4;
            this.tabTodos.Text = "Todos";
            this.tabTodos.UseVisualStyleBackColor = true;
            // 
            // dataTodos
            // 
            this.dataTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTodos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTodos.Location = new System.Drawing.Point(0, 0);
            this.dataTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataTodos.Name = "dataTodos";
            this.dataTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTodos.Size = new System.Drawing.Size(448, 380);
            this.dataTodos.TabIndex = 1;
            this.dataTodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTodos_CellContentClick);
            this.dataTodos.SelectionChanged += new System.EventHandler(this.dataTodos_SelectionChanged);
            // 
            // tabHerbicida
            // 
            this.tabHerbicida.Controls.Add(this.dataHerb);
            this.tabHerbicida.Location = new System.Drawing.Point(4, 25);
            this.tabHerbicida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHerbicida.Name = "tabHerbicida";
            this.tabHerbicida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHerbicida.Size = new System.Drawing.Size(448, 380);
            this.tabHerbicida.TabIndex = 0;
            this.tabHerbicida.Text = "Herbicida";
            this.tabHerbicida.UseVisualStyleBackColor = true;
            // 
            // dataHerb
            // 
            this.dataHerb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHerb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHerb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHerb.Location = new System.Drawing.Point(4, 5);
            this.dataHerb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataHerb.MultiSelect = false;
            this.dataHerb.Name = "dataHerb";
            this.dataHerb.ReadOnly = true;
            this.dataHerb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHerb.Size = new System.Drawing.Size(440, 370);
            this.dataHerb.TabIndex = 0;
            this.dataHerb.SelectionChanged += new System.EventHandler(this.dataHerb_SelectionChanged);
            // 
            // tabFertilizante
            // 
            this.tabFertilizante.Controls.Add(this.dataFert);
            this.tabFertilizante.Location = new System.Drawing.Point(4, 25);
            this.tabFertilizante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFertilizante.Name = "tabFertilizante";
            this.tabFertilizante.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFertilizante.Size = new System.Drawing.Size(448, 380);
            this.tabFertilizante.TabIndex = 1;
            this.tabFertilizante.Text = "Fertilizante";
            this.tabFertilizante.UseVisualStyleBackColor = true;
            // 
            // dataFert
            // 
            this.dataFert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFert.Location = new System.Drawing.Point(4, 5);
            this.dataFert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFert.Name = "dataFert";
            this.dataFert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFert.Size = new System.Drawing.Size(440, 370);
            this.dataFert.TabIndex = 1;
            this.dataFert.SelectionChanged += new System.EventHandler(this.dataFert_SelectionChanged);
            // 
            // tabFungicida
            // 
            this.tabFungicida.Controls.Add(this.dataFungi);
            this.tabFungicida.Location = new System.Drawing.Point(4, 25);
            this.tabFungicida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFungicida.Name = "tabFungicida";
            this.tabFungicida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFungicida.Size = new System.Drawing.Size(448, 380);
            this.tabFungicida.TabIndex = 2;
            this.tabFungicida.Text = "Fungicida";
            this.tabFungicida.UseVisualStyleBackColor = true;
            // 
            // dataFungi
            // 
            this.dataFungi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFungi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFungi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFungi.Location = new System.Drawing.Point(4, 5);
            this.dataFungi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFungi.Name = "dataFungi";
            this.dataFungi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFungi.Size = new System.Drawing.Size(440, 370);
            this.dataFungi.TabIndex = 1;
            this.dataFungi.SelectionChanged += new System.EventHandler(this.dataFungi_SelectionChanged);
            // 
            // tabInsecticida
            // 
            this.tabInsecticida.Controls.Add(this.dataInsect);
            this.tabInsecticida.Location = new System.Drawing.Point(4, 25);
            this.tabInsecticida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInsecticida.Name = "tabInsecticida";
            this.tabInsecticida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInsecticida.Size = new System.Drawing.Size(448, 380);
            this.tabInsecticida.TabIndex = 3;
            this.tabInsecticida.Text = "Insecticida";
            this.tabInsecticida.UseVisualStyleBackColor = true;
            // 
            // dataInsect
            // 
            this.dataInsect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInsect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInsect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInsect.Location = new System.Drawing.Point(4, 5);
            this.dataInsect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataInsect.Name = "dataInsect";
            this.dataInsect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInsect.Size = new System.Drawing.Size(440, 370);
            this.dataInsect.TabIndex = 1;
            this.dataInsect.SelectionChanged += new System.EventHandler(this.dataInsect_SelectionChanged);
            // 
            // tabNematicida
            // 
            this.tabNematicida.Controls.Add(this.dataNema);
            this.tabNematicida.Location = new System.Drawing.Point(4, 25);
            this.tabNematicida.Name = "tabNematicida";
            this.tabNematicida.Size = new System.Drawing.Size(448, 380);
            this.tabNematicida.TabIndex = 5;
            this.tabNematicida.Text = "Nematicida";
            this.tabNematicida.UseVisualStyleBackColor = true;
            // 
            // dataNema
            // 
            this.dataNema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNema.Location = new System.Drawing.Point(0, 0);
            this.dataNema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataNema.Name = "dataNema";
            this.dataNema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNema.Size = new System.Drawing.Size(448, 380);
            this.dataNema.TabIndex = 2;
            this.dataNema.SelectionChanged += new System.EventHandler(this.dataNema_SelectionChanged);
            // 
            // tabOtros
            // 
            this.tabOtros.Controls.Add(this.dataOtros);
            this.tabOtros.Location = new System.Drawing.Point(4, 25);
            this.tabOtros.Name = "tabOtros";
            this.tabOtros.Size = new System.Drawing.Size(448, 380);
            this.tabOtros.TabIndex = 6;
            this.tabOtros.Text = "Otros";
            this.tabOtros.UseVisualStyleBackColor = true;
            // 
            // dataOtros
            // 
            this.dataOtros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOtros.Location = new System.Drawing.Point(0, 0);
            this.dataOtros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOtros.Name = "dataOtros";
            this.dataOtros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOtros.Size = new System.Drawing.Size(448, 380);
            this.dataOtros.TabIndex = 2;
            this.dataOtros.SelectionChanged += new System.EventHandler(this.dataOtros_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnModificarDosis);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(534, 470);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos en aplicacion:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione un producto para cambiar dosis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnModificarDosis
            // 
            this.btnModificarDosis.ForeColor = System.Drawing.Color.Black;
            this.btnModificarDosis.Location = new System.Drawing.Point(361, 433);
            this.btnModificarDosis.Name = "btnModificarDosis";
            this.btnModificarDosis.Size = new System.Drawing.Size(90, 26);
            this.btnModificarDosis.TabIndex = 3;
            this.btnModificarDosis.Text = "Cambiar dosis";
            this.btnModificarDosis.UseVisualStyleBackColor = true;
            this.btnModificarDosis.Click += new System.EventHandler(this.btnModificarDosis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(511, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtEtapa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAplicacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(665, 132);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacíon de Aplicacion:";
            // 
            // txtEtapa
            // 
            this.txtEtapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEtapa.Location = new System.Drawing.Point(324, 38);
            this.txtEtapa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(69, 22);
            this.txtEtapa.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Etapa:";
            // 
            // txtAplicacion
            // 
            this.txtAplicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAplicacion.Location = new System.Drawing.Point(173, 37);
            this.txtAplicacion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAplicacion.Name = "txtAplicacion";
            this.txtAplicacion.Size = new System.Drawing.Size(51, 22);
            this.txtAplicacion.TabIndex = 11;
            this.txtAplicacion.TextChanged += new System.EventHandler(this.txtAplicacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero de Aplicacion:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(175, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(477, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Aplicación:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Vistas.Properties.Resources.Arrowhead_Left_011;
            this.btnAdd.Location = new System.Drawing.Point(555, 331);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 51);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::Vistas.Properties.Resources.Arrowhead_Right_01;
            this.btnRemove.Location = new System.Drawing.Point(555, 392);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 52);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::Vistas.Properties.Resources.Delete;
            this.btnCerrar.Location = new System.Drawing.Point(1026, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 55);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // AplicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondoprueba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 648);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AplicacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AplicacionForm";
            this.Load += new System.EventHandler(this.AplicacionForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTodos)).EndInit();
            this.tabHerbicida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHerb)).EndInit();
            this.tabFertilizante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFert)).EndInit();
            this.tabFungicida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFungi)).EndInit();
            this.tabInsecticida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInsect)).EndInit();
            this.tabNematicida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNema)).EndInit();
            this.tabOtros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOtros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHerbicida;
        private System.Windows.Forms.DataGridView dataHerb;
        private System.Windows.Forms.TabPage tabFertilizante;
        private System.Windows.Forms.DataGridView dataFert;
        private System.Windows.Forms.TabPage tabFungicida;
        private System.Windows.Forms.DataGridView dataFungi;
        private System.Windows.Forms.TabPage tabInsecticida;
        private System.Windows.Forms.DataGridView dataInsect;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.DataGridView dataTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnModificarDosis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAplicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabNematicida;
        private System.Windows.Forms.DataGridView dataNema;
        private System.Windows.Forms.TabPage tabOtros;
        private System.Windows.Forms.DataGridView dataOtros;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrar;
    }
}