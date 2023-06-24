namespace Reg_vacuna
{
    partial class frmRegVac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegVac));
            txtEfectos = new System.Windows.Forms.TextBox();
            txtFechaVencimiento = new System.Windows.Forms.TextBox();
            txtDosis = new System.Windows.Forms.TextBox();
            txtTipo = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            efectos = new System.Windows.Forms.Label();
            txfechadeven = new System.Windows.Forms.Label();
            txdosis = new System.Windows.Forms.Label();
            txtipo = new System.Windows.Forms.Label();
            txnombre = new System.Windows.Forms.Label();
            Tabla = new System.Windows.Forms.DataGridView();
            Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha_de_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Efect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnVolver = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btneliminar = new System.Windows.Forms.Button();
            btnMostrar = new System.Windows.Forms.Button();
            btnlimpiar = new System.Windows.Forms.Button();
            Añadir = new System.Windows.Forms.Button();
            txtInfo = new System.Windows.Forms.TextBox();
            txifo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEfectos
            // 
            txtEfectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEfectos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtEfectos.ForeColor = System.Drawing.Color.Black;
            txtEfectos.Location = new System.Drawing.Point(869, 224);
            txtEfectos.Name = "txtEfectos";
            txtEfectos.Size = new System.Drawing.Size(214, 29);
            txtEfectos.TabIndex = 13;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFechaVencimiento.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtFechaVencimiento.ForeColor = System.Drawing.Color.Black;
            txtFechaVencimiento.Location = new System.Drawing.Point(869, 274);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new System.Drawing.Size(216, 29);
            txtFechaVencimiento.TabIndex = 11;
            txtFechaVencimiento.TextChanged += textBox5_TextChanged;
            // 
            // txtDosis
            // 
            txtDosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDosis.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtDosis.ForeColor = System.Drawing.Color.Black;
            txtDosis.Location = new System.Drawing.Point(345, 221);
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new System.Drawing.Size(214, 29);
            txtDosis.TabIndex = 10;
            // 
            // txtTipo
            // 
            txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTipo.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTipo.ForeColor = System.Drawing.Color.Black;
            txtTipo.Location = new System.Drawing.Point(343, 271);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new System.Drawing.Size(216, 29);
            txtTipo.TabIndex = 9;
            txtTipo.TextChanged += textBox3_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNombre.ForeColor = System.Drawing.Color.Black;
            txtNombre.Location = new System.Drawing.Point(343, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(216, 29);
            txtNombre.TabIndex = 7;
            // 
            // efectos
            // 
            efectos.AutoSize = true;
            efectos.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            efectos.ForeColor = System.Drawing.Color.Black;
            efectos.Location = new System.Drawing.Point(627, 221);
            efectos.Name = "efectos";
            efectos.Size = new System.Drawing.Size(69, 21);
            efectos.TabIndex = 6;
            efectos.Text = "Efectos";
            // 
            // txfechadeven
            // 
            txfechadeven.AutoSize = true;
            txfechadeven.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txfechadeven.ForeColor = System.Drawing.Color.Black;
            txfechadeven.Location = new System.Drawing.Point(627, 274);
            txfechadeven.Name = "txfechadeven";
            txfechadeven.Size = new System.Drawing.Size(190, 21);
            txfechadeven.TabIndex = 3;
            txfechadeven.Text = "Fecha de Vencimiento";
            // 
            // txdosis
            // 
            txdosis.AutoSize = true;
            txdosis.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txdosis.ForeColor = System.Drawing.Color.Black;
            txdosis.Location = new System.Drawing.Point(265, 224);
            txdosis.Name = "txdosis";
            txdosis.Size = new System.Drawing.Size(56, 21);
            txdosis.TabIndex = 2;
            txdosis.Text = "Dosis";
            // 
            // txtipo
            // 
            txtipo.AutoSize = true;
            txtipo.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtipo.ForeColor = System.Drawing.Color.Black;
            txtipo.Location = new System.Drawing.Point(265, 274);
            txtipo.Name = "txtipo";
            txtipo.Size = new System.Drawing.Size(49, 21);
            txtipo.TabIndex = 1;
            txtipo.Text = "Tipo";
            // 
            // txnombre
            // 
            txnombre.AutoSize = true;
            txnombre.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txnombre.ForeColor = System.Drawing.Color.Black;
            txnombre.Location = new System.Drawing.Point(261, 172);
            txnombre.Name = "txnombre";
            txnombre.Size = new System.Drawing.Size(76, 21);
            txnombre.TabIndex = 0;
            txnombre.Text = "Nombre";
            txnombre.Click += label2_Click;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.BackgroundColor = System.Drawing.Color.Turquoise;
            Tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nom, tipo, Dosis, Fecha_de_Vencimiento, Efect, Column1 });
            Tabla.Location = new System.Drawing.Point(248, 405);
            Tabla.Name = "Tabla";
            Tabla.RowHeadersWidth = 51;
            Tabla.RowTemplate.Height = 29;
            Tabla.Size = new System.Drawing.Size(878, 126);
            Tabla.TabIndex = 3;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nombre";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.Width = 200;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // Dosis
            // 
            Dosis.HeaderText = "Dosis";
            Dosis.MinimumWidth = 6;
            Dosis.Name = "Dosis";
            Dosis.Width = 125;
            // 
            // Fecha_de_Vencimiento
            // 
            Fecha_de_Vencimiento.HeaderText = "Fecha de Vencimiento";
            Fecha_de_Vencimiento.MinimumWidth = 6;
            Fecha_de_Vencimiento.Name = "Fecha_de_Vencimiento";
            Fecha_de_Vencimiento.Width = 250;
            // 
            // Efect
            // 
            Efect.HeaderText = "Efectos";
            Efect.MinimumWidth = 6;
            Efect.Name = "Efect";
            Efect.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Informacion de la Vacuna";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            btnVolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(31, 619);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(173, 61);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btneliminar);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(btnlimpiar);
            panel1.Controls.Add(Añadir);
            panel1.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(265, 616);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(864, 54);
            panel1.TabIndex = 15;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = System.Drawing.Color.SteelBlue;
            btneliminar.Location = new System.Drawing.Point(9, 2);
            btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new System.Drawing.Size(181, 44);
            btneliminar.TabIndex = 3;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = System.Drawing.Color.SteelBlue;
            btnMostrar.Location = new System.Drawing.Point(230, 4);
            btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(181, 44);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = System.Drawing.Color.SteelBlue;
            btnlimpiar.Location = new System.Drawing.Point(680, 2);
            btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(181, 46);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.SteelBlue;
            Añadir.Location = new System.Drawing.Point(460, 3);
            Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(181, 46);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += Añadir_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtInfo.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtInfo.ForeColor = System.Drawing.Color.Black;
            txtInfo.Location = new System.Drawing.Point(869, 173);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new System.Drawing.Size(216, 29);
            txtInfo.TabIndex = 8;
            // 
            // txifo
            // 
            txifo.AutoSize = true;
            txifo.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txifo.ForeColor = System.Drawing.Color.Black;
            txifo.Location = new System.Drawing.Point(627, 173);
            txifo.Name = "txifo";
            txifo.Size = new System.Drawing.Size(218, 21);
            txifo.TabIndex = 4;
            txifo.Text = "Información de la vacuna";
            txifo.Click += txifo_Click;
            // 
            // frmRegVac
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__10_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1223, 682);
            Controls.Add(panel1);
            Controls.Add(txtEfectos);
            Controls.Add(btnVolver);
            Controls.Add(Tabla);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtDosis);
            Controls.Add(txtipo);
            Controls.Add(txtTipo);
            Controls.Add(txnombre);
            Controls.Add(txtInfo);
            Controls.Add(txdosis);
            Controls.Add(txtNombre);
            Controls.Add(txfechadeven);
            Controls.Add(efectos);
            Controls.Add(txifo);
            DoubleBuffered = true;
            ForeColor = System.Drawing.Color.Red;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRegVac";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro de Vacunas";
            Load += frmRegVac_Load;
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtEfectos;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label efectos;
        private System.Windows.Forms.Label txfechadeven;
        private System.Windows.Forms.Label txdosis;
        private System.Windows.Forms.Label txtipo;
        private System.Windows.Forms.Label txnombre;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label txifo;
    }
}
