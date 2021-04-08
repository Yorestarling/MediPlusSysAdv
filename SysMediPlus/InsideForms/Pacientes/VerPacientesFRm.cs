using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace SysMediPlus.InsideForms
{
    public partial class VerPacientesFRm : Form
    {
        public VerPacientesFRm()
        {
            InitializeComponent();
        }

        private void VerPacientesFRm_Load(object sender, EventArgs e)
        {
            using var db = new MediPlusSysContext();


            //dataGridView1.DataSource = db.Pacientes.ToList();


            var PacientesData = from c in db.Pacientes select c;

            if (PacientesData != null)
            {

                if (PacientesData.Count() > 0)
                {
                    dataGridViewPacientes.DataSource = PacientesData.ToList();
                }
                else
                {
                    MessageBox.Show("Nada");
                    dataGridViewPacientes.DataSource = null;
                }
            }

        }
    }
}
