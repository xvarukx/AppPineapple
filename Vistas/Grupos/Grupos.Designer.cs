namespace Vistas.Grupos
{
    partial class Grupos
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtLoteA = new System.Windows.Forms.TextBox();
            this.txtBloqueA = new System.Windows.Forms.TextBox();
            this.txtSeccionA = new System.Windows.Forms.TextBox();
            this.txtSeccionB = new System.Windows.Forms.TextBox();
            this.txtBloqueB = new System.Windows.Forms.TextBox();
            this.txtLoteB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Secciones = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Secciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(513, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(523, 307);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Mostrar Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtLoteA
            // 
            this.txtLoteA.Location = new System.Drawing.Point(8, 44);
            this.txtLoteA.Name = "txtLoteA";
            this.txtLoteA.Size = new System.Drawing.Size(100, 22);
            this.txtLoteA.TabIndex = 5;
            this.txtLoteA.TextChanged += new System.EventHandler(this.txtLoteA_TextChanged);
            // 
            // txtBloqueA
            // 
            this.txtBloqueA.Location = new System.Drawing.Point(114, 44);
            this.txtBloqueA.Name = "txtBloqueA";
            this.txtBloqueA.Size = new System.Drawing.Size(100, 22);
            this.txtBloqueA.TabIndex = 6;
            this.txtBloqueA.TextChanged += new System.EventHandler(this.txtBloqueA_TextChanged);
            // 
            // txtSeccionA
            // 
            this.txtSeccionA.Location = new System.Drawing.Point(220, 44);
            this.txtSeccionA.Name = "txtSeccionA";
            this.txtSeccionA.Size = new System.Drawing.Size(100, 22);
            this.txtSeccionA.TabIndex = 7;
            this.txtSeccionA.TextChanged += new System.EventHandler(this.txtSeccionA_TextChanged);
            // 
            // txtSeccionB
            // 
            this.txtSeccionB.Location = new System.Drawing.Point(218, 44);
            this.txtSeccionB.Name = "txtSeccionB";
            this.txtSeccionB.Size = new System.Drawing.Size(71, 22);
            this.txtSeccionB.TabIndex = 11;
            this.txtSeccionB.TextChanged += new System.EventHandler(this.txtSeccionB_TextChanged);
            // 
            // txtBloqueB
            // 
            this.txtBloqueB.Location = new System.Drawing.Point(112, 44);
            this.txtBloqueB.Name = "txtBloqueB";
            this.txtBloqueB.Size = new System.Drawing.Size(100, 22);
            this.txtBloqueB.TabIndex = 10;
            this.txtBloqueB.TextChanged += new System.EventHandler(this.txtBloqueB_TextChanged);
            // 
            // txtLoteB
            // 
            this.txtLoteB.Location = new System.Drawing.Point(6, 44);
            this.txtLoteB.Name = "txtLoteB";
            this.txtLoteB.Size = new System.Drawing.Size(100, 22);
            this.txtLoteB.TabIndex = 9;
            this.txtLoteB.TextChanged += new System.EventHandler(this.txtLoteB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bloque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bloque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lote:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Secciones
            // 
            this.Secciones.Controls.Add(this.label1);
            this.Secciones.Controls.Add(this.checkBox1);
            this.Secciones.Controls.Add(this.label2);
            this.Secciones.Controls.Add(this.txtLoteA);
            this.Secciones.Controls.Add(this.txtBloqueA);
            this.Secciones.Controls.Add(this.txtSeccionA);
            this.Secciones.Controls.Add(this.label3);
            this.Secciones.Controls.Add(this.dataGridView1);
            this.Secciones.Location = new System.Drawing.Point(12, 12);
            this.Secciones.Name = "Secciones";
            this.Secciones.Size = new System.Drawing.Size(535, 397);
            this.Secciones.TabIndex = 21;
            this.Secciones.TabStop = false;
            this.Secciones.Text = "Secciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLoteB);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.txtBloqueB);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtSeccionB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(599, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 397);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos de Forza";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Vistas.Properties.Resources.Garbage_Closed1;
            this.btnBorrar.Location = new System.Drawing.Point(489, 31);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(34, 34);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Vistas.Properties.Resources.Data_Erase_WF;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(397, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::Vistas.Properties.Resources.Add_New1;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(305, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 24);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo grupo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Vistas.Properties.Resources.left_arrow__2_;
            this.btnRemove.Location = new System.Drawing.Point(553, 224);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Vistas.Properties.Resources.right_arrow__1_;
            this.btnAdd.Location = new System.Drawing.Point(553, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1138, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Secciones);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Secciones.ResumeLayout(false);
            this.Secciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtLoteA;
        private System.Windows.Forms.TextBox txtBloqueA;
        private System.Windows.Forms.TextBox txtSeccionA;
        private System.Windows.Forms.TextBox txtSeccionB;
        private System.Windows.Forms.TextBox txtBloqueB;
        private System.Windows.Forms.TextBox txtLoteB;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox Secciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBorrar;
    }
}