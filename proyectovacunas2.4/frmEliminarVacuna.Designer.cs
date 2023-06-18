namespace proyectovacunas2._4
{
    partial class frmEliminarVacuna
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
            button1 = new System.Windows.Forms.Button();
            cbVacunas = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(146, 150);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 29);
            button1.TabIndex = 6;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbVacunas
            // 
            cbVacunas.FormattingEnabled = true;
            cbVacunas.Location = new System.Drawing.Point(31, 78);
            cbVacunas.Name = "cbVacunas";
            cbVacunas.Size = new System.Drawing.Size(380, 28);
            cbVacunas.TabIndex = 5;
            cbVacunas.SelectedIndexChanged += cbVacunas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 20);
            label1.TabIndex = 4;
            label1.Text = "Elija el nombre de la Vacuna";
            label1.Click += label1_Click;
            // 
            // frmEliminarVacuna
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 217);
            Controls.Add(button1);
            Controls.Add(cbVacunas);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmEliminarVacuna";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar";
            Load += frmEliminarVacuna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbVacunas;
        private System.Windows.Forms.Label label1;
    }
}