namespace Presentacion
{
    partial class Solicitudes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_IdSol = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Fondo = new System.Windows.Forms.TableLayoutPanel();
            this.label_Emisor = new System.Windows.Forms.Label();
            this.checkBox_Seleccionar = new System.Windows.Forms.CheckBox();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Asunto = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 1);
            this.panel1.TabIndex = 2;
            // 
            // textBox_IdSol
            // 
            this.textBox_IdSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_IdSol.Location = new System.Drawing.Point(36, 19);
            this.textBox_IdSol.Multiline = true;
            this.textBox_IdSol.Name = "textBox_IdSol";
            this.textBox_IdSol.ReadOnly = true;
            this.textBox_IdSol.Size = new System.Drawing.Size(713, 3);
            this.textBox_IdSol.TabIndex = 5;
            this.textBox_IdSol.Visible = false;
            // 
            // tableLayoutPanel_Fondo
            // 
            this.tableLayoutPanel_Fondo.ColumnCount = 5;
            this.tableLayoutPanel_Fondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7551F));
            this.tableLayoutPanel_Fondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2449F));
            this.tableLayoutPanel_Fondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel_Fondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel_Fondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel_Fondo.Controls.Add(this.label_Emisor, 0, 0);
            this.tableLayoutPanel_Fondo.Controls.Add(this.checkBox_Seleccionar, 0, 0);
            this.tableLayoutPanel_Fondo.Controls.Add(this.label_Descripcion, 3, 0);
            this.tableLayoutPanel_Fondo.Controls.Add(this.label_Asunto, 2, 0);
            this.tableLayoutPanel_Fondo.Controls.Add(this.label_Fecha, 4, 0);
            this.tableLayoutPanel_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Fondo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Fondo.Name = "tableLayoutPanel_Fondo";
            this.tableLayoutPanel_Fondo.RowCount = 1;
            this.tableLayoutPanel_Fondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Fondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Fondo.Size = new System.Drawing.Size(748, 40);
            this.tableLayoutPanel_Fondo.TabIndex = 4;
            // 
            // label_Emisor
            // 
            this.label_Emisor.AutoSize = true;
            this.label_Emisor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Emisor.Location = new System.Drawing.Point(52, 0);
            this.label_Emisor.Name = "label_Emisor";
            this.label_Emisor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_Emisor.Size = new System.Drawing.Size(59, 29);
            this.label_Emisor.TabIndex = 5;
            this.label_Emisor.Text = "Emisor";
            this.label_Emisor.MouseHover += new System.EventHandler(this.label_Descripcion_MouseHover);
            // 
            // checkBox_Seleccionar
            // 
            this.checkBox_Seleccionar.AutoSize = true;
            this.checkBox_Seleccionar.Location = new System.Drawing.Point(3, 3);
            this.checkBox_Seleccionar.Name = "checkBox_Seleccionar";
            this.checkBox_Seleccionar.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Seleccionar.Size = new System.Drawing.Size(35, 34);
            this.checkBox_Seleccionar.TabIndex = 0;
            this.checkBox_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Descripcion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descripcion.Location = new System.Drawing.Point(286, 0);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_Descripcion.Size = new System.Drawing.Size(304, 40);
            this.label_Descripcion.TabIndex = 1;
            this.label_Descripcion.Text = "Descripcion";
            this.label_Descripcion.MouseHover += new System.EventHandler(this.label_Descripcion_MouseHover);
            // 
            // label_Asunto
            // 
            this.label_Asunto.AutoSize = true;
            this.label_Asunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Asunto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Asunto.Location = new System.Drawing.Point(134, 0);
            this.label_Asunto.Name = "label_Asunto";
            this.label_Asunto.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_Asunto.Size = new System.Drawing.Size(146, 40);
            this.label_Asunto.TabIndex = 4;
            this.label_Asunto.Text = "Asunto";
            this.label_Asunto.MouseHover += new System.EventHandler(this.label_Descripcion_MouseHover);
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Fecha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fecha.Location = new System.Drawing.Point(596, 0);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_Fecha.Size = new System.Drawing.Size(149, 40);
            this.label_Fecha.TabIndex = 2;
            this.label_Fecha.Text = "Fecha";
            this.label_Fecha.MouseHover += new System.EventHandler(this.label_Descripcion_MouseHover);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_IdSol);
            this.Controls.Add(this.tableLayoutPanel_Fondo);
            this.Controls.Add(this.panel1);
            this.Name = "Solicitudes";
            this.Size = new System.Drawing.Size(748, 41);
            this.tableLayoutPanel_Fondo.ResumeLayout(false);
            this.tableLayoutPanel_Fondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox_IdSol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Fondo;
        private System.Windows.Forms.Label label_Emisor;
        private System.Windows.Forms.CheckBox checkBox_Seleccionar;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Asunto;
        private System.Windows.Forms.Label label_Fecha;
    }
}
