namespace Vistas
{
    partial class Vehiculos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalles = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditDescripcion = new System.Windows.Forms.TextBox();
            this.txtEditMarca = new System.Windows.Forms.TextBox();
            this.txtEditCodigo = new System.Windows.Forms.TextBox();
            this.tabAgregar = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddDescripcion = new System.Windows.Forms.TextBox();
            this.txtAddMarca = new System.Windows.Forms.TextBox();
            this.txtAddCodigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDetalles.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDetalles);
            this.tabControl1.Controls.Add(this.tabAgregar);
            this.tabControl1.Location = new System.Drawing.Point(434, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDetalles
            // 
            this.tabDetalles.Controls.Add(this.btnEditar);
            this.tabDetalles.Controls.Add(this.btnEliminar);
            this.tabDetalles.Controls.Add(this.label3);
            this.tabDetalles.Controls.Add(this.label2);
            this.tabDetalles.Controls.Add(this.label1);
            this.tabDetalles.Controls.Add(this.txtEditDescripcion);
            this.tabDetalles.Controls.Add(this.txtEditMarca);
            this.tabDetalles.Controls.Add(this.txtEditCodigo);
            this.tabDetalles.Location = new System.Drawing.Point(4, 25);
            this.tabDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetalles.Name = "tabDetalles";
            this.tabDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.tabDetalles.Size = new System.Drawing.Size(264, 323);
            this.tabDetalles.TabIndex = 0;
            this.tabDetalles.Text = "Detalles";
            this.tabDetalles.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Vistas.Properties.Resources.Data_Edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(87, 251);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 64);
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
            this.btnEliminar.Location = new System.Drawing.Point(176, 251);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 64);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // txtEditDescripcion
            // 
            this.txtEditDescripcion.Location = new System.Drawing.Point(109, 138);
            this.txtEditDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditDescripcion.Multiline = true;
            this.txtEditDescripcion.Name = "txtEditDescripcion";
            this.txtEditDescripcion.Size = new System.Drawing.Size(132, 105);
            this.txtEditDescripcion.TabIndex = 2;
            // 
            // txtEditMarca
            // 
            this.txtEditMarca.Location = new System.Drawing.Point(109, 85);
            this.txtEditMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditMarca.Name = "txtEditMarca";
            this.txtEditMarca.Size = new System.Drawing.Size(132, 22);
            this.txtEditMarca.TabIndex = 1;
            // 
            // txtEditCodigo
            // 
            this.txtEditCodigo.Location = new System.Drawing.Point(109, 34);
            this.txtEditCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditCodigo.Name = "txtEditCodigo";
            this.txtEditCodigo.ReadOnly = true;
            this.txtEditCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtEditCodigo.TabIndex = 0;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.btnAgregar);
            this.tabAgregar.Controls.Add(this.label4);
            this.tabAgregar.Controls.Add(this.label5);
            this.tabAgregar.Controls.Add(this.label6);
            this.tabAgregar.Controls.Add(this.txtAddDescripcion);
            this.tabAgregar.Controls.Add(this.txtAddMarca);
            this.tabAgregar.Controls.Add(this.txtAddCodigo);
            this.tabAgregar.Location = new System.Drawing.Point(4, 25);
            this.tabAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.Padding = new System.Windows.Forms.Padding(4);
            this.tabAgregar.Size = new System.Drawing.Size(264, 323);
            this.tabAgregar.TabIndex = 1;
            this.tabAgregar.Text = "Agregar Nuevo";
            this.tabAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Vistas.Properties.Resources.Save1;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(87, 251);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 67);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Codigo";
            // 
            // txtAddDescripcion
            // 
            this.txtAddDescripcion.Location = new System.Drawing.Point(109, 138);
            this.txtAddDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddDescripcion.Multiline = true;
            this.txtAddDescripcion.Name = "txtAddDescripcion";
            this.txtAddDescripcion.Size = new System.Drawing.Size(132, 107);
            this.txtAddDescripcion.TabIndex = 8;
            // 
            // txtAddMarca
            // 
            this.txtAddMarca.Location = new System.Drawing.Point(109, 85);
            this.txtAddMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddMarca.Name = "txtAddMarca";
            this.txtAddMarca.Size = new System.Drawing.Size(132, 22);
            this.txtAddMarca.TabIndex = 7;
            // 
            // txtAddCodigo
            // 
            this.txtAddCodigo.Location = new System.Drawing.Point(109, 34);
            this.txtAddCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddCodigo.Name = "txtAddCodigo";
            this.txtAddCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtAddCodigo.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(413, 446);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(77, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(351, 22);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Buscar";
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(709, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDetalles.ResumeLayout(false);
            this.tabDetalles.PerformLayout();
            this.tabAgregar.ResumeLayout(false);
            this.tabAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetalles;
        private System.Windows.Forms.TabPage tabAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditDescripcion;
        private System.Windows.Forms.TextBox txtEditMarca;
        private System.Windows.Forms.TextBox txtEditCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddDescripcion;
        private System.Windows.Forms.TextBox txtAddMarca;
        private System.Windows.Forms.TextBox txtAddCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}