namespace Vistas
{
    partial class DetalleBloque
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
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbPlantas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(15, 82);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(257, 153);
            this.txtDetalles.TabIndex = 26;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(171, 47);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 21;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(133, 50);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(32, 13);
            this.lbArea.TabIndex = 20;
            this.lbArea.Text = "Area:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 16);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // lbPlantas
            // 
            this.lbPlantas.AutoSize = true;
            this.lbPlantas.Location = new System.Drawing.Point(61, 19);
            this.lbPlantas.Name = "lbPlantas";
            this.lbPlantas.Size = new System.Drawing.Size(104, 13);
            this.lbPlantas.TabIndex = 18;
            this.lbPlantas.Text = "Cantidad de plantas:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(205, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DetalleBloque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbPlantas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DetalleBloque";
            this.Text = "DetalleBloque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbPlantas;
        private System.Windows.Forms.Button button1;
    }
}