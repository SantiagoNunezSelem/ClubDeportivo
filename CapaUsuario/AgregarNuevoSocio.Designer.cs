namespace CapaUsuario
{
    partial class AgregarNuevoSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.inputDni = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputApellido = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputTelefono = new System.Windows.Forms.MaskedTextBox();
            this.buscarDni = new System.Windows.Forms.Button();
            this.registrarUsuario = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar un nuevo Socio";
            // 
            // inputDni
            // 
            this.inputDni.AccessibleDescription = "";
            this.inputDni.AccessibleName = "";
            this.inputDni.AllowPromptAsInput = false;
            this.inputDni.BackColor = System.Drawing.SystemColors.Control;
            this.inputDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDni.CausesValidation = false;
            this.inputDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputDni.ForeColor = System.Drawing.Color.Black;
            this.inputDni.Location = new System.Drawing.Point(122, 112);
            this.inputDni.Mask = "99999999";
            this.inputDni.Name = "inputDni";
            this.inputDni.RejectInputOnFirstFailure = true;
            this.inputDni.ResetOnPrompt = false;
            this.inputDni.ResetOnSpace = false;
            this.inputDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputDni.ShortcutsEnabled = false;
            this.inputDni.Size = new System.Drawing.Size(100, 16);
            this.inputDni.SkipLiterals = false;
            this.inputDni.TabIndex = 5;
            this.inputDni.Tag = "";
            this.inputDni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputDni.ValidatingType = typeof(int);
            this.inputDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaskedTextBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(81, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(55, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // inputNombre
            // 
            this.inputNombre.AccessibleDescription = "";
            this.inputNombre.AccessibleName = "";
            this.inputNombre.AllowPromptAsInput = false;
            this.inputNombre.BackColor = System.Drawing.SystemColors.Control;
            this.inputNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNombre.CausesValidation = false;
            this.inputNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputNombre.ForeColor = System.Drawing.Color.Black;
            this.inputNombre.Location = new System.Drawing.Point(121, 185);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.RejectInputOnFirstFailure = true;
            this.inputNombre.ResetOnPrompt = false;
            this.inputNombre.ResetOnSpace = false;
            this.inputNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputNombre.ShortcutsEnabled = false;
            this.inputNombre.Size = new System.Drawing.Size(100, 16);
            this.inputNombre.SkipLiterals = false;
            this.inputNombre.TabIndex = 8;
            this.inputNombre.Tag = "";
            this.inputNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox2_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(53, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido:";
            // 
            // inputApellido
            // 
            this.inputApellido.AccessibleDescription = "";
            this.inputApellido.AccessibleName = "";
            this.inputApellido.AllowPromptAsInput = false;
            this.inputApellido.BackColor = System.Drawing.SystemColors.Control;
            this.inputApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputApellido.CausesValidation = false;
            this.inputApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputApellido.ForeColor = System.Drawing.Color.Black;
            this.inputApellido.Location = new System.Drawing.Point(119, 255);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.RejectInputOnFirstFailure = true;
            this.inputApellido.ResetOnPrompt = false;
            this.inputApellido.ResetOnSpace = false;
            this.inputApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputApellido.ShortcutsEnabled = false;
            this.inputApellido.Size = new System.Drawing.Size(100, 16);
            this.inputApellido.SkipLiterals = false;
            this.inputApellido.TabIndex = 11;
            this.inputApellido.Tag = "";
            this.inputApellido.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputApellido.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputApellido_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(32, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nacimiento:";
            // 
            // inputFechaNacimiento
            // 
            this.inputFechaNacimiento.AccessibleDescription = "";
            this.inputFechaNacimiento.AccessibleName = "";
            this.inputFechaNacimiento.AllowPromptAsInput = false;
            this.inputFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.inputFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFechaNacimiento.CausesValidation = false;
            this.inputFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.inputFechaNacimiento.Location = new System.Drawing.Point(117, 333);
            this.inputFechaNacimiento.Mask = "00/00/0000";
            this.inputFechaNacimiento.Name = "inputFechaNacimiento";
            this.inputFechaNacimiento.RejectInputOnFirstFailure = true;
            this.inputFechaNacimiento.ResetOnPrompt = false;
            this.inputFechaNacimiento.ResetOnSpace = false;
            this.inputFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputFechaNacimiento.ShortcutsEnabled = false;
            this.inputFechaNacimiento.Size = new System.Drawing.Size(100, 16);
            this.inputFechaNacimiento.SkipLiterals = false;
            this.inputFechaNacimiento.TabIndex = 14;
            this.inputFechaNacimiento.Tag = "";
            this.inputFechaNacimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputFechaNacimiento.ValidatingType = typeof(System.DateTime);
            this.inputFechaNacimiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputFechaNacimiento_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(34, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(384, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email:";
            // 
            // inputEmail
            // 
            this.inputEmail.AccessibleDescription = "";
            this.inputEmail.AccessibleName = "";
            this.inputEmail.AllowPromptAsInput = false;
            this.inputEmail.BackColor = System.Drawing.SystemColors.Control;
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputEmail.CausesValidation = false;
            this.inputEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputEmail.ForeColor = System.Drawing.Color.Black;
            this.inputEmail.Location = new System.Drawing.Point(440, 247);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.RejectInputOnFirstFailure = true;
            this.inputEmail.ResetOnPrompt = false;
            this.inputEmail.ResetOnSpace = false;
            this.inputEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputEmail.ShortcutsEnabled = false;
            this.inputEmail.Size = new System.Drawing.Size(100, 16);
            this.inputEmail.SkipLiterals = false;
            this.inputEmail.TabIndex = 21;
            this.inputEmail.Tag = "";
            this.inputEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputEmail_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(368, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Teléfono:";
            // 
            // inputTelefono
            // 
            this.inputTelefono.AccessibleDescription = "";
            this.inputTelefono.AccessibleName = "";
            this.inputTelefono.AllowPromptAsInput = false;
            this.inputTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.inputTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTelefono.CausesValidation = false;
            this.inputTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inputTelefono.ForeColor = System.Drawing.Color.Black;
            this.inputTelefono.Location = new System.Drawing.Point(442, 185);
            this.inputTelefono.Mask = "0000-0000";
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.RejectInputOnFirstFailure = true;
            this.inputTelefono.ResetOnPrompt = false;
            this.inputTelefono.ResetOnSpace = false;
            this.inputTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputTelefono.ShortcutsEnabled = false;
            this.inputTelefono.Size = new System.Drawing.Size(100, 16);
            this.inputTelefono.SkipLiterals = false;
            this.inputTelefono.TabIndex = 18;
            this.inputTelefono.Tag = "";
            this.inputTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputTelefono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputTelefono_MouseClick);
            // 
            // buscarDni
            // 
            this.buscarDni.Location = new System.Drawing.Point(228, 110);
            this.buscarDni.Name = "buscarDni";
            this.buscarDni.Size = new System.Drawing.Size(75, 23);
            this.buscarDni.TabIndex = 24;
            this.buscarDni.Text = "Buscar";
            this.buscarDni.UseVisualStyleBackColor = true;
            // 
            // registrarUsuario
            // 
            this.registrarUsuario.Location = new System.Drawing.Point(438, 298);
            this.registrarUsuario.Name = "registrarUsuario";
            this.registrarUsuario.Size = new System.Drawing.Size(96, 23);
            this.registrarUsuario.TabIndex = 25;
            this.registrarUsuario.Text = "Registrar";
            this.registrarUsuario.UseVisualStyleBackColor = true;
            this.registrarUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registrarUsuario_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox5.Location = new System.Drawing.Point(438, 264);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 11);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox6.Location = new System.Drawing.Point(440, 202);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(96, 11);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(115, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 11);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(117, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 11);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(119, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 11);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(120, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 11);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // AgregarNuevoSocio
            // 
            this.AccessibleName = "AgregarNuevoSocio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarUsuario);
            this.Controls.Add(this.buscarDni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.inputTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.inputFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.inputApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.inputDni);
            this.Controls.Add(this.label1);
            this.Name = "AgregarNuevoSocio";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.inputDni, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.inputNombre, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.inputApellido, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.inputFechaNacimiento, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.inputTelefono, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.inputEmail, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.buscarDni, 0);
            this.Controls.SetChildIndex(this.registrarUsuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox inputDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox inputNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox inputApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MaskedTextBox inputFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MaskedTextBox inputEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MaskedTextBox inputTelefono;
        private System.Windows.Forms.Button buscarDni;
        private System.Windows.Forms.Button registrarUsuario;
    }
}
