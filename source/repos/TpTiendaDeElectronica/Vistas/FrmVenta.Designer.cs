namespace Vistas
{
    partial class FrmVenta
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
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtgvListaPorductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaPorductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_NombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(143, 24);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(123, 19);
            this.lbl_NombreEmpresa.TabIndex = 0;
            this.lbl_NombreEmpresa.Text = "PC Electronic S.RL";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Direccion.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Direccion.Location = new System.Drawing.Point(143, 58);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(184, 30);
            this.lbl_Direccion.TabIndex = 1;
            this.lbl_Direccion.Text = "Venta de Productos";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(26, 113);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(51, 17);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "Fecha :";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(98, 110);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(100, 25);
            this.txt_Fecha.TabIndex = 3;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(26, 156);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(59, 17);
            this.lbl_Cliente.TabIndex = 4;
            this.lbl_Cliente.Text = "Cliente :";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(98, 157);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.PlaceholderText = "Nombre";
            this.txt_NombreCliente.Size = new System.Drawing.Size(100, 25);
            this.txt_NombreCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dni :";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(439, 157);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "0.000.000";
            this.txt_Dni.Size = new System.Drawing.Size(84, 25);
            this.txt_Dni.TabIndex = 7;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(237, 157);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 25);
            this.txt_Apellido.TabIndex = 8;
            // 
            // lbl_TelefonoCliente
            // 
            this.lbl_TelefonoCliente.AutoSize = true;
            this.lbl_TelefonoCliente.Location = new System.Drawing.Point(567, 160);
            this.lbl_TelefonoCliente.Name = "lbl_TelefonoCliente";
            this.lbl_TelefonoCliente.Size = new System.Drawing.Size(72, 17);
            this.lbl_TelefonoCliente.TabIndex = 9;
            this.lbl_TelefonoCliente.Text = "Telefono :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(661, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "011 -0000000";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 10;
            // 
            // dtgvListaPorductos
            // 
            this.dtgvListaPorductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaPorductos.Location = new System.Drawing.Point(39, 286);
            this.dtgvListaPorductos.Name = "dtgvListaPorductos";
            this.dtgvListaPorductos.RowTemplate.Height = 25;
            this.dtgvListaPorductos.Size = new System.Drawing.Size(376, 159);
            this.dtgvListaPorductos.TabIndex = 11;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.dtgvListaPorductos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_TelefonoCliente);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_NombreEmpresa);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmVenta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaPorductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreEmpresa;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_TelefonoCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dtgvListaPorductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
    }
}