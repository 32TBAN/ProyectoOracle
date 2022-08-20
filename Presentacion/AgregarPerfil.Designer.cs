namespace Presentacion
{
    partial class AgregarPerfil
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
            this.label_Error = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rjTextBox_Contrasenia = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjTextBox_nICKNAME = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjTextBox_Apellido = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rjTextBox_Nombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.iconButton_Error = new FontAwesome.Sharp.IconButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboBox_TipoPerfil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.White;
            this.label_Error.Location = new System.Drawing.Point(563, 193);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(31, 13);
            this.label_Error.TabIndex = 32;
            this.label_Error.Text = "Error";
            this.label_Error.Visible = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(171, 306);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(376, 43);
            this.rjButton1.TabIndex = 30;
            this.rjButton1.Text = "Guardar";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo de perfil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Contraseña";
            // 
            // rjTextBox_Contrasenia
            // 
            this.rjTextBox_Contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_Contrasenia.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_Contrasenia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Contrasenia.BorderRadius = 5;
            this.rjTextBox_Contrasenia.BorderSize = 2;
            this.rjTextBox_Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Contrasenia.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_Contrasenia.Location = new System.Drawing.Point(170, 206);
            this.rjTextBox_Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Contrasenia.Multiline = false;
            this.rjTextBox_Contrasenia.Name = "rjTextBox_Contrasenia";
            this.rjTextBox_Contrasenia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Contrasenia.PasswordChar = true;
            this.rjTextBox_Contrasenia.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Contrasenia.PlaceholderText = "Contraseña";
            this.rjTextBox_Contrasenia.Size = new System.Drawing.Size(380, 31);
            this.rjTextBox_Contrasenia.TabIndex = 26;
            this.rjTextBox_Contrasenia.Texts = "";
            this.rjTextBox_Contrasenia.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nickname";
            // 
            // rjTextBox_nICKNAME
            // 
            this.rjTextBox_nICKNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_nICKNAME.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_nICKNAME.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_nICKNAME.BorderRadius = 5;
            this.rjTextBox_nICKNAME.BorderSize = 2;
            this.rjTextBox_nICKNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_nICKNAME.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_nICKNAME.Location = new System.Drawing.Point(170, 153);
            this.rjTextBox_nICKNAME.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_nICKNAME.Multiline = false;
            this.rjTextBox_nICKNAME.Name = "rjTextBox_nICKNAME";
            this.rjTextBox_nICKNAME.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_nICKNAME.PasswordChar = false;
            this.rjTextBox_nICKNAME.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_nICKNAME.PlaceholderText = "Nickname";
            this.rjTextBox_nICKNAME.Size = new System.Drawing.Size(380, 31);
            this.rjTextBox_nICKNAME.TabIndex = 24;
            this.rjTextBox_nICKNAME.Texts = "";
            this.rjTextBox_nICKNAME.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido";
            // 
            // rjTextBox_Apellido
            // 
            this.rjTextBox_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_Apellido.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_Apellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Apellido.BorderRadius = 5;
            this.rjTextBox_Apellido.BorderSize = 2;
            this.rjTextBox_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Apellido.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_Apellido.Location = new System.Drawing.Point(169, 104);
            this.rjTextBox_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Apellido.Multiline = false;
            this.rjTextBox_Apellido.Name = "rjTextBox_Apellido";
            this.rjTextBox_Apellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Apellido.PasswordChar = false;
            this.rjTextBox_Apellido.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Apellido.PlaceholderText = "Apellido";
            this.rjTextBox_Apellido.Size = new System.Drawing.Size(379, 31);
            this.rjTextBox_Apellido.TabIndex = 22;
            this.rjTextBox_Apellido.Texts = "";
            this.rjTextBox_Apellido.UnderlinedStyle = false;
            this.rjTextBox_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox_Apellido_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // rjTextBox_Nombre
            // 
            this.rjTextBox_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_Nombre.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_Nombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Nombre.BorderRadius = 5;
            this.rjTextBox_Nombre.BorderSize = 2;
            this.rjTextBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Nombre.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_Nombre.Location = new System.Drawing.Point(167, 60);
            this.rjTextBox_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Nombre.Multiline = false;
            this.rjTextBox_Nombre.Name = "rjTextBox_Nombre";
            this.rjTextBox_Nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Nombre.PasswordChar = false;
            this.rjTextBox_Nombre.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjTextBox_Nombre.PlaceholderText = "Nombre";
            this.rjTextBox_Nombre.Size = new System.Drawing.Size(380, 31);
            this.rjTextBox_Nombre.TabIndex = 20;
            this.rjTextBox_Nombre.Texts = "";
            this.rjTextBox_Nombre.UnderlinedStyle = false;
            this.rjTextBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox_Apellido_KeyPress_1);
            // 
            // iconButton_Error
            // 
            this.iconButton_Error.FlatAppearance.BorderSize = 0;
            this.iconButton_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Error.ForeColor = System.Drawing.Color.White;
            this.iconButton_Error.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconButton_Error.IconColor = System.Drawing.Color.Red;
            this.iconButton_Error.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Error.IconSize = 25;
            this.iconButton_Error.Location = new System.Drawing.Point(557, 153);
            this.iconButton_Error.Name = "iconButton_Error";
            this.iconButton_Error.Size = new System.Drawing.Size(37, 25);
            this.iconButton_Error.TabIndex = 31;
            this.iconButton_Error.UseVisualStyleBackColor = true;
            this.iconButton_Error.Visible = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(170, 364);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(376, 43);
            this.rjButton2.TabIndex = 33;
            this.rjButton2.Text = "Cancelar";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(649, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(19, 18);
            this.iconButton2.TabIndex = 34;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // comboBox_TipoPerfil
            // 
            this.comboBox_TipoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_TipoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_TipoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_TipoPerfil.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TipoPerfil.FormattingEnabled = true;
            this.comboBox_TipoPerfil.Location = new System.Drawing.Point(171, 268);
            this.comboBox_TipoPerfil.Name = "comboBox_TipoPerfil";
            this.comboBox_TipoPerfil.Size = new System.Drawing.Size(375, 22);
            this.comboBox_TipoPerfil.TabIndex = 35;
            // 
            // AgregarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 429);
            this.Controls.Add(this.comboBox_TipoPerfil);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.iconButton_Error);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rjTextBox_Contrasenia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rjTextBox_nICKNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjTextBox_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjTextBox_Nombre);
            this.Name = "AgregarPerfil";
            this.Text = "AgregarPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Error;
        private FontAwesome.Sharp.IconButton iconButton_Error;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Contrasenia;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_nICKNAME;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Apellido;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Nombre;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox comboBox_TipoPerfil;
    }
}