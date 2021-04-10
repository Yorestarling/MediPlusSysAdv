using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysMediPlus.InsideForms;
using SysMediPlus.InsideForms.Pacientes;

namespace SysMediPlus.InsideForms
{
    public partial class PACIENTES : Form
    {
        public PACIENTES()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MENU men = new MENU();
            men.ShowDialog();

            //this.Close();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerPacientesFRm ver = new VerPacientesFRm();
            ver.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCrearPacientes pacientes = new FrmCrearPacientes();
            pacientes.ShowDialog();
        }
    }
}
