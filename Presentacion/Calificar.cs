using FontAwesome.Sharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Presentacion.Entidades;
using Presentacion.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Calificar : Form
    {
        private SolicitudEntidad solicitudEntidad { get; set; }
        private UsuarioEntidad usuarioEntidadTecnico { get; set; }
        private UsuarioEntidad usuarioEntidadNormal { get; set; }
        private int usllama { get; set; }
        public Calificar(int idSolicitud, int usllama)
        {
            InitializeComponent();
            this.usllama = usllama;
            CargarDatos(idSolicitud);
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            if (usuarioEntidadNormal.Id != usllama)
            {
                iconButton_Eliminar.Visible = false;
                iconButton_Editar.Visible = false;
            }
        }

        private void CargarDatos(int idSolicitud)
        {
            solicitudEntidad = SolicitudNegocio.BuscarSolicitud(idSolicitud);
            usuarioEntidadNormal = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdUsuario);
            usuarioEntidadTecnico = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdTecnico);

            if (solicitudEntidad != null)
            {
                CargarTxtPerfil();
            }
        }

        private void CargarTxtPerfil()
        {
            label_Asunto.Text = solicitudEntidad.Asunto;
            label_Descrpcion.Text = solicitudEntidad.Descripcion;
            label_Fecha_Envio.Text = solicitudEntidad.FechaEnvio.ToLongDateString() + "        ";

            if (usuarioEntidadNormal.Id == usllama)
            {
                if (solicitudEntidad.Estado == 1)
                {
                    label_Coreo.Text = usuarioEntidadTecnico.Nickname;
                    Fecha.Text = "En proceso";
                    richTextBox_Requisitos.Text = "Aun no se revisa su solicitud";
                    Total.Text = "Aun no se revisa su solicitud";
                }
                else if (solicitudEntidad.Estado == 2)
                {
                    label_Coreo.Text = usuarioEntidadTecnico.Nickname;

                    Fecha.Text = solicitudEntidad.FechaEntrega.ToString();
                    richTextBox_Requisitos.Text = solicitudEntidad.Respuesta;
                    Total.Text += solicitudEntidad.Total.ToString();
                }
                else
                {
                    label_Coreo.Text = "No se ha asignado";
                    richTextBox_Requisitos.Text = "No se ha asignado";
                    Fecha.Text = "En proceso";
                }
            }
            else
            {
                UsuarioEntidad usuarioEnvio = UsuarioNegocio.BuscarUsuarioID(solicitudEntidad.IdUsuario);
                if (solicitudEntidad.Estado == 1)
                {
                    label_Coreo.Text = usuarioEnvio.Nickname;
                    Fecha.Text = solicitudEntidad.FechaEnvio.ToString();
                    richTextBox_Requisitos.Text = "Escriba todo lo necesitado para solicionar el problema(heramientas, programas etc.)";
                    Total.Text += "Aun no se revisa la solicitud";
                    richTextBox_Requisitos.ReadOnly = false;
                    rjButton_EnviarRes.Visible = true;

                    label_Coreo.Text = usuarioEnvio.Nickname;
                    Fecha.Text = solicitudEntidad.FechaEntrega.ToString();
                    richTextBox_Requisitos.Text = solicitudEntidad.Respuesta;
                    Total.Text = "Total: " + solicitudEntidad.Total.ToString();

                    if (richTextBox_Requisitos.Text == solicitudEntidad.Respuesta)
                    {
                        richTextBox_Requisitos.ReadOnly = true;
                        rjButton_EnviarRes.Visible = false;
                    }
                }
                else
                {
                    label_Coreo.Text = usuarioEnvio.Nickname;
                    Fecha.Text = solicitudEntidad.FechaEntrega.ToString();
                    richTextBox_Requisitos.Text = solicitudEntidad.Respuesta;
                    Total.Text = "Total: " + solicitudEntidad.Total.ToString();

                    richTextBox_Requisitos.ReadOnly = true;
                }
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            NotaServicio();
        }

        private void NotaServicio()
        {
            CalificacionEntidad calificacionEntidad = CalificacionNegocio.SolicitudCal(solicitudEntidad.Id);
            if (solicitudEntidad.Estado == 2 && usuarioEntidadNormal.Id == usllama && calificacionEntidad.IdSol == 0)
                panel_Calificasion.Visible = true;
            else
                this.Close();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            panel_Calificasion.Visible = false;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            NotaServicio();
            PdfServicio();
        }

        private void PdfServicio()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = solicitudEntidad.Id + ".pdf";
                string estructura = Properties.Resources.Plantillapdf.ToString();

                estructura = estructura.Replace("@nombre", (usuarioEntidadNormal.Nombre + " " + usuarioEntidadNormal.Apellido));
                estructura = estructura.Replace("@Nickname", usuarioEntidadNormal.Nickname);

                estructura = estructura.Replace("@numSol", solicitudEntidad.Id.ToString());
                estructura = estructura.Replace("@fecha", DateTime.Now.ToString());

                estructura = estructura.Replace("@dispositivo", solicitudEntidad.Dispositivo);
                estructura = estructura.Replace("@asunto", solicitudEntidad.Asunto);
                estructura = estructura.Replace("@descripcion", solicitudEntidad.Descripcion);
                estructura = estructura.Replace("@total", Total.Text);

                estructura = estructura.Replace("@nombreTec", (usuarioEntidadTecnico.Nombre + " " + usuarioEntidadTecnico.Apellido));
                estructura = estructura.Replace("@NicknamelTec", usuarioEntidadTecnico.Nickname);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(document, stream);

                        document.Open();
                        document.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.inicio, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 75);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(document.LeftMargin, document.Top - 50);
                        document.Add(img);

                        using (StringReader sr = new StringReader(estructura))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                        }
                        document.Close();
                        stream.Close();
                        writer.Close();
                    }
                }
                MessageBox.Show("Se ha generado su pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el pdf " + ex.Message.ToString());
            }

        }

        private bool ControlDatos()
        {
            if (textBox_Asunto.Text == "" || richTextBox_Descripcion.Text == "" ||
                rjComboBox_Urgencia.Texts == "" || rjComboBox_Dispositivo.Texts == "")
            {
                MostrarError(Mensajes.FaltanDatos);
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
        private void Limpiar()
        {
            textBox_Asunto.Text = "";
            richTextBox_Descripcion.Text = "";
        }
        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            if (!panel_Min.Visible)
            {
                panel_Min.Visible = true;
                if (usuarioEntidadTecnico.Id != 0 && solicitudEntidad.Estado != 0)
                {
                    label_Encargado.Text = usuarioEntidadTecnico.Nombre + " " + usuarioEntidadTecnico.Apellido;
                    if (usuarioEntidadNormal != null)
                    {
                        label_Para.Text = usuarioEntidadNormal.Nombre + " " + usuarioEntidadNormal.Apellido;
                    }
                    label_AsuntoMin.Text = solicitudEntidad.Asunto;
                }
                else
                {
                    label_Encargado.Visible = false;
                    label_Para.Visible = false;
                    Fecha.Visible = false;
                    label_AsuntoMin.Visible = false;
                    label_ENCARGO.Visible = true;
                }
            }
            else
                panel_Min.Visible = false;
        }

        private void iconButton_Editar_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = true;
        }

        private void iconButton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro que desea eliminar esta solicitud?", "Eliminar", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SolicitudNegocio.EliminarSolicitud(solicitudEntidad.Id))
                    {
                        MessageBox.Show("Se ha eliminado");
                        this.Close();
                    }
                    else
                        MessageBox.Show("No se ha podido eliminar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar esta solictud por que ya esta en proceso");
            }
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            panel_NuevaSolicitud.Visible = false;
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (solicitudEntidad.Estado == 0)
            {
                if (ControlDatos())
                {
                    solicitudEntidad.Asunto = textBox_Asunto.Text;
                    solicitudEntidad.Descripcion = richTextBox_Descripcion.Text;
                    solicitudEntidad.Urgencia = rjComboBox_Urgencia.Texts;
                    solicitudEntidad.Dispositivo = rjComboBox_Dispositivo.Texts;
                    solicitudEntidad.Area = rjComboBox_Area.Texts;
                    solicitudEntidad.FechaEntrega = DateTime.Now;
                    solicitudEntidad.Estado = 0;

                    solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                    if (solicitudEntidad != null)
                    {
                        MessageBox.Show("Se ha modificado su solicitud");
                        Limpiar();
                        panel_NuevaSolicitud.Visible = false;
                        CargarDatos(solicitudEntidad.Id);
                    }
                    else
                    {
                        MessageBox.Show("No puede editar esta solicitud");
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede editar esta solicitud");
            }
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            CalificacionEntidad calificacionEntidad = new CalificacionEntidad();
            calificacionEntidad.IdSol = solicitudEntidad.Id;

            if (checkBox1.Checked)
            {
                calificacionEntidad.Calificacion = 4;
                calificacionEntidad.Comentario = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                calificacionEntidad.Calificacion = 3;
                calificacionEntidad.Comentario = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                calificacionEntidad.Calificacion = 2;
                calificacionEntidad.Comentario = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                calificacionEntidad.Calificacion = 1;
                calificacionEntidad.Comentario = checkBox4.Text;
            }


            calificacionEntidad = CalificacionNegocio.Calificar(calificacionEntidad);
            if (calificacionEntidad != null)
            {
                MessageBox.Show("Gracias");
            }
            this.Close();
        }

        private void richTextBox_Requisitos_Enter_1(object sender, EventArgs e)
        {
            if (richTextBox_Requisitos.Text == "Escriba todo lo necesitado para solicionar el problema(heramientas, programas etc.)")
            {
                richTextBox_Requisitos.Text = "";
            }
        }

        private void rjButton_EnviarRes_Click_1(object sender, EventArgs e)
        {
            if (richTextBox_Requisitos.Text != "")
            {
                solicitudEntidad.Respuesta = richTextBox_Requisitos.Text;
                solicitudEntidad.FechaEntrega = DateTime.Now;

                solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                if (solicitudEntidad != null)
                {
                    MessageBox.Show("Se ha enviado su respuesta el tecnico jefe la revisara");
                    richTextBox_Requisitos.ReadOnly = true;
                    rjButton_EnviarRes.Visible = false;
                }
                else
                    MessageBox.Show("Error al envia su respuesta");
            }
            else
            {
                MessageBox.Show("Aun no ha escrito su respuesta");
            }

        }
    }
}
