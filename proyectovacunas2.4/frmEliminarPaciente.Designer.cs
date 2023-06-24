namespace proyectovacunas2._4
{
    partial class frmEliminarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarPaciente));
            button1 = new System.Windows.Forms.Button();
            cbPacientes = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(146, 150);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 29);
            button1.TabIndex = 9;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbPacientes
            // 
            cbPacientes.FormattingEnabled = true;
            cbPacientes.Location = new System.Drawing.Point(31, 78);
            cbPacientes.Name = "cbPacientes";
            cbPacientes.Size = new System.Drawing.Size(380, 28);
            cbPacientes.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(193, 20);
            label1.TabIndex = 7;
            label1.Text = "Elija el nombre del Paciente\r\n";
            // 
            // frmEliminarPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 217);
            Controls.Add(button1);
            Controls.Add(cbPacientes);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmEliminarPaciente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar";
            Load += frmEliminarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label1;
    }
}