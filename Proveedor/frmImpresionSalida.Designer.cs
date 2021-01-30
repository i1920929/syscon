namespace Proveedor
{
    partial class frmImpresionSalida
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_ImprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet16 = new Proveedor.DBSYSCONDataSet16();
            this.Sp_ImprimirTableAdapter = new Proveedor.DBSYSCONDataSet16TableAdapters.Sp_ImprimirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ImprimirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_ImprimirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.Impresion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 556);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_ImprimirBindingSource
            // 
            this.Sp_ImprimirBindingSource.DataMember = "Sp_Imprimir";
            this.Sp_ImprimirBindingSource.DataSource = this.DBSYSCONDataSet16;
            // 
            // DBSYSCONDataSet16
            // 
            this.DBSYSCONDataSet16.DataSetName = "DBSYSCONDataSet16";
            this.DBSYSCONDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_ImprimirTableAdapter
            // 
            this.Sp_ImprimirTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmImpresionSalida";
            this.Text = "frmImpresionSalida";
            this.Load += new System.EventHandler(this.frmImpresionSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ImprimirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_ImprimirBindingSource;
        private DBSYSCONDataSet16 DBSYSCONDataSet16;
        private DBSYSCONDataSet16TableAdapters.Sp_ImprimirTableAdapter Sp_ImprimirTableAdapter;

    }
}