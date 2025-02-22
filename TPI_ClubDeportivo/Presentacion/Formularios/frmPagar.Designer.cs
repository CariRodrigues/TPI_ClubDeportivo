﻿namespace TPI_ClubDeportivo
{
    partial class frmPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagar));
            lblIngreseNumero = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cboCuotasTarjeta = new ComboBox();
            optTarjeta = new RadioButton();
            optEfvo = new RadioButton();
            txtDocumento = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            picLogo = new PictureBox();
            lblPagar = new Label();
            panel1 = new Panel();
            btnVolverInsAct = new Button();
            txtIdPago = new TextBox();
            label2 = new Label();
            dtgvDeudas = new DataGridView();
            ID_Pago = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btnBuscarDeudas = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudas).BeginInit();
            SuspendLayout();
            // 
            // lblIngreseNumero
            // 
            lblIngreseNumero.AutoSize = true;
            lblIngreseNumero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreseNumero.Location = new Point(214, 137);
            lblIngreseNumero.Name = "lblIngreseNumero";
            lblIngreseNumero.Size = new Size(425, 35);
            lblIngreseNumero.TabIndex = 0;
            lblIngreseNumero.Text = "Número de Documento del Cliente";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboCuotasTarjeta);
            groupBox1.Controls.Add(optTarjeta);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(46, 524);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 128);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 35;
            label1.Text = "Cant. Cuotas";
            // 
            // cboCuotasTarjeta
            // 
            cboCuotasTarjeta.Enabled = false;
            cboCuotasTarjeta.FormattingEnabled = true;
            cboCuotasTarjeta.Items.AddRange(new object[] { "1 ", "3", "6", "12" });
            cboCuotasTarjeta.Location = new Point(168, 126);
            cboCuotasTarjeta.Name = "cboCuotasTarjeta";
            cboCuotasTarjeta.Size = new Size(103, 36);
            cboCuotasTarjeta.TabIndex = 35;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(38, 90);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(90, 32);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(38, 54);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(102, 32);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            optEfvo.CheckedChanged += optEfvo_CheckedChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(307, 195);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(251, 41);
            txtDocumento.TabIndex = 2;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(477, 586);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(200, 60);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobante.Location = new Point(771, 586);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(200, 60);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = null;
            picLogo.Location = new Point(37, 34);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 34;
            picLogo.TabStop = false;
            picLogo.WaitOnLoad = true;
            // 
            // lblPagar
            // 
            lblPagar.AutoSize = true;
            lblPagar.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblPagar.ForeColor = Color.FromArgb(64, 64, 64);
            lblPagar.Location = new Point(454, 32);
            lblPagar.Name = "lblPagar";
            lblPagar.Size = new Size(146, 47);
            lblPagar.TabIndex = 11;
            lblPagar.Text = "Pagos ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lblPagar);
            panel1.Controls.Add(btnVolverInsAct);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 110);
            panel1.TabIndex = 33;
            // 
            // btnVolverInsAct
            // 
            btnVolverInsAct.BackColor = Color.Gainsboro;
            btnVolverInsAct.Font = new Font("Futura Md BT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInsAct.ForeColor = Color.DimGray;
            btnVolverInsAct.Location = new Point(873, 29);
            btnVolverInsAct.Name = "btnVolverInsAct";
            btnVolverInsAct.Size = new Size(140, 50);
            btnVolverInsAct.TabIndex = 1;
            btnVolverInsAct.Text = "Volver";
            btnVolverInsAct.UseVisualStyleBackColor = false;
            btnVolverInsAct.Click += btnVolverInsAct_Click;
            // 
            // txtIdPago
            // 
            txtIdPago.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdPago.Location = new Point(174, 453);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(251, 41);
            txtIdPago.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 453);
            label2.Name = "label2";
            label2.Size = new Size(105, 35);
            label2.TabIndex = 36;
            label2.Text = "ID Pago";
            // 
            // dtgvDeudas
            // 
            dtgvDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDeudas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDeudas.Columns.AddRange(new DataGridViewColumn[] { ID_Pago, Actividad, Fecha, Precio });
            dtgvDeudas.Location = new Point(37, 266);
            dtgvDeudas.Name = "dtgvDeudas";
            dtgvDeudas.RowHeadersWidth = 50;
            dtgvDeudas.RowTemplate.Height = 33;
            dtgvDeudas.Size = new Size(977, 164);
            dtgvDeudas.TabIndex = 37;
            // 
            // ID_Pago
            // 
            ID_Pago.HeaderText = "ID PAGO";
            ID_Pago.MinimumWidth = 6;
            ID_Pago.Name = "ID_Pago";
            // 
            // Actividad
            // 
            Actividad.HeaderText = "ACTIVIDAD";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO ($)";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // btnBuscarDeudas
            // 
            btnBuscarDeudas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarDeudas.Location = new Point(746, 161);
            btnBuscarDeudas.Name = "btnBuscarDeudas";
            btnBuscarDeudas.Size = new Size(200, 60);
            btnBuscarDeudas.TabIndex = 38;
            btnBuscarDeudas.Text = "BUSCAR";
            btnBuscarDeudas.UseVisualStyleBackColor = true;
            btnBuscarDeudas.Click += btnBuscarDeudas_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 734);
            Controls.Add(btnBuscarDeudas);
            Controls.Add(dtgvDeudas);
            Controls.Add(label2);
            Controls.Add(txtIdPago);
            Controls.Add(picLogo);
            Controls.Add(panel1);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtDocumento);
            Controls.Add(groupBox1);
            Controls.Add(lblIngreseNumero);
            Name = "frmPagar";
            Text = "frmPagar";
            Load += frmPagar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDeudas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblIngreseNumero;
        private GroupBox groupBox1;
        private RadioButton optTarjeta;
        private RadioButton optEfvo;
        private TextBox txtDocumento;
        private Button btnPagar;
        private Button btnComprobante;

        #endregion

        private PictureBox picLogo;
        private Label lblPagar;
        private Panel panel1;
        private Button btnVolverInsAct;
        private ComboBox cboCuotasTarjeta;
        private Label label1;
        private TextBox txtIdPago;
        private Label label2;
        private DataGridView dtgvDeudas;
        private DataGridViewTextBoxColumn ID_Pago;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Precio;
        private Button btnBuscarDeudas;
    }
}