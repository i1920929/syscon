namespace Proveedor
{
    partial class frmDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucion));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtcproducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudpreciov = new System.Windows.Forms.NumericUpDown();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.nudprecioc = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnREntradaP = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtpersonal = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvEProducto = new System.Windows.Forms.DataGridView();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.cmbtipodoc = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreciov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecioc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.dtpFechaVenc);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.nudCantidad);
            this.groupBox5.Controls.Add(this.txtcproducto);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.nudpreciov);
            this.groupBox5.Controls.Add(this.txtproducto);
            this.groupBox5.Controls.Add(this.nudprecioc);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(382, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 217);
            this.groupBox5.TabIndex = 105;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Producto";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 13);
            this.label22.TabIndex = 66;
            this.label22.Text = "Fecha de Vencimiento";
            this.label22.Visible = false;
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenc.Location = new System.Drawing.Point(136, 168);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaVenc.TabIndex = 65;
            this.dtpFechaVenc.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Codigo";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(122, 138);
            this.nudCantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(74, 20);
            this.nudCantidad.TabIndex = 3;
            // 
            // txtcproducto
            // 
            this.txtcproducto.Enabled = false;
            this.txtcproducto.Location = new System.Drawing.Point(122, 60);
            this.txtcproducto.MaxLength = 15;
            this.txtcproducto.Name = "txtcproducto";
            this.txtcproducto.Size = new System.Drawing.Size(78, 20);
            this.txtcproducto.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cantidad";
            // 
            // nudpreciov
            // 
            this.nudpreciov.DecimalPlaces = 2;
            this.nudpreciov.Enabled = false;
            this.nudpreciov.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudpreciov.Location = new System.Drawing.Point(122, 112);
            this.nudpreciov.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudpreciov.Name = "nudpreciov";
            this.nudpreciov.Size = new System.Drawing.Size(74, 20);
            this.nudpreciov.TabIndex = 57;
            // 
            // txtproducto
            // 
            this.txtproducto.Enabled = false;
            this.txtproducto.Location = new System.Drawing.Point(122, 34);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(149, 20);
            this.txtproducto.TabIndex = 58;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // nudprecioc
            // 
            this.nudprecioc.DecimalPlaces = 2;
            this.nudprecioc.Enabled = false;
            this.nudprecioc.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudprecioc.Location = new System.Drawing.Point(122, 86);
            this.nudprecioc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudprecioc.Name = "nudprecioc";
            this.nudprecioc.Size = new System.Drawing.Size(74, 20);
            this.nudprecioc.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Producto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Precio Costo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Precio Venta";
            // 
            // btnREntradaP
            // 
            this.btnREntradaP.Location = new System.Drawing.Point(538, 323);
            this.btnREntradaP.Name = "btnREntradaP";
            this.btnREntradaP.Size = new System.Drawing.Size(121, 32);
            this.btnREntradaP.TabIndex = 108;
            this.btnREntradaP.Text = "Registrar devolución";
            this.btnREntradaP.UseVisualStyleBackColor = true;
            this.btnREntradaP.Click += new System.EventHandler(this.btnREntradaP_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(382, 323);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 32);
            this.btnAgregar.TabIndex = 106;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(458, 323);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(61, 32);
            this.btnQuitar.TabIndex = 107;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroDoc);
            this.groupBox2.Controls.Add(this.cmbtipodoc);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtmotivo);
            this.groupBox2.Controls.Add(this.txtpersonal);
            this.groupBox2.Controls.Add(this.cmbProveedor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpEntrada);
            this.groupBox2.Controls.Add(this.txtCEntrada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 261);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Entrada";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 62;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Motivo";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(126, 140);
            this.txtmotivo.MaxLength = 150;
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(128, 90);
            this.txtmotivo.TabIndex = 60;
            // 
            // txtpersonal
            // 
            this.txtpersonal.Enabled = false;
            this.txtpersonal.Location = new System.Drawing.Point(126, 114);
            this.txtpersonal.Name = "txtpersonal";
            this.txtpersonal.Size = new System.Drawing.Size(128, 20);
            this.txtpersonal.TabIndex = 5;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(126, 112);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(128, 21);
            this.cmbProveedor.TabIndex = 4;
            this.cmbProveedor.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Proveedor";
            this.label6.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Personal";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(126, 86);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(128, 20);
            this.dtpEntrada.TabIndex = 3;
            // 
            // txtCEntrada
            // 
            this.txtCEntrada.Enabled = false;
            this.txtCEntrada.Location = new System.Drawing.Point(126, 157);
            this.txtCEntrada.MaxLength = 5;
            this.txtCEntrada.Name = "txtCEntrada";
            this.txtCEntrada.Size = new System.Drawing.Size(78, 20);
            this.txtCEntrada.TabIndex = 2;
            this.txtCEntrada.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nro Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha Entrada";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(329, 211);
            this.dataGridView1.TabIndex = 103;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 82);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Devolución de Productos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Proveedor.Properties.Resources.embalaje_opt;
            this.pictureBox2.Location = new System.Drawing.Point(203, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 64);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dgvEProducto
            // 
            this.dgvEProducto.AllowUserToAddRows = false;
            this.dgvEProducto.AllowUserToDeleteRows = false;
            this.dgvEProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEProducto.Location = new System.Drawing.Point(12, 367);
            this.dgvEProducto.Name = "dgvEProducto";
            this.dgvEProducto.ReadOnly = true;
            this.dgvEProducto.RowHeadersVisible = false;
            this.dgvEProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEProducto.Size = new System.Drawing.Size(311, 211);
            this.dgvEProducto.TabIndex = 101;
            this.dgvEProducto.CurrentCellChanged += new System.EventHandler(this.dgvEProducto_CurrentCellChanged);
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.Location = new System.Drawing.Point(581, 604);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(80, 25);
            this.btnCerrarP.TabIndex = 109;
            this.btnCerrarP.Text = "Cerrar";
            this.btnCerrarP.UseVisualStyleBackColor = true;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // cmbtipodoc
            // 
            this.cmbtipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipodoc.FormattingEnabled = true;
            this.cmbtipodoc.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "GUIA DE REMISIÓN",
            "SALIDA INTERNA"});
            this.cmbtipodoc.Location = new System.Drawing.Point(126, 33);
            this.cmbtipodoc.Name = "cmbtipodoc";
            this.cmbtipodoc.Size = new System.Drawing.Size(128, 21);
            this.cmbtipodoc.TabIndex = 63;
            this.cmbtipodoc.SelectedIndexChanged += new System.EventHandler(this.cmbtipodoc_SelectedIndexChanged);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumeroDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNumeroDoc.FormattingEnabled = true;
            this.txtNumeroDoc.ItemHeight = 13;
            this.txtNumeroDoc.Location = new System.Drawing.Point(126, 63);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(128, 21);
            this.txtNumeroDoc.TabIndex = 123;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 110;
            this.checkBox1.Text = "No tiene";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 637);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnREntradaP);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvEProducto);
            this.Name = "frmDevolucion";
            this.Text = "frmDevolucion";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreciov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecioc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtcproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudpreciov;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.NumericUpDown nudprecioc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnREntradaP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.TextBox txtpersonal;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtCEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvEProducto;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.ComboBox cmbtipodoc;
        private System.Windows.Forms.ComboBox txtNumeroDoc;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}