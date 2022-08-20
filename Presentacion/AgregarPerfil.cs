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
    public partial class AgregarPerfil : Form
    {
        UsuarioEntidad usuarioEntidad = new UsuarioEntidad();

        public AgregarPerfil()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            comboBox_TipoPerfil.DataSource = UsuarioNegocio.TiposUsuarios();
            comboBox_TipoPerfil.DisplayMember = "Tipo";
            comboBox_TipoPerfil.ValueMember = "Id";

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            CrearNuevoPerfil();
        }
        private void CrearNuevoPerfil()
        {
            try
            {
                if (ControlDatos())
                {
                    usuarioEntidad.Nombre = rjTextBox_Nombre.Texts;
                    usuarioEntidad.Apellido = rjTextBox_Apellido.Texts;
                    usuarioEntidad.Nickname = rjTextBox_nICKNAME.Texts;
                    usuarioEntidad.Contraseña = rjTextBox_Contrasenia.Texts;
                    usuarioEntidad.NumPerfil = ((TipoPerfilEntidad)(comboBox_TipoPerfil.SelectedValue)).Id;

                    UsuarioEntidad usuarioEntidadRespadldo = usuarioEntidad;
                    usuarioEntidad = UsuarioNegocio.Guardar(usuarioEntidad);
                    if (usuarioEntidad != null)
                    {
                        MessageBox.Show("Se ha guardado");
                        iconButton_Error.Visible = false;
                        label_Error.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(Mensajes.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usuarioEntidad = usuarioEntidadRespadldo;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: datos no validos");
            }
        }
        private bool ControlDatos()
        {
            UsuarioEntidad usuarioEntidadBuscado = UsuarioNegocio.BuscarUsuarioNickname(rjTextBox_nICKNAME.Texts);
            if (usuarioEntidadBuscado != null)
            {
                if (rjTextBox_Nombre.Texts == "" || rjTextBox_Apellido.Texts == "" ||
                                rjTextBox_nICKNAME.Texts == "" || rjTextBox_Contrasenia.Texts == "" ||
                                comboBox_TipoPerfil.Text == "")
                {
                    MostrarError(Mensajes.FaltanDatos);
                    return false;
                }
                else if (rjTextBox_nICKNAME.Texts == usuarioEntidadBuscado.Nickname)
                {
                    MostrarError(Mensajes.YaExisteNickname);
                    return false;
                }
                else if (rjTextBox_nICKNAME.Texts.Length > 20)
                {
                    MostrarError(Mensajes.ErrorNickname);
                    return false;
                }
                else
                {
                    foreach (var item in comboBox_TipoPerfil.Items)
                    {
                        if (item.ToString().Equals(comboBox_TipoPerfil.Text))
                        {
                            return true;
                        }
                    }
                }
                MostrarError(Mensajes.PerfilNoValido);
                return false;
            }
            else
            {
                MessageBox.Show("A ocurrido un error en los datos");
                return false;
            }
        }

        private void MostrarError(string v)
        {
            label_Error.Text = v;
            label_Error.ForeColor = Color.Red;
            iconButton_Error.Visible = true;
            label_Error.Visible = true;
        }

        private void rjTextBox_Apellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            rjTextBox_Nombre.Texts = "";
            rjTextBox_Apellido.Texts = "";
            rjTextBox_nICKNAME.Texts = "";
            rjTextBox_Contrasenia.Texts = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
