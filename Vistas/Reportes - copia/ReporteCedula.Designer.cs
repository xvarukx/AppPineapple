namespace Vistas.Reportes
{
    partial class ReporteCedula
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
            this.detallecedulaproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleseccioncedulaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sprayboomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detalleseccioncedulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cedulaidentidadTableAdapter = new Vistas.pinaDataSetTableAdapters.cedulaidentidadTableAdapter();
            this.sprayboomTableAdapter = new Vistas.pinaDataSetTableAdapters.sprayboomTableAdapter();
            this.detalleseccioncedulaTableAdapter = new Vistas.pinaDataSetTableAdapters.detalleseccioncedulaTableAdapter();
            this.detallecedulaproductosTableAdapter = new Vistas.pinaDataSetTableAdapters.detallecedulaproductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cedulaidentidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaproductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprayboomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // detallecedulaproductosBindingSource
            // 
            this.detallecedulaproductosBindingSource.DataMember = "detallecedulaproductos";
            this.detallecedulaproductosBindingSource.DataSource = this.pinaDataSet;
            // 
            // detalleseccioncedulaBindingSource1
            // 
            this.detalleseccioncedulaBindingSource1.DataMember = "detalleseccioncedula";
            this.detalleseccioncedulaBindingSource1.DataSource = this.pinaDataSet;
            // 
            // sprayboomBindingSource
            // 
            this.sprayboomBindingSource.DataMember = "sprayboom";
            this.sprayboomBindingSource.DataSource = this.pinaDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CedulaIdentidad";
            reportDataSource1.Value = this.cedulaidentidadBindingSource;
            reportDataSource2.Name = "DetalleProductos";
            reportDataSource2.Value = this.detallecedulaproductosBindingSource;
            reportDataSource3.Name = "DetalleSeccion";
            reportDataSource3.Value = this.detalleseccioncedulaBindingSource1;
            reportDataSource4.Name = "Spray";
            reportDataSource4.Value = this.sprayboomBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vistas.Reportes.CedulaIdentidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 705);
            this.reportViewer1.TabIndex = 0;
            // 
            // detalleseccioncedulaBindingSource
            // 
            this.detalleseccioncedulaBindingSource.DataMember = "detalleseccioncedula";
            this.detalleseccioncedulaBindingSource.DataSource = this.pinaDataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "cedulaidentidad";
            this.bindingSource1.DataSource = this.pinaDataSet;
            // 
            // cedulaidentidadTableAdapter
            // 
            this.cedulaidentidadTableAdapter.ClearBeforeFill = true;
            // 
            // sprayboomTableAdapter
            // 
            this.sprayboomTableAdapter.ClearBeforeFill = true;
            // 
            // detalleseccioncedulaTableAdapter
            // 
            this.detalleseccioncedulaTableAdapter.ClearBeforeFill = true;
            // 
            // detallecedulaproductosTableAdapter
            // 
            this.detallecedulaproductosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 716);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCedula";
            this.Load += new System.EventHandler(this.ReporteCedula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cedulaidentidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecedulaproductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprayboomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleseccioncedulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pinaDataSet pinaDataSet;
        private pinaDataSetTableAdapters.cedulaidentidadTableAdapter cedulaidentidadTableAdapter;
        private System.Windows.Forms.BindingSource cedulaidentidadBindingSource;
        private System.Windows.Forms.BindingSource detalleseccioncedulaBindingSource;
        private System.Windows.Forms.BindingSource sprayboomBindingSource;
        private pinaDataSetTableAdapters.sprayboomTableAdapter sprayboomTableAdapter;
        private System.Windows.Forms.BindingSource detalleseccioncedulaBindingSource1;
        private pinaDataSetTableAdapters.detalleseccioncedulaTableAdapter detalleseccioncedulaTableAdapter;
        private System.Windows.Forms.BindingSource detallecedulaproductosBindingSource;
        private pinaDataSetTableAdapters.detallecedulaproductosTableAdapter detallecedulaproductosTableAdapter;
    }
}