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
            this.cmb_Categorias = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PrecioMaximo = new System.Windows.Forms.TextBox();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.dtgv_CarroDeCompras = new System.Windows.Forms.DataGridView();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_ProductosSeleccionados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaPorductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CarroDeCompras)).BeginInit();
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
            this.txt_Dni.Location = new System.Drawing.Point(427, 157);
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
            this.textBox2.Location = new System.Drawing.Point(645, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "011 -0000000";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 10;
            // 
            // dtgvListaPorductos
            // 
            this.dtgvListaPorductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaPorductos.Location = new System.Drawing.Point(26, 372);
            this.dtgvListaPorductos.Name = "dtgvListaPorductos";
            this.dtgvListaPorductos.RowTemplate.Height = 25;
            this.dtgvListaPorductos.Size = new System.Drawing.Size(395, 190);
            this.dtgvListaPorductos.TabIndex = 11;
            this.dtgvListaPorductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListaPorductos_CellClick);
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
            // cmb_Categorias
            // 
            this.cmb_Categorias.FormattingEnabled = true;
            this.cmb_Categorias.Items.AddRange(new object[] {
            "Mother",
            "Microprocesador",
            "Perisfericos",
            "Gabinete",
            "Monitor"});
            this.cmb_Categorias.Location = new System.Drawing.Point(108, 209);
            this.cmb_Categorias.Name = "cmb_Categorias";
            this.cmb_Categorias.Size = new System.Drawing.Size(121, 25);
            this.cmb_Categorias.TabIndex = 12;
            this.cmb_Categorias.SelectedIndexChanged += new System.EventHandler(this.cmb_Categorias_SelectedIndexChanged);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(26, 212);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(76, 17);
            this.lbl_Categoria.TabIndex = 13;
            this.lbl_Categoria.Text = "Categoria :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio Maximo :";
            // 
            // txt_PrecioMaximo
            // 
            this.txt_PrecioMaximo.Location = new System.Drawing.Point(163, 302);
            this.txt_PrecioMaximo.Name = "txt_PrecioMaximo";
            this.txt_PrecioMaximo.PlaceholderText = "0.00";
            this.txt_PrecioMaximo.Size = new System.Drawing.Size(66, 25);
            this.txt_PrecioMaximo.TabIndex = 15;
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(26, 265);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(72, 17);
            this.lbl_NombreProducto.TabIndex = 16;
            this.lbl_NombreProducto.Text = "Nombre : ";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(108, 257);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(121, 25);
            this.txt_NombreProducto.TabIndex = 17;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(26, 594);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(121, 32);
            this.btn_Agregar.TabIndex = 18;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(645, 593);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(121, 33);
            this.btn_Borrar.TabIndex = 19;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // dtgv_CarroDeCompras
            // 
            this.dtgv_CarroDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CarroDeCompras.Location = new System.Drawing.Point(645, 372);
            this.dtgv_CarroDeCompras.Name = "dtgv_CarroDeCompras";
            this.dtgv_CarroDeCompras.RowTemplate.Height = 25;
            this.dtgv_CarroDeCompras.Size = new System.Drawing.Size(386, 190);
            this.dtgv_CarroDeCompras.TabIndex = 20;
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Location = new System.Drawing.Point(26, 348);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(84, 17);
            this.lbl_Productos.TabIndex = 21;
            this.lbl_Productos.Text = "Productos : ";
            // 
            // lbl_ProductosSeleccionados
            // 
            this.lbl_ProductosSeleccionados.AutoSize = true;
            this.lbl_ProductosSeleccionados.Location = new System.Drawing.Point(647, 345);
            this.lbl_ProductosSeleccionados.Name = "lbl_ProductosSeleccionados";
            this.lbl_ProductosSeleccionados.Size = new System.Drawing.Size(176, 17);
            this.lbl_ProductosSeleccionados.TabIndex = 22;
            this.lbl_ProductosSeleccionados.Text = "Producctos Seleccionados :";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1177, 657);
            this.Controls.Add(this.lbl_ProductosSeleccionados);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.dtgv_CarroDeCompras);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.lbl_NombreProducto);
            this.Controls.Add(this.txt_PrecioMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.cmb_Categorias);
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
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaPorductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CarroDeCompras)).EndInit();
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
        private System.Windows.Forms.ComboBox cmb_Categorias;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PrecioMaximo;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.DataGridView dtgv_CarroDeCompras;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_ProductosSeleccionados;
    }
}