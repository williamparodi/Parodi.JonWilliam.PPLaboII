namespace Vistas
{
    partial class FrmDetalleCompra
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
            this.lbl_DetallesDeCompra = new System.Windows.Forms.Label();
            this.lbl_ListaProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DetallesDeCompra
            // 
            this.lbl_DetallesDeCompra.AutoSize = true;
            this.lbl_DetallesDeCompra.Location = new System.Drawing.Point(308, 30);
            this.lbl_DetallesDeCompra.Name = "lbl_DetallesDeCompra";
            this.lbl_DetallesDeCompra.Size = new System.Drawing.Size(110, 15);
            this.lbl_DetallesDeCompra.TabIndex = 0;
            this.lbl_DetallesDeCompra.Text = "Detalles de Compra";
            // 
            // lbl_ListaProductos
            // 
            this.lbl_ListaProductos.AutoSize = true;
            this.lbl_ListaProductos.Location = new System.Drawing.Point(307, 95);
            this.lbl_ListaProductos.Name = "lbl_ListaProductos";
            this.lbl_ListaProductos.Size = new System.Drawing.Size(38, 15);
            this.lbl_ListaProductos.TabIndex = 1;
            this.lbl_ListaProductos.Text = "label1";
            // 
            // FrmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ListaProductos);
            this.Controls.Add(this.lbl_DetallesDeCompra);
            this.Name = "FrmDetalleCompra";
            this.Text = "Detalle de Compra";
            this.Load += new System.EventHandler(this.FrmDetalleCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DetallesDeCompra;
        private System.Windows.Forms.Label lbl_ListaProductos;
    }
}