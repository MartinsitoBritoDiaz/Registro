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

namespace Registro.UI.Consulta
{
    public partial class ConsultaInscripcionForm : Form
    {
        public ConsultaInscripcionForm()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripciones>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = InscripcionesBLL.GetList(p => true);
                        break;
                    
                    case 1:
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = InscripcionesBLL.GetList(p => p.InscripcionId == id);
                            break;
                        }
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = InscripcionesBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
