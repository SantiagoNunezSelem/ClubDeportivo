namespace CapaUsuario
{
    partial class DarBajaSocio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBuscarDni
            // 
            this.InputBuscarDni.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.InputBuscarDni.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.InputBuscarDni_MaskInputRejected);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(588, 354);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(183, 28);
            this.botonEliminar.TabIndex = 35;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botonEliminar_MouseClick);
            // 
            // DarBajaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.botonEliminar);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DarBajaSocio";
            this.Controls.SetChildIndex(this.InputBuscarDni, 0);
            this.Controls.SetChildIndex(this.botonEliminar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
    }
}
