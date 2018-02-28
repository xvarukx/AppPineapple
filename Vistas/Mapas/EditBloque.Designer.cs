namespace Vistas.Mapas
{
    partial class EditBloque
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbPlantas = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtAreaUtilizada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(202, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(12, 140);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.Size = new System.Drawing.Size(257, 153);
            this.txtDetalles.TabIndex = 40;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(166, 47);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 39;
            this.txtArea.Text = "0";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(60, 50);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(100, 16);
            this.lbArea.TabIndex = 38;
            this.lbArea.Text = "Area Bruta(Ha):";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(166, 16);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 37;
            this.txtCantidad.Text = "0";
            // 
            // lbPlantas
            // 
            this.lbPlantas.AutoSize = true;
            this.lbPlantas.Location = new System.Drawing.Point(29, 19);
            this.lbPlantas.Name = "lbPlantas";
            this.lbPlantas.Size = new System.Drawing.Size(131, 16);
            this.lbPlantas.TabIndex = 36;
            this.lbPlantas.Text = "Cantidad de plantas:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "Editar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtAreaUtilizada
            // 
            this.txtAreaUtilizada.Location = new System.Drawing.Point(166, 79);
            this.txtAreaUtilizada.Name = "txtAreaUtilizada";
            this.txtAreaUtilizada.ReadOnly = true;
            this.txtAreaUtilizada.Size = new System.Drawing.Size(100, 22);
            this.txtAreaUtilizada.TabIndex = 44;
            this.txtAreaUtilizada.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Area Sembrada(Ha):";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(12, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 23);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EditBloque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 330);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAreaUtilizada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbPlantas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditBloque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBloque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbPlantas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtAreaUtilizada;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnEliminar;
    }
}