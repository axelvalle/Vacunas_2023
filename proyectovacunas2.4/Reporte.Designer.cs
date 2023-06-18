namespace proyectovacunas2._4
{
    partial class Reporte
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
            registro = new System.Windows.Forms.DataGridView();
            Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnlimpiar = new System.Windows.Forms.Button();
            btnmostrar = new System.Windows.Forms.Button();
            btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)registro).BeginInit();
            SuspendLayout();
            // 
            // registro
            // 
            registro.AllowUserToAddRows = false;
            registro.BackgroundColor = System.Drawing.Color.White;
            registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Tip, rango, sector, fecha });
            registro.Location = new System.Drawing.Point(302, 215);
            registro.Name = "registro";
            registro.RowHeadersWidth = 51;
            registro.RowTemplate.Height = 29;
            registro.Size = new System.Drawing.Size(554, 188);
            registro.TabIndex = 0;
            // 
            // Tip
            // 
            Tip.HeaderText = "Tipo de Vacuna";
            Tip.MinimumWidth = 6;
            Tip.Name = "Tip";
            Tip.Width = 125;
            // 
            // rango
            // 
            rango.HeaderText = "Rango de Edades";
            rango.MinimumWidth = 6;
            rango.Name = "rango";
            rango.Width = 125;
            // 
            // sector
            // 
            sector.HeaderText = "Sector de la población";
            sector.MinimumWidth = 6;
            sector.Name = "sector";
            sector.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = System.Drawing.Color.SteelBlue;
            btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnlimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            btnlimpiar.Location = new System.Drawing.Point(600, 434);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(157, 61);
            btnlimpiar.TabIndex = 10;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.BackColor = System.Drawing.Color.SteelBlue;
            btnmostrar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnmostrar.ForeColor = System.Drawing.Color.AliceBlue;
            btnmostrar.Location = new System.Drawing.Point(375, 434);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new System.Drawing.Size(157, 61);
            btnmostrar.TabIndex = 11;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = false;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnvolver
            // 
            btnvolver.BackColor = System.Drawing.Color.SteelBlue;
            btnvolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnvolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnvolver.Location = new System.Drawing.Point(496, 553);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new System.Drawing.Size(157, 61);
            btnvolver.TabIndex = 12;
            btnvolver.Text = "Regresar";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnvolver_Click;
            // 
            // Reporte
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen__20_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1130, 670);
            Controls.Add(btnvolver);
            Controls.Add(btnmostrar);
            Controls.Add(btnlimpiar);
            Controls.Add(registro);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Reporte";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Reporte";
            Load += Reporte_Load;
            ((System.ComponentModel.ISupportInitialize)registro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn rango;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnvolver;
    }
}