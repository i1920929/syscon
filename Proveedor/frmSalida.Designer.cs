namespace Proveedor
{
    partial class frmSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalida));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbtipodoc = new System.Windows.Forms.ComboBox();
            this.txtpersonal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtmfechasalida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.cmbsubcategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtunidad = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtpreciov = new System.Windows.Forms.NumericUpDown();
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cmdagrega = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpreciov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtserie);
            this.groupBox2.Controls.Add(this.cmbtipodoc);
            this.groupBox2.Controls.Add(this.txtpersonal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdocumento);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.dtmfechasalida);
            this.groupBox2.Location = new System.Drawing.Point(18, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RegistarSalida";
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
            this.cmbtipodoc.Location = new System.Drawing.Point(110, 43);
            this.cmbtipodoc.Name = "cmbtipodoc";
            this.cmbtipodoc.Size = new System.Drawing.Size(123, 23);
            this.cmbtipodoc.TabIndex = 57;
            this.cmbtipodoc.SelectedIndexChanged += new System.EventHandler(this.cmbtipodoc_SelectedIndexChanged);
            // 
            // txtpersonal
            // 
            this.txtpersonal.Enabled = false;
            this.txtpersonal.Location = new System.Drawing.Point(110, 164);
            this.txtpersonal.Name = "txtpersonal";
            this.txtpersonal.Size = new System.Drawing.Size(122, 21);
            this.txtpersonal.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "Codigo";
            this.label14.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "FechaSalida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nro Documento";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(163, 83);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(70, 21);
            this.txtdocumento.TabIndex = 2;
            this.txtdocumento.TextChanged += new System.EventHandler(this.txtdocumento_TextChanged);
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(110, 210);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(123, 21);
            this.txtCod.TabIndex = 18;
            this.txtCod.Visible = false;
            // 
            // dtmfechasalida
            // 
            this.dtmfechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmfechasalida.Location = new System.Drawing.Point(110, 121);
            this.dtmfechasalida.Name = "dtmfechasalida";
            this.dtmfechasalida.Size = new System.Drawing.Size(123, 21);
            this.dtmfechasalida.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 87);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Salida de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Proveedor.Properties.Resources.tienda_online_opt;
            this.pictureBox1.Location = new System.Drawing.Point(261, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtprecio);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtIdProducto);
            this.groupBox5.Controls.Add(this.cmbsubcategoria);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtunidad);
            this.groupBox5.Controls.Add(this.txtstock);
            this.groupBox5.Controls.Add(this.cmbproducto);
            this.groupBox5.Controls.Add(this.cmbcategoria);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(284, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(468, 134);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Producto";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtprecio
            // 
            this.txtprecio.DecimalPlaces = 2;
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(244, 97);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(78, 21);
            this.txtprecio.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "IdProducto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(78, 96);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(76, 21);
            this.txtIdProducto.TabIndex = 23;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // cmbsubcategoria
            // 
            this.cmbsubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubcategoria.FormattingEnabled = true;
            this.cmbsubcategoria.Location = new System.Drawing.Point(324, 26);
            this.cmbsubcategoria.Name = "cmbsubcategoria";
            this.cmbsubcategoria.Size = new System.Drawing.Size(138, 23);
            this.cmbsubcategoria.TabIndex = 2;
            this.cmbsubcategoria.SelectedIndexChanged += new System.EventHandler(this.cmbsubcategoria_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Precio Costo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "SubCategoria";
            // 
            // txtunidad
            // 
            this.txtunidad.Enabled = false;
            this.txtunidad.Location = new System.Drawing.Point(355, 60);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(104, 21);
            this.txtunidad.TabIndex = 17;
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Location = new System.Drawing.Point(382, 96);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(80, 21);
            this.txtstock.TabIndex = 16;
            this.txtstock.Text = "0";
            // 
            // cmbproducto
            // 
            this.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(72, 60);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(238, 23);
            this.cmbproducto.TabIndex = 3;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(72, 26);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(162, 23);
            this.cmbcategoria.TabIndex = 1;
            this.cmbcategoria.SelectedIndexChanged += new System.EventHandler(this.cmbcategoria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "U.M.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Precio Venta";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtpreciov);
            this.groupBox6.Controls.Add(this.nudcantidad);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(284, 266);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 126);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Digitar Detalles";
            // 
            // txtpreciov
            // 
            this.txtpreciov.DecimalPlaces = 2;
            this.txtpreciov.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtpreciov.Location = new System.Drawing.Point(107, 43);
            this.txtpreciov.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtpreciov.Name = "txtpreciov";
            this.txtpreciov.Size = new System.Drawing.Size(98, 21);
            this.txtpreciov.TabIndex = 12;
            // 
            // nudcantidad
            // 
            this.nudcantidad.Location = new System.Drawing.Point(107, 86);
            this.nudcantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(98, 21);
            this.nudcantidad.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cantidad";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(15, 407);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(737, 222);
            this.dgv1.TabIndex = 30;
            this.dgv1.CurrentCellChanged += new System.EventHandler(this.dgv1_CurrentCellChanged);
            // 
            // cmdagrega
            // 
            this.cmdagrega.Location = new System.Drawing.Point(555, 330);
            this.cmdagrega.Name = "cmdagrega";
            this.cmdagrega.Size = new System.Drawing.Size(73, 32);
            this.cmdagrega.TabIndex = 4;
            this.cmdagrega.Text = "Agregar";
            this.cmdagrega.UseVisualStyleBackColor = true;
            this.cmdagrega.Click += new System.EventHandler(this.cmdagrega_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(555, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Registrar Salida de Producto";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(679, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 32);
            this.button7.TabIndex = 5;
            this.button7.Text = "Quitar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(663, 668);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 81;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(110, 83);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(34, 21);
            this.txtserie.TabIndex = 58;
            this.txtserie.Text = "003";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "-";
            // 
            // frmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 703);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cmdagrega);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "frmSalida";
            this.Text = "frmSalida";
            this.Load += new System.EventHandler(this.Salida_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpreciov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.DateTimePicker dtmfechasalida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtunidad;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button cmdagrega;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmbsubcategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtpersonal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown txtpreciov;
        private System.Windows.Forms.ComboBox cmbtipodoc;
        private System.Windows.Forms.NumericUpDown txtprecio;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label label4;

    }
}