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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            using (var db = new MediPlusSysContext())
            {

                //var o = new Usuario();

                //var pac2 = db.Usuarios.ToList().Find(X=>X.NombreDeUsuario == o.NombreDeUsuario);


                //LblSesion.Text = " " + pac2;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoctores doctores = new FrmDoctores();
            doctores.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas();
            citas.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PACIENTES pacientes = new PACIENTES();
            pacientes.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
