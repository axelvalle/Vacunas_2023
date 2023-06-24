namespace Empleados
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            lblnombre = new System.Windows.Forms.Label();
            lbledad = new System.Windows.Forms.Label();
            lbldept = new System.Windows.Forms.Label();
            lbldir = new System.Windows.Forms.Label();
            lblcargo = new System.Windows.Forms.Label();
            btneliminar = new System.Windows.Forms.Button();
            btnlimpiar = new System.Windows.Forms.Button();
            btnMostrar = new System.Windows.Forms.Button();
            Añadir = new System.Windows.Forms.Button();
            txtCargo = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtDepartamento = new System.Windows.Forms.TextBox();
            txtEdad = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            btnVolver = new System.Windows.Forms.Button();
            tabla = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Departmamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = System.Drawing.Color.Transparent;
            lblnombre.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblnombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblnombre.Location = new System.Drawing.Point(204, 158);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new System.Drawing.Size(86, 22);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.BackColor = System.Drawing.Color.Transparent;
            lbledad.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbledad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbledad.Location = new System.Drawing.Point(204, 198);
            lbledad.Name = "lbledad";
            lbledad.Size = new System.Drawing.Size(54, 22);
            lbledad.TabIndex = 2;
            lbledad.Text = "Edad";
            lbledad.Click += label2_Click;
            // 
            // lbldept
            // 
            lbldept.AutoSize = true;
            lbldept.BackColor = System.Drawing.Color.Transparent;
            lbldept.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbldept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbldept.Location = new System.Drawing.Point(590, 158);
            lbldept.Name = "lbldept";
            lbldept.Size = new System.Drawing.Size(142, 22);
            lbldept.TabIndex = 3;
            lbldept.Text = "Departamento";
            // 
            // lbldir
            // 
            lbldir.AutoSize = true;
            lbldir.BackColor = System.Drawing.Color.Transparent;
            lbldir.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbldir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lbldir.Location = new System.Drawing.Point(590, 198);
            lbldir.Name = "lbldir";
            lbldir.Size = new System.Drawing.Size(101, 22);
            lbldir.TabIndex = 4;
            lbldir.Text = "Dirección";
            // 
            // lblcargo
            // 
            lblcargo.AutoSize = true;
            lblcargo.BackColor = System.Drawing.Color.Transparent;
            lblcargo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblcargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblcargo.Location = new System.Drawing.Point(204, 238);
            lblcargo.Name = "lblcargo";
            lblcargo.Size = new System.Drawing.Size(67, 22);
            lblcargo.TabIndex = 5;
            lblcargo.Text = "Cargo";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            btneliminar.Location = new System.Drawing.Point(-16, 2);
            btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new System.Drawing.Size(181, 44);
            btneliminar.TabIndex = 3;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += button4_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            btnlimpiar.Location = new System.Drawing.Point(570, 2);
            btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(181, 46);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += button3_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = System.Drawing.Color.LightSeaGreen;
            btnMostrar.Location = new System.Drawing.Point(196, 3);
            btnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(181, 44);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += button2_Click;
            // 
            // Añadir
            // 
            Añadir.BackColor = System.Drawing.Color.LightSeaGreen;
            Añadir.Location = new System.Drawing.Point(383, 2);
            Añadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Añadir.Name = "Añadir";
            Añadir.Size = new System.Drawing.Size(181, 46);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = false;
            Añadir.Click += button1_Click;
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtCargo.Location = new System.Drawing.Point(361, 242);
            txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new System.Drawing.Size(195, 27);
            txtCargo.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDireccion.Location = new System.Drawing.Point(747, 198);
            txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(195, 27);
            txtDireccion.TabIndex = 10;
            txtDireccion.TextChanged += textBox4_TextChanged;
            // 
            // txtDepartamento
            // 
            txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDepartamento.Location = new System.Drawing.Point(747, 158);
            txtDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new System.Drawing.Size(195, 27);
            txtDepartamento.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEdad.Location = new System.Drawing.Point(361, 198);
            txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new System.Drawing.Size(195, 27);
            txtEdad.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNombre.Location = new System.Drawing.Point(361, 158);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(195, 27);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.SteelBlue;
            btnVolver.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.Color.AliceBlue;
            btnVolver.Location = new System.Drawing.Point(27, 592);
            btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(157, 61);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Regresar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.BackgroundColor = System.Drawing.Color.White;
            tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Edad, Departmamento, Direccion, Cargo });
            tabla.Location = new System.Drawing.Point(190, 364);
            tabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabla.Name = "tabla";
            tabla.RowHeadersWidth = 51;
            tabla.RowTemplate.Height = 29;
            tabla.Size = new System.Drawing.Size(854, 105);
            tabla.TabIndex = 8;
            tabla.CellContentClick += tabla_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.Width = 70;
            // 
            // Departmamento
            // 
            Departmamento.HeaderText = "Departamento";
            Departmamento.MinimumWidth = 6;
            Departmamento.Name = "Departmamento";
            Departmamento.Width = 120;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 170;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 240;
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
            panel1.Location = new System.Drawing.Point(231, 568);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(754, 54);
            panel1.TabIndex = 14;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepPink;
            BackgroundImage = proyectovacunas2._4.Properties.Resources.Imagen__9_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1223, 665);
            Controls.Add(panel1);
            Controls.Add(tabla);
            Controls.Add(txtCargo);
            Controls.Add(btnVolver);
            Controls.Add(txtDireccion);
            Controls.Add(lblnombre);
            Controls.Add(txtDepartamento);
            Controls.Add(lbldir);
            Controls.Add(txtEdad);
            Controls.Add(lbledad);
            Controls.Add(txtNombre);
            Controls.Add(lblcargo);
            Controls.Add(lbldept);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmpleados";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lbldir;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departmamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}
