namespace proyectovacunas2._4
{
    partial class frmInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            Tabla = new System.Windows.Forms.DataGridView();
            namepaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            agepatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Vacuna_Aplicada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            primeradosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            segundadosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnvolver = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.BackgroundColor = System.Drawing.Color.MidnightBlue;
            Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { namepaciente, agepatient, direccion, sickness, Vacuna_Aplicada, primeradosis, segundadosis, Observaciones });
            Tabla.Location = new System.Drawing.Point(12, 82);
            Tabla.Name = "Tabla";
            Tabla.RowHeadersWidth = 51;
            Tabla.RowTemplate.Height = 29;
            Tabla.Size = new System.Drawing.Size(561, 155);
            Tabla.TabIndex = 0;
            // 
            // namepaciente
            // 
            namepaciente.HeaderText = "Nombre del paciente";
            namepaciente.MinimumWidth = 6;
            namepaciente.Name = "namepaciente";
            namepaciente.Width = 125;
            // 
            // agepatient
            // 
            agepatient.HeaderText = "Edad del paciente";
            agepatient.MinimumWidth = 6;
            agepatient.Name = "agepatient";
            agepatient.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.Width = 125;
            // 
            // sickness
            // 
            sickness.HeaderText = "Enfermedad";
            sickness.MinimumWidth = 6;
            sickness.Name = "sickness";
            sickness.Width = 125;
            // 
            // Vacuna_Aplicada
            // 
            Vacuna_Aplicada.HeaderText = "Vacuna aplicada";
            Vacuna_Aplicada.MinimumWidth = 6;
            Vacuna_Aplicada.Name = "Vacuna_Aplicada";
            Vacuna_Aplicada.Width = 125;
            // 
            // primeradosis
            // 
            primeradosis.HeaderText = "Primera Dosis";
            primeradosis.MinimumWidth = 6;
            primeradosis.Name = "primeradosis";
            primeradosis.Width = 125;
            // 
            // segundadosis
            // 
            segundadosis.HeaderText = "Segunda Dosis";
            segundadosis.MinimumWidth = 6;
            segundadosis.Name = "segundadosis";
            segundadosis.Width = 125;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.MinimumWidth = 6;
            Observaciones.Name = "Observaciones";
            Observaciones.Width = 125;
            // 
            // btnvolver
            // 
            btnvolver.BackColor = System.Drawing.Color.SteelBlue;
            btnvolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnvolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnvolver.Location = new System.Drawing.Point(30, 288);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new System.Drawing.Size(157, 61);
            btnvolver.TabIndex = 13;
            btnvolver.Text = "Regresar";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.SteelBlue;
            button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.AliceBlue;
            button1.Location = new System.Drawing.Point(395, 288);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(157, 61);
            button1.TabIndex = 14;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmInformacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MidnightBlue;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(585, 374);
            Controls.Add(button1);
            Controls.Add(btnvolver);
            Controls.Add(Tabla);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInformacion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Informacion";
            Load += frmInformacion_Load;
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn agepatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna_Aplicada;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeradosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundadosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button button1;
    }
}