namespace Reportes
{
    partial class Seccion_Producto
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
            this.buscarSeccion_ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pinaDataSet = new Reportes.pinaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buscarSeccion_ProductoTableAdapter = new Reportes.pinaDataSetTableAdapters.buscarSeccion_ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buscarSeccion_ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarSeccion_ProductoBindingSource
            // 
            this.buscarSeccion_ProductoBindingSource.DataMember = "buscarSeccion_Producto";
            this.buscarSeccion_ProductoBindingSource.DataSource = this.pinaDataSet;
            // 
            // pinaDataSet
            // 
            this.pinaDataSet.DataSetName = "pinaDataSet";
            this.pinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSeccion_Producto";
            reportDataSource1.Value = this.buscarSeccion_ProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.ReportSeccion_Producto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(642, 338);
            this.reportViewer1.TabIndex = 0;
            // 
            // buscarSeccion_ProductoTableAdapter
            // 
            this.buscarSeccion_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Seccion_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 338);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Seccion_Producto";
            this.Text = "Seccion_Producto";
            this.Load += new System.EventHandler(this.Seccion_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarSeccion_ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarSeccion_ProductoBindingSource;
        private pinaDataSet pinaDataSet;
        private pinaDataSetTableAdapters.buscarSeccion_ProductoTableAdapter buscarSeccion_ProductoTableAdapter;
    }
}