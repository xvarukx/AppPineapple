namespace Vistas.Reportes
{
    partial class ReporteProductos
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
            this.pinaDataSet = new Vistas.pinaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductoCalendarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoCalendarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pinaDataSet
            // 
            this.pinaDataSet.DataSetName = "pinaDataSet";
            this.pinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 22;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductoCalendarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vistas.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(619, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductoCalendarioBindingSource
            // 
            this.ProductoCalendarioBindingSource.DataMember = "ProductoCalendario";
            this.ProductoCalendarioBindingSource.DataSource = this.pinaDataSet;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 551);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProductos";
            this.Text = "ReporteProductos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoCalendarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private pinaDataSet pinaDataSet;
        private System.Windows.Forms.BindingSource ProductoCalendarioBindingSource;
    }
}