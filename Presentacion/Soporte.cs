using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Entidades;
using Presentacion.Negocio;

namespace Presentacion
{
    public partial class Soporte : Form
    {
        public UsuarioEntidad usuarioEntidad { get; set; }
        SolicitudEntidad solicitudEntidad = new SolicitudEntidad();
        private IconButton bottonActivo;
        private Panel bordeInferior;
        public Soporte(UsuarioEntidad usuarioEntidad)
        {
            InitializeComponent();
            this.usuarioEntidad = usuarioEntidad;
            CargarDatos();
            CargarPermisos();
            solicitudes1.Enabled = false;
            solicitudes1.ForeColor = Color.White;
        }
        private void CargarPermisos()
        {
            if (usuarioEntidad.NumPerfil == 1)
                iconButton_SolicituAsig.Visible = false;
            else
                iconButton_NUebasol.Visible = false;
        }

        private void CargarDatos()
        {
            CargarSolicitudes(0);
            //botones
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(181, 2);
            panel_Cabezera.Controls.Add(bordeInferior);
            ActivateButton(iconButton_Pincipal);
        }
        private void CargarSolicitudes(int general)
        {

            List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();

            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                if (item.IdUsuario == usuarioEntidad.Id || item.IdTecnico == usuarioEntidad.Id)
                {
                    solicitudEntidads.Add(item);
                }
            }
            if (solicitudEntidads.Count >= 1)
            {
                panel_Contendor.Controls.Clear();
                panel_Contendor.Controls.Add(label_Solicitud);
                if (general == 0)
                {
                    List<SolicitudEntidad> solicitudesPendiente = null;
                    if (usuarioEntidad.NumPerfil == 1)
                        solicitudesPendiente = solicitudEntidads.Where(x => x.Estado == 0 || x.Estado == 1).ToList();
                    else
                        solicitudesPendiente = solicitudEntidads.Where(x => x.Estado == 1).ToList();

                    CargarSolicitudComponente(solicitudesPendiente);

                }
                else if (general == 1)
                {
                    List<SolicitudEntidad> solicitudHechas = solicitudEntidads.Where(x => x.Estado == 2).ToList();
                    CargarSolicitudComponente(solicitudHechas);
                }
                else
                {
                    List<SolicitudEntidad> solicitudAsignadas = solicitudEntidads.Where(x => x.Estado == 1).ToList();
                    CargarSolicitudComponente(solicitudAsignadas);
                }
            }
            else
                label_Solicitud.Visible = true;
            panel_Contendor.Controls.Add(panel_NuevaSolicitud);
            panel_NuevaSolicitud.Visible = false;
        }

        private void CargarSolicitudComponente(List<SolicitudEntidad> solicitudesPendiente)
        {
            if (solicitudesPendiente.Count >= 1)
            {
                foreach (var item in solicitudesPendiente)
                {
                    Solicitudes solicitudes = new Solicitudes();
                    solicitudes.textBox_IdSol.Click += TextBox_IdSol_Click;
                    if (item.Estado == 0)
                        solicitudes.Emisor = "Aun no se ha asignado aun tecnico";
                    else
                    {
                        if (usuarioEntidad.Perfil == "Tecnico")
                            solicitudes.Emisor = "Jefe Tecnico";
                        else
                            solicitudes.Emisor = UsuarioNegocio.BuscarUsuarioID(item.IdTecnico).Nombre;
                    }


                    solicitudes.Asunto = item.Asunto;
                    solicitudes.Descripcion = item.Descripcion;
                    solicitudes.Fecha = item.FechaEnvio.ToShortDateString();
                    solicitudes.IdSolicitud = item.Id;

                    panel_Contendor.Controls.Add(solicitudes);
                    foreach (Solicitudes sol in panel_Contendor.Controls.OfType<Solicitudes>())
                    {
                        sol.Dock = DockStyle.Top;
                    }
                }
                label_Solicitud.Visible = false;
            }
            else
            {
                label_Solicitud.Visible = true;
            }

        }

        //Envia la informacion
        private void TextBox_IdSol_Click(object sender, EventArgs e)
        {
            panel_Cabezera.Visible = false;
            panel_Contendor.Controls.Clear();
            panel_Contendor.Controls.Add(panel_NuevaSolicitud);
            AbrirForm(new Calificar(Convert.ToInt32(((TextBox)(sender)).Text), usuarioEntidad.Id));
        }

        public void AbrirForm(Form form)
        {
            form.TopLevel = true;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_Contendor.Controls.Add(form);
            panel_Contendor.Tag = form;
            form.BringToFront();
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel_Cabezera.Visible = true;
            ActivateButton(iconButton_Pincipal);
            CargarSolicitudes(0);
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            CargarSolicitudes(1);
        }

        private void Limpiar()
        {
            textBox_Asunto.Text = "";
            richTextBox_Descripcion.Text = "";
        }


        private bool ControlDatos()
        {
            if (textBox_Asunto.Text == "" || richTextBox_Descripcion.Text == "" ||
                rjComboBox_Urgencia.Texts == "" || rjComboBox_Dispositivo.Texts == "")
            {
                MostrarError(Mensajes.Error);
                return false;
            }
            return true;
        }

        private void MostrarError(string v)
        {
            label_Error.Text = v;
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }

        #region DiseñoBotones

        //Methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                bottonActivo = (IconButton)senderBtn;
                bottonActivo.ForeColor = Color.Red;
                bottonActivo.TextAlign = ContentAlignment.MiddleCenter;
                bottonActivo.IconColor = Color.Red;

                bordeInferior.BackColor = Color.Red;
                bordeInferior.Location = new Point(bottonActivo.Location.X, 5);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (bottonActivo != null)
            {
                bottonActivo.BackColor = Color.Black;
                bottonActivo.ForeColor = Color.White;
                bottonActivo.IconColor = Color.FromArgb(242, 207, 141);
            }
        }
        #endregion

        private void iconButton_Pincipal_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            CargarSolicitudes(0);
        }

        private void iconButton_SolicituAsig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            CargarSolicitudes(2);
        }

        private void iconButton_NUebasol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel_NuevaSolicitud.Visible = true;
            panel_NuevaSolicitud.BringToFront();
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = false;
            panel_NuevaSolicitud.SendToBack();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            if (ControlDatos())
            {
                solicitudEntidad.IdUsuario = usuarioEntidad.Id;
                solicitudEntidad.Asunto = textBox_Asunto.Text;
                solicitudEntidad.Descripcion = richTextBox_Descripcion.Text;
                solicitudEntidad.Urgencia = rjComboBox_Urgencia.Texts;
                solicitudEntidad.Dispositivo = rjComboBox_Dispositivo.Texts;
                solicitudEntidad.Area = rjComboBox_Area.Texts;
                solicitudEntidad.FechaEnvio = DateTime.Now;
                solicitudEntidad.Estado = 0;

                solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                if (solicitudEntidad != null)
                {
                    MessageBox.Show("Se ha enviado su solicitud");
                    Limpiar();
                    panel_NuevaSolicitud.Visible = false;
                    CargarSolicitudes(0);
                }
            }
        }
    }
}
