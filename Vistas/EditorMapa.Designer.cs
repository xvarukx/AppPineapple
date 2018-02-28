namespace Vistas
{
    partial class EditorMapa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.lblLote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbBloque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSeccion = new System.Windows.Forms.Panel();
            this.dateSiembra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarSeccion = new System.Windows.Forms.Button();
            this.btnAceptarSeccion = new System.Windows.Forms.Button();
            this.numPlantas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBloque = new System.Windows.Forms.Panel();
            this.btnCancelarBloque = new System.Windows.Forms.Button();
            this.btnAceptarBloque = new System.Windows.Forms.Button();
            this.numPlantasBloque = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAreaBloque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAreaLote = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panelSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlantas)).BeginInit();
            this.panelBloque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlantasBloque)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(100, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Subir Mapa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(118, 4);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(50, 24);
            this.lblLote.TabIndex = 7;
            this.lblLote.Text = "2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lote:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbBloque
            // 
            this.cmbBloque.FormattingEnabled = true;
            this.cmbBloque.Location = new System.Drawing.Point(60, 13);
            this.cmbBloque.Name = "cmbBloque";
            this.cmbBloque.Size = new System.Drawing.Size(53, 21);
            this.cmbBloque.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bloque";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(60, 39);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Area:";
            // 
            // panelSeccion
            // 
            this.panelSeccion.BackColor = System.Drawing.Color.Honeydew;
            this.panelSeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSeccion.Controls.Add(this.dateSiembra);
            this.panelSeccion.Controls.Add(this.label2);
            this.panelSeccion.Controls.Add(this.btnCancelarSeccion);
            this.panelSeccion.Controls.Add(this.btnAceptarSeccion);
            this.panelSeccion.Controls.Add(this.numPlantas);
            this.panelSeccion.Controls.Add(this.label6);
            this.panelSeccion.Controls.Add(this.label4);
            this.panelSeccion.Controls.Add(this.label5);
            this.panelSeccion.Controls.Add(this.cmbBloque);
            this.panelSeccion.Controls.Add(this.txtArea);
            this.panelSeccion.Location = new System.Drawing.Point(200, 22);
            this.panelSeccion.Name = "panelSeccion";
            this.panelSeccion.Size = new System.Drawing.Size(365, 136);
            this.panelSeccion.TabIndex = 14;
            this.panelSeccion.Visible = false;
            this.panelSeccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeccion_Paint);
            // 
            // dateSiembra
            // 
            this.dateSiembra.Location = new System.Drawing.Point(215, 13);
            this.dateSiembra.Name = "dateSiembra";
            this.dateSiembra.Size = new System.Drawing.Size(141, 20);
            this.dateSiembra.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Siembra:";
            // 
            // btnCancelarSeccion
            // 
            this.btnCancelarSeccion.BackColor = System.Drawing.Color.White;
            this.btnCancelarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSeccion.Location = new System.Drawing.Point(105, 106);
            this.btnCancelarSeccion.Name = "btnCancelarSeccion";
            this.btnCancelarSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarSeccion.TabIndex = 17;
            this.btnCancelarSeccion.Text = "Cancelar";
            this.btnCancelarSeccion.UseVisualStyleBackColor = false;
            this.btnCancelarSeccion.Click += new System.EventHandler(this.btnCancelarSeccion_Click);
            // 
            // btnAceptarSeccion
            // 
            this.btnAceptarSeccion.BackColor = System.Drawing.Color.White;
            this.btnAceptarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarSeccion.Location = new System.Drawing.Point(17, 106);
            this.btnAceptarSeccion.Name = "btnAceptarSeccion";
            this.btnAceptarSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarSeccion.TabIndex = 16;
            this.btnAceptarSeccion.Text = "Aceptar";
            this.btnAceptarSeccion.UseVisualStyleBackColor = false;
            this.btnAceptarSeccion.Click += new System.EventHandler(this.btnAceptarSeccion_Click);
            // 
            // numPlantas
            // 
            this.numPlantas.Location = new System.Drawing.Point(105, 69);
            this.numPlantas.Name = "numPlantas";
            this.numPlantas.Size = new System.Drawing.Size(65, 20);
            this.numPlantas.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numero Plantas:";
            // 
            // panelBloque
            // 
            this.panelBloque.BackColor = System.Drawing.Color.Honeydew;
            this.panelBloque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBloque.Controls.Add(this.btnCancelarBloque);
            this.panelBloque.Controls.Add(this.btnAceptarBloque);
            this.panelBloque.Controls.Add(this.numPlantasBloque);
            this.panelBloque.Controls.Add(this.label7);
            this.panelBloque.Controls.Add(this.label9);
            this.panelBloque.Controls.Add(this.txtAreaBloque);
            this.panelBloque.Location = new System.Drawing.Point(11, 17);
            this.panelBloque.Name = "panelBloque";
            this.panelBloque.Size = new System.Drawing.Size(183, 139);
            this.panelBloque.TabIndex = 18;
            this.panelBloque.Visible = false;
            // 
            // btnCancelarBloque
            // 
            this.btnCancelarBloque.BackColor = System.Drawing.Color.White;
            this.btnCancelarBloque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBloque.Location = new System.Drawing.Point(101, 99);
            this.btnCancelarBloque.Name = "btnCancelarBloque";
            this.btnCancelarBloque.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBloque.TabIndex = 17;
            this.btnCancelarBloque.Text = "Cancelar";
            this.btnCancelarBloque.UseVisualStyleBackColor = false;
            this.btnCancelarBloque.Click += new System.EventHandler(this.btnCancelarBloque_Click);
            // 
            // btnAceptarBloque
            // 
            this.btnAceptarBloque.BackColor = System.Drawing.Color.White;
            this.btnAceptarBloque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarBloque.Location = new System.Drawing.Point(17, 99);
            this.btnAceptarBloque.Name = "btnAceptarBloque";
            this.btnAceptarBloque.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBloque.TabIndex = 16;
            this.btnAceptarBloque.Text = "Aceptar";
            this.btnAceptarBloque.UseVisualStyleBackColor = false;
            this.btnAceptarBloque.Click += new System.EventHandler(this.btnAceptarBloque_Click);
            // 
            // numPlantasBloque
            // 
            this.numPlantasBloque.Location = new System.Drawing.Point(107, 40);
            this.numPlantasBloque.Name = "numPlantasBloque";
            this.numPlantasBloque.Size = new System.Drawing.Size(65, 20);
            this.numPlantasBloque.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero Plantas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Area:";
            // 
            // txtAreaBloque
            // 
            this.txtAreaBloque.Location = new System.Drawing.Point(62, 10);
            this.txtAreaBloque.Name = "txtAreaBloque";
            this.txtAreaBloque.Size = new System.Drawing.Size(100, 20);
            this.txtAreaBloque.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAreaLote);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLote);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 179);
            this.panel1.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(19, 135);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 37);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar Mapa";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Area:";
            // 
            // txtAreaLote
            // 
            this.txtAreaLote.Location = new System.Drawing.Point(68, 39);
            this.txtAreaLote.Name = "txtAreaLote";
            this.txtAreaLote.Size = new System.Drawing.Size(100, 20);
            this.txtAreaLote.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panelBloque);
            this.panel2.Controls.Add(this.panelSeccion);
            this.panel2.Location = new System.Drawing.Point(232, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 179);
            this.panel2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Vistas.Properties.Resources.seccion1;
            this.button3.Location = new System.Drawing.Point(195, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 155);
            this.button3.TabIndex = 4;
            this.button3.Text = " Crear Seccion";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Vistas.Properties.Resources.bloque2;
            this.button4.Location = new System.Drawing.Point(11, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 151);
            this.button4.TabIndex = 5;
            this.button4.Text = "Crear Bloque";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::Vistas.Properties.Resources.Garbage2;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(873, 207);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 71);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            this.btnBorrar.MouseLeave += new System.EventHandler(this.btnBorrar_MouseLeave);
            this.btnBorrar.MouseHover += new System.EventHandler(this.btnBorrar_MouseHover);
            this.btnBorrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBorrar_MouseMove);
            // 
            // EditorMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(983, 665);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "EditorMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditorMapa_MouseUp);
            this.panelSeccion.ResumeLayout(false);
            this.panelSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlantas)).EndInit();
            this.panelBloque.ResumeLayout(false);
            this.panelBloque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlantasBloque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBloque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSeccion;
        private System.Windows.Forms.Button btnCancelarSeccion;
        private System.Windows.Forms.Button btnAceptarSeccion;
        private System.Windows.Forms.NumericUpDown numPlantas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelBloque;
        private System.Windows.Forms.Button btnCancelarBloque;
        private System.Windows.Forms.Button btnAceptarBloque;
        private System.Windows.Forms.NumericUpDown numPlantasBloque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAreaBloque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAreaLote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateSiembra;
        private System.Windows.Forms.Label label2;
    }
}

