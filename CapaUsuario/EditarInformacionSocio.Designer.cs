﻿namespace CapaUsuario
{
    partial class EditarInformacionSocio
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
            this.registrarUsuario = new System.Windows.Forms.Button();
            this.buscarDni = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.inputEmail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.inputTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.inputFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.inputApellido = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputNombre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InputBuscarDni = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // registrarUsuario
            // 
            this.registrarUsuario.Location = new System.Drawing.Point(599, 394);
            this.registrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.registrarUsuario.Name = "registrarUsuario";
            this.registrarUsuario.Size = new System.Drawing.Size(128, 28);
            this.registrarUsuario.TabIndex = 47;
            this.registrarUsuario.Text = "Guardar";
            this.registrarUsuario.UseVisualStyleBackColor = true;
            this.registrarUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveNewSocio_MouseClick);
            // 
            // buscarDni
            // 
            this.buscarDni.Location = new System.Drawing.Point(320, 158);
            this.buscarDni.Margin = new System.Windows.Forms.Padding(4);
            this.buscarDni.Name = "buscarDni";
            this.buscarDni.Size = new System.Drawing.Size(100, 28);
            this.buscarDni.TabIndex = 46;
            this.buscarDni.Text = "Buscar";
            this.buscarDni.UseVisualStyleBackColor = true;
            this.buscarDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchByDni_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(527, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Email:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox5.Location = new System.Drawing.Point(599, 352);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 14);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
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
            this.inputEmail.Location = new System.Drawing.Point(601, 331);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(4);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.RejectInputOnFirstFailure = true;
            this.inputEmail.ResetOnPrompt = false;
            this.inputEmail.ResetOnSpace = false;
            this.inputEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputEmail.ShortcutsEnabled = false;
            this.inputEmail.Size = new System.Drawing.Size(133, 20);
            this.inputEmail.SkipLiterals = false;
            this.inputEmail.TabIndex = 43;
            this.inputEmail.Tag = "";
            this.inputEmail.Text = "infoemail@gmail.com";
            this.inputEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(505, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Teléfono:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox6.Location = new System.Drawing.Point(601, 276);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 14);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
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
            this.inputTelefono.Location = new System.Drawing.Point(604, 255);
            this.inputTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.inputTelefono.Mask = "0000-0000";
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.RejectInputOnFirstFailure = true;
            this.inputTelefono.ResetOnPrompt = false;
            this.inputTelefono.ResetOnSpace = false;
            this.inputTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputTelefono.ShortcutsEnabled = false;
            this.inputTelefono.Size = new System.Drawing.Size(133, 20);
            this.inputTelefono.SkipLiterals = false;
            this.inputTelefono.TabIndex = 40;
            this.inputTelefono.Tag = "";
            this.inputTelefono.Text = "45672323";
            this.inputTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(60, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(57, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nacimiento:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(168, 452);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 14);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
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
            this.inputFechaNacimiento.Location = new System.Drawing.Point(171, 431);
            this.inputFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.inputFechaNacimiento.Mask = "00/00/0000";
            this.inputFechaNacimiento.Name = "inputFechaNacimiento";
            this.inputFechaNacimiento.RejectInputOnFirstFailure = true;
            this.inputFechaNacimiento.ResetOnPrompt = false;
            this.inputFechaNacimiento.ResetOnSpace = false;
            this.inputFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputFechaNacimiento.ShortcutsEnabled = false;
            this.inputFechaNacimiento.Size = new System.Drawing.Size(133, 20);
            this.inputFechaNacimiento.SkipLiterals = false;
            this.inputFechaNacimiento.TabIndex = 36;
            this.inputFechaNacimiento.Tag = "";
            this.inputFechaNacimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.inputFechaNacimiento.ValidatingType = typeof(System.DateTime);
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(85, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Apellido:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(171, 356);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
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
            this.inputApellido.Location = new System.Drawing.Point(173, 335);
            this.inputApellido.Margin = new System.Windows.Forms.Padding(4);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.RejectInputOnFirstFailure = true;
            this.inputApellido.ResetOnPrompt = false;
            this.inputApellido.ResetOnSpace = false;
            this.inputApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputApellido.ShortcutsEnabled = false;
            this.inputApellido.Size = new System.Drawing.Size(133, 20);
            this.inputApellido.SkipLiterals = false;
            this.inputApellido.TabIndex = 33;
            this.inputApellido.Tag = "";
            this.inputApellido.Text = "InfoApellido";
            this.inputApellido.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(88, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(173, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
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
            this.inputNombre.Location = new System.Drawing.Point(176, 249);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(4);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.RejectInputOnFirstFailure = true;
            this.inputNombre.ResetOnPrompt = false;
            this.inputNombre.ResetOnSpace = false;
            this.inputNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputNombre.ShortcutsEnabled = false;
            this.inputNombre.Size = new System.Drawing.Size(133, 20);
            this.inputNombre.SkipLiterals = false;
            this.inputNombre.TabIndex = 30;
            this.inputNombre.Tag = "";
            this.inputNombre.Text = "InfoNombre";
            this.inputNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(124, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "DNI:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaUsuario.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(176, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // InputBuscarDni
            // 
            this.InputBuscarDni.AccessibleDescription = "";
            this.InputBuscarDni.AccessibleName = "";
            this.InputBuscarDni.AllowPromptAsInput = false;
            this.InputBuscarDni.BackColor = System.Drawing.SystemColors.Control;
            this.InputBuscarDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBuscarDni.CausesValidation = false;
            this.InputBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.InputBuscarDni.ForeColor = System.Drawing.Color.Black;
            this.InputBuscarDni.Location = new System.Drawing.Point(179, 160);
            this.InputBuscarDni.Margin = new System.Windows.Forms.Padding(4);
            this.InputBuscarDni.Mask = "99999999";
            this.InputBuscarDni.Name = "InputBuscarDni";
            this.InputBuscarDni.RejectInputOnFirstFailure = true;
            this.InputBuscarDni.ResetOnPrompt = false;
            this.InputBuscarDni.ResetOnSpace = false;
            this.InputBuscarDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputBuscarDni.ShortcutsEnabled = false;
            this.InputBuscarDni.Size = new System.Drawing.Size(133, 20);
            this.InputBuscarDni.SkipLiterals = false;
            this.InputBuscarDni.TabIndex = 27;
            this.InputBuscarDni.Tag = "";
            this.InputBuscarDni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.InputBuscarDni.ValidatingType = typeof(int);
            this.InputBuscarDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InputBuscarDni_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Editar Informacion de un Socio";
            // 
            // EditarInformacionSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.InputBuscarDni);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditarInformacionSocio";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.InputBuscarDni, 0);
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

        private System.Windows.Forms.Button registrarUsuario;
        private System.Windows.Forms.Button buscarDni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MaskedTextBox inputEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MaskedTextBox inputTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MaskedTextBox inputFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox inputApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox inputNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox InputBuscarDni;
        private System.Windows.Forms.Label label1;
    }
}
