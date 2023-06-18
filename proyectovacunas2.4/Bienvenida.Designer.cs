namespace proyectovacunas2._4
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            lblBienvenida = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnacceder = new System.Windows.Forms.Button();
            botonsalir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            lblBienvenida.Font = new System.Drawing.Font("Upheaval TT (BRK)", 70.2000046F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBienvenida.ForeColor = System.Drawing.SystemColors.Control;
            lblBienvenida.Location = new System.Drawing.Point(195, 21);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new System.Drawing.Size(743, 106);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "BIENVENIDO";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Upheaval TT (BRK)", 22.1999989F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(289, 115);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(514, 34);
            label1.TabIndex = 2;
            label1.Text = "AL SISTEMA DE VACUNACION";
            // 
            // btnacceder
            // 
            btnacceder.BackColor = System.Drawing.Color.SteelBlue;
            btnacceder.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnacceder.ForeColor = System.Drawing.Color.White;
            btnacceder.Location = new System.Drawing.Point(401, 476);
            btnacceder.Name = "btnacceder";
            btnacceder.Size = new System.Drawing.Size(346, 74);
            btnacceder.TabIndex = 3;
            btnacceder.Text = "Acceder con una cuenta";
            btnacceder.UseVisualStyleBackColor = false;
            btnacceder.Click += button1_Click;
            // 
            // botonsalir
            // 
            botonsalir.BackColor = System.Drawing.Color.SteelBlue;
            botonsalir.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            botonsalir.ForeColor = System.Drawing.Color.White;
            botonsalir.Location = new System.Drawing.Point(12, 529);
            botonsalir.Name = "botonsalir";
            botonsalir.Size = new System.Drawing.Size(188, 53);
            botonsalir.TabIndex = 4;
            botonsalir.Text = "Salir";
            botonsalir.UseVisualStyleBackColor = false;
            botonsalir.Click += botonsalir_Click;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen__7_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1096, 605);
            Controls.Add(botonsalir);
            Controls.Add(btnacceder);
            Controls.Add(label1);
            Controls.Add(lblBienvenida);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bienvenida";
            Opacity = 0.9D;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Button botonsalir;
    }
}