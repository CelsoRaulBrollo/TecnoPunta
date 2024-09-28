using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class GestionUsuarios : Form
    {
        private bool editando = false;
        private int filaSeleccionadaIndex = -1;

        public GestionUsuarios()
        {
            InitializeComponent();
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

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                LValiEmail.ForeColor = Color.Red;
                LValiEmail.Text = "Ingrese un email válido.";
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

                if (editando)
                {
                    if (filaSeleccionadaIndex >= 0)
                    {
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CPuesto"].Value = CBPuesto.SelectedItem.ToString();
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CUsuario"].Value = TUsuario.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CDni"].Value = TDni.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CNombre"].Value = TNombre.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CApellido"].Value = TApellido.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CEmail"].Value = TEmail.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CSexo"].Value = CBSexo.SelectedItem.ToString();
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CSueldo"].Value = TSueldo.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CTelefono"].Value = TTelefono.Text;
                        DGUsuarios.Rows[filaSeleccionadaIndex].Cells["CContraseña"].Value = TContraseña.Text;

                        LimpiarMensajesDeValidacion();
                        LValido.Text = "Usuario editado exitosamente.";

                        editando = false;
                        filaSeleccionadaIndex = -1;
                    }
                }
                else
                {
                    if (!ValidarDni(TDni.Text))
                    {
                        return;
                    }

                    DGUsuarios.Rows.Add(CBPuesto.SelectedItem.ToString(), TUsuario.Text, TDni.Text, TNombre.Text, TApellido.Text, TEmail.Text, CBSexo.SelectedItem.ToString(), TSueldo.Text, TTelefono.Text, TContraseña.Text);

                    LValido.Text = "Usuario agregado exitosamente.";
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
                    DataGridViewRow filaSeleccionada = DGUsuarios.SelectedRows[0];
                    filaSeleccionadaIndex = filaSeleccionada.Index;

                    CBPuesto.SelectedItem = filaSeleccionada.Cells["CPuesto"].Value.ToString();
                    TUsuario.Text = filaSeleccionada.Cells["CUsuario"].Value.ToString();
                    TDni.Text = filaSeleccionada.Cells["CDni"].Value.ToString();
                    TNombre.Text = filaSeleccionada.Cells["CNombre"].Value.ToString();
                    TApellido.Text = filaSeleccionada.Cells["CApellido"].Value.ToString();
                    TEmail.Text = filaSeleccionada.Cells["CEmail"].Value.ToString();
                    CBSexo.SelectedItem = filaSeleccionada.Cells["CSexo"].Value.ToString();
                    TSueldo.Text = filaSeleccionada.Cells["CSueldo"].Value.ToString();
                    TTelefono.Text = filaSeleccionada.Cells["CTelefono"].Value.ToString();
                    TContraseña.Text = filaSeleccionada.Cells["CContraseña"].Value.ToString();

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
                    foreach (DataGridViewRow row in DGUsuarios.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DGUsuarios.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            DGUsuarios.Rows.Add("Administrador", "CelsoBro", "42733217", "Celso", "Brollo", "celsobrollo@gmail.com", "Masculino", "500000", "3624274989", "12345");
            DGUsuarios.Rows.Add("Vendedor", "MariaGon", "37654321", "María", "González", "mariagonzalez@gmail.com", "Femenino", "40000", "0987654321", "37654321");
            DGUsuarios.Rows.Add("Gerente", "CarlosFernan", "11223344", "Carlos", "Fernández", "carlosfernandez@gmail.com", "Masculino", "60000", "1231231234", "784512963");
            DGUsuarios.Rows.Add("Gerente", "AnaMarti", "44332211", "Ana", "Martínez", "anamartinez@hotmail.com", "Femenino", "35000", "3213214321", "Ana5588");
            DGUsuarios.Rows.Add("Vendedor", "PedroSan", "45667788", "Pedro", "Sánchez", "pedrosanchez@gmail.com", "Masculino", "45000", "6546546546", "35687qwe");
        }

        private void TBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            string filtro = TBuscarUsuarios.Text.ToLower();
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (fila.Cells["CNombre"].Value != null)
                {
                    string usuario = fila.Cells["CUsuario"].Value.ToString().ToLower();
                    string dni = fila.Cells["CDni"].Value.ToString().ToLower();
                    string nombre = fila.Cells["CNombre"].Value.ToString().ToLower();
                    string apellido = fila.Cells["CApellido"].Value.ToString().ToLower();
                    string telefono = fila.Cells["CTelefono"].Value.ToString().ToLower();
                    string email = fila.Cells["CEmail"].Value.ToString().ToLower();

                    if (usuario.Contains(filtro) || dni.Contains(filtro) || nombre.Contains(filtro) || apellido.Contains(filtro) || telefono.Contains(filtro) || email.Contains(filtro))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
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
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (CBGerente.Checked && fila.Cells["CPuesto"].Value.ToString() == "Gerente")
                    {
                        fila.Visible = true;
                    }
                    else if (CBVendedor.Checked && fila.Cells["CPuesto"].Value.ToString() == "Vendedor")
                    {
                        fila.Visible = true;
                    }
                    else if (CBAdministrador.Checked && fila.Cells["CPuesto"].Value.ToString() == "Administrador")
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }
    }
}