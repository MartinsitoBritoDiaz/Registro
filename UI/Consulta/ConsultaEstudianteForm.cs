﻿using Registro.BLL;
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
    public partial class ConsultaEstudianteForm : Form
    {
        public ConsultaEstudianteForm()
        {
            InitializeComponent();
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = EstudiantesBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = EstudiantesBLL.GetList(p => p.EstudianteId == id);
                        break;

                    case 2:
                        listado = EstudiantesBLL.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        listado = EstudiantesBLL.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                        break;

                    case 4:
                        listado = EstudiantesBLL.GetList(p => p.Matricula.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.FechaNacimiento.Date >= DesdeDateTimePicker.Value.Date && c.FechaNacimiento.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = EstudiantesBLL.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

        private void ConsultaEstudianteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
