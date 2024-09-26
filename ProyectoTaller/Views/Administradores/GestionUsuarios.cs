using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            string puesto = CBPuesto.SelectedItem?.ToString();
            string dnitexto = TDni.Text;
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string telefonotexto = TTelefono.Text;
            string email = TEmail.Text;
            string sexo = CBSexo.SelectedItem?.ToString();
            string sueldotexto = TSueldo.Text;

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

            if (valido)
            {
                LimpiarMensajesDeValidacion();

                if (editando)
                {
                    DataGridViewRow filaSeleccionada = DGUsuarios.Rows[filaSeleccionadaIndex];
                    filaSeleccionada.Cells["CPuesto"].Value = CBPuesto.SelectedItem.ToString();
                    filaSeleccionada.Cells["CDni"].Value = TDni.Text;
                    filaSeleccionada.Cells["CNombre"].Value = TNombre.Text;
                    filaSeleccionada.Cells["CApellido"].Value = TApellido.Text;
                    filaSeleccionada.Cells["CTelefono"].Value = TTelefono.Text;
                    filaSeleccionada.Cells["CEmail"].Value = TEmail.Text;
                    filaSeleccionada.Cells["CSexo"].Value = CBSexo.SelectedItem.ToString();
                    filaSeleccionada.Cells["CSueldo"].Value = TSueldo.Text;

                    LValido.Text = "Usuario editado exitosamente.";

                    editando = false;
                }
                else
                {
                    DGUsuarios.Rows.Add(CBPuesto.SelectedItem.ToString(), TDni.Text, TNombre.Text, TApellido.Text, TTelefono.Text, TEmail.Text, CBSexo.SelectedItem.ToString(), TSueldo.Text);

                    LValido.Text = "Usuario agregado exitosamente.";
                }

                CBPuesto.SelectedIndex = -1;
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                TTelefono.Clear();
                TEmail.Clear();
                CBSexo.SelectedIndex = -1;
                TSueldo.Clear();
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            CBPuesto.SelectedIndex = -1;
            TDni.Clear();
            TNombre.Clear();
            TApellido.Clear();
            TTelefono.Clear();
            TEmail.Clear();
            CBSexo.SelectedIndex = -1;
            TSueldo.Clear();

            LValido.Text = string.Empty;
            LimpiarMensajesDeValidacion();
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiPuesto.Text = string.Empty;
            LValiDni.Text = string.Empty;
            LValiNombre.Text = string.Empty;
            LValiApellido.Text = string.Empty;
            LValiTelefono.Text = string.Empty;
            LValiEmail.Text = string.Empty;
            LValiSexo.Text = string.Empty;
            LValiSueldo.Text = string.Empty;
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            if (DGUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGUsuarios.SelectedRows[0];
                filaSeleccionadaIndex = filaSeleccionada.Index;

                CBPuesto.SelectedItem = filaSeleccionada.Cells["CPuesto"].Value.ToString();
                TDni.Text = filaSeleccionada.Cells["CDni"].Value.ToString();
                TNombre.Text = filaSeleccionada.Cells["CNombre"].Value.ToString();
                TApellido.Text = filaSeleccionada.Cells["CApellido"].Value.ToString();
                TTelefono.Text = filaSeleccionada.Cells["CTelefono"].Value.ToString();
                TEmail.Text = filaSeleccionada.Cells["CEmail"].Value.ToString();
                CBSexo.SelectedItem = filaSeleccionada.Cells["CSexo"].Value.ToString();
                TSueldo.Text = filaSeleccionada.Cells["CSueldo"].Value.ToString();

                editando = true;
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
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGUsuarios.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
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
            DGUsuarios.Rows.Add("Administrador", "42733217", "Celso", "Brollo", "3624274989", "celsobrollo@gmail.com", "Masculino", "500000");
            DGUsuarios.Rows.Add("Vendedor", "37654321", "María", "González", "0987654321", "mariagonzalez@gmail.com", "Femenino", "40000");
            DGUsuarios.Rows.Add("Gerente", "11223344", "Carlos", "Fernández", "1231231234", "carlosfernandez@gmail.com", "Masculino", "60000");
            DGUsuarios.Rows.Add("Gerente", "44332211", "Ana", "Martínez", "3213214321", "anamartinez@hotmail.com", "Femenino", "35000");
            DGUsuarios.Rows.Add("Vendedor", "45667788", "Pedro", "Sánchez", "6546546546", "pedrosanchez@gmail.com", "Masculino", "45000");
        }

        private void TBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            string filtro = TBuscarUsuarios.Text.ToLower();
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (fila.Cells["CNombre"].Value != null)
                {
                    string dni = fila.Cells["CDni"].Value.ToString().ToLower();
                    string nombre = fila.Cells["CNombre"].Value.ToString().ToLower();
                    string apellido = fila.Cells["CApellido"].Value.ToString().ToLower();
                    string telefono = fila.Cells["CTelefono"].Value.ToString().ToLower();
                    string email = fila.Cells["CEmail"].Value.ToString().ToLower();

                    if (dni.Contains(filtro) || nombre.Contains(filtro) || apellido.Contains(filtro) || telefono.Contains(filtro) || email.Contains(filtro))
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
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (CBGerente.Checked)
                    {
                        if (fila.Cells["CPuesto"].Value.ToString() == "Gerente")
                        {
                            fila.Visible = true;
                        }
                        else
                        {
                            fila.Visible = false;
                        }
                    }
                    else
                    {
                        fila.Visible = true;
                    }
                }
            }
        }

        private void CBVendedor_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (CBVendedor.Checked)
                    {
                        if (fila.Cells["CPuesto"].Value.ToString() == "Vendedor")
                        {
                            fila.Visible = true;
                        }
                        else
                        {
                            fila.Visible = false;
                        }
                    }
                    else
                    {
                        fila.Visible = true;
                    }
                }
            }
        }

        private void CBAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (CBAdministrador.Checked)
                    {
                        if (fila.Cells["CPuesto"].Value.ToString() == "Administrador")
                        {
                            fila.Visible = true;
                        }
                        else
                        {
                            fila.Visible = false;
                        }
                    }
                    else
                    {
                        fila.Visible = true;
                    }
                }
            }
        }
    }
}
