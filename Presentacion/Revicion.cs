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
    public partial class Revicion : Form
    {
        private SolicitudEntidad solicitudEntidad { get; set; }
        List<SolicitudEntidad> solicitudEntidads = new List<SolicitudEntidad>();
        public Revicion()
        {
            InitializeComponent();
            CargarListas();
        }

        private void CargarListas()
        {
            foreach (var item in SolicitudNegocio.ListaSolicitudesCompleta())
            {
                    if (item.Estado == 1)
                        solicitudEntidads.Add(item);
            }
            dataGridView_Realizadas.DataSource = solicitudEntidads;
            dataGridView_Realizadas.Columns["Id"].Visible = false;
            dataGridView_Realizadas.Columns["IdUsuario"].Visible = false;
            dataGridView_Realizadas.Columns["IdTecnico"].Visible = false;
            dataGridView_Realizadas.Columns["Estado"].Visible = false;
        }

        private void dataGridView_Realizadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Q = Convert.ToInt32(dataGridView_Realizadas.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                CargarDatos(Q);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no ha seleccionado una fila valida" +
                    " " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos(int q)
        {
            foreach (var item in solicitudEntidads)
            {
                if (item.Id == q)
                {
                    solicitudEntidad = item;
                }
            }
            Fecha.Text = solicitudEntidad.FechaEnvio.ToString();
            label_Descripcion.Text = solicitudEntidad.Descripcion;
            label_Requisitos.Text = solicitudEntidad.Respuesta;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                solicitudEntidad.Total = Convert.ToSingle(textBox_Total.Text);
                solicitudEntidad = SolicitudNegocio.Guardar(solicitudEntidad);
                if (solicitudEntidad != null)
                {
                    MessageBox.Show("Se ha enviado el total");
                    solicitudEntidad.Estado = 2;
                    SolicitudNegocio.Guardar(solicitudEntidad);
                    CargarListas();
                }
                else
                    MessageBox.Show("A ocurrido un error al enviar el total");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro el valor no es valido");
            }
        }

        private void textBox_Total_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}

