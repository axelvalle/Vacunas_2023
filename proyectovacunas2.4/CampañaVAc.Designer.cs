namespace CampañadeVac
{
    partial class frmCampañaVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampañaVA));
            btnVolver = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            DTFecha = new System.Windows.Forms.DateTimePicker();
            comboBoxVacunas = new System.Windows.Forms.ComboBox();
            comboBoxRangodeEdades = new System.Windows.Forms.ComboBox();
            txtLugar = new System.Windows.Forms.TextBox();
            comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            btnsave = new System.Windows.Forms.Button();
            btnshow = new System.Windows.Forms.Button();
            txtEjecutada = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            btnVolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(1037, 596);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(157, 61);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(444, 220);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(249, 21);
            label1.TabIndex = 11;
            label1.Text = "Fecha de la siguiente jornada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(446, 317);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(214, 21);
            label2.TabIndex = 12;
            label2.Text = "Vacunas que se aplicaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(446, 371);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 21);
            label3.TabIndex = 13;
            label3.Text = "Rango de Edades";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(446, 434);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(212, 21);
            label4.TabIndex = 14;
            label4.Text = "Lugar donde se realizará";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(448, 487);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(239, 21);
            label5.TabIndex = 15;
            label5.Text = "Empleados que participaron";
            // 
            // DTFecha
            // 
            DTFecha.Location = new System.Drawing.Point(725, 218);
            DTFecha.Name = "DTFecha";
            DTFecha.Size = new System.Drawing.Size(250, 27);
            DTFecha.TabIndex = 16;
            // 
            // comboBoxVacunas
            // 
            comboBoxVacunas.FormattingEnabled = true;
            comboBoxVacunas.Location = new System.Drawing.Point(727, 322);
            comboBoxVacunas.Name = "comboBoxVacunas";
            comboBoxVacunas.Size = new System.Drawing.Size(250, 28);
            comboBoxVacunas.TabIndex = 17;
            // 
            // comboBoxRangodeEdades
            // 
            comboBoxRangodeEdades.FormattingEnabled = true;
            comboBoxRangodeEdades.Items.AddRange(new object[] { "0-9", "10-19", "20-29", "30-49", "50-59", "59+" });
            comboBoxRangodeEdades.Location = new System.Drawing.Point(727, 381);
            comboBoxRangodeEdades.Name = "comboBoxRangodeEdades";
            comboBoxRangodeEdades.Size = new System.Drawing.Size(250, 28);
            comboBoxRangodeEdades.TabIndex = 18;
            // 
            // txtLugar
            // 
            txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtLugar.Location = new System.Drawing.Point(725, 442);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new System.Drawing.Size(252, 27);
            txtLugar.TabIndex = 19;
            // 
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new System.Drawing.Point(725, 498);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new System.Drawing.Size(252, 28);
            comboBoxEmpleados.TabIndex = 20;
            // 
            // btnsave
            // 
            btnsave.BackColor = System.Drawing.Color.SteelBlue;
            btnsave.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnsave.Location = new System.Drawing.Point(522, 596);
            btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(181, 56);
            btnsave.TabIndex = 22;
            btnsave.Text = "Guardar";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnshow
            // 
            btnshow.BackColor = System.Drawing.Color.SteelBlue;
            btnshow.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnshow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnshow.Location = new System.Drawing.Point(723, 596);
            btnshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnshow.Name = "btnshow";
            btnshow.Size = new System.Drawing.Size(181, 56);
            btnshow.TabIndex = 21;
            btnshow.Text = "Mostrar Contenido";
            btnshow.UseVisualStyleBackColor = false;
            btnshow.Click += btnshow_Click;
            // 
            // txtEjecutada
            // 
            txtEjecutada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEjecutada.Location = new System.Drawing.Point(725, 276);
            txtEjecutada.Name = "txtEjecutada";
            txtEjecutada.Size = new System.Drawing.Size(252, 27);
            txtEjecutada.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(446, 268);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(131, 21);
            label6.TabIndex = 23;
            label6.Text = "Fue ejecutada?";
            // 
            // frmCampañaVA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__5_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1206, 676);
            Controls.Add(txtEjecutada);
            Controls.Add(label6);
            Controls.Add(btnsave);
            Controls.Add(btnshow);
            Controls.Add(comboBoxEmpleados);
            Controls.Add(txtLugar);
            Controls.Add(comboBoxRangodeEdades);
            Controls.Add(comboBoxVacunas);
            Controls.Add(DTFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmCampañaVA";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Jornadas";
            Load += frmCampañaVA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.ComboBox comboBoxVacunas;
        private System.Windows.Forms.ComboBox comboBoxRangodeEdades;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox txtEjecutada;
        private System.Windows.Forms.Label label6;
    }
}
