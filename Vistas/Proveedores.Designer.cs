namespace Vistas
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalles = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditDescripcion = new System.Windows.Forms.TextBox();
            this.txtEditCorreo = new System.Windows.Forms.TextBox();
            this.txtEditDireccion = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditTelefono = new System.Windows.Forms.TextBox();
            this.txtEditNombre = new System.Windows.Forms.TextBox();
            this.txtEditCodigo = new System.Windows.Forms.TextBox();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddDescripcion = new System.Windows.Forms.TextBox();
            this.txtAddCorreo = new System.Windows.Forms.TextBox();
            this.txtAddDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddTelefono = new System.Windows.Forms.TextBox();
            this.txtAddNombre = new System.Windows.Forms.TextBox();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
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
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(74, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(350, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 418);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDetalles);
            this.tabControl1.Controls.Add(this.tabAgregar);
            this.tabControl1.Location = new System.Drawing.Point(481, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 445);
            this.tabControl1.TabIndex = 4;
            // 
            // tabDetalles
            // 
            this.tabDetalles.Controls.Add(this.button1);
            this.tabDetalles.Controls.Add(this.label11);
            this.tabDetalles.Controls.Add(this.label12);
            this.tabDetalles.Controls.Add(this.label13);
            this.tabDetalles.Controls.Add(this.txtEditDescripcion);
            this.tabDetalles.Controls.Add(this.txtEditCorreo);
            this.tabDetalles.Controls.Add(this.txtEditDireccion);
            this.tabDetalles.Controls.Add(this.btnEditar);
            this.tabDetalles.Controls.Add(this.btnEliminar);
            this.tabDetalles.Controls.Add(this.label3);
            this.tabDetalles.Controls.Add(this.label2);
            this.tabDetalles.Controls.Add(this.label1);
            this.tabDetalles.Controls.Add(this.txtEditTelefono);
            this.tabDetalles.Controls.Add(this.txtEditNombre);
            this.tabDetalles.Controls.Add(this.txtEditCodigo);
            this.tabDetalles.Location = new System.Drawing.Point(4, 25);
            this.tabDetalles.Name = "tabDetalles";
            this.tabDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalles.Size = new System.Drawing.Size(300, 416);
            this.tabDetalles.TabIndex = 0;
            this.tabDetalles.Text = "Detalles";
            this.tabDetalles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Vistas.Properties.Resources.Garbage_Closed;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(189, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 65);
            this.button1.TabIndex = 42;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Correo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Direccion";
            // 
            // txtEditDescripcion
            // 
            this.txtEditDescripcion.Location = new System.Drawing.Point(98, 156);
            this.txtEditDescripcion.Multiline = true;
            this.txtEditDescripcion.Name = "txtEditDescripcion";
            this.txtEditDescripcion.Size = new System.Drawing.Size(168, 116);
            this.txtEditDescripcion.TabIndex = 5;
            // 
            // txtEditCorreo
            // 
            this.txtEditCorreo.Location = new System.Drawing.Point(98, 128);
            this.txtEditCorreo.Name = "txtEditCorreo";
            this.txtEditCorreo.Size = new System.Drawing.Size(168, 22);
            this.txtEditCorreo.TabIndex = 4;
            // 
            // txtEditDireccion
            // 
            this.txtEditDireccion.Location = new System.Drawing.Point(98, 101);
            this.txtEditDireccion.Name = "txtEditDireccion";
            this.txtEditDireccion.Size = new System.Drawing.Size(168, 22);
            this.txtEditDireccion.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Vistas.Properties.Resources.Data_Edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(98, 278);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 65);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(352, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 64);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // txtEditTelefono
            // 
            this.txtEditTelefono.Location = new System.Drawing.Point(98, 73);
            this.txtEditTelefono.Name = "txtEditTelefono";
            this.txtEditTelefono.Size = new System.Drawing.Size(168, 22);
            this.txtEditTelefono.TabIndex = 2;
            // 
            // txtEditNombre
            // 
            this.txtEditNombre.Location = new System.Drawing.Point(98, 45);
            this.txtEditNombre.Name = "txtEditNombre";
            this.txtEditNombre.Size = new System.Drawing.Size(168, 22);
            this.txtEditNombre.TabIndex = 1;
            // 
            // txtEditCodigo
            // 
            this.txtEditCodigo.Location = new System.Drawing.Point(98, 17);
            this.txtEditCodigo.Name = "txtEditCodigo";
            this.txtEditCodigo.ReadOnly = true;
            this.txtEditCodigo.Size = new System.Drawing.Size(168, 22);
            this.txtEditCodigo.TabIndex = 0;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.label4);
            this.tabAgregar.Controls.Add(this.label5);
            this.tabAgregar.Controls.Add(this.label8);
            this.tabAgregar.Controls.Add(this.label9);
            this.tabAgregar.Controls.Add(this.label10);
            this.tabAgregar.Controls.Add(this.txtAddDescripcion);
            this.tabAgregar.Controls.Add(this.txtAddCorreo);
            this.tabAgregar.Controls.Add(this.txtAddDireccion);
            this.tabAgregar.Controls.Add(this.label6);
            this.tabAgregar.Controls.Add(this.txtAddTelefono);
            this.tabAgregar.Controls.Add(this.txtAddNombre);
            this.tabAgregar.Controls.Add(this.txtAddCodigo);
            this.tabAgregar.Controls.Add(this.btnAgregar);
            this.tabAgregar.Location = new System.Drawing.Point(4, 25);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregar.Size = new System.Drawing.Size(300, 416);
            this.tabAgregar.TabIndex = 1;
            this.tabAgregar.Text = "Agregar Nuevo";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nombre";
            // 
            // txtAddDescripcion
            // 
            this.txtAddDescripcion.Location = new System.Drawing.Point(98, 156);
            this.txtAddDescripcion.Multiline = true;
            this.txtAddDescripcion.Name = "txtAddDescripcion";
            this.txtAddDescripcion.Size = new System.Drawing.Size(168, 116);
            this.txtAddDescripcion.TabIndex = 15;
            // 
            // txtAddCorreo
            // 
            this.txtAddCorreo.Location = new System.Drawing.Point(98, 128);
            this.txtAddCorreo.Name = "txtAddCorreo";
            this.txtAddCorreo.Size = new System.Drawing.Size(168, 22);
            this.txtAddCorreo.TabIndex = 14;
            // 
            // txtAddDireccion
            // 
            this.txtAddDireccion.Location = new System.Drawing.Point(98, 101);
            this.txtAddDireccion.Name = "txtAddDireccion";
            this.txtAddDireccion.Size = new System.Drawing.Size(168, 22);
            this.txtAddDireccion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Codigo";
            // 
            // txtAddTelefono
            // 
            this.txtAddTelefono.Location = new System.Drawing.Point(98, 73);
            this.txtAddTelefono.Name = "txtAddTelefono";
            this.txtAddTelefono.Size = new System.Drawing.Size(168, 22);
            this.txtAddTelefono.TabIndex = 8;
            // 
            // txtAddNombre
            // 
            this.txtAddNombre.Location = new System.Drawing.Point(98, 45);
            this.txtAddNombre.Name = "txtAddNombre";
            this.txtAddNombre.Size = new System.Drawing.Size(168, 22);
            this.txtAddNombre.TabIndex = 7;
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Location = new System.Drawing.Point(98, 17);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(168, 22);
            this.txtAddCodigo.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Vistas.Properties.Resources.Save1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(189, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 65);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditDescripcion;
        private System.Windows.Forms.TextBox txtEditCorreo;
        private System.Windows.Forms.TextBox txtEditDireccion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditTelefono;
        private System.Windows.Forms.TextBox txtEditNombre;
        private System.Windows.Forms.TextBox txtEditCodigo;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddDescripcion;
        private System.Windows.Forms.TextBox txtAddCorreo;
        private System.Windows.Forms.TextBox txtAddDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddTelefono;
        private System.Windows.Forms.TextBox txtAddNombre;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.Button button1;
    }
}