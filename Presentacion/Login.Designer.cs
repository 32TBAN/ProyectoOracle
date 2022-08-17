namespace Presentacion
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjTextBox_Contrasenia = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox_Usuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 431);
            this.panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(297, 270);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(390, 40);
            this.rjButton1.TabIndex = 12;
            this.rjButton1.Text = "Ingresar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjTextBox_Contrasenia
            // 
            this.rjTextBox_Contrasenia.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.rjTextBox_Contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_Contrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjTextBox_Contrasenia.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_Contrasenia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rjTextBox_Contrasenia.BorderRadius = 5;
            this.rjTextBox_Contrasenia.BorderSize = 2;
            this.rjTextBox_Contrasenia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Contrasenia.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_Contrasenia.Location = new System.Drawing.Point(297, 191);
            this.rjTextBox_Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Contrasenia.Multiline = false;
            this.rjTextBox_Contrasenia.Name = "rjTextBox_Contrasenia";
            this.rjTextBox_Contrasenia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Contrasenia.PasswordChar = true;
            this.rjTextBox_Contrasenia.PlaceholderColor = System.Drawing.Color.White;
            this.rjTextBox_Contrasenia.PlaceholderText = "Contraseña";
            this.rjTextBox_Contrasenia.Size = new System.Drawing.Size(390, 34);
            this.rjTextBox_Contrasenia.TabIndex = 11;
            this.rjTextBox_Contrasenia.Texts = "";
            this.rjTextBox_Contrasenia.UnderlinedStyle = false;
            // 
            // rjTextBox_Usuario
            // 
            this.rjTextBox_Usuario.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.rjTextBox_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjTextBox_Usuario.BorderColor = System.Drawing.Color.Black;
            this.rjTextBox_Usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rjTextBox_Usuario.BorderRadius = 5;
            this.rjTextBox_Usuario.BorderSize = 2;
            this.rjTextBox_Usuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Usuario.ForeColor = System.Drawing.Color.White;
            this.rjTextBox_Usuario.Location = new System.Drawing.Point(297, 114);
            this.rjTextBox_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Usuario.Multiline = false;
            this.rjTextBox_Usuario.Name = "rjTextBox_Usuario";
            this.rjTextBox_Usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Usuario.PasswordChar = false;
            this.rjTextBox_Usuario.PlaceholderColor = System.Drawing.Color.White;
            this.rjTextBox_Usuario.PlaceholderText = "Usuario";
            this.rjTextBox_Usuario.Size = new System.Drawing.Size(390, 34);
            this.rjTextBox_Usuario.TabIndex = 9;
            this.rjTextBox_Usuario.Texts = "";
            this.rjTextBox_Usuario.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(399, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iniciar sesion";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(671, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 25);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.inicio;
            this.pictureBox1.Location = new System.Drawing.Point(28, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(709, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjTextBox_Contrasenia);
            this.Controls.Add(this.rjTextBox_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Contrasenia;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Usuario;
        private System.Windows.Forms.Label label1;
    }
}

