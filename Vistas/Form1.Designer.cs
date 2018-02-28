namespace Vistas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnPaquete = new System.Windows.Forms.Button();
            this.btnCedulas = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSpray = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAplicacion = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(260, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::Vistas.Properties.Resources.fondoprueba;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btnHome);
            this.menu.Controls.Add(this.btnProveedores);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.btnConfiguracion);
            this.menu.Controls.Add(this.btnPaquete);
            this.menu.Controls.Add(this.btnCedulas);
            this.menu.Controls.Add(this.btnVehiculos);
            this.menu.Controls.Add(this.btnEmpleados);
            this.menu.Controls.Add(this.btnSpray);
            this.menu.Controls.Add(this.btnInventario);
            this.menu.Controls.Add(this.btnAplicacion);
            this.menu.Controls.Add(this.btnCalendario);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.button2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(263, 741);
            this.menu.TabIndex = 1;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::Vistas.Properties.Resources.House_08;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 172);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(257, 54);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProveedores.Image = global::Vistas.Properties.Resources.Transport_Van1;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(3, 598);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(257, 47);
            this.btnProveedores.TabIndex = 10;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.leave);
            this.btnProveedores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.pineapple__3_;
            this.pictureBox1.Location = new System.Drawing.Point(101, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Piña Alegre";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracion.Image = global::Vistas.Properties.Resources.Settings___11;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(3, 687);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(257, 54);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.MouseLeave += new System.EventHandler(this.leave);
            this.btnConfiguracion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnPaquete
            // 
            this.btnPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaquete.BackColor = System.Drawing.Color.Transparent;
            this.btnPaquete.FlatAppearance.BorderSize = 0;
            this.btnPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquete.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaquete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaquete.Image = global::Vistas.Properties.Resources.Stop_Clock_WF;
            this.btnPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquete.Location = new System.Drawing.Point(0, 638);
            this.btnPaquete.Name = "btnPaquete";
            this.btnPaquete.Size = new System.Drawing.Size(260, 58);
            this.btnPaquete.TabIndex = 3;
            this.btnPaquete.Text = "Etapas";
            this.btnPaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaquete.UseVisualStyleBackColor = false;
            this.btnPaquete.Click += new System.EventHandler(this.btnPaquete_Click);
            this.btnPaquete.MouseLeave += new System.EventHandler(this.leave);
            this.btnPaquete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnCedulas
            // 
            this.btnCedulas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCedulas.BackColor = System.Drawing.Color.Transparent;
            this.btnCedulas.FlatAppearance.BorderSize = 0;
            this.btnCedulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCedulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCedulas.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCedulas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCedulas.Image = global::Vistas.Properties.Resources.To_Do_List_WF;
            this.btnCedulas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCedulas.Location = new System.Drawing.Point(3, 218);
            this.btnCedulas.Name = "btnCedulas";
            this.btnCedulas.Size = new System.Drawing.Size(257, 54);
            this.btnCedulas.TabIndex = 8;
            this.btnCedulas.Text = "Cedula Identidad";
            this.btnCedulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCedulas.UseVisualStyleBackColor = false;
            this.btnCedulas.Click += new System.EventHandler(this.button3_Click);
            this.btnCedulas.MouseLeave += new System.EventHandler(this.leave);
            this.btnCedulas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVehiculos.Image = global::Vistas.Properties.Resources.Van___01;
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(3, 547);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(257, 45);
            this.btnVehiculos.TabIndex = 7;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            this.btnVehiculos.MouseLeave += new System.EventHandler(this.leave);
            this.btnVehiculos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpleados.Image = global::Vistas.Properties.Resources.Employee;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(3, 504);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(257, 49);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.leave);
            this.btnEmpleados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnSpray
            // 
            this.btnSpray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpray.BackColor = System.Drawing.Color.Transparent;
            this.btnSpray.FlatAppearance.BorderSize = 0;
            this.btnSpray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSpray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpray.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpray.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpray.Image = global::Vistas.Properties.Resources.Aerosal_can_WF;
            this.btnSpray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpray.Location = new System.Drawing.Point(3, 466);
            this.btnSpray.Name = "btnSpray";
            this.btnSpray.Size = new System.Drawing.Size(257, 42);
            this.btnSpray.TabIndex = 5;
            this.btnSpray.Text = "Spray Booms";
            this.btnSpray.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpray.UseVisualStyleBackColor = false;
            this.btnSpray.Click += new System.EventHandler(this.btnSpray_Click);
            this.btnSpray.MouseLeave += new System.EventHandler(this.leave);
            this.btnSpray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Image = global::Vistas.Properties.Resources.Product_Box_02_WF2;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(3, 429);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(257, 41);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            this.btnInventario.MouseLeave += new System.EventHandler(this.leave);
            this.btnInventario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnAplicacion
            // 
            this.btnAplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.btnAplicacion.FlatAppearance.BorderSize = 0;
            this.btnAplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicacion.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAplicacion.Image = global::Vistas.Properties.Resources.Filter_Standard;
            this.btnAplicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicacion.Location = new System.Drawing.Point(3, 387);
            this.btnAplicacion.Name = "btnAplicacion";
            this.btnAplicacion.Size = new System.Drawing.Size(257, 46);
            this.btnAplicacion.TabIndex = 4;
            this.btnAplicacion.Text = "Aplicaciones";
            this.btnAplicacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicacion.UseVisualStyleBackColor = false;
            this.btnAplicacion.Click += new System.EventHandler(this.btnAplicacion_Click);
            this.btnAplicacion.MouseLeave += new System.EventHandler(this.leave);
            this.btnAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendario.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendario.Image = global::Vistas.Properties.Resources.Date;
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(3, 345);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(257, 46);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendario.MouseLeave += new System.EventHandler(this.leave);
            this.btnCalendario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Vistas.Properties.Resources.Dropper_WF2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aplicar Productos";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.leave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Vistas.Properties.Resources.Map;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mapa";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.leave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.BackgroundImage = global::Vistas.Properties.Resources.fondoprueba;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Location = new System.Drawing.Point(260, -1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1245, 107);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(196, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(9, 82);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(157, 25);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Administrador";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogin.Image = global::Vistas.Properties.Resources.User_Login1;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.Location = new System.Drawing.Point(996, 13);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 70);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnPaquete;
        private System.Windows.Forms.Button btnAplicacion;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSpray;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCedulas;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnHome;
    }
}