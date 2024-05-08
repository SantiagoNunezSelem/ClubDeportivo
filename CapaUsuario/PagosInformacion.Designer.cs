namespace CapaUsuario
{
    partial class PagosInformacion
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
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buscarDni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDniBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEstadoCuotaSocial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectTipoPago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.listBoxPagos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelApellido.Location = new System.Drawing.Point(117, 249);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(0, 17);
            this.labelApellido.TabIndex = 92;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombre.Location = new System.Drawing.Point(117, 179);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 17);
            this.labelNombre.TabIndex = 91;
            // 
            // buscarDni
            // 
            this.buscarDni.Location = new System.Drawing.Point(226, 107);
            this.buscarDni.Name = "buscarDni";
            this.buscarDni.Size = new System.Drawing.Size(75, 23);
            this.buscarDni.TabIndex = 90;
            this.buscarDni.Text = "Buscar";
            this.buscarDni.UseVisualStyleBackColor = true;
            this.buscarDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buscarDni_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(51, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(53, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(79, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "DNI:";
            // 
            // inputDniBuscar
            // 
            this.inputDniBuscar.AccessibleDescription = "";
            this.inputDniBuscar.AccessibleName = "";
            this.inputDniBuscar.AllowPromptAsInput = false;
            this.inputDniBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.inputDniBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDniBuscar.CausesValidation = false;
            this.inputDniBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputDniBuscar.ForeColor = System.Drawing.Color.Black;
            this.inputDniBuscar.Location = new System.Drawing.Point(120, 109);
            this.inputDniBuscar.Mask = "99999999";
            this.inputDniBuscar.Name = "inputDniBuscar";
            this.inputDniBuscar.RejectInputOnFirstFailure = true;
            this.inputDniBuscar.ResetOnPrompt = false;
            this.inputDniBuscar.ResetOnSpace = false;
            this.inputDniBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputDniBuscar.ShortcutsEnabled = false;
            this.inputDniBuscar.Size = new System.Drawing.Size(100, 16);
            this.inputDniBuscar.SkipLiterals = false;
            this.inputDniBuscar.TabIndex = 83;
            this.inputDniBuscar.Tag = "";
            this.inputDniBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputDniBuscar.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Informacion de Pagos";
            // 
            // labelEstadoCuotaSocial
            // 
            this.labelEstadoCuotaSocial.AutoSize = true;
            this.labelEstadoCuotaSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstadoCuotaSocial.Location = new System.Drawing.Point(112, 314);
            this.labelEstadoCuotaSocial.Name = "labelEstadoCuotaSocial";
            this.labelEstadoCuotaSocial.Size = new System.Drawing.Size(0, 17);
            this.labelEstadoCuotaSocial.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(32, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Membresía:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(110, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 11);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(115, 269);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 11);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(117, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(118, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // selectTipoPago
            // 
            this.selectTipoPago.FormattingEnabled = true;
            this.selectTipoPago.Items.AddRange(new object[] {
            "Pagos de Cuota Social",
            "Pagos de Actividad Deportiva"});
            this.selectTipoPago.Location = new System.Drawing.Point(595, 116);
            this.selectTipoPago.Name = "selectTipoPago";
            this.selectTipoPago.Size = new System.Drawing.Size(118, 21);
            this.selectTipoPago.TabIndex = 98;
            this.selectTipoPago.TextChanged += new System.EventHandler(this.selectTipoPago_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(414, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 17);
            this.label13.TabIndex = 97;
            this.label13.Text = "Seleccionar Tipo de Pago:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox7.Location = new System.Drawing.Point(595, 137);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(118, 15);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 96;
            this.pictureBox7.TabStop = false;
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.Location = new System.Drawing.Point(417, 179);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(296, 160);
            this.listBoxPagos.TabIndex = 99;
            // 
            // PagosInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPagos);
            this.Controls.Add(this.selectTipoPago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.labelEstadoCuotaSocial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buscarDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.inputDniBuscar);
            this.Controls.Add(this.label1);
            this.Name = "PagosInformacion";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.inputDniBuscar, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.buscarDni, 0);
            this.Controls.SetChildIndex(this.labelNombre, 0);
            this.Controls.SetChildIndex(this.labelApellido, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.labelEstadoCuotaSocial, 0);
            this.Controls.SetChildIndex(this.pictureBox7, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.selectTipoPago, 0);
            this.Controls.SetChildIndex(this.listBoxPagos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buscarDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox inputDniBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEstadoCuotaSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox selectTipoPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ListBox listBoxPagos;
    }
}
