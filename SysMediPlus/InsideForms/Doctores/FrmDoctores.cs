﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysMediPlus.InsideForms.Doctores
{
    public partial class FrmDoctores : Form
    {
        public FrmDoctores()
        {
            InitializeComponent();
        }

        private void BtnCrearD_Click(object sender, EventArgs e)
        {
            FrmCrearDoctores doctores = new FrmCrearDoctores();
            doctores.ShowDialog();
        }

        private void BtnVerD_Click(object sender, EventArgs e)
        {
            VerDoctoresFrm doctores = new VerDoctoresFrm();
            doctores.ShowDialog();
        }
    }
}
