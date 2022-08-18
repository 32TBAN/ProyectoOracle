using Presentacion.Entidades;
using Presentacion.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        UsuarioEntidad usuarioEntidad = new UsuarioEntidad();
        public Login()
        {
            InitializeComponent();
        }
        #region MoverInterfas
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaprure();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsq, int wParam, int lParam);

        private void Login_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones
        //salir
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Abre el from principal
        private void rjButton1_Click(object sender, EventArgs e)
        {
            AbrirForm();
        }
        #endregion

        #region Metodos
        private void AbrirForm()
        {
            if (ControlarDatos())
            {
                this.Hide();
                Principal principal = new Principal(usuarioEntidad);
                principal.FormClosed += Principal_FormClosed;
                principal.Show();
                rjTextBox_Usuario.Texts = "";
                rjTextBox_Contrasenia.Texts = "";
            }
        }
        private bool ControlarDatos()
        {
            if (rjTextBox_Usuario.Texts == "")
            {
                MostrarError(Mensajes.NoCorreo);
                return false;
            }
            else if (rjTextBox_Contrasenia.Texts == "")
            {
                MostrarError(Mensajes.NoContrasenia);
                return false;
            }
            else
            {
                usuarioEntidad = UsuarioNegocio.BuscarUsuarioNickname(rjTextBox_Usuario.Texts);
                if (usuarioEntidad == null)
                {
                    usuarioEntidad = new UsuarioEntidad();
                    MostrarError(Mensajes.Error);
                    return false;
                }
                else if (usuarioEntidad.Id == 0)
                {
                    MostrarError(Mensajes.NoRegistrado);
                    return false;
                }
                else if (usuarioEntidad.Contraseña != rjTextBox_Contrasenia.Texts)
                {
                    MostrarError(Mensajes.NoConcidenciaContrasenia);
                    return false;
                }
            }
            iconButton_Error.Visible = false;
            label_Error.Visible = false;
            return true;
        }
        public void MostrarError(string mensajes)
        {
            label_Error.Text = mensajes;
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }
        #endregion

        #region Eventos
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion
      
    }
}
