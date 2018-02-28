namespace Vistas
{
    partial class SpraysBooms
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalles = new System.Windows.Forms.TabPage();
            this.txtEditMetodo = new System.Windows.Forms.TextBox();
            this.txtEditMarcha = new System.Windows.Forms.TextBox();
            this.txtEditKm = new System.Windows.Forms.TextBox();
            this.txtEditBoquilla = new System.Windows.Forms.TextBox();
            this.txtEditRpm = new System.Windows.Forms.TextBox();
            this.txtEditPsi = new System.Windows.Forms.TextBox();
            this.txtEditCapacidad = new System.Windows.Forms.TextBox();
            this.txtEditCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAddMetodo = new System.Windows.Forms.TextBox();
            this.txtAddMarcha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddKm = new System.Windows.Forms.TextBox();
            this.txtAddBoquilla = new System.Windows.Forms.TextBox();
            this.txtAddRPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddPSI = new System.Windows.Forms.TextBox();
            this.txtAddCapacidad = new System.Windows.Forms.TextBox();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDetalles.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(61, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(351, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 383);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDetalles);
            this.tabControl1.Controls.Add(this.tabAgregar);
            this.tabControl1.Location = new System.Drawing.Point(511, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 412);
            this.tabControl1.TabIndex = 4;
            // 
            // tabDetalles
            // 
            this.tabDetalles.Controls.Add(this.txtEditMetodo);
            this.tabDetalles.Controls.Add(this.txtEditMarcha);
            this.tabDetalles.Controls.Add(this.txtEditKm);
            this.tabDetalles.Controls.Add(this.txtEditBoquilla);
            this.tabDetalles.Controls.Add(this.txtEditRpm);
            this.tabDetalles.Controls.Add(this.txtEditPsi);
            this.tabDetalles.Controls.Add(this.txtEditCapacidad);
            this.tabDetalles.Controls.Add(this.txtEditCodigo);
            this.tabDetalles.Controls.Add(this.label1);
            this.tabDetalles.Controls.Add(this.label2);
            this.tabDetalles.Controls.Add(this.label3);
            this.tabDetalles.Controls.Add(this.label8);
            this.tabDetalles.Controls.Add(this.label9);
            this.tabDetalles.Controls.Add(this.label10);
            this.tabDetalles.Controls.Add(this.label12);
            this.tabDetalles.Controls.Add(this.label13);
            this.tabDetalles.Controls.Add(this.btnEditar);
            this.tabDetalles.Controls.Add(this.btnEliminar);
            this.tabDetalles.Location = new System.Drawing.Point(4, 25);
            this.tabDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetalles.Name = "tabDetalles";
            this.tabDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.tabDetalles.Size = new System.Drawing.Size(305, 383);
            this.tabDetalles.TabIndex = 0;
            this.tabDetalles.Text = "Detalles";
            this.tabDetalles.UseVisualStyleBackColor = true;
            // 
            // txtEditMetodo
            // 
            this.txtEditMetodo.Location = new System.Drawing.Point(117, 221);
            this.txtEditMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditMetodo.Name = "txtEditMetodo";
            this.txtEditMetodo.Size = new System.Drawing.Size(169, 22);
            this.txtEditMetodo.TabIndex = 39;
            // 
            // txtEditMarcha
            // 
            this.txtEditMarcha.Location = new System.Drawing.Point(117, 191);
            this.txtEditMarcha.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditMarcha.Name = "txtEditMarcha";
            this.txtEditMarcha.Size = new System.Drawing.Size(169, 22);
            this.txtEditMarcha.TabIndex = 38;
            // 
            // txtEditKm
            // 
            this.txtEditKm.Location = new System.Drawing.Point(117, 161);
            this.txtEditKm.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditKm.Name = "txtEditKm";
            this.txtEditKm.Size = new System.Drawing.Size(169, 22);
            this.txtEditKm.TabIndex = 37;
            // 
            // txtEditBoquilla
            // 
            this.txtEditBoquilla.Location = new System.Drawing.Point(117, 131);
            this.txtEditBoquilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditBoquilla.Name = "txtEditBoquilla";
            this.txtEditBoquilla.Size = new System.Drawing.Size(169, 22);
            this.txtEditBoquilla.TabIndex = 36;
            // 
            // txtEditRpm
            // 
            this.txtEditRpm.Location = new System.Drawing.Point(117, 101);
            this.txtEditRpm.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditRpm.Name = "txtEditRpm";
            this.txtEditRpm.Size = new System.Drawing.Size(169, 22);
            this.txtEditRpm.TabIndex = 35;
            // 
            // txtEditPsi
            // 
            this.txtEditPsi.Location = new System.Drawing.Point(117, 71);
            this.txtEditPsi.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditPsi.Name = "txtEditPsi";
            this.txtEditPsi.Size = new System.Drawing.Size(169, 22);
            this.txtEditPsi.TabIndex = 34;
            // 
            // txtEditCapacidad
            // 
            this.txtEditCapacidad.Location = new System.Drawing.Point(117, 41);
            this.txtEditCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCapacidad.Name = "txtEditCapacidad";
            this.txtEditCapacidad.Size = new System.Drawing.Size(169, 22);
            this.txtEditCapacidad.TabIndex = 33;
            // 
            // txtEditCodigo
            // 
            this.txtEditCodigo.Location = new System.Drawing.Point(117, 15);
            this.txtEditCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCodigo.Name = "txtEditCodigo";
            this.txtEditCodigo.Size = new System.Drawing.Size(169, 22);
            this.txtEditCodigo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Metodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Marcha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kmph";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Boquilla";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Rpm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Psi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Capacidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Codigo";
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.label17);
            this.tabAgregar.Controls.Add(this.label18);
            this.tabAgregar.Controls.Add(this.txtAddMetodo);
            this.tabAgregar.Controls.Add(this.txtAddMarcha);
            this.tabAgregar.Controls.Add(this.label11);
            this.tabAgregar.Controls.Add(this.label14);
            this.tabAgregar.Controls.Add(this.label15);
            this.tabAgregar.Controls.Add(this.txtAddKm);
            this.tabAgregar.Controls.Add(this.txtAddBoquilla);
            this.tabAgregar.Controls.Add(this.txtAddRPM);
            this.tabAgregar.Controls.Add(this.label4);
            this.tabAgregar.Controls.Add(this.label5);
            this.tabAgregar.Controls.Add(this.label6);
            this.tabAgregar.Controls.Add(this.txtAddPSI);
            this.tabAgregar.Controls.Add(this.txtAddCapacidad);
            this.tabAgregar.Controls.Add(this.txtAddCodigo);
            this.tabAgregar.Controls.Add(this.btnAgregar);
            this.tabAgregar.Location = new System.Drawing.Point(4, 25);
            this.tabAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(4);
            this.tabAgregar.Size = new System.Drawing.Size(305, 383);
            this.tabAgregar.TabIndex = 1;
            this.tabAgregar.Text = "Agregar Nuevo";
            this.tabAgregar.UseVisualStyleBackColor = true;
            this.tabAgregar.Click += new System.EventHandler(this.tabAgregar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 224);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "Metodo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 194);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Marcha";
            // 
            // txtAddMetodo
            // 
            this.txtAddMetodo.Location = new System.Drawing.Point(117, 221);
            this.txtAddMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddMetodo.Name = "txtAddMetodo";
            this.txtAddMetodo.Size = new System.Drawing.Size(169, 22);
            this.txtAddMetodo.TabIndex = 13;
            // 
            // txtAddMarcha
            // 
            this.txtAddMarcha.Location = new System.Drawing.Point(117, 191);
            this.txtAddMarcha.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddMarcha.Name = "txtAddMarcha";
            this.txtAddMarcha.Size = new System.Drawing.Size(169, 22);
            this.txtAddMarcha.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Kmph";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 134);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Boquilla";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Rpm";
            // 
            // txtAddKm
            // 
            this.txtAddKm.Location = new System.Drawing.Point(117, 161);
            this.txtAddKm.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddKm.Name = "txtAddKm";
            this.txtAddKm.Size = new System.Drawing.Size(169, 22);
            this.txtAddKm.TabIndex = 11;
            // 
            // txtAddBoquilla
            // 
            this.txtAddBoquilla.Location = new System.Drawing.Point(117, 131);
            this.txtAddBoquilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddBoquilla.Name = "txtAddBoquilla";
            this.txtAddBoquilla.Size = new System.Drawing.Size(169, 22);
            this.txtAddBoquilla.TabIndex = 10;
            // 
            // txtAddRPM
            // 
            this.txtAddRPM.Location = new System.Drawing.Point(117, 101);
            this.txtAddRPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddRPM.Name = "txtAddRPM";
            this.txtAddRPM.Size = new System.Drawing.Size(169, 22);
            this.txtAddRPM.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Psi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Codigo";
            // 
            // txtAddPSI
            // 
            this.txtAddPSI.Location = new System.Drawing.Point(117, 71);
            this.txtAddPSI.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddPSI.Name = "txtAddPSI";
            this.txtAddPSI.Size = new System.Drawing.Size(169, 22);
            this.txtAddPSI.TabIndex = 8;
            // 
            // txtAddCapacidad
            // 
            this.txtAddCapacidad.Location = new System.Drawing.Point(117, 41);
            this.txtAddCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCapacidad.Name = "txtAddCapacidad";
            this.txtAddCapacidad.Size = new System.Drawing.Size(169, 22);
            this.txtAddCapacidad.TabIndex = 7;
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Location = new System.Drawing.Point(117, 15);
            this.txtAddCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(169, 22);
            this.txtAddCodigo.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Vistas.Properties.Resources.Data_Edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(117, 251);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 66);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Vistas.Properties.Resources.Garbage_Closed;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(217, 251);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 66);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Vistas.Properties.Resources.Save1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(218, 251);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 60);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // SpraysBooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 435);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SpraysBooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpraysBooms";
            this.Load += new System.EventHandler(this.SpraysBooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDetalles.ResumeLayout(false);
            this.tabDetalles.PerformLayout();
            this.tabAgregar.ResumeLayout(false);
            this.tabAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetalles;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddPSI;
        private System.Windows.Forms.TextBox txtAddCapacidad;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAddMetodo;
        private System.Windows.Forms.TextBox txtAddMarcha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddKm;
        private System.Windows.Forms.TextBox txtAddBoquilla;
        private System.Windows.Forms.TextBox txtAddRPM;
        private System.Windows.Forms.TextBox txtEditMetodo;
        private System.Windows.Forms.TextBox txtEditMarcha;
        private System.Windows.Forms.TextBox txtEditKm;
        private System.Windows.Forms.TextBox txtEditBoquilla;
        private System.Windows.Forms.TextBox txtEditRpm;
        private System.Windows.Forms.TextBox txtEditPsi;
        private System.Windows.Forms.TextBox txtEditCapacidad;
        private System.Windows.Forms.TextBox txtEditCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}