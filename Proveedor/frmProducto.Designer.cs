namespace Proveedor
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudstockactual = new System.Windows.Forms.NumericUpDown();
            this.cmbsubcategoria = new System.Windows.Forms.ComboBox();
            this.cmbunidadmedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudstockmin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudprecioc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudpreciov = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbSubcategoria = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockactual)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecioc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreciov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            this.dgvproducto.AllowUserToDeleteRows = false;
            this.dgvproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(29, 428);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.ReadOnly = true;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducto.Size = new System.Drawing.Size(713, 255);
            this.dgvproducto.TabIndex = 3;
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            this.dgvproducto.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(33, 40);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(76, 25);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "N&uevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.AllowDrop = true;
            this.btnactualizar.Location = new System.Drawing.Point(33, 121);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(76, 25);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Ac&tualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(33, 81);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(76, 25);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Registrar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(597, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Sub Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(122, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(136, 21);
            this.txtnombre.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Unidad de Medida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(287, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Stock Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Precio Venta";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(122, 74);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(88, 21);
            this.txtmarca.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(122, 20);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(88, 21);
            this.txtcodigo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Marca";
            // 
            // nudstockactual
            // 
            this.nudstockactual.Enabled = false;
            this.nudstockactual.Location = new System.Drawing.Point(398, 107);
            this.nudstockactual.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.nudstockactual.Name = "nudstockactual";
            this.nudstockactual.Size = new System.Drawing.Size(54, 21);
            this.nudstockactual.TabIndex = 6;
            // 
            // cmbsubcategoria
            // 
            this.cmbsubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubcategoria.FormattingEnabled = true;
            this.cmbsubcategoria.Location = new System.Drawing.Point(397, 49);
            this.cmbsubcategoria.Name = "cmbsubcategoria";
            this.cmbsubcategoria.Size = new System.Drawing.Size(136, 23);
            this.cmbsubcategoria.TabIndex = 5;
            // 
            // cmbunidadmedida
            // 
            this.cmbunidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbunidadmedida.FormattingEnabled = true;
            this.cmbunidadmedida.Location = new System.Drawing.Point(397, 77);
            this.cmbunidadmedida.Name = "cmbunidadmedida";
            this.cmbunidadmedida.Size = new System.Drawing.Size(88, 23);
            this.cmbunidadmedida.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(397, 20);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(136, 23);
            this.cmbcategoria.TabIndex = 4;
            this.cmbcategoria.SelectedIndexChanged += new System.EventHandler(this.cmbcategoria_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudstockmin);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudprecioc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudpreciov);
            this.groupBox2.Controls.Add(this.cmbcategoria);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbunidadmedida);
            this.groupBox2.Controls.Add(this.cmbsubcategoria);
            this.groupBox2.Controls.Add(this.nudstockactual);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nudstockmin
            // 
            this.nudstockmin.Location = new System.Drawing.Point(398, 134);
            this.nudstockmin.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nudstockmin.Name = "nudstockmin";
            this.nudstockmin.Size = new System.Drawing.Size(54, 21);
            this.nudstockmin.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Stock Mínimo";
            // 
            // nudprecioc
            // 
            this.nudprecioc.DecimalPlaces = 2;
            this.nudprecioc.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudprecioc.Location = new System.Drawing.Point(122, 128);
            this.nudprecioc.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudprecioc.Name = "nudprecioc";
            this.nudprecioc.Size = new System.Drawing.Size(88, 21);
            this.nudprecioc.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Precio Costo";
            // 
            // nudpreciov
            // 
            this.nudpreciov.DecimalPlaces = 2;
            this.nudpreciov.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudpreciov.Location = new System.Drawing.Point(122, 101);
            this.nudpreciov.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudpreciov.Name = "nudpreciov";
            this.nudpreciov.Size = new System.Drawing.Size(88, 21);
            this.nudpreciov.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Proveedor.Properties.Resources.embalaje_opt;
            this.pictureBox2.Location = new System.Drawing.Point(293, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 68);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(29, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 87);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(666, 689);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(80, 25);
            this.btncerrar.TabIndex = 36;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbSubcategoria);
            this.groupBox4.Controls.Add(this.rdbCodigo);
            this.groupBox4.Controls.Add(this.rdbNombre);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Location = new System.Drawing.Point(65, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(641, 102);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda";
            // 
            // rdbSubcategoria
            // 
            this.rdbSubcategoria.AutoSize = true;
            this.rdbSubcategoria.Location = new System.Drawing.Point(431, 33);
            this.rdbSubcategoria.Name = "rdbSubcategoria";
            this.rdbSubcategoria.Size = new System.Drawing.Size(98, 19);
            this.rdbSubcategoria.TabIndex = 1;
            this.rdbSubcategoria.Text = "Subcategoría";
            this.rdbSubcategoria.UseVisualStyleBackColor = true;
            this.rdbSubcategoria.CheckedChanged += new System.EventHandler(this.rdbSubcategoria_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(275, 33);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(64, 19);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código\r\n";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Checked = true;
            this.rdbNombre.Location = new System.Drawing.Point(95, 33);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(70, 19);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(95, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(483, 21);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 714);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvproducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudstockactual)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstockmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecioc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudpreciov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudstockactual;
        private System.Windows.Forms.ComboBox cmbsubcategoria;
        private System.Windows.Forms.ComboBox cmbunidadmedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.NumericUpDown nudpreciov;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbSubcategoria;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.NumericUpDown nudprecioc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudstockmin;
        private System.Windows.Forms.Label label11;
    }
}