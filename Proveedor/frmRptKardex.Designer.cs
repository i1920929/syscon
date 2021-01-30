namespace Proveedor
{
    partial class frmRptKardex
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptKardex));
            this.Sp_RptKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet22 = new Proveedor.DBSYSCONDataSet22();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbfechas = new System.Windows.Forms.RadioButton();
            this.rbComprobante = new System.Windows.Forms.RadioButton();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Sp_RptKardexTableAdapter = new Proveedor.DBSYSCONDataSet22TableAdapters.Sp_RptKardexTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet22)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_RptKardexBindingSource
            // 
            this.Sp_RptKardexBindingSource.DataMember = "Sp_RptKardex";
            this.Sp_RptKardexBindingSource.DataSource = this.DBSYSCONDataSet22;
            // 
            // DBSYSCONDataSet22
            // 
            this.DBSYSCONDataSet22.DataSetName = "DBSYSCONDataSet22";
            this.DBSYSCONDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Sp_RptKardexBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Proveedor.RptKardex.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(43, 280);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(611, 327);
            this.reportViewer2.TabIndex = 130;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.RptTopProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 280);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 327);
            this.reportViewer1.TabIndex = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbfechas);
            this.groupBox1.Controls.Add(this.rbComprobante);
            this.groupBox1.Controls.Add(this.dtpinicio);
            this.groupBox1.Controls.Add(this.dtpfin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(111, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 125);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportar por : ";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(27, 96);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(184, 20);
            this.txtnom.TabIndex = 119;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(318, 103);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 22);
            this.btnListar.TabIndex = 118;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Fecha inicio";
            // 
            // rbfechas
            // 
            this.rbfechas.AutoSize = true;
            this.rbfechas.Location = new System.Drawing.Point(27, 72);
            this.rbfechas.Name = "rbfechas";
            this.rbfechas.Size = new System.Drawing.Size(122, 17);
            this.rbfechas.TabIndex = 115;
            this.rbfechas.Text = "Kardex por Producto";
            this.rbfechas.UseVisualStyleBackColor = true;
            this.rbfechas.CheckedChanged += new System.EventHandler(this.rbfechas_CheckedChanged);
            // 
            // rbComprobante
            // 
            this.rbComprobante.AutoSize = true;
            this.rbComprobante.Checked = true;
            this.rbComprobante.Location = new System.Drawing.Point(27, 34);
            this.rbComprobante.Name = "rbComprobante";
            this.rbComprobante.Size = new System.Drawing.Size(98, 17);
            this.rbComprobante.TabIndex = 116;
            this.rbComprobante.TabStop = true;
            this.rbComprobante.Text = "Kardex General";
            this.rbComprobante.UseVisualStyleBackColor = true;
            this.rbComprobante.CheckedChanged += new System.EventHandler(this.rbComprobante_CheckedChanged);
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(313, 34);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(96, 20);
            this.dtpinicio.TabIndex = 110;
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(313, 72);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(96, 20);
            this.dtpfin.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Fecha fin ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(31, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 82);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de Kardex de Productos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Sp_RptKardexTableAdapter
            // 
            this.Sp_RptKardexTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(568, 613);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 131;
            this.button4.Text = "Volver";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmRptKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 703);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmRptKardex";
            this.Text = "frmRptKardex";
            this.Load += new System.EventHandler(this.frmRptKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet22)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbfechas;
        private System.Windows.Forms.RadioButton rbComprobante;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource Sp_RptKardexBindingSource;
        private DBSYSCONDataSet22 DBSYSCONDataSet22;
        private System.Windows.Forms.TextBox txtnom;
        private DBSYSCONDataSet22TableAdapters.Sp_RptKardexTableAdapter Sp_RptKardexTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}