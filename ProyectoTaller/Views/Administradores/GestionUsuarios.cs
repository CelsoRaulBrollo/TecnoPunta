using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoTaller.Views.Administradores
{
    public partial class GestionUsuarios : Form
    {
        private UsuarioNegocio usuariosNegocio;
        private bool editando = false;
        private int filaSeleccionadaIndex = -1;

        public GestionUsuarios()
        {
            InitializeComponent();
            usuariosNegocio = new UsuarioNegocio();
            cargarComboRol();
            cargarComboSexo();
            GestionUsuarios_Load();
            DGUsuarios.RowPostPaint += DGUsuarios_RowPostPaint;

        }

        public void cargarComboRol()
        {
            RolNegocio rolDatos = new RolNegocio();
            List<Rol> roles = rolDatos.ListarRoles();
            CBPuesto.DataSource = roles;
            CBPuesto.DisplayMember = "Descripcion_Rol";
            CBPuesto.ValueMember = "Id_Rol"; 
        }

        public void cargarComboSexo()
        {
            SexoNegocio sexoDatos = new SexoNegocio();
            List<Sexo> sexos = sexoDatos.ListarSexo();
            CBSexo.DataSource = sexos;
            CBSexo.DisplayMember = "Descripcion_Sexo";
            CBSexo.ValueMember = "Id_Sexo";
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            BAgregar.Text = "Agregar";

            string puesto = CBPuesto.SelectedItem?.ToString();
            string usuario = TUsuario.Text;
            string dnitexto = TDni.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string telefonotexto = TTelefono.Text;
            string email = TEmail.Text;
            string sexo = CBSexo.SelectedItem?.ToString();
            string sueldotexto = TSueldo.Text;
            string contraseña = TContraseña.Text;

            bool valido = true;

            long telefonotextoLONG;
            long.TryParse(telefonotexto, out telefonotextoLONG);

            if (string.IsNullOrEmpty(puesto))
            {
                LValiPuesto.ForeColor = Color.Red;
                LValiPuesto.Text = "Seleccione un Puesto.";
                valido = false;
            }
            else
            {
                LValiPuesto.Text = string.Empty;
            }

            
            if (string.IsNullOrWhiteSpace(dnitexto))
            {
                LValiDni.ForeColor = Color.Red;
                LValiDni.Text = "Ingrese un número de DNI.";
                valido = false;
            }
            else if (!int.TryParse(dnitexto, out int dni))
            {
                LValiDni.ForeColor = Color.Red;
                LValiDni.Text = "El DNI solo debe contener números.";
                valido = false;
            }
            else if (dnitexto.Length != 8 || !dnitexto.All(char.IsDigit))
            {
                LValiDni.ForeColor = Color.Red;
                LValiDni.Text = "el DNI debe ser de 8 digitos.";
                valido = false;
            }
            else
            {
                LValiDni.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Ingrese el Nombre.";
                valido = false;
            }
            else if (nombre.Length < 3)
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Nombre de al menos 3 caracteres.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z]"))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "El Nombre debe contener solo letras.";
                valido = false;
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                LValiApellido.ForeColor = Color.Red;
                LValiApellido.Text = "Ingrese el Apellido.";
                valido = false;
            }
            else if (apellido.Length < 3)
            {
                LValiApellido.ForeColor = Color.Red;
                LValiApellido.Text = "Apellido de al menos 3 caracteres.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(apellido, @"^[a-zA-Z]"))
            {
                LValiApellido.ForeColor = Color.Red;
                LValiApellido.Text = "El Apellido debe contener solo letras.";
                valido = false;
            }
            else
            {
                LValiApellido.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(telefonotexto))
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un Teléfono.";
                valido = false;
            }
            else if (telefonotexto.Length < 8 || telefonotexto.Length > 15 || !telefonotexto.All(char.IsDigit))
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un Teléfono válido (de 8 a 15 dígitos).";
                valido = false;
            }
            else
            {
                LValiTelefono.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                LValiEmail.ForeColor = Color.Red;
                LValiEmail.Text = "Ingrese un email.";
                valido = false;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                LValiEmail.ForeColor = Color.Red;
                LValiEmail.Text = "El email debe contener @ t (.).";
                valido = false;
            }
            else
            {
                LValiEmail.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(sexo))
            {
                LValiSexo.ForeColor = Color.Red;
                LValiSexo.Text = "Seleccione el sexo.";
                valido = false;
            }
            else
            {
                LValiSexo.Text = string.Empty;
            }

            if (!decimal.TryParse(sueldotexto, out decimal sueldo) || sueldo <= 0)
            {
                LValiSueldo.ForeColor = Color.Red;
                LValiSueldo.Text = "Ingrese un sueldo válido (número mayor a 0).";
                valido = false;
            }
            else
            {
                LValiSueldo.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                LValiUsuario.ForeColor = Color.Red;
                LValiUsuario.Text = "Ingrese el Usuario.";
                valido = false;
            }
            else if (usuario.Length < 4)
            {
                LValiUsuario.ForeColor = Color.Red;
                LValiUsuario.Text = "Usuario de al menos 4 caracteres.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(usuario, @"^[a-zA-Z]"))
            {
                LValiUsuario.ForeColor = Color.Red;
                LValiUsuario.Text = "El Usuario debe contener solo letras.";
                valido = false;
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                LValiContraseña.ForeColor = Color.Red;
                LValiContraseña.Text = "Ingrese una Contraseña.";
                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(contraseña, @"^[a-zA-Z0-9]"))
            {
                LValiContraseña.ForeColor = Color.Red;
                LValiContraseña.Text = "La Contraseña debe contener solo letras y números.";
                valido = false;
            }
            else if (contraseña.Length < 5 || contraseña.Length > 20)
            {
                LValiContraseña.ForeColor = Color.Red;
                LValiContraseña.Text = "Contraseña de 5 a 20 caracteres.";
                valido = false;
            }
            else
            {
                LValiContraseña.Text = string.Empty;
            }

            if (valido)
            {
                LimpiarMensajesDeValidacion();

                string mensaje = editando ? "¿Está seguro que desea modificar este usuario?" : "¿Está seguro que desea agregar el usuario?";
                var result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    if (editando)
                    {
                        if (filaSeleccionadaIndex >= 0)
                        {
                            
                           
                            usuariosNegocio = new UsuarioNegocio();
                            usuariosNegocio.EditarUsuario(GenerarUsuario());


                            LimpiarMensajesDeValidacion();
                            LValido.Text = "Usuario editado exitosamente.";
                            GestionUsuarios_Load();
                            TDni.ReadOnly = false;
                            TDni.BackColor = Color.White;
                            
                        }

                        editando = false;
                        filaSeleccionadaIndex = -1;

                    }
                    else
                    {
                        /*if (!ValidarDni(TDni.Text))
                        {
                            return;
                        }*/



                        Usuario usuarioGuardar = new Usuario
                        {
                            Nombre_Usuario = nombre,
                            Apellido_Usuario = apellido,
                            DNI_Usuario = Convert.ToInt32(dnitexto),
                            Sueldo_Usuario = Convert.ToInt32(sueldotexto),
                            Telefono_Usuario = telefonotexto,
                            Correo_Usuario = email,
                            Contraseña = contraseña,
                            Usuario_Login = usuario,
                            Sexo_Usuario = (int)CBSexo.SelectedValue,
                            Rol_Usuario = (int)CBPuesto.SelectedValue
                     
                        };


                        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                        usuarioNegocio.GuardarUsuario(usuarioGuardar);
                        GestionUsuarios_Load();
                        LValido.Text = "Usuario agregado exitosamente.";
                    }
                }

                CBPuesto.SelectedIndex = -1;
                TUsuario.Clear();
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                TEmail.Clear();
                CBSexo.SelectedIndex = -1;
                TSueldo.Clear();
                TTelefono.Clear();
                TContraseña.Clear();
            }
        }

        private bool ValidarDni(string dniTexto)
        {
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (fila.Cells["CDni"].Value != null && fila.Cells["CDni"].Value.ToString() == dniTexto)
                {
                    LValiDni.ForeColor = Color.Red;
                    LValiDni.Text = "El DNI ya está registrado.";
                    return false;
                }
            }

            LValiDni.Text = string.Empty;
            return true;
        }

        public Usuario GenerarUsuario()
        {
            Usuario usuarioGuardar = new Usuario
            {
                Nombre_Usuario = TUsuario.Text,
                Apellido_Usuario = TApellido.Text,
                DNI_Usuario = Convert.ToInt32(TDni.Text),
                Sueldo_Usuario = Convert.ToDecimal(TSueldo.Text),
                Telefono_Usuario = TTelefono.Text,
                Correo_Usuario = TEmail.Text,
                Contraseña = TContraseña.Text,
                Usuario_Login = TUsuario.Text,
                Sexo_Usuario = (int)CBSexo.SelectedValue,
                Rol_Usuario = (int)CBPuesto.SelectedValue

            };

            return usuarioGuardar;
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar todos los datos?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (editando)
                {
                    CBPuesto.SelectedIndex = -1;
                    TUsuario.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TEmail.Clear();
                    CBSexo.SelectedIndex = -1;
                    TSueldo.Clear();
                    TTelefono.Clear();
                    TContraseña.Clear();
                    MessageBox.Show("Datos Borrados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CBPuesto.SelectedIndex = -1;
                    TUsuario.Clear();
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TEmail.Clear();
                    CBSexo.SelectedIndex = -1;
                    TSueldo.Clear();
                    TTelefono.Clear();
                    TContraseña.Clear();
                    MessageBox.Show("Datos Borrados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LValido.Text = string.Empty;
                LimpiarMensajesDeValidacion();
            }
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiPuesto.Text = string.Empty;
            LValiUsuario.Text = string.Empty;
            LValiDni.Text = string.Empty;
            LValiNombre.Text = string.Empty;
            LValiApellido.Text = string.Empty;
            LValiEmail.Text = string.Empty;
            LValiSexo.Text = string.Empty;
            LValiSueldo.Text = string.Empty;
            LValiTelefono.Text = string.Empty;
            LValiContraseña.Text = string.Empty;
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();

            if (DGUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea editar el usuario seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    RolNegocio rolNegocio = new RolNegocio();
                    SexoNegocio sexoNegocio = new SexoNegocio();

                    DataGridViewRow filaSeleccionada = DGUsuarios.SelectedRows[0];
                    filaSeleccionadaIndex = filaSeleccionada.Index;

                    CBPuesto.SelectedValue = rolNegocio.buscarIDRolPorDescripcion(filaSeleccionada.Cells["Rol"].Value.ToString());
                    TUsuario.Text = filaSeleccionada.Cells["Usuario"].Value.ToString();
                    TDni.Text = filaSeleccionada.Cells["DNI"].Value.ToString();
                    TNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    TApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                    TEmail.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                    CBSexo.SelectedValue = sexoNegocio.buscarIDSexoPorDescripcion(filaSeleccionada.Cells["Sexo"].Value.ToString()) ;
                    TSueldo.Text = filaSeleccionada.Cells["Sueldo"].Value.ToString();
                    TTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                    TContraseña.Text = filaSeleccionada.Cells["Contraseña"].Value.ToString();

                    TDni.ReadOnly = true;
                    TDni.BackColor = Color.LightGray;
                    editando = true;

                    BAgregar.Text = "Modificar";
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (DGUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    usuariosNegocio = new UsuarioNegocio();
                    DataGridViewRow filaSeleccionada = DGUsuarios.SelectedRows[0];
                    filaSeleccionadaIndex = filaSeleccionada.Index;
                    string dni = filaSeleccionada.Cells["DNI"].Value.ToString();

                    usuariosNegocio.actualizarEstado(int.Parse(dni));
                    cargarComboRol();
                    cargarComboSexo();
                    GestionUsuarios_Load();


                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                     
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionUsuarios_Load()
        {

            DGUsuarios.DataSource = usuariosNegocio.ListarUsuarios();
           


        }

        private void DGUsuarios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var estado = DGUsuarios.Rows[e.RowIndex].Cells["Estado"].Value;

            if (estado != null && estado.ToString() == "BAJA")
            {
                DGUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                DGUsuarios.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // Opcional
            }
        }

        private void TBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            string filtro = TBuscarUsuarios.Text.ToLower();
       
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (fila.Cells["Nombre"].Value != null)
                {
                    string dni = fila.Cells["DNI"].Value.ToString().ToLower();
                    string usuario = fila.Cells["Usuario"].Value.ToString().ToLower();
                    string nombre = fila.Cells["Nombre"].Value.ToString().ToLower();
                    string apellido = fila.Cells["Apellido"].Value.ToString().ToLower();
                    string correo = fila.Cells["Correo"].Value.ToString().ToLower();
                    string sueldo = fila.Cells["Sueldo"].Value.ToString().ToLower();
                    string telefono = fila.Cells["Telefono"].Value.ToString().ToLower();
                    string contraseña = fila.Cells["Contraseña"].Value.ToString().ToLower();
                    string sexo = fila.Cells["Sexo"].Value.ToString().ToLower();
                    string rol = fila.Cells["Rol"].Value.ToString().ToLower();


                    if (dni.Contains(filtro) ||  usuario.Contains(filtro) || nombre.Contains(filtro) || apellido.Contains(filtro) || correo.Contains(filtro) || sueldo.Contains(filtro) || telefono.Contains(filtro) || contraseña.Contains(filtro) || sexo.Contains(filtro) || rol.Contains(filtro))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
          
                        DGUsuarios.CurrentCell = null;
                        fila.Visible = false;

                    }
                }
            }
        }

        private void CBGerente_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBGerente está seleccionado
            if (CBGerente.Checked)
            {
                CBVendedor.Checked = false;
                CBAdministrador.Checked = false;
            }

            FiltrarPorPuesto();
        }

        private void CBVendedor_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBVendedor está seleccionado
            if (CBVendedor.Checked)
            {
                CBGerente.Checked = false;
                CBAdministrador.Checked = false;
            }

            FiltrarPorPuesto();
        }

        private void CBAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            // Desmarcar otros CheckBoxes si CBAdministrador está seleccionado
            if (CBAdministrador.Checked)
            {
                CBGerente.Checked = false;
                CBVendedor.Checked = false;
            }

            FiltrarPorPuesto();
        }

        private void FiltrarPorPuesto()
        {
            bool hayFiltroActivo = CBGerente.Checked || CBVendedor.Checked || CBAdministrador.Checked;

            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (!hayFiltroActivo)
                    {
                        fila.Visible = true;
                    }
                    else if (CBGerente.Checked && fila.Cells["Rol"].Value.ToString() == "Gerente")
                    {
                        fila.Visible = true;
                    }
                    else if (CBVendedor.Checked && fila.Cells["Rol"].Value.ToString() == "Vendedor")
                    {
                        fila.Visible = true;
                    }
                    else if (CBAdministrador.Checked && fila.Cells["Rol"].Value.ToString() == "Administrador")
                    {
                        fila.Visible = true;
                    }
                    else
                    {

                        DGUsuarios.CurrentCell = null;
                        fila.Visible = false;
                    }
                }
            }
        }
    }
}