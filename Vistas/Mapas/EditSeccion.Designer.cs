namespace Vistas.Mapas
{
    partial class EditSeccion
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
            this.txtFSiembra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.fecha1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbPlantas = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtBloque = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFSiembra
            // 
            this.txtFSiembra.Enabled = false;
            this.txtFSiembra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFSiembra.Location = new System.Drawing.Point(170, 155);
            this.txtFSiembra.Name = "txtFSiembra";
            this.txtFSiembra.Size = new System.Drawing.Size(100, 22);
            this.txtFSiembra.TabIndex = 6;
            this.txtFSiembra.ValueChanged += new System.EventHandler(this.txtFSiembra_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Bloque:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(170, 127);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Peso de la Semilla:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(170, 98);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo de Semilla:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(20, 214);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ReadOnly = true;
            this.txtDetalle.Size = new System.Drawing.Size(257, 153);
            this.txtDetalle.TabIndex = 8;
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Location = new System.Drawing.Point(38, 160);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(103, 16);
            this.fecha1.TabIndex = 53;
            this.fecha1.Text = "Fecha Siembra:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(170, 69);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 3;
            this.txtArea.Text = "0";
            this.txtArea.TextChanged += new System.EventHandler(this.validarNumeros);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(75, 72);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(69, 16);
            this.lbArea.TabIndex = 51;
            this.lbArea.Text = "Area (Ha):";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(170, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.validarNumeros);
            // 
            // lbPlantas
            // 
            this.lbPlantas.AutoSize = true;
            this.lbPlantas.Location = new System.Drawing.Point(10, 43);
            this.lbPlantas.Name = "lbPlantas";
            this.lbPlantas.Size = new System.Drawing.Size(131, 16);
            this.lbPlantas.TabIndex = 49;
            this.lbPlantas.Text = "Cantidad de plantas:";
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Gray;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Location = new System.Drawing.Point(140, 373);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(67, 23);
            this.btnHistorial.TabIndex = 73;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Visible = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(20, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 23);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(213, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(67, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Editar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtBloque
            // 
            this.txtBloque.Location = new System.Drawing.Point(170, 12);
            this.txtBloque.Name = "txtBloque";
            this.txtBloque.ReadOnly = true;
            this.txtBloque.Size = new System.Drawing.Size(100, 22);
            this.txtBloque.TabIndex = 1;
            // 
            // EditSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 407);
            this.Controls.Add(this.txtBloque);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFSiembra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbPlantas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSeccion";
            this.Load += new System.EventHandler(this.EditSeccion_Load);
            this.TextChanged += new System.EventHandler(this.validarNumeros);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtFSiembra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbPlantas;
        public System.Windows.Forms.Button btnHistorial;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtBloque;
    }
}