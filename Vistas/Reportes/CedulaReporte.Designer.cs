namespace Vistas.Reportes
{
    partial class CedulaReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cedulaidentidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pinaDataSet = new Vistas.pinaDataSet();
            this.detalleseccioncedulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallecedulaproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallecedulaprayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sprayboomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cedulaidentidadTableAdapter = new Vistas.pinaDataSetTableAdapters.cedulaidentidadTableAdapter();
            this.detalleseccioncedulaTableAdapter = new Vistas.pinaDataSetTableAdapters.detalleseccioncedulaTableAdapter();
            this.detallecedulaproductosTableAdapter = new Vistas.pinaDataSetTableAdapters.detallecedulaproductosTableAdapter();
            this.detallecedulaprayTableAdapter = new Vistas.pinaDataSetTableAdapters.detallecedulaprayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cedulaidentidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaproductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaprayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprayboomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaidentidadBindingSource
            // 
            this.cedulaidentidadBindingSource.DataMember = "cedulaidentidad";
            this.cedulaidentidadBindingSource.DataSource = this.pinaDataSet;
            // 
            // pinaDataSet
            // 
            this.pinaDataSet.DataSetName = "pinaDataSet";
            this.pinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleseccioncedulaBindingSource
            // 
            this.detalleseccioncedulaBindingSource.DataMember = "detalleseccioncedula";
            this.detalleseccioncedulaBindingSource.DataSource = this.pinaDataSet;
            // 
            // detallecedulaproductosBindingSource
            // 
            this.detallecedulaproductosBindingSource.DataMember = "detallecedulaproductos";
            this.detallecedulaproductosBindingSource.DataSource = this.pinaDataSet;
            // 
            // detallecedulaprayBindingSource
            // 
            this.detallecedulaprayBindingSource.DataMember = "detallecedulapray";
            this.detallecedulaprayBindingSource.DataSource = this.pinaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 34;
            reportDataSource1.Name = "cedulaidentidad";
            reportDataSource1.Value = this.cedulaidentidadBindingSource;
            reportDataSource2.Name = "seccion";
            reportDataSource2.Value = this.detalleseccioncedulaBindingSource;
            reportDataSource3.Name = "productos";
            reportDataSource3.Value = this.detallecedulaproductosBindingSource;
            reportDataSource4.Name = "spray";
            reportDataSource4.Value = this.detallecedulaprayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vistas.Reportes.NuevaCedula.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Luis Mora\\Desktop\\Proyecto-Pi-a\\Vistas\\Reportes\\NuevaCedula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(648, 918);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sprayboomBindingSource
            // 
            this.sprayboomBindingSource.DataMember = "sprayboom";
            this.sprayboomBindingSource.DataSource = this.pinaDataSet;
            // 
            // cedulaidentidadTableAdapter
            // 
            this.cedulaidentidadTableAdapter.ClearBeforeFill = true;
            // 
            // detalleseccioncedulaTableAdapter
            // 
            this.detalleseccioncedulaTableAdapter.ClearBeforeFill = true;
            // 
            // detallecedulaproductosTableAdapter
            // 
            this.detallecedulaproductosTableAdapter.ClearBeforeFill = true;
            // 
            // detallecedulaprayTableAdapter
            // 
            this.detallecedulaprayTableAdapter.ClearBeforeFill = true;
            // 
            // CedulaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 865);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CedulaReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CedulaReporteForza";
            this.Load += new System.EventHandler(this.CedulaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cedulaidentidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaproductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaprayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprayboomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pinaDataSet pinaDataSet;
        private System.Windows.Forms.BindingSource cedulaidentidadBindingSource;
        private pinaDataSetTableAdapters.cedulaidentidadTableAdapter cedulaidentidadTableAdapter;
        private System.Windows.Forms.BindingSource detalleseccioncedulaBindingSource;
        private pinaDataSetTableAdapters.detalleseccioncedulaTableAdapter detalleseccioncedulaTableAdapter;
        private System.Windows.Forms.BindingSource detallecedulaproductosBindingSource;
        private pinaDataSetTableAdapters.detallecedulaproductosTableAdapter detallecedulaproductosTableAdapter;
        private System.Windows.Forms.BindingSource detallecedulaprayBindingSource;
        private pinaDataSetTableAdapters.detallecedulaprayTableAdapter detallecedulaprayTableAdapter;
        private System.Windows.Forms.BindingSource sprayboomBindingSource;
    }
}