namespace proyectovacunas2._4
{
    partial class frmEliminarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarEmpleado));
            label1 = new System.Windows.Forms.Label();
            cbEmpleado = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Elija el nombre del Empleado";
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new System.Drawing.Point(12, 80);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new System.Drawing.Size(380, 28);
            cbEmpleado.TabIndex = 2;
            cbEmpleado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(127, 152);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(145, 29);
            button1.TabIndex = 3;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEliminarEmpleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 217);
            Controls.Add(button1);
            Controls.Add(cbEmpleado);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmEliminarEmpleado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Eliminar";
            Load += frmEliminarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Button button1;
    }
}