namespace TPI_ClubDeportivo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            lblUsuario = new Label();
            btnSalir = new Button();
            button2 = new Button();
            btnAsignarCurso = new Button();
            btnVerActividades = new Button();
            btnEmitirCarnet = new Button();
            btnPagar = new Button();
            button3 = new Button();
            panel1 = new Panel();
            lblIFTS29 = new Label();
            picLogo = new PictureBox();
            lblRol = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(270, 100);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 31);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gainsboro;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.DimGray;
            btnSalir.Location = new Point(512, 17);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 30);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(39, 148);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(245, 60);
            button2.TabIndex = 0;
            button2.Text = "Registrar Cliente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnInscribir_Click;
            // 
            // btnAsignarCurso
            // 
            btnAsignarCurso.BackColor = Color.DarkGoldenrod;
            btnAsignarCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignarCurso.ForeColor = Color.White;
            btnAsignarCurso.Location = new Point(338, 148);
            btnAsignarCurso.Margin = new Padding(2, 2, 2, 2);
            btnAsignarCurso.Name = "btnAsignarCurso";
            btnAsignarCurso.Size = new Size(245, 60);
            btnAsignarCurso.TabIndex = 1;
            btnAsignarCurso.Text = "Inscribir en Actividad";
            btnAsignarCurso.UseVisualStyleBackColor = false;
            btnAsignarCurso.Click += btnAsignarCurso_Click;
            // 
            // btnVerActividades
            // 
            btnVerActividades.BackColor = Color.DarkGoldenrod;
            btnVerActividades.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerActividades.ForeColor = Color.White;
            btnVerActividades.Location = new Point(39, 233);
            btnVerActividades.Margin = new Padding(2, 2, 2, 2);
            btnVerActividades.Name = "btnVerActividades";
            btnVerActividades.Size = new Size(245, 60);
            btnVerActividades.TabIndex = 2;
            btnVerActividades.Text = "Ver Actividades";
            btnVerActividades.UseVisualStyleBackColor = false;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.DarkGoldenrod;
            btnEmitirCarnet.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitirCarnet.ForeColor = Color.White;
            btnEmitirCarnet.Location = new Point(338, 233);
            btnEmitirCarnet.Margin = new Padding(2, 2, 2, 2);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(245, 60);
            btnEmitirCarnet.TabIndex = 3;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkGoldenrod;
            btnPagar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(39, 317);
            btnPagar.Margin = new Padding(2, 2, 2, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(245, 60);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGoldenrod;
            button3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(338, 317);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(245, 60);
            button3.TabIndex = 5;
            button3.Text = "Cuotas que Vencen Hoy";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lblIFTS29);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 66);
            panel1.TabIndex = 8;
            // 
            // lblIFTS29
            // 
            lblIFTS29.AutoSize = true;
            lblIFTS29.Font = new Font("Century", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblIFTS29.ForeColor = Color.FromArgb(64, 64, 64);
            lblIFTS29.Location = new Point(199, 15);
            lblIFTS29.Margin = new Padding(2, 0, 2, 0);
            lblIFTS29.Name = "lblIFTS29";
            lblIFTS29.Size = new Size(283, 41);
            lblIFTS29.TabIndex = 11;
            lblIFTS29.Text = "Menú Principal";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = null;
            picLogo.Location = new Point(22, 20);
            picLogo.Margin = new Padding(2, 2, 2, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(105, 90);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 9;
            picLogo.TabStop = false;
            picLogo.WaitOnLoad = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.Location = new Point(206, 73);
            lblRol.Margin = new Padding(2, 0, 2, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(234, 31);
            lblRol.TabIndex = 10;
            lblRol.Text = "* Administrador *";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(624, 404);
            Controls.Add(lblRol);
            Controls.Add(picLogo);
            Controls.Add(panel1);
            Controls.Add(lblUsuario);
            Controls.Add(button3);
            Controls.Add(btnPagar);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnVerActividades);
            Controls.Add(btnAsignarCurso);
            Controls.Add(button2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTANA PRINCIPAL";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnSalir;
        private Button button2;
        private Button btnAsignarCurso;
        private Button btnVerActividades;
        private Button btnEmitirCarnet;
        private Button btnPagar;
        private Button button3;
        private Panel panel1;
        private PictureBox picLogo;
        private Label lblRol;
        private Label lblIFTS29;
    }
}