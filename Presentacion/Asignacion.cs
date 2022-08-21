using Presentacion.Entidades;
using Presentacion.Negocio;
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
    public partial class Asignacion : Form
    {
        private UsuarioEntidad usuarioSeleccionado = new UsuarioEntidad();
        private SolicitudEntidad solicitudSeleccionado = new SolicitudEntidad();
        private List<SolicitudEntidad> solicitudEntidadsAsignadas = new List<SolicitudEntidad>();
        public Asignacion()
        {
            InitializeComponent();
            CargarDataGrint();
        }
        private void CargarDataGrint()
        {
            List<UsuarioEntidad> usuariosTecnicos = new List<UsuarioEntidad>();

            foreach (var item in UsuarioNegocio.ListaUsuarios())
            {
                if (item.NumPerfil == 2)
                {
                    usuariosTecnicos.Add(item);
                }
            }

            List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();

            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                if (item.Estado == 0)
                {
                    solicitudEntidads.Add(item);
                }
            }

            dataGridView_Tecnicos.DataSource = usuariosTecnicos;
            dataGridView_Tecnicos.Columns["Id"].Visible = false;
            dataGridView_Tecnicos.Columns["Contraseña"].Visible = false;
            dataGridView_Tecnicos.Columns["Perfil"].Visible = false;

            dataGridView_Solicitudes.DataSource = solicitudEntidads;
            dataGridView_Solicitudes.Columns["Id"].Visible = false;
            dataGridView_Solicitudes.Columns["IdUsuario"].Visible = false;
            dataGridView_Solicitudes.Columns["IdTecnico"].Visible = false;
            dataGridView_Solicitudes.Columns["Estado"].Visible = false;
            dataGridView_Solicitudes.Columns["FechaEnvio"].Visible = false;
            dataGridView_Solicitudes.Columns["FechaEntrega"].Visible = false;
            dataGridView_Solicitudes.Columns["Respuesta"].Visible = false;
            dataGridView_Solicitudes.Columns["Total"].Visible = false;
        }
        private void CargarSolucitudes()
        {
            dataGridView_Asignadas.DataSource = null;
            dataGridView_Asignadas.DataSource = solicitudEntidadsAsignadas;
            dataGridView_Asignadas.Columns["Id"].Visible = false;
            dataGridView_Asignadas.Columns["IdUsuario"].Visible = false;
            dataGridView_Asignadas.Columns["IdTecnico"].Visible = false;
            dataGridView_Asignadas.Columns["Estado"].Visible = false;
            dataGridView_Asignadas.Columns["FechaEnvio"].Visible = false;
            dataGridView_Asignadas.Columns["FechaEntrega"].Visible = false;
            dataGridView_Asignadas.Columns["Respuesta"].Visible = false;
            dataGridView_Asignadas.Columns["Total"].Visible = false;
        }
        private void CargarSolictudesTec()
        {
            List<SolicitudEntidad> solicitudEntidadTecnico = new List<SolicitudEntidad>();
            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                if (item.IdTecnico == usuarioSeleccionado.Id && item.Estado == 1)
                    solicitudEntidadTecnico.Add(item);
            }
            dataGridView_SolicitudesTec.DataSource = solicitudEntidadTecnico;
            dataGridView_SolicitudesTec.Columns["Id"].Visible = false;
            dataGridView_SolicitudesTec.Columns["IdUsuario"].Visible = false;
            dataGridView_SolicitudesTec.Columns["IdTecnico"].Visible = false;
            dataGridView_SolicitudesTec.Columns["Estado"].Visible = false;
            dataGridView_SolicitudesTec.Columns["FechaEnvio"].Visible = false;
            dataGridView_SolicitudesTec.Columns["FechaEntrega"].Visible = false;
            dataGridView_SolicitudesTec.Columns["Respuesta"].Visible = false;
            dataGridView_SolicitudesTec.Columns["Total"].Visible = false;
        }
        private bool ComprobarExistencia(int c)
        {
            foreach (var item in solicitudEntidadsAsignadas)
            {
                if (item.Id == c)
                {
                    MessageBox.Show("Esa solicitud ya esta asigna a este usuario");
                    return false;
                }
            }
            return true;
        }
        private void QuitarLista(int quitar)
        {
            if (MessageBox.Show("Esta seguro que desea quitar esta solicitud?", "Quitar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in solicitudEntidadsAsignadas)
                {
                    if (item.Id == quitar)
                    {
                        solicitudEntidadsAsignadas.Remove(item);
                        break;
                    }
                }
                CargarSolucitudes();
            }

        }
        private void CargarAsignaciones()
        {
            if (solicitudEntidadsAsignadas.Count >= 1)
            {
                foreach (var item in solicitudEntidadsAsignadas)
                {
                    item.IdTecnico = usuarioSeleccionado.Id;
                    item.Respuesta = "";
                    item.Total = 0;
                    item.Estado = 1;
                    if (SolicitudNegocio.Guardar(item) == null)
                    {
                        MessageBox.Show("Error al asignar la solicitud" + " " + item.Id);
                    }
                }
                MessageBox.Show("Se han asignado todas las solicitudes");
                CargarDataGrint();
                CargarSolictudesTec();
                solicitudEntidadsAsignadas.Clear();
                dataGridView_Asignadas.DataSource = null;
            }
            else
                MessageBox.Show("Aun no hay ninguna solicitud");
        }
        private void EliminarAsignacion(int quitar)
        {
            if (MessageBox.Show("Esta seguro que desea quitarle esta solicitud a este tecnico?", "Quitar", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SolicitudEntidad solicitudEntidadEliminar = SolicitudNegocio.BuscarSolicitud(quitar);
                solicitudEntidadEliminar.Estado = 0;
                solicitudEntidadEliminar = SolicitudNegocio.Guardar(solicitudEntidadEliminar);

                if (solicitudEntidadEliminar != null)
                {
                    MessageBox.Show("Se ha quitado esa asigancion");
                    CargarDataGrint();
                    CargarSolictudesTec();
                }
                else
                {
                    MessageBox.Show("Error eliminar");
                }
                CargarSolucitudes();
            }
        }
        private void dataGridView_Tecnicos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuarioSeleccionado.Id = Convert.ToInt32(dataGridView_Tecnicos.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                usuarioSeleccionado.Nickname = dataGridView_Tecnicos.Rows[e.RowIndex].Cells["Nickname"].Value.ToString();
                textBox_Cedula.Text = usuarioSeleccionado.Nickname;
                label_Tecnico.Text = usuarioSeleccionado.Nickname;
                CargarSolictudesTec();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView_Solicitudes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (usuarioSeleccionado.Id != 0)
                {
                    int c = Convert.ToInt32(dataGridView_Solicitudes.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    if (ComprobarExistencia(c))
                    {
                        solicitudSeleccionado = SolicitudNegocio.BuscarSolicitud(c);
                        solicitudEntidadsAsignadas.Add(solicitudSeleccionado);
                        CargarSolucitudes();
                    }
                }
                else
                    MessageBox.Show("Primero debe seleccionar un tecnico");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView_Asignadas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int quitar = Convert.ToInt32(dataGridView_Asignadas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                QuitarLista(quitar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            CargarAsignaciones();
        }
        private void dataGridView_SolicitudesTec_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Q = Convert.ToInt32(dataGridView_SolicitudesTec.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                EliminarAsignacion(Q);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

