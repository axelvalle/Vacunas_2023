namespace Administracion_de_vacunas
{
    partial class frmvacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvacunacion));
            label7 = new System.Windows.Forms.Label();
            txtObservaciones = new System.Windows.Forms.TextBox();
            dtSegundaDosis = new System.Windows.Forms.DateTimePicker();
            dtPrimeraDosis = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtEdadPaciente = new System.Windows.Forms.TextBox();
            txtPaciente = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnVolver = new System.Windows.Forms.Button();
            btnguardar = new System.Windows.Forms.Button();
            btnshowcontent = new System.Windows.Forms.Button();
            btnback = new System.Windows.Forms.Button();
            cbVacuna = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtEnfermedad = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(344, 524);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(117, 20);
            label7.TabIndex = 13;
            label7.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtObservaciones.Location = new System.Drawing.Point(618, 516);
            txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new System.Drawing.Size(345, 28);
            txtObservaciones.TabIndex = 12;
            // 
            // dtSegundaDosis
            // 
            dtSegundaDosis.Location = new System.Drawing.Point(618, 462);
            dtSegundaDosis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtSegundaDosis.Name = "dtSegundaDosis";
            dtSegundaDosis.Size = new System.Drawing.Size(345, 28);
            dtSegundaDosis.TabIndex = 11;
            // 
            // dtPrimeraDosis
            // 
            dtPrimeraDosis.Location = new System.Drawing.Point(618, 412);
            dtPrimeraDosis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtPrimeraDosis.Name = "dtPrimeraDosis";
            dtPrimeraDosis.Size = new System.Drawing.Size(345, 28);
            dtPrimeraDosis.TabIndex = 10;
            dtPrimeraDosis.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(344, 470);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(191, 20);
            label6.TabIndex = 9;
            label6.Text = "Fecha de Siguiente Dosis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(344, 418);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 20);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Primera Dosis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Image = proyectovacunas2._4.Properties.Resources.Imagen__22_;
            label4.Location = new System.Drawing.Point(344, 292);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(135, 20);
            label4.TabIndex = 5;
            label4.Text = "Vacuna Aplicada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(344, 246);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 20);
            label3.TabIndex = 3;
            label3.Text = "Edad del Paciente";
            label3.Click += label3_Click;
            // 
            // txtEdadPaciente
            // 
            txtEdadPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEdadPaciente.Location = new System.Drawing.Point(618, 238);
            txtEdadPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEdadPaciente.Name = "txtEdadPaciente";
            txtEdadPaciente.Size = new System.Drawing.Size(345, 28);
            txtEdadPaciente.TabIndex = 2;
            // 
            // txtPaciente
            // 
            txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPaciente.Location = new System.Drawing.Point(618, 191);
            txtPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new System.Drawing.Size(345, 28);
            txtPaciente.TabIndex = 1;
            txtPaciente.TextChanged += txtPaciente_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(344, 199);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(161, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre del Paciente";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            btnVolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(1299, 566);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(196, 61);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = System.Drawing.Color.SteelBlue;
            btnguardar.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnguardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnguardar.Location = new System.Drawing.Point(537, 591);
            btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new System.Drawing.Size(181, 56);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnshowcontent
            // 
            btnshowcontent.BackColor = System.Drawing.Color.SteelBlue;
            btnshowcontent.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnshowcontent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnshowcontent.Location = new System.Drawing.Point(738, 591);
            btnshowcontent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnshowcontent.Name = "btnshowcontent";
            btnshowcontent.Size = new System.Drawing.Size(181, 56);
            btnshowcontent.TabIndex = 14;
            btnshowcontent.Text = "Mostrar Contenido";
            btnshowcontent.UseVisualStyleBackColor = false;
            btnshowcontent.Click += btnMostrar_Click;
            // 
            // btnback
            // 
            btnback.BackColor = System.Drawing.Color.SteelBlue;
            btnback.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnback.ForeColor = System.Drawing.Color.AliceBlue;
            btnback.Location = new System.Drawing.Point(1060, 591);
            btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(157, 61);
            btnback.TabIndex = 16;
            btnback.Text = "Regresar";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // cbVacuna
            // 
            cbVacuna.FormattingEnabled = true;
            cbVacuna.Location = new System.Drawing.Point(618, 289);
            cbVacuna.Name = "cbVacuna";
            cbVacuna.Size = new System.Drawing.Size(345, 28);
            cbVacuna.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(344, 332);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 18;
            label1.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(344, 374);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 20);
            label8.TabIndex = 19;
            label8.Text = "Enfermedad";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDireccion.Location = new System.Drawing.Point(618, 332);
            txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(345, 28);
            txtDireccion.TabIndex = 20;
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEnfermedad.Location = new System.Drawing.Point(618, 372);
            txtEnfermedad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new System.Drawing.Size(345, 28);
            txtEnfermedad.TabIndex = 21;
            // 
            // frmvacunacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__22_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1229, 663);
            Controls.Add(txtEnfermedad);
            Controls.Add(txtDireccion);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(cbVacuna);
            Controls.Add(btnguardar);
            Controls.Add(btnshowcontent);
            Controls.Add(btnback);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(txtObservaciones);
            Controls.Add(dtSegundaDosis);
            Controls.Add(txtPaciente);
            Controls.Add(dtPrimeraDosis);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtEdadPaciente);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "frmvacunacion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro de Administración de vacunas";
            Load += frmvacunacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtSegundaDosis;
        private System.Windows.Forms.DateTimePicker dtPrimeraDosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdadPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnshowcontent;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEnfermedad;
    }
}
