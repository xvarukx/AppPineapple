namespace Vistas.Mapas
{
    partial class AddSeccion
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.fecha1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbPlantas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtFSiembra = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(172, 135);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Peso de la Semilla:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(172, 106);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tipo de Semilla:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(205, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(15, 192);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(257, 153);
            this.txtDetalle.TabIndex = 6;
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Location = new System.Drawing.Point(40, 169);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(103, 16);
            this.fecha1.TabIndex = 32;
            this.fecha1.Text = "Fecha Siembra:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(172, 77);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 2;
            this.txtArea.Text = "0";
            this.txtArea.TextChanged += new System.EventHandler(this.validarNumeros);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(74, 80);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(69, 16);
            this.lbArea.TabIndex = 30;
            this.lbArea.Text = "Area (Ha):";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(172, 48);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextChanged += new System.EventHandler(this.validarNumeros);
            // 
            // lbPlantas
            // 
            this.lbPlantas.AutoSize = true;
            this.lbPlantas.Location = new System.Drawing.Point(12, 51);
            this.lbPlantas.Name = "lbPlantas";
            this.lbPlantas.Size = new System.Drawing.Size(131, 16);
            this.lbPlantas.TabIndex = 28;
            this.lbPlantas.Text = "Cantidad de plantas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Bloque:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFSiembra
            // 
            this.txtFSiembra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFSiembra.Location = new System.Drawing.Point(172, 164);
            this.txtFSiembra.Name = "txtFSiembra";
            this.txtFSiembra.Size = new System.Drawing.Size(100, 22);
            this.txtFSiembra.TabIndex = 5;
            // 
            // AddSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 389);
            this.Controls.Add(this.txtFSiembra);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbPlantas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbPlantas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker txtFSiembra;
    }
}