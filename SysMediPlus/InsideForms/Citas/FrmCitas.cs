using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysMediPlus.InsideForms.Citas
{
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCrearCitas citas = new FrmCrearCitas();
            citas.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerCitasFRm cita = new VerCitasFRm();
            cita.ShowDialog();
        }
    }
}
