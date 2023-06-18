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
            btnVolver = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            btnsave = new System.Windows.Forms.Button();
            btnshow = new System.Windows.Forms.Button();
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
            label2.Location = new System.Drawing.Point(444, 277);
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
            label3.Location = new System.Drawing.Point(444, 331);
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
            label4.Location = new System.Drawing.Point(444, 394);
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
            label5.Location = new System.Drawing.Point(446, 447);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(239, 21);
            label5.TabIndex = 15;
            label5.Text = "Empleados que participaron";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(725, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(725, 282);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(250, 28);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(725, 341);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(250, 28);
            comboBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Location = new System.Drawing.Point(723, 402);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(252, 27);
            textBox1.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(723, 458);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(252, 28);
            comboBox3.TabIndex = 20;
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
            // 
            // frmCampañaVA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__5_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1206, 676);
            Controls.Add(btnsave);
            Controls.Add(btnshow);
            Controls.Add(comboBox3);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MinimizeBox = false;
            Name = "frmCampañaVA";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Jornadas";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnshow;
    }
}
