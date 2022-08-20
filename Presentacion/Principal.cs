using FontAwesome.Sharp;
using Presentacion.Entidades;
using Presentacion.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public UsuarioEntidad usuarioEntidad { get; set; }
        private Form formAbierto = null;
        private int bordeForm = 2;
        private Size formSize;
        private IconButton bottonActivo;
        private Panel leftBorderBtn;
        public Principal(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            this.usuarioEntidad = usuarioEntidad;
            CargarDatos();
            //Menu
            this.Padding = new Padding(bordeForm);
            this.BackColor = Color.FromArgb(41, 39, 89);
            //botones
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 42);
            panel_Menu.Controls.Add(leftBorderBtn);
            MostrarPermiso();
        }
        private void MostrarPermiso()
        {
            if (usuarioEntidad.NumPerfil == 1)
            {
                iconButton_Agregar.Visible = false;
                iconButton_ASIGNAR.Visible = false;
                iconButton_revisar.Visible = false;
            }
            else if (usuarioEntidad.NumPerfil == 2)
            {
                iconButton_Agregar.Visible = false;
                iconButton_ASIGNAR.Visible = false;
                iconButton_revisar.Visible = false;
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            label_Permisos.Text = usuarioEntidad.Perfil;
            label_Nombre.Text = usuarioEntidad.Nombre + " " + usuarioEntidad.Apellido;
            textBox_Usuario.Text = usuarioEntidad.Nickname;
            textBox_Contrasenia.Text = usuarioEntidad.Contraseña;
        }
        #region Botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                bottonActivo = (IconButton)senderBtn;
                bottonActivo.BackColor = Color.FromArgb(64, 64, 64);
                bottonActivo.ForeColor = color;
                bottonActivo.TextAlign = ContentAlignment.MiddleCenter;
                bottonActivo.IconColor = color;
                bottonActivo.TextImageRelation = TextImageRelation.TextBeforeImage;
                bottonActivo.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, bottonActivo.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconButton_Form.IconChar = bottonActivo.IconChar;
                iconButton_Form.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (bottonActivo != null)
            {
                bottonActivo.BackColor = Color.White;
                bottonActivo.ForeColor = Color.Black;
                bottonActivo.TextAlign = ContentAlignment.MiddleLeft;
                bottonActivo.IconColor = Color.FromArgb(166,166, 166);
                bottonActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
                bottonActivo.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        #region Redimencionar Form
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);

        }
        #endregion
        public void AbrirFormularios(Form form)
        {
            if (formAbierto != null)
            {
                formAbierto.Close();
            }
            formAbierto = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_C.Controls.Add(form);
            panel_C.Tag = form;
            form.BringToFront();
            form.Show();
        }

        #region MoverForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void Principal_Resize(object sender, EventArgs e)
        {
            AjustarForm();
        }
        private void AjustarForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != bordeForm)
                        this.Padding = new Padding(bordeForm);
                    break;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconButton_Form.IconChar = IconChar.Home;
            iconButton_Form.IconColor = Color.FromArgb(242, 207, 141);
        }

        private void iconButton_Form_Click(object sender, EventArgs e)
        {
            if (formAbierto != null)
            {
                formAbierto.Close();
                Reset();
            }
        }

        private void iconButton_Agregar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color2);
            AbrirFormularios(new Soporte());
        }

        private void iconButton_ASIGNAR_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormularios(new Asignacion());
        }

        private void iconButton_revisar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            if (MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            textBox_Usuario.ReadOnly = false;
            textBox_Usuario.Focus();
            rjButton_Guardar.Visible = true;
        }
        private void iconButton13_Click(object sender, EventArgs e)
        {
            textBox_Contrasenia.ReadOnly = false;
            textBox_Contrasenia.Focus();
            textBox_Contrasenia.UseSystemPasswordChar = false;
            rjButton_Guardar.Visible = true;
        }
        private void rjButton_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlDatos())
                {
                    UsuarioEntidad usuarioEntidadRespaldo = usuarioEntidad;
                    usuarioEntidad.Contraseña = textBox_Contrasenia.Text;
                    usuarioEntidad.Nickname = textBox_Usuario.Text;

                    usuarioEntidad = UsuarioNegocio.Guardar(usuarioEntidad);
                    if (usuarioEntidad == null)
                    {
                        usuarioEntidad = usuarioEntidadRespaldo;
                        MessageBox.Show(Mensajes.Error);
                    }
                    else
                        MessageBox.Show(Mensajes.Actualizado);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Mensajes.ErrorActualizar);
            }
        }

        private bool ControlDatos()
        {
            if (textBox_Contrasenia.Text == "" || textBox_Usuario.Text =="")
            {
                MessageBox.Show(Mensajes.FaltanDatos);
                return false;
            }
            else
            {
                UsuarioEntidad usuarioEntidadB = UsuarioNegocio.BuscarUsuarioNickname(textBox_Usuario.Text);
                if (usuarioEntidadB.Id != 0)
                {
                    MessageBox.Show(Mensajes.YaExisteNickname);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            ActivateButton(iconButton_Agregar, RGBColors.color1);
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            ActivateButton(iconButton6, RGBColors.color2);
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ActivateButton(iconButton_ASIGNAR, RGBColors.color3);
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(iconButton_revisar, RGBColors.color4);
            AbrirFormularios(new AgregarPerfil());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (panel_Perfil.Visible == true)
                panel_Perfil.Visible = false;
            else
            {
                panel_Perfil.Visible = true;
                panel_Perfil.BringToFront();
            }
                textBox_Contrasenia.UseSystemPasswordChar = true;
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
