using Presentacion.Entidades;
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
    public partial class Principal : Form
    {
        public UsuarioEntidad usuarioEntidad { get; set; }

        public Principal(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            this.usuarioEntidad = usuarioEntidad;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
