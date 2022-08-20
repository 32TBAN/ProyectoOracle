using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Solicitudes : UserControl
    {
        public bool Seleccionar
        {
            get { return checkBox_Seleccionar.Checked; }
            set { checkBox_Seleccionar.Checked = value; }
        }
        public string Emisor
        {
            get { return label_Emisor.Text; }
            set { label_Emisor.Text = value; }
        }
        public string Asunto
        {
            get { return label_Asunto.Text; }
            set { label_Asunto.Text = value; }
        }
        public string Descripcion
        {
            get { return label_Descripcion.Text; }
            set { label_Descripcion.Text = value; }
        }
        public string Fecha
        {
            get { return label_Fecha.Text; }
            set { label_Fecha.Text = value; }
        }
        public int IdSolicitud
        {
            get { return Convert.ToInt32(textBox_IdSol.Text); }
            set { textBox_IdSol.Text = Convert.ToString(value); }
        }
        public Solicitudes()
        {
            InitializeComponent();
        }

        private void label_Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void label_Descripcion_MouseHover(object sender, EventArgs e)
        {
            textBox_IdSol.Visible = true;
        }
    }
}
