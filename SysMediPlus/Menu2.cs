using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SysMediPlus.InsideForms.Citas;
using DataAccess;

namespace SysMediPlus
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();
            citas.ShowDialog();
        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            using (var db = new MediPlusSysContext())
            {
                var Cidb = new Usuario();

                LblSesion.Text = " " + Cidb.NombreDeUsuario;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
