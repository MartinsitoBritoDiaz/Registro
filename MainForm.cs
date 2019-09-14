using Registro.UI.Consulta;
using Registro.UI.Inscripcion;
using Registro.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registroFormulario = new RegistroForm();
            registroFormulario.MdiParent = this;
            registroFormulario.Show();
        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEstudianteForm consultaFormulario = new ConsultaEstudianteForm();
            consultaFormulario.MdiParent = this;
            consultaFormulario.Show();
        }
        
        private void EstudiantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaInscripcionForm consultaInscripcionForm = new ConsultaInscripcionForm();
            consultaInscripcionForm.MdiParent = this;
            consultaInscripcionForm.Show();
        }

        private void InscripcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            InscripcionForm inscripcionFormulario = new InscripcionForm();
            inscripcionFormulario.MdiParent = this;
            inscripcionFormulario.Show();
        }
    }
}
