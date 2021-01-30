namespace Proveedor
{
    partial class frmRptFechaVenc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptFechaVenc));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_RptFechaVencBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet18 = new Proveedor.DBSYSCONDataSet18();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCateg = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_RptFechaVencTableAdapter = new Proveedor.DBSYSCONDataSet18TableAdapters.Sp_RptFechaVencTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptFechaVencBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet18)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sp_RptFechaVencBindingSource
            // 
            this.Sp_RptFechaVencBindingSource.DataMember = "Sp_RptFechaVenc";
            this.Sp_RptFechaVencBindingSource.DataSource = this.DBSYSCONDataSet18;
            // 
            // DBSYSCONDataSet18
            // 
            this.DBSYSCONDataSet18.DataSetName = "DBSYSCONDataSet18";
            this.DBSYSCONDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(26, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 82);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 86);
            this.label10.TabIndex = 1;
            this.label10.Text = "Reporte de productos por Fecha de Vencimiento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCateg);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbTodo);
            this.groupBox1.Location = new System.Drawing.Point(100, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 105);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar por : ";
            // 
            // rbCateg
            // 
            this.rbCateg.AutoSize = true;
            this.rbCateg.Location = new System.Drawing.Point(197, 45);
            this.rbCateg.Name = "rbCateg";
            this.rbCateg.Size = new System.Drawing.Size(151, 17);
            this.rbCateg.TabIndex = 107;
            this.rbCateg.Text = "Productos pronto a vencer";
            this.rbCateg.UseVisualStyleBackColor = true;
            this.rbCateg.CheckedChanged += new System.EventHandler(this.rbCateg_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 105;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbTodo
            // 
            this.rbTodo.AutoSize = true;
            this.rbTodo.Checked = true;
            this.rbTodo.Location = new System.Drawing.Point(46, 45);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(120, 17);
            this.rbTodo.TabIndex = 104;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Productos Vencidos";
            this.rbTodo.UseVisualStyleBackColor = true;
            this.rbTodo.CheckedChanged += new System.EventHandler(this.rbTodo_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_RptFechaVencBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.RptFechaVenc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 272);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 327);
            this.reportViewer1.TabIndex = 109;
            // 
            // Sp_RptFechaVencTableAdapter
            // 
            this.Sp_RptFechaVencTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(555, 605);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 110;
            this.button4.Text = "Volver";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmRptFechaVenc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 703);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptFechaVenc";
            this.Text = "frmRptFechaVenc";
            this.Load += new System.EventHandler(this.frmRptFechaVenc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptFechaVencBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet18)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCateg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTodo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_RptFechaVencBindingSource;
        private DBSYSCONDataSet18 DBSYSCONDataSet18;
        private DBSYSCONDataSet18TableAdapters.Sp_RptFechaVencTableAdapter Sp_RptFechaVencTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}