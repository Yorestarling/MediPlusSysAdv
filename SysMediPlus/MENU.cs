using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysMediPlus.InsideForms;
using SysMediPlus.InsideForms.Doctores;
using SysMediPlus.InsideForms.Citas;
using DataAccess;
using System.Linq;

namespace SysMediPlus
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PACIENTES pacientes = new PACIENTES();
            pacientes.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctores doctores = new FrmDoctores();
            doctores.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();
            citas.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            using (var db = new MediPlusSysContext())
            {
                var Cidb = new Usuario();

                LblSesion.Text = " " + Cidb.NombreDeUsuario;
            }
            
        }
    }
}
