namespace Proveedor
{
    partial class frmRptProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptProducto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_RptProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet1 = new Proveedor.DBSYSCONDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.rbSubcat = new System.Windows.Forms.RadioButton();
            this.rbCateg = new System.Windows.Forms.RadioButton();
            this.txtcad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.Sp_ListarProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBSYSCONDataSet = new Proveedor.DBSYSCONDataSet();
            this.Sp_ListarProductoTableAdapter = new Proveedor.DBSYSCONDataSetTableAdapters.Sp_ListarProductoTableAdapter();
            this.Sp_RptProductoTableAdapter = new Proveedor.DBSYSCONDataSet1TableAdapters.Sp_RptProductoTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ListarProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_RptProductoBindingSource
            // 
            this.Sp_RptProductoBindingSource.DataMember = "Sp_RptProducto";
            this.Sp_RptProductoBindingSource.DataSource = this.DBSYSCONDataSet1;
            // 
            // DBSYSCONDataSet1
            // 
            this.DBSYSCONDataSet1.DataSetName = "DBSYSCONDataSet1";
            this.DBSYSCONDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(561, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 102;
            this.button4.Text = "Volver";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStock);
            this.groupBox1.Controls.Add(this.rbSubcat);
            this.groupBox1.Controls.Add(this.rbCateg);
            this.groupBox1.Controls.Add(this.txtcad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbTodo);
            this.groupBox1.Location = new System.Drawing.Point(106, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 141);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar por : ";
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Location = new System.Drawing.Point(252, 45);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(91, 17);
            this.rbStock.TabIndex = 109;
            this.rbStock.Text = "Stock Mínimo";
            this.rbStock.UseVisualStyleBackColor = true;
            this.rbStock.CheckedChanged += new System.EventHandler(this.rbStock_CheckedChanged);
            // 
            // rbSubcat
            // 
            this.rbSubcat.AutoSize = true;
            this.rbSubcat.Location = new System.Drawing.Point(157, 45);
            this.rbSubcat.Name = "rbSubcat";
            this.rbSubcat.Size = new System.Drawing.Size(90, 17);
            this.rbSubcat.TabIndex = 108;
            this.rbSubcat.Text = "Subcategoría";
            this.rbSubcat.UseVisualStyleBackColor = true;
            this.rbSubcat.CheckedChanged += new System.EventHandler(this.rbSubcat_CheckedChanged);
            // 
            // rbCateg
            // 
            this.rbCateg.AutoSize = true;
            this.rbCateg.Location = new System.Drawing.Point(79, 45);
            this.rbCateg.Name = "rbCateg";
            this.rbCateg.Size = new System.Drawing.Size(72, 17);
            this.rbCateg.TabIndex = 107;
            this.rbCateg.Text = "Categoría";
            this.rbCateg.UseVisualStyleBackColor = true;
            this.rbCateg.CheckedChanged += new System.EventHandler(this.rbCateg_CheckedChanged);
            // 
            // txtcad
            // 
            this.txtcad.Location = new System.Drawing.Point(23, 84);
            this.txtcad.Name = "txtcad";
            this.txtcad.Size = new System.Drawing.Size(320, 20);
            this.txtcad.TabIndex = 106;
            this.txtcad.TextChanged += new System.EventHandler(this.txtcad_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 84);
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
            this.rbTodo.Location = new System.Drawing.Point(23, 45);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(50, 17);
            this.rbTodo.TabIndex = 104;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = true;
            this.rbTodo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Sp_ListarProductoBindingSource
            // 
            this.Sp_ListarProductoBindingSource.DataMember = "Sp_ListarProducto";
            this.Sp_ListarProductoBindingSource.DataSource = this.DBSYSCONDataSet;
            // 
            // DBSYSCONDataSet
            // 
            this.DBSYSCONDataSet.DataSetName = "DBSYSCONDataSet";
            this.DBSYSCONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_ListarProductoTableAdapter
            // 
            this.Sp_ListarProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Sp_RptProductoTableAdapter
            // 
            this.Sp_RptProductoTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Reporte de productos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(32, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 82);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_RptProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proveedor.RptProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 287);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 327);
            this.reportViewer1.TabIndex = 103;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmRptProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRptProducto";
            this.Text = "frmRptProducto";
            this.Load += new System.EventHandler(this.frmRptProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_RptProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_ListarProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBSYSCONDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Sp_ListarProductoBindingSource;
        private DBSYSCONDataSet DBSYSCONDataSet;
        private DBSYSCONDataSetTableAdapters.Sp_ListarProductoTableAdapter Sp_ListarProductoTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTodo;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.RadioButton rbSubcat;
        private System.Windows.Forms.RadioButton rbCateg;
        private System.Windows.Forms.BindingSource Sp_RptProductoBindingSource;
        private DBSYSCONDataSet1 DBSYSCONDataSet1;
        private DBSYSCONDataSet1TableAdapters.Sp_RptProductoTableAdapter Sp_RptProductoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}