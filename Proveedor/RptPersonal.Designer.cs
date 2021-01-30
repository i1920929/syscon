using Microsoft.Reporting.WinForms;

namespace Proveedor
{
    partial class RptPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPersonal));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_ListarPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet2 = new Proveedor.DBSYSCONDataSet2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_ListarPersonalTableAdapter = new Proveedor.DBSYSCONDataSet2TableAdapters.Sp_ListarPersonalTableAdapter();
            this.btnListar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ListarPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_ListarPersonalBindingSource
            // 
            this.Sp_ListarPersonalBindingSource.DataMember = "Sp_ListarPersonal";
            this.Sp_ListarPersonalBindingSource.DataSource = this.DBSYSCONDataSet2;
            this.Sp_ListarPersonalBindingSource.CurrentChanged += new System.EventHandler(this.Sp_ListarPersonalBindingSource_CurrentChanged);
            // 
            // DBSYSCONDataSet2
            // 
            this.DBSYSCONDataSet2.DataSetName = "DBSYSCONDataSet2";
            this.DBSYSCONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(32, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 82);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Reporte de personal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Proveedor.Properties.Resources._2019_10_03__3_;
            this.pictureBox2.Location = new System.Drawing.Point(191, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Sp_ListarPersonalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.RptPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 229);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 290);
            this.reportViewer1.TabIndex = 109;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Sp_ListarPersonalTableAdapter
            // 
            this.Sp_ListarPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(550, 161);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 36);
            this.btnListar.TabIndex = 118;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(559, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 119;
            this.button4.Text = "Volver";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // RptPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox3);
            this.Name = "RptPersonal";
            this.Text = "RptPersonal";
            this.Load += new System.EventHandler(this.RptPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ListarPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource Sp_ListarPersonalBindingSource;
        private DBSYSCONDataSet2 DBSYSCONDataSet2;
        private DBSYSCONDataSet2TableAdapters.Sp_ListarPersonalTableAdapter Sp_ListarPersonalTableAdapter;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnListar;
        private ReportViewer reportViewer1;
        private System.Windows.Forms.Button button4;
    }
}