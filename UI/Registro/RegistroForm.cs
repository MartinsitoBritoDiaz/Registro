using Registro.BLL;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.UI.Registro
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            MatriculaMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
            SexoComboBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Estudiantes LLenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(IdNumericUpDown.Value);
            estudiante.Nombres = NombreTextBox.Text;
            estudiante.Apellidos = ApellidoTextBox.Text;
            estudiante.Cedula = CedulaMaskedTextBox.Text;
            estudiante.Matricula = MatriculaMaskedTextBox.Text;
            estudiante.Telefono = TelefonoMaskedTextBox.Text;
            estudiante.Celular = CelularMaskedTextBox.Text;
            estudiante.Email = EmailTextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            estudiante.Sexo = SexoComboBox.SelectedIndex;

            return estudiante;
        }
        
        private void LLenaCampo(Estudiantes estudiante)
        {
            IdNumericUpDown.Value = estudiante.EstudianteId;
            NombreTextBox.Text = estudiante.Nombres;
            ApellidoTextBox.Text = estudiante.Apellidos;
            CedulaMaskedTextBox.Text = estudiante.Cedula;
            MatriculaMaskedTextBox.Text = estudiante.Matricula;
            TelefonoMaskedTextBox.Text = estudiante.Telefono;
            CelularMaskedTextBox.Text = estudiante.Celular;
            EmailTextBox.Text = estudiante.Email;
            FechaNacimientoDateTimePicker.Value = estudiante.FechaNacimiento;
            SexoComboBox.SelectedIndex = estudiante.Sexo;
            BalanceTextBox.Text = Convert.ToString(estudiante.Balance);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LLenaClase();

            if(IdNumericUpDown.Value == 0)
                paso = EstudiantesBLL.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBLL.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardar!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiantes estudiante = EstudiantesBLL.Buscar((int)IdNumericUpDown.Value);

            return (estudiante != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                MyErrorProvider.SetError(ApellidoTextBox, "El campo Apellido no puede estar vacio");
                ApellidoTextBox.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(MatriculaMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(MatriculaMaskedTextBox, "El campo Matricula no puede estar vacio");
                MatriculaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El campo Telefono no puede estar vacio");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo Celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SexoComboBox.Text))
            {
                MyErrorProvider.SetError(SexoComboBox, "El campo Sexo no puede estar vacio");
                SexoComboBox.Focus();
                paso = false;
            }


            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            id = Convert.ToInt32(IdNumericUpDown.Value);

            Limpiar();

            estudiante = EstudiantesBLL.Buscar(id);

            if(estudiante != null)
            {
                LLenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (EstudiantesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar una persona que no existe");
        }

        private void SexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BalanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
