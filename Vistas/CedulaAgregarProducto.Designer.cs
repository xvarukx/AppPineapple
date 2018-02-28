namespace Vistas
{
    partial class CedulaAgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-161, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(13, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(498, 444);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(73, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(293, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_2);
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
            this.tabControl1.Location = new System.Drawing.Point(8, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.Controls.Add(this.dataTodos);
            this.tabTodos.Location = new System.Drawing.Point(4, 22);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Size = new System.Drawing.Size(474, 383);
            this.tabTodos.TabIndex = 4;
            this.tabTodos.Text = "Todos";
            this.tabTodos.UseVisualStyleBackColor = true;
            // 
            // dataTodos
            // 
            this.dataTodos.AllowUserToAddRows = false;
            this.dataTodos.AllowUserToDeleteRows = false;
            this.dataTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTodos.Location = new System.Drawing.Point(0, 0);
            this.dataTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataTodos.Name = "dataTodos";
            this.dataTodos.ReadOnly = true;
            this.dataTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTodos.Size = new System.Drawing.Size(474, 383);
            this.dataTodos.TabIndex = 1;
            this.dataTodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTodos_CellContentClick);
            this.dataTodos.SelectionChanged += new System.EventHandler(this.dataTodos_SelectionChanged);
            // 
            // tabHerbicida
            // 
            this.tabHerbicida.Controls.Add(this.dataHerb);
            this.tabHerbicida.Location = new System.Drawing.Point(4, 22);
            this.tabHerbicida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHerbicida.Name = "tabHerbicida";
            this.tabHerbicida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHerbicida.Size = new System.Drawing.Size(474, 383);
            this.tabHerbicida.TabIndex = 0;
            this.tabHerbicida.Text = "Herbicida";
            this.tabHerbicida.UseVisualStyleBackColor = true;
            // 
            // dataHerb
            // 
            this.dataHerb.AllowUserToAddRows = false;
            this.dataHerb.AllowUserToDeleteRows = false;
            this.dataHerb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHerb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHerb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHerb.Location = new System.Drawing.Point(4, 5);
            this.dataHerb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataHerb.MultiSelect = false;
            this.dataHerb.Name = "dataHerb";
            this.dataHerb.ReadOnly = true;
            this.dataHerb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHerb.Size = new System.Drawing.Size(466, 373);
            this.dataHerb.TabIndex = 0;
            this.dataHerb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHerb_CellContentClick);
            this.dataHerb.SelectionChanged += new System.EventHandler(this.dataHerb_SelectionChanged);
            // 
            // tabFertilizante
            // 
            this.tabFertilizante.Controls.Add(this.dataFert);
            this.tabFertilizante.Location = new System.Drawing.Point(4, 22);
            this.tabFertilizante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFertilizante.Name = "tabFertilizante";
            this.tabFertilizante.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFertilizante.Size = new System.Drawing.Size(474, 383);
            this.tabFertilizante.TabIndex = 1;
            this.tabFertilizante.Text = "Fertilizante";
            this.tabFertilizante.UseVisualStyleBackColor = true;
            // 
            // dataFert
            // 
            this.dataFert.AllowUserToAddRows = false;
            this.dataFert.AllowUserToDeleteRows = false;
            this.dataFert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFert.Location = new System.Drawing.Point(4, 5);
            this.dataFert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFert.Name = "dataFert";
            this.dataFert.ReadOnly = true;
            this.dataFert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFert.Size = new System.Drawing.Size(466, 373);
            this.dataFert.TabIndex = 1;
            this.dataFert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFert_CellContentClick);
            this.dataFert.SelectionChanged += new System.EventHandler(this.dataFert_SelectionChanged);
            // 
            // tabFungicida
            // 
            this.tabFungicida.Controls.Add(this.dataFungi);
            this.tabFungicida.Location = new System.Drawing.Point(4, 22);
            this.tabFungicida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFungicida.Name = "tabFungicida";
            this.tabFungicida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFungicida.Size = new System.Drawing.Size(474, 383);
            this.tabFungicida.TabIndex = 2;
            this.tabFungicida.Text = "Fungicida";
            this.tabFungicida.UseVisualStyleBackColor = true;
            // 
            // dataFungi
            // 
            this.dataFungi.AllowUserToAddRows = false;
            this.dataFungi.AllowUserToDeleteRows = false;
            this.dataFungi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFungi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFungi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFungi.Location = new System.Drawing.Point(4, 5);
            this.dataFungi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFungi.Name = "dataFungi";
            this.dataFungi.ReadOnly = true;
            this.dataFungi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFungi.Size = new System.Drawing.Size(466, 373);
            this.dataFungi.TabIndex = 1;
            this.dataFungi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFungi_CellContentClick);
            this.dataFungi.SelectionChanged += new System.EventHandler(this.dataFungi_SelectionChanged);
            // 
            // tabInsecticida
            // 
            this.tabInsecticida.Controls.Add(this.dataInsect);
            this.tabInsecticida.Location = new System.Drawing.Point(4, 22);
            this.tabInsecticida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInsecticida.Name = "tabInsecticida";
            this.tabInsecticida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInsecticida.Size = new System.Drawing.Size(474, 383);
            this.tabInsecticida.TabIndex = 3;
            this.tabInsecticida.Text = "Insecticida";
            this.tabInsecticida.UseVisualStyleBackColor = true;
            // 
            // dataInsect
            // 
            this.dataInsect.AllowUserToAddRows = false;
            this.dataInsect.AllowUserToDeleteRows = false;
            this.dataInsect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInsect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInsect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInsect.Location = new System.Drawing.Point(4, 5);
            this.dataInsect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataInsect.Name = "dataInsect";
            this.dataInsect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInsect.Size = new System.Drawing.Size(466, 373);
            this.dataInsect.TabIndex = 1;
            this.dataInsect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInsect_CellContentClick);
            this.dataInsect.SelectionChanged += new System.EventHandler(this.dataInsect_SelectionChanged);
            // 
            // tabNematicida
            // 
            this.tabNematicida.Controls.Add(this.dataNema);
            this.tabNematicida.Location = new System.Drawing.Point(4, 22);
            this.tabNematicida.Name = "tabNematicida";
            this.tabNematicida.Size = new System.Drawing.Size(474, 383);
            this.tabNematicida.TabIndex = 5;
            this.tabNematicida.Text = "Nematicida";
            this.tabNematicida.UseVisualStyleBackColor = true;
            // 
            // dataNema
            // 
            this.dataNema.AllowUserToAddRows = false;
            this.dataNema.AllowUserToDeleteRows = false;
            this.dataNema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNema.Location = new System.Drawing.Point(0, 0);
            this.dataNema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataNema.Name = "dataNema";
            this.dataNema.ReadOnly = true;
            this.dataNema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNema.Size = new System.Drawing.Size(474, 383);
            this.dataNema.TabIndex = 2;
            this.dataNema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNema_CellContentClick);
            this.dataNema.SelectionChanged += new System.EventHandler(this.dataNema_SelectionChanged);
            // 
            // tabOtros
            // 
            this.tabOtros.Controls.Add(this.dataOtros);
            this.tabOtros.Location = new System.Drawing.Point(4, 22);
            this.tabOtros.Name = "tabOtros";
            this.tabOtros.Size = new System.Drawing.Size(474, 383);
            this.tabOtros.TabIndex = 6;
            this.tabOtros.Text = "Otros";
            this.tabOtros.UseVisualStyleBackColor = true;
            // 
            // dataOtros
            // 
            this.dataOtros.AllowUserToAddRows = false;
            this.dataOtros.AllowUserToDeleteRows = false;
            this.dataOtros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOtros.Location = new System.Drawing.Point(0, 0);
            this.dataOtros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOtros.Name = "dataOtros";
            this.dataOtros.ReadOnly = true;
            this.dataOtros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOtros.Size = new System.Drawing.Size(474, 383);
            this.dataOtros.TabIndex = 2;
            this.dataOtros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOtros_CellContentClick);
            this.dataOtros.SelectionChanged += new System.EventHandler(this.dataOtros_SelectionChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Vistas.Properties.Resources.Add_New;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(156, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Vistas.Properties.Resources.Command_Undo_WF;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(285, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CedulaAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(527, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CedulaAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CedulaAgregarProducto";
            this.Load += new System.EventHandler(this.CedulaAgregarProducto_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.DataGridView dataTodos;
        private System.Windows.Forms.TabPage tabHerbicida;
        private System.Windows.Forms.DataGridView dataHerb;
        private System.Windows.Forms.TabPage tabFertilizante;
        private System.Windows.Forms.DataGridView dataFert;
        private System.Windows.Forms.TabPage tabFungicida;
        private System.Windows.Forms.DataGridView dataFungi;
        private System.Windows.Forms.TabPage tabInsecticida;
        private System.Windows.Forms.DataGridView dataInsect;
        private System.Windows.Forms.TabPage tabNematicida;
        private System.Windows.Forms.DataGridView dataNema;
        private System.Windows.Forms.TabPage tabOtros;
        private System.Windows.Forms.DataGridView dataOtros;
    }
}