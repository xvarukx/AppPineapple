namespace Vistas.Mapas
{
    partial class DetalleLote
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnMapa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbEditando = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Lote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area(Ha)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(40, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(217, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(40, 149);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(217, 26);
            this.txtArea.TabIndex = 3;
            this.txtArea.Text = "0";
            this.txtArea.TextChanged += new System.EventHandler(this.validarNumeros);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(40, 247);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.ReadOnly = true;
            this.txtImagen.Size = new System.Drawing.Size(217, 26);
            this.txtImagen.TabIndex = 4;
            // 
            // btnMapa
            // 
            this.btnMapa.BackColor = System.Drawing.Color.DimGray;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapa.Location = new System.Drawing.Point(40, 194);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(80, 34);
            this.btnMapa.TabIndex = 5;
            this.btnMapa.Text = "Mapa";
            this.btnMapa.UseVisualStyleBackColor = false;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(177, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbEditando
            // 
            this.cbEditando.AutoSize = true;
            this.cbEditando.Location = new System.Drawing.Point(43, 279);
            this.cbEditando.Name = "cbEditando";
            this.cbEditando.Size = new System.Drawing.Size(81, 22);
            this.cbEditando.TabIndex = 26;
            this.cbEditando.Text = "Editando";
            this.cbEditando.UseVisualStyleBackColor = true;
            this.cbEditando.Visible = false;
            this.cbEditando.CheckedChanged += new System.EventHandler(this.cbEditando_CheckedChanged);
            // 
            // DetalleLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(297, 362);
            this.Controls.Add(this.cbEditando);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetalleLote";
            this.Text = "CreateLote";
            this.Load += new System.EventHandler(this.DetalleLote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbEditando;
    }
}