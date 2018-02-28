namespace Vistas
{
    partial class DetalleSeccion
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
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtFecha2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha1 = new System.Windows.Forms.TextBox();
            this.fecha1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbPlantas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(15, 144);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(257, 153);
            this.txtDetalle.TabIndex = 17;
            // 
            // txtFecha2
            // 
            this.txtFecha2.Location = new System.Drawing.Point(172, 108);
            this.txtFecha2.Name = "txtFecha2";
            this.txtFecha2.ReadOnly = true;
            this.txtFecha2.Size = new System.Drawing.Size(100, 20);
            this.txtFecha2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha Programada:";
            // 
            // txtFecha1
            // 
            this.txtFecha1.Location = new System.Drawing.Point(172, 77);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.ReadOnly = true;
            this.txtFecha1.Size = new System.Drawing.Size(100, 20);
            this.txtFecha1.TabIndex = 14;
            // 
            // fecha1
            // 
            this.fecha1.AutoSize = true;
            this.fecha1.Location = new System.Drawing.Point(88, 80);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(81, 13);
            this.fecha1.TabIndex = 13;
            this.fecha1.Text = "Fecha Siembra:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(172, 46);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 12;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(134, 49);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(32, 13);
            this.lbArea.TabIndex = 11;
            this.lbArea.Text = "Area:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(172, 15);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lbPlantas
            // 
            this.lbPlantas.AutoSize = true;
            this.lbPlantas.Location = new System.Drawing.Point(62, 18);
            this.lbPlantas.Name = "lbPlantas";
            this.lbPlantas.Size = new System.Drawing.Size(104, 13);
            this.lbPlantas.TabIndex = 9;
            this.lbPlantas.Text = "Cantidad de plantas:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(205, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DetalleSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtFecha2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha1);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbPlantas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetalleSeccion";
            this.Text = "DetalleSeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.Label fecha1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbPlantas;
        private System.Windows.Forms.Button button1;
    }
}