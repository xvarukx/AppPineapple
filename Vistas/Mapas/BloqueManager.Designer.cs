namespace Vistas.Mapas
{
    partial class BloqueManager
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboPaquete = new System.Windows.Forms.ComboBox();
            this.comboPosicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBloque = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Etapas = new System.Windows.Forms.GroupBox();
            this.btnPaquete = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Etapas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(697, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(673, 486);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboPaquete
            // 
            this.comboPaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaquete.FormattingEnabled = true;
            this.comboPaquete.Location = new System.Drawing.Point(4, 53);
            this.comboPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.comboPaquete.Name = "comboPaquete";
            this.comboPaquete.Size = new System.Drawing.Size(122, 24);
            this.comboPaquete.TabIndex = 4;
            this.comboPaquete.SelectedIndexChanged += new System.EventHandler(this.comboPaquete_SelectedIndexChanged);
            // 
            // comboPosicion
            // 
            this.comboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPosicion.FormattingEnabled = true;
            this.comboPosicion.Location = new System.Drawing.Point(4, 111);
            this.comboPosicion.Margin = new System.Windows.Forms.Padding(4);
            this.comboPosicion.Name = "comboPosicion";
            this.comboPosicion.Size = new System.Drawing.Size(122, 24);
            this.comboPosicion.TabIndex = 6;
            this.comboPosicion.SelectedIndexChanged += new System.EventHandler(this.comboPosicion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Etapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bloque:";
            // 
            // comboBloque
            // 
            this.comboBloque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBloque.FormattingEnabled = true;
            this.comboBloque.Location = new System.Drawing.Point(697, 40);
            this.comboBloque.Margin = new System.Windows.Forms.Padding(4);
            this.comboBloque.Name = "comboBloque";
            this.comboBloque.Size = new System.Drawing.Size(139, 24);
            this.comboBloque.TabIndex = 11;
            this.comboBloque.SelectedIndexChanged += new System.EventHandler(this.comboBloque_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(499, 508);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Seleccionar Todos/Limpiar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Etapas
            // 
            this.Etapas.Controls.Add(this.comboPaquete);
            this.Etapas.Controls.Add(this.btnPaquete);
            this.Etapas.Controls.Add(this.comboPosicion);
            this.Etapas.Controls.Add(this.label3);
            this.Etapas.Controls.Add(this.label2);
            this.Etapas.Location = new System.Drawing.Point(697, 189);
            this.Etapas.Name = "Etapas";
            this.Etapas.Size = new System.Drawing.Size(150, 214);
            this.Etapas.TabIndex = 15;
            this.Etapas.TabStop = false;
            this.Etapas.Text = "Etapas";
            // 
            // btnPaquete
            // 
            this.btnPaquete.BackColor = System.Drawing.Color.White;
            this.btnPaquete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquete.Image = global::Vistas.Properties.Resources.Timer_WF2;
            this.btnPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquete.Location = new System.Drawing.Point(4, 157);
            this.btnPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaquete.Name = "btnPaquete";
            this.btnPaquete.Size = new System.Drawing.Size(135, 31);
            this.btnPaquete.TabIndex = 5;
            this.btnPaquete.Text = "Aplicar";
            this.btnPaquete.UseVisualStyleBackColor = false;
            this.btnPaquete.Click += new System.EventHandler(this.btnPaquete_Click);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Image = global::Vistas.Properties.Resources.Calender_Refresh_WF;
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(697, 139);
            this.btnDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(139, 28);
            this.btnDate.TabIndex = 3;
            this.btnDate.Text = "Aplicar";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarGrupo);
            this.groupBox1.Location = new System.Drawing.Point(697, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 92);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // btnLimpiarGrupo
            // 
            this.btnLimpiarGrupo.BackColor = System.Drawing.Color.White;
            this.btnLimpiarGrupo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLimpiarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarGrupo.Location = new System.Drawing.Point(8, 39);
            this.btnLimpiarGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarGrupo.Name = "btnLimpiarGrupo";
            this.btnLimpiarGrupo.Size = new System.Drawing.Size(135, 31);
            this.btnLimpiarGrupo.TabIndex = 11;
            this.btnLimpiarGrupo.Text = "Limpiar Datos";
            this.btnLimpiarGrupo.UseVisualStyleBackColor = false;
            this.btnLimpiarGrupo.Click += new System.EventHandler(this.btnLimpiarGrupo_Click);
            // 
            // BloqueManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Etapas);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBloque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BloqueManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloqueManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloqueManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BloqueManager_FormClosed);
            this.Load += new System.EventHandler(this.BloqueManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Etapas.ResumeLayout(false);
            this.Etapas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.ComboBox comboPaquete;
        private System.Windows.Forms.Button btnPaquete;
        private System.Windows.Forms.ComboBox comboPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBloque;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox Etapas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarGrupo;
    }
}