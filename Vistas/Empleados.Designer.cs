namespace Vistas
{
    partial class Empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalles = new System.Windows.Forms.TabPage();
            this.dtEditFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditPuesto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtEditTelefono = new System.Windows.Forms.TextBox();
            this.txtEditApellido2 = new System.Windows.Forms.TextBox();
            this.txtEditApellido = new System.Windows.Forms.TextBox();
            this.txtEditNombre = new System.Windows.Forms.TextBox();
            this.txtEditCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.dtAddFecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddPuesto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddTelefono = new System.Windows.Forms.TextBox();
            this.txtAddApellido2 = new System.Windows.Forms.TextBox();
            this.txtAddApellido = new System.Windows.Forms.TextBox();
            this.txtAddNombre = new System.Windows.Forms.TextBox();
            this.txtAddCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDetalles.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDetalles);
            this.tabControl1.Controls.Add(this.tabAgregar);
            this.tabControl1.Location = new System.Drawing.Point(489, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 353);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDetalles
            // 
            this.tabDetalles.Controls.Add(this.dtEditFecha);
            this.tabDetalles.Controls.Add(this.label13);
            this.tabDetalles.Controls.Add(this.txtEditPuesto);
            this.tabDetalles.Controls.Add(this.label12);
            this.tabDetalles.Controls.Add(this.btnEliminar);
            this.tabDetalles.Controls.Add(this.btnModificar);
            this.tabDetalles.Controls.Add(this.txtEditTelefono);
            this.tabDetalles.Controls.Add(this.txtEditApellido2);
            this.tabDetalles.Controls.Add(this.txtEditApellido);
            this.tabDetalles.Controls.Add(this.txtEditNombre);
            this.tabDetalles.Controls.Add(this.txtEditCedula);
            this.tabDetalles.Controls.Add(this.label5);
            this.tabDetalles.Controls.Add(this.label4);
            this.tabDetalles.Controls.Add(this.label3);
            this.tabDetalles.Controls.Add(this.label2);
            this.tabDetalles.Controls.Add(this.label1);
            this.tabDetalles.Location = new System.Drawing.Point(4, 25);
            this.tabDetalles.Name = "tabDetalles";
            this.tabDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalles.Size = new System.Drawing.Size(333, 324);
            this.tabDetalles.TabIndex = 0;
            this.tabDetalles.Text = "Detalles";
            this.tabDetalles.UseVisualStyleBackColor = true;
            // 
            // dtEditFecha
            // 
            this.dtEditFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditFecha.Location = new System.Drawing.Point(183, 202);
            this.dtEditFecha.Name = "dtEditFecha";
            this.dtEditFecha.Size = new System.Drawing.Size(135, 22);
            this.dtEditFecha.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Fecha de Contratacion:";
            // 
            // txtEditPuesto
            // 
            this.txtEditPuesto.Location = new System.Drawing.Point(183, 173);
            this.txtEditPuesto.Name = "txtEditPuesto";
            this.txtEditPuesto.Size = new System.Drawing.Size(135, 22);
            this.txtEditPuesto.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Puesto:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Vistas.Properties.Resources.Garbage_Closed;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(248, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 68);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Vistas.Properties.Resources.Data_Edit;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(170, 250);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 68);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtEditTelefono
            // 
            this.txtEditTelefono.Location = new System.Drawing.Point(183, 142);
            this.txtEditTelefono.Name = "txtEditTelefono";
            this.txtEditTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtEditTelefono.TabIndex = 5;
            // 
            // txtEditApellido2
            // 
            this.txtEditApellido2.Location = new System.Drawing.Point(183, 110);
            this.txtEditApellido2.Name = "txtEditApellido2";
            this.txtEditApellido2.Size = new System.Drawing.Size(135, 22);
            this.txtEditApellido2.TabIndex = 4;
            // 
            // txtEditApellido
            // 
            this.txtEditApellido.Location = new System.Drawing.Point(183, 78);
            this.txtEditApellido.Name = "txtEditApellido";
            this.txtEditApellido.Size = new System.Drawing.Size(135, 22);
            this.txtEditApellido.TabIndex = 3;
            // 
            // txtEditNombre
            // 
            this.txtEditNombre.Location = new System.Drawing.Point(183, 46);
            this.txtEditNombre.Name = "txtEditNombre";
            this.txtEditNombre.Size = new System.Drawing.Size(135, 22);
            this.txtEditNombre.TabIndex = 2;
            // 
            // txtEditCedula
            // 
            this.txtEditCedula.Location = new System.Drawing.Point(183, 14);
            this.txtEditCedula.Name = "txtEditCedula";
            this.txtEditCedula.Size = new System.Drawing.Size(135, 22);
            this.txtEditCedula.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.dtAddFecha);
            this.tabAgregar.Controls.Add(this.label14);
            this.tabAgregar.Controls.Add(this.txtAddPuesto);
            this.tabAgregar.Controls.Add(this.label15);
            this.tabAgregar.Controls.Add(this.txtAddTelefono);
            this.tabAgregar.Controls.Add(this.txtAddApellido2);
            this.tabAgregar.Controls.Add(this.txtAddApellido);
            this.tabAgregar.Controls.Add(this.txtAddNombre);
            this.tabAgregar.Controls.Add(this.txtAddCedula);
            this.tabAgregar.Controls.Add(this.label6);
            this.tabAgregar.Controls.Add(this.label7);
            this.tabAgregar.Controls.Add(this.label8);
            this.tabAgregar.Controls.Add(this.label9);
            this.tabAgregar.Controls.Add(this.label10);
            this.tabAgregar.Controls.Add(this.btnAgregar);
            this.tabAgregar.Location = new System.Drawing.Point(4, 25);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(333, 324);
            this.tabAgregar.TabIndex = 1;
            this.tabAgregar.Text = "Agregar Nuevo";
            this.tabAgregar.UseVisualStyleBackColor = true;
            this.tabAgregar.Click += new System.EventHandler(this.tabAgregar_Click);
            // 
            // dtAddFecha
            // 
            this.dtAddFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAddFecha.Location = new System.Drawing.Point(183, 202);
            this.dtAddFecha.Name = "dtAddFecha";
            this.dtAddFecha.Size = new System.Drawing.Size(135, 22);
            this.dtAddFecha.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Fecha de Contratacion:";
            // 
            // txtAddPuesto
            // 
            this.txtAddPuesto.Location = new System.Drawing.Point(183, 174);
            this.txtAddPuesto.Name = "txtAddPuesto";
            this.txtAddPuesto.Size = new System.Drawing.Size(135, 22);
            this.txtAddPuesto.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Puesto:";
            // 
            // txtAddTelefono
            // 
            this.txtAddTelefono.Location = new System.Drawing.Point(183, 142);
            this.txtAddTelefono.Name = "txtAddTelefono";
            this.txtAddTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtAddTelefono.TabIndex = 21;
            // 
            // txtAddApellido2
            // 
            this.txtAddApellido2.Location = new System.Drawing.Point(183, 110);
            this.txtAddApellido2.Name = "txtAddApellido2";
            this.txtAddApellido2.Size = new System.Drawing.Size(135, 22);
            this.txtAddApellido2.TabIndex = 20;
            // 
            // txtAddApellido
            // 
            this.txtAddApellido.Location = new System.Drawing.Point(183, 78);
            this.txtAddApellido.Name = "txtAddApellido";
            this.txtAddApellido.Size = new System.Drawing.Size(135, 22);
            this.txtAddApellido.TabIndex = 19;
            // 
            // txtAddNombre
            // 
            this.txtAddNombre.Location = new System.Drawing.Point(183, 46);
            this.txtAddNombre.Name = "txtAddNombre";
            this.txtAddNombre.Size = new System.Drawing.Size(135, 22);
            this.txtAddNombre.TabIndex = 18;
            // 
            // txtAddCedula
            // 
            this.txtAddCedula.Location = new System.Drawing.Point(183, 14);
            this.txtAddCedula.Name = "txtAddCedula";
            this.txtAddCedula.Size = new System.Drawing.Size(135, 22);
            this.txtAddCedula.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Segundo Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Primer Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cedula:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Vistas.Properties.Resources.Save1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(248, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 64);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(82, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 22);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Buscar:";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 557);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choferes";
            this.Load += new System.EventHandler(this.Choferes_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.TextBox txtEditTelefono;
        private System.Windows.Forms.TextBox txtEditApellido2;
        private System.Windows.Forms.TextBox txtEditApellido;
        private System.Windows.Forms.TextBox txtEditNombre;
        private System.Windows.Forms.TextBox txtEditCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAddTelefono;
        private System.Windows.Forms.TextBox txtAddApellido2;
        private System.Windows.Forms.TextBox txtAddApellido;
        private System.Windows.Forms.TextBox txtAddNombre;
        private System.Windows.Forms.TextBox txtAddCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtEditFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditPuesto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtAddFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddPuesto;
        private System.Windows.Forms.Label label15;
    }
}