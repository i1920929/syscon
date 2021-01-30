namespace Proveedor
{
    partial class RptEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptEntrada));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_RptEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet8 = new Proveedor.DBSYSCONDataSet8();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbfechas = new System.Windows.Forms.RadioButton();
            this.rbNumDoc = new System.Windows.Forms.RadioButton();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptEntradaTableAdapter = new Proveedor.DBSYSCONDataSet8TableAdapters.Sp_RptEntradaTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet8)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sp_RptEntradaBindingSource
            // 
            this.Sp_RptEntradaBindingSource.DataMember = "Sp_RptEntrada";
            this.Sp_RptEntradaBindingSource.DataSource = this.DBSYSCONDataSet8;
            // 
            // DBSYSCONDataSet8
            // 
            this.DBSYSCONDataSet8.DataSetName = "DBSYSCONDataSet8";
            this.DBSYSCONDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(32, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 82);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de Entrada de Productos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Proveedor.Properties.Resources._2019_10_03__3_;
            this.pictureBox2.Location = new System.Drawing.Point(129, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbComprobante);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbfechas);
            this.groupBox1.Controls.Add(this.rbNumDoc);
            this.groupBox1.Controls.Add(this.dtpinicio);
            this.groupBox1.Controls.Add(this.dtpfin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(118, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 134);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por : ";
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.ItemHeight = 13;
            this.cmbComprobante.Location = new System.Drawing.Point(275, 66);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(154, 21);
            this.cmbComprobante.TabIndex = 121;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(275, 101);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 117;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Fecha inicio";
            // 
            // rbfechas
            // 
            this.rbfechas.AutoSize = true;
            this.rbfechas.Checked = true;
            this.rbfechas.Location = new System.Drawing.Point(27, 34);
            this.rbfechas.Name = "rbfechas";
            this.rbfechas.Size = new System.Drawing.Size(60, 17);
            this.rbfechas.TabIndex = 115;
            this.rbfechas.TabStop = true;
            this.rbfechas.Text = "Fechas";
            this.rbfechas.UseVisualStyleBackColor = true;
            this.rbfechas.CheckedChanged += new System.EventHandler(this.rbfechas_CheckedChanged);
            // 
            // rbNumDoc
            // 
            this.rbNumDoc.AutoSize = true;
            this.rbNumDoc.Location = new System.Drawing.Point(275, 34);
            this.rbNumDoc.Name = "rbNumDoc";
            this.rbNumDoc.Size = new System.Drawing.Size(184, 17);
            this.rbNumDoc.TabIndex = 116;
            this.rbNumDoc.Text = "Número de comprobante de pago";
            this.rbNumDoc.UseVisualStyleBackColor = true;
            this.rbNumDoc.CheckedChanged += new System.EventHandler(this.rbNumDoc_CheckedChanged);
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(94, 63);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(96, 20);
            this.dtpinicio.TabIndex = 110;
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(94, 101);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(96, 20);
            this.dtpfin.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Fecha fin ";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Sp_RptEntradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.RptEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(44, 281);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 327);
            this.reportViewer1.TabIndex = 119;
            // 
            // Sp_RptEntradaTableAdapter
            // 
            this.Sp_RptEntradaTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(569, 614);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 120;
            this.button4.Text = "Volver";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // RptEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 703);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "RptEntrada";
            this.Text = "RptEntrada";
            this.Load += new System.EventHandler(this.RptEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet8)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbfechas;
        private System.Windows.Forms.RadioButton rbNumDoc;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_RptEntradaBindingSource;
        private DBSYSCONDataSet8 DBSYSCONDataSet8;
        private DBSYSCONDataSet8TableAdapters.Sp_RptEntradaTableAdapter Sp_RptEntradaTableAdapter;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.Button button4;
    }
}