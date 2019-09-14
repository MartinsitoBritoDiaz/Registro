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

namespace Registro.UI.Inscripcion
{
    public partial class InscripcionForm : Form
    {
        public InscripcionForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            InscripcionIdNumericUpDown.Value = 0;
            EstudianteIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            MontoTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            ComentariosRichTextBox.Text = string.Empty;
        }

        private void InscripcionForm_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Inscripciones LlenaClase()
        {
            decimal monto;
            decimal deposito;

            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            inscripcion.EstudianteId = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.Monto = Convert.ToDecimal(MontoTextBox.Text);
            inscripcion.Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            monto = Convert.ToDecimal(MontoTextBox.Text);
            deposito = Convert.ToDecimal(DepositoTextBox.Text);

            inscripcion.Comentario = ComentariosRichTextBox.Text;

            if (Convert.ToDecimal(BalanceTextBox.Text + "0") > 0)
            {
                EstudiantesBLL.GuardarBalance(Convert.ToInt32(EstudianteIdNumericUpDown.Value), (-1 * deposito));
                inscripcion.Balance = (Convert.ToDecimal(BalanceTextBox.Text) - deposito);
            }
            else
            {
                EstudiantesBLL.GuardarBalance(Convert.ToInt32(EstudianteIdNumericUpDown.Value), (monto - deposito));
                inscripcion.Balance = (monto - deposito);
            }

            return inscripcion;
        }

        private void LLenaCampo(Inscripciones inscripcion)
        {
            InscripcionIdNumericUpDown.Value = inscripcion.InscripcionId;
            EstudianteIdNumericUpDown.Value = inscripcion.EstudianteId;
            FechaDateTimePicker.Value = inscripcion.Fecha;
            MontoTextBox.Text = Convert.ToString(inscripcion.Monto);
            DepositoTextBox.Text = Convert.ToString(inscripcion.Deposito);
            BalanceTextBox.Text = Convert.ToString(inscripcion.Balance);
            ComentariosRichTextBox.Text = inscripcion.Comentario;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion;
            bool paso = false;

            if (!Validar())
                return;

            inscripcion = LlenaClase();

            if(EstudiantesBLL.Buscar(inscripcion.EstudianteId) != null)
            {
                if (InscripcionIdNumericUpDown.Value == 0)
                    paso = InscripcionesBLL.Guardar(inscripcion);
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar una inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    paso = InscripcionesBLL.Modificar(inscripcion);
                }

                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", " Exito ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No fue posible guardar !!", " Fallo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No fue posible guardar el estudiante no existe", " Fallo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Inscripciones inscripcion = InscripcionesBLL.Buscar((int)InscripcionIdNumericUpDown.Value);
            return (inscripcion != null);
        }

        private bool Validar()
        {
            decimal monto;
            decimal deposito;

            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(MontoTextBox.Text))
            {
                MyerrorProvider.SetError(MontoTextBox, " El campo monto no puede estar vacio. ");
                MontoTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text))
            {
                MyerrorProvider.SetError(DepositoTextBox, " El campo deposito no puede estar vacio. ");
                DepositoTextBox.Focus();
                paso = false;
            }

            monto = Convert.ToDecimal(MontoTextBox.Text);
            deposito = Convert.ToDecimal(DepositoTextBox.Text);

            if (deposito > monto)
            {
                MyerrorProvider.SetError(DepositoTextBox, " El campo deposito no puede ser mayor que el campo monto. ");
                DepositoTextBox.Focus();

                MyerrorProvider.SetError(MontoTextBox, " El campo monto no puede ser menor que el campo deposito. ");
                MontoTextBox.Focus();
                paso = false;
            }

            //todo: Recordame habilitarlo si el balance no va readonly en inscripciones
            /*if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
            {
                MyerrorProvider.SetError(BalanceTextBox, " El campo balance no puede estar vacio. ");
                BalanceTextBox.Focus();
                paso = false;
            }*/

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones inscripcion = new Inscripciones();
            id = Convert.ToInt32(InscripcionIdNumericUpDown.Value);

            Limpiar();

            inscripcion = InscripcionesBLL.Buscar(id);

            if(inscripcion != null)
            {
                LLenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("Inscripcion no encontrada");
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();

            int id;
            id = (int) InscripcionIdNumericUpDown.Value;
            Inscripciones inscripcion = new Inscripciones();
                 
            inscripcion = InscripcionesBLL.Buscar(id);
            Limpiar();

            if (InscripcionesBLL.Eliminar(id))
            {
                EstudiantesBLL.GuardarBalance(inscripcion.EstudianteId, (-1 * inscripcion.Balance));
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MyerrorProvider.SetError(InscripcionIdNumericUpDown, "No se puede eliminar una inscripcion que no existe");
        }

    }
}
