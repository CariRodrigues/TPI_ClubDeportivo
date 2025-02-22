﻿namespace TPI_ClubDeportivo
{
    partial class frmInscribirActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscribirActividad));
            dtgvActividades = new DataGridView();
            lblTitleListAct = new Label();
            lblIdcliente = new Label();
            txtIdCliente = new TextBox();
            lblIdActividad = new Label();
            txtIdActividad = new TextBox();
            lblInsCliente = new Label();
            picLogo = new PictureBox();
            panel1 = new Panel();
            lblInsAct = new Label();
            btnVolverInsAct = new Button();
            btnLimpiarInscripcion = new Button();
            btnInscribirCliente = new Button();
            panel2 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            Dias = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvActividades
            // 
            dtgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividades.Columns.AddRange(new DataGridViewColumn[] { ID, Actividad, Dias, Hora, Instructor, Precio });
            dtgvActividades.Location = new Point(36, 213);
            dtgvActividades.Name = "dtgvActividades";
            dtgvActividades.RowHeadersWidth = 50;
            dtgvActividades.RowTemplate.Height = 33;
            dtgvActividades.Size = new Size(983, 211);
            dtgvActividades.TabIndex = 0;
            // 
            // lblTitleListAct
            // 
            lblTitleListAct.AutoSize = true;
            lblTitleListAct.Font = new Font("Futura Md BT", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleListAct.Location = new Point(375, 142);
            lblTitleListAct.Name = "lblTitleListAct";
            lblTitleListAct.Size = new Size(304, 35);
            lblTitleListAct.TabIndex = 1;
            lblTitleListAct.Text = "Lista de Actividades";
            // 
            // lblIdcliente
            // 
            lblIdcliente.AutoSize = true;
            lblIdcliente.Font = new Font("Futura Md BT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdcliente.Location = new Point(308, 539);
            lblIdcliente.Name = "lblIdcliente";
            lblIdcliente.Size = new Size(170, 29);
            lblIdcliente.TabIndex = 3;
            lblIdcliente.Text = "ID de Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Futura Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCliente.Location = new Point(302, 587);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(182, 40);
            txtIdCliente.TabIndex = 5;
            // 
            // lblIdActividad
            // 
            lblIdActividad.AutoSize = true;
            lblIdActividad.Font = new Font("Futura Md BT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdActividad.Location = new Point(551, 539);
            lblIdActividad.Name = "lblIdActividad";
            lblIdActividad.Size = new Size(199, 29);
            lblIdActividad.TabIndex = 6;
            lblIdActividad.Text = "ID de Actividad";
            // 
            // txtIdActividad
            // 
            txtIdActividad.Font = new Font("Futura Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdActividad.Location = new Point(559, 587);
            txtIdActividad.Name = "txtIdActividad";
            txtIdActividad.Size = new Size(182, 40);
            txtIdActividad.TabIndex = 7;
            // 
            // lblInsCliente
            // 
            lblInsCliente.AutoSize = true;
            lblInsCliente.Font = new Font("Futura Md BT", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblInsCliente.Location = new Point(405, 469);
            lblInsCliente.Name = "lblInsCliente";
            lblInsCliente.Size = new Size(244, 35);
            lblInsCliente.TabIndex = 8;
            lblInsCliente.Text = "Inscribir Cliente";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = null;
            picLogo.Location = new Point(35, 34);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 32;
            picLogo.TabStop = false;
            picLogo.WaitOnLoad = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lblInsAct);
            panel1.Controls.Add(btnVolverInsAct);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 110);
            panel1.TabIndex = 31;
            // 
            // lblInsAct
            // 
            lblInsAct.AutoSize = true;
            lblInsAct.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblInsAct.ForeColor = Color.FromArgb(64, 64, 64);
            lblInsAct.Location = new Point(270, 31);
            lblInsAct.Name = "lblInsAct";
            lblInsAct.Size = new Size(516, 47);
            lblInsAct.TabIndex = 11;
            lblInsAct.Text = "Inscipcion en Actividades";
            // 
            // btnVolverInsAct
            // 
            btnVolverInsAct.BackColor = Color.Gainsboro;
            btnVolverInsAct.Font = new Font("Futura Md BT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverInsAct.ForeColor = Color.DimGray;
            btnVolverInsAct.Location = new Point(876, 29);
            btnVolverInsAct.Name = "btnVolverInsAct";
            btnVolverInsAct.Size = new Size(140, 50);
            btnVolverInsAct.TabIndex = 1;
            btnVolverInsAct.Text = "Volver";
            btnVolverInsAct.UseVisualStyleBackColor = false;
            btnVolverInsAct.Click += btnVolverInsAct_Click;
            // 
            // btnLimpiarInscripcion
            // 
            btnLimpiarInscripcion.BackColor = Color.Gray;
            btnLimpiarInscripcion.Font = new Font("Futura Md BT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarInscripcion.ForeColor = Color.White;
            btnLimpiarInscripcion.Location = new Point(149, 676);
            btnLimpiarInscripcion.Name = "btnLimpiarInscripcion";
            btnLimpiarInscripcion.Size = new Size(320, 70);
            btnLimpiarInscripcion.TabIndex = 34;
            btnLimpiarInscripcion.Text = "LIMPIAR";
            btnLimpiarInscripcion.UseVisualStyleBackColor = false;
            btnLimpiarInscripcion.Click += btnLimpiarInscripcion_Click;
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.BackColor = Color.DodgerBlue;
            btnInscribirCliente.Font = new Font("Futura Md BT", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirCliente.ForeColor = Color.White;
            btnInscribirCliente.Location = new Point(576, 676);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(320, 70);
            btnInscribirCliente.TabIndex = 33;
            btnInscribirCliente.Text = "INGRESAR";
            btnInscribirCliente.UseVisualStyleBackColor = false;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(-1, 442);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 10);
            panel2.TabIndex = 35;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Actividad
            // 
            Actividad.HeaderText = "ACTIVIDAD";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            // 
            // Dias
            // 
            Dias.HeaderText = "DÍAS";
            Dias.MinimumWidth = 6;
            Dias.Name = "Dias";
            // 
            // Hora
            // 
            Hora.HeaderText = "HORA";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            // 
            // Instructor
            // 
            Instructor.HeaderText = "INSTRUCTOR";
            Instructor.MinimumWidth = 6;
            Instructor.Name = "Instructor";
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO ($)";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // frmInscribirActividad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 784);
            Controls.Add(panel2);
            Controls.Add(btnLimpiarInscripcion);
            Controls.Add(btnInscribirCliente);
            Controls.Add(picLogo);
            Controls.Add(panel1);
            Controls.Add(lblInsCliente);
            Controls.Add(txtIdActividad);
            Controls.Add(lblIdActividad);
            Controls.Add(txtIdCliente);
            Controls.Add(lblIdcliente);
            Controls.Add(lblTitleListAct);
            Controls.Add(dtgvActividades);
            Name = "frmInscribirActividad";
            Text = "frmAsignar";
            Load += frmAsignar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvActividades;
        private Label lblTitleListAct;
        private Button btnVolverAsignar;
        private Label lblIdcliente;
        private Button btnAsignar;
        private TextBox txtIdCliente;
        private Label lblIdActividad;
        private TextBox txtIdActividad;
        private Label lblInsCliente;
        private PictureBox picLogo;
        private Panel panel1;
        private Label lblInsAct;
        private Button btnVolverInsAct;
        private Button btnLimpiarInscripcion;
        private Button btnInscribirCliente;
        private Panel panel2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Dias;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn Precio;
    }    
}