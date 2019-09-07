using Registro.UI.Consulta;
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
            registroFormulario.Show();
        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaForm consultaFormulario = new ConsultaForm();
            consultaFormulario.Show();
        }
    }
}
