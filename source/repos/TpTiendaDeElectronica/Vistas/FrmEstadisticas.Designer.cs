namespace Vistas
{
    partial class FrmEstadisticas
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
            this.txt_CantidadVentas = new System.Windows.Forms.TextBox();
            this.lbl_CantidadVentas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_CantidadVentas
            // 
            this.txt_CantidadVentas.Location = new System.Drawing.Point(68, 50);
            this.txt_CantidadVentas.Name = "txt_CantidadVentas";
            this.txt_CantidadVentas.Size = new System.Drawing.Size(108, 23);
            this.txt_CantidadVentas.TabIndex = 0;
            // 
            // lbl_CantidadVentas
            // 
            this.lbl_CantidadVentas.AutoSize = true;
            this.lbl_CantidadVentas.Location = new System.Drawing.Point(68, 19);
            this.lbl_CantidadVentas.Name = "lbl_CantidadVentas";
            this.lbl_CantidadVentas.Size = new System.Drawing.Size(108, 15);
            this.lbl_CantidadVentas.TabIndex = 1;
            this.lbl_CantidadVentas.Text = "Cantidad de Ventas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_CantidadVentas);
            this.Controls.Add(this.txt_CantidadVentas);
            this.Name = "FrmEstadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CantidadVentas;
        private System.Windows.Forms.Label lbl_CantidadVentas;
        private System.Windows.Forms.Button button1;
    }
}