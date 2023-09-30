namespace modeloParcial.Presentaciones
{
    partial class FrmReporteStock
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
            this.dataSetOrden = new modeloParcial.Presentaciones.Reportes.DataSetOrden();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetOrden
            // 
            this.dataSetOrden.DataSetName = "DataSetOrden";
            this.dataSetOrden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetOrdenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "modeloParcial.Presentaciones.Reportes.ReportStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(561, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetOrdenBindingSource
            // 
            this.dataSetOrdenBindingSource.DataSource = this.dataSetOrden;
            this.dataSetOrdenBindingSource.Position = 0;
            // 
            // FrmReporteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteStock";
            this.Text = "Reporte Stock";
            this.Load += new System.EventHandler(this.FrmReporteStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DataSetOrden dataSetOrden;
        private System.Windows.Forms.BindingSource dataSetOrdenBindingSource;
    }
}