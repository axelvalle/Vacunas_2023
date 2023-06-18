namespace proyectovacunas2._4
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            Salir = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            btnAdminVac = new System.Windows.Forms.Button();
            btnRegistro = new System.Windows.Forms.Button();
            btnJornadas = new System.Windows.Forms.Button();
            btnreporte = new System.Windows.Forms.Button();
            btnEmp = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Salir
            // 
            Salir.BackColor = System.Drawing.Color.RoyalBlue;
            Salir.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Salir.Location = new System.Drawing.Point(12, 612);
            Salir.Name = "Salir";
            Salir.Size = new System.Drawing.Size(114, 54);
            Salir.TabIndex = 2;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAdminVac);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(btnJornadas);
            panel1.Controls.Add(btnreporte);
            panel1.Controls.Add(btnEmp);
            panel1.Location = new System.Drawing.Point(719, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(337, 666);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.SteelBlue;
            button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.AliceBlue;
            button1.Location = new System.Drawing.Point(27, 515);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(289, 95);
            button1.TabIndex = 6;
            button1.Text = "Información del Centro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAdminVac
            // 
            btnAdminVac.BackColor = System.Drawing.Color.SteelBlue;
            btnAdminVac.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdminVac.ForeColor = System.Drawing.Color.AliceBlue;
            btnAdminVac.Location = new System.Drawing.Point(27, 392);
            btnAdminVac.Name = "btnAdminVac";
            btnAdminVac.Size = new System.Drawing.Size(289, 97);
            btnAdminVac.TabIndex = 5;
            btnAdminVac.Text = "Vacunación";
            btnAdminVac.UseVisualStyleBackColor = false;
            btnAdminVac.Click += btnAdminVac_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = System.Drawing.Color.SteelBlue;
            btnRegistro.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegistro.ForeColor = System.Drawing.Color.AliceBlue;
            btnRegistro.Location = new System.Drawing.Point(27, 194);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new System.Drawing.Size(289, 89);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "Registro de Vacunas";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnJornadas
            // 
            btnJornadas.BackColor = System.Drawing.Color.SteelBlue;
            btnJornadas.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnJornadas.ForeColor = System.Drawing.Color.AliceBlue;
            btnJornadas.Location = new System.Drawing.Point(27, 116);
            btnJornadas.Name = "btnJornadas";
            btnJornadas.Size = new System.Drawing.Size(289, 61);
            btnJornadas.TabIndex = 2;
            btnJornadas.Text = "Proximas Jornadas";
            btnJornadas.UseVisualStyleBackColor = false;
            btnJornadas.Click += btnJornadas_Click;
            // 
            // btnreporte
            // 
            btnreporte.BackColor = System.Drawing.Color.SteelBlue;
            btnreporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnreporte.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnreporte.ForeColor = System.Drawing.Color.AliceBlue;
            btnreporte.Location = new System.Drawing.Point(27, 304);
            btnreporte.Name = "btnreporte";
            btnreporte.Size = new System.Drawing.Size(289, 61);
            btnreporte.TabIndex = 1;
            btnreporte.Text = "Reporte";
            btnreporte.UseVisualStyleBackColor = false;
            btnreporte.Click += btnReporte_Click;
            // 
            // btnEmp
            // 
            btnEmp.BackColor = System.Drawing.Color.SteelBlue;
            btnEmp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEmp.ForeColor = System.Drawing.Color.AliceBlue;
            btnEmp.Location = new System.Drawing.Point(27, 39);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new System.Drawing.Size(289, 61);
            btnEmp.TabIndex = 0;
            btnEmp.Text = "Empleados";
            btnEmp.UseVisualStyleBackColor = false;
            btnEmp.Click += btnEmp_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SteelBlue;
            BackgroundImage = Properties.Resources.Imagen__41_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1067, 678);
            Controls.Add(panel1);
            Controls.Add(Salir);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SISTEMA DE VACUNACION";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masSobreNosotrosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminVac;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnJornadas;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button button1;
    }
}
