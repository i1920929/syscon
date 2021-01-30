namespace Proveedor
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.panelcontenedor1 = new System.Windows.Forms.Panel();
            this.btnrptsalida = new System.Windows.Forms.Button();
            this.btnrptfechavenc = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnrptkardex = new System.Windows.Forms.Button();
            this.btnrptentrada = new System.Windows.Forms.Button();
            this.btnrptpersonal = new System.Windows.Forms.Button();
            this.btnrptproveedores = new System.Windows.Forms.Button();
            this.btnrptproductos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnrpttop = new System.Windows.Forms.Button();
            this.panelcontenedor1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedor1
            // 
            this.panelcontenedor1.Controls.Add(this.btnrpttop);
            this.panelcontenedor1.Controls.Add(this.btnrptsalida);
            this.panelcontenedor1.Controls.Add(this.btnrptfechavenc);
            this.panelcontenedor1.Controls.Add(this.btnCerrar);
            this.panelcontenedor1.Controls.Add(this.btnrptkardex);
            this.panelcontenedor1.Controls.Add(this.btnrptentrada);
            this.panelcontenedor1.Controls.Add(this.btnrptpersonal);
            this.panelcontenedor1.Controls.Add(this.btnrptproveedores);
            this.panelcontenedor1.Controls.Add(this.btnrptproductos);
            this.panelcontenedor1.Controls.Add(this.groupBox3);
            this.panelcontenedor1.Location = new System.Drawing.Point(-8, -28);
            this.panelcontenedor1.Name = "panelcontenedor1";
            this.panelcontenedor1.Size = new System.Drawing.Size(777, 739);
            this.panelcontenedor1.TabIndex = 0;
            // 
            // btnrptsalida
            // 
            this.btnrptsalida.Image = global::Proveedor.Properties.Resources.entrega_opt;
            this.btnrptsalida.Location = new System.Drawing.Point(280, 298);
            this.btnrptsalida.Name = "btnrptsalida";
            this.btnrptsalida.Size = new System.Drawing.Size(145, 116);
            this.btnrptsalida.TabIndex = 101;
            this.btnrptsalida.Text = "Lista de Salida de Productos";
            this.btnrptsalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptsalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptsalida.UseVisualStyleBackColor = true;
            this.btnrptsalida.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnrptfechavenc
            // 
            this.btnrptfechavenc.Image = ((System.Drawing.Image)(resources.GetObject("btnrptfechavenc.Image")));
            this.btnrptfechavenc.Location = new System.Drawing.Point(186, 445);
            this.btnrptfechavenc.Name = "btnrptfechavenc";
            this.btnrptfechavenc.Size = new System.Drawing.Size(147, 116);
            this.btnrptfechavenc.TabIndex = 100;
            this.btnrptfechavenc.Text = "Reporte Fecha de Vencimiento";
            this.btnrptfechavenc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptfechavenc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptfechavenc.UseVisualStyleBackColor = true;
            this.btnrptfechavenc.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(540, 597);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 99;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnrptkardex
            // 
            this.btnrptkardex.Image = ((System.Drawing.Image)(resources.GetObject("btnrptkardex.Image")));
            this.btnrptkardex.Location = new System.Drawing.Point(392, 447);
            this.btnrptkardex.Name = "btnrptkardex";
            this.btnrptkardex.Size = new System.Drawing.Size(143, 114);
            this.btnrptkardex.TabIndex = 98;
            this.btnrptkardex.Text = "Reporte de Kardex";
            this.btnrptkardex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptkardex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptkardex.UseVisualStyleBackColor = true;
            this.btnrptkardex.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnrptentrada
            // 
            this.btnrptentrada.Image = global::Proveedor.Properties.Resources._2019_10_03__2_;
            this.btnrptentrada.Location = new System.Drawing.Point(72, 298);
            this.btnrptentrada.Name = "btnrptentrada";
            this.btnrptentrada.Size = new System.Drawing.Size(147, 116);
            this.btnrptentrada.TabIndex = 97;
            this.btnrptentrada.Text = "Lista de Entrada deProductos";
            this.btnrptentrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptentrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptentrada.UseVisualStyleBackColor = true;
            this.btnrptentrada.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnrptpersonal
            // 
            this.btnrptpersonal.Image = global::Proveedor.Properties.Resources._2019_10_03__1_;
            this.btnrptpersonal.Location = new System.Drawing.Point(486, 173);
            this.btnrptpersonal.Name = "btnrptpersonal";
            this.btnrptpersonal.Size = new System.Drawing.Size(147, 103);
            this.btnrptpersonal.TabIndex = 96;
            this.btnrptpersonal.Text = "Lista de Personal";
            this.btnrptpersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptpersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptpersonal.UseVisualStyleBackColor = true;
            this.btnrptpersonal.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnrptproveedores
            // 
            this.btnrptproveedores.Image = global::Proveedor.Properties.Resources._2019_10_03;
            this.btnrptproveedores.Location = new System.Drawing.Point(280, 173);
            this.btnrptproveedores.Name = "btnrptproveedores";
            this.btnrptproveedores.Size = new System.Drawing.Size(145, 103);
            this.btnrptproveedores.TabIndex = 95;
            this.btnrptproveedores.Text = "Lista de Proveedores";
            this.btnrptproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptproveedores.UseVisualStyleBackColor = true;
            this.btnrptproveedores.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnrptproductos
            // 
            this.btnrptproductos.Image = global::Proveedor.Properties.Resources._2019_10_03__5_;
            this.btnrptproductos.Location = new System.Drawing.Point(72, 173);
            this.btnrptproductos.Name = "btnrptproductos";
            this.btnrptproductos.Size = new System.Drawing.Size(147, 103);
            this.btnrptproductos.TabIndex = 94;
            this.btnrptproductos.Text = "Lista de Productos";
            this.btnrptproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrptproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrptproductos.UseVisualStyleBackColor = true;
            this.btnrptproductos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(33, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 82);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Reportes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Proveedor.Properties.Resources._2019_10_03__3_;
            this.pictureBox2.Location = new System.Drawing.Point(259, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnrpttop
            // 
            this.btnrpttop.Image = ((System.Drawing.Image)(resources.GetObject("btnrpttop.Image")));
            this.btnrpttop.Location = new System.Drawing.Point(486, 298);
            this.btnrpttop.Name = "btnrpttop";
            this.btnrpttop.Size = new System.Drawing.Size(147, 116);
            this.btnrpttop.TabIndex = 102;
            this.btnrpttop.Text = "Reporte Top Productos";
            this.btnrpttop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrpttop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrpttop.UseVisualStyleBackColor = true;
            this.btnrpttop.Click += new System.EventHandler(this.btnrpttop_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 703);
            this.Controls.Add(this.panelcontenedor1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.panelcontenedor1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnrptkardex;
        private System.Windows.Forms.Button btnrptentrada;
        private System.Windows.Forms.Button btnrptpersonal;
        private System.Windows.Forms.Button btnrptproveedores;
        private System.Windows.Forms.Button btnrptproductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrptfechavenc;
        private System.Windows.Forms.Button btnrptsalida;
        private System.Windows.Forms.Button btnrpttop;
    }
}