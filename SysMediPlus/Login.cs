using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace SysMediPlus
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
        }

   
        
        private void DeskLogin()
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                MessageBox.Show("Ingresa tu Nombre de usuario.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(TxtContraseña.Text))
            {
                MessageBox.Show("Ingresa tu Contraseña.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtContraseña.Focus();
                return;
            }
            try
            {
                using (MediPlusSysContext test = new MediPlusSysContext())
                {

                    var query = from o in test.Usuarios
                                where o.NombreDeUsuario == TxtUsuario.Text && o.Contraseña == TxtContraseña.Text && o.IdCargo == 2
                                select o;

                    var query2 = from u in test.Usuarios
                                where u.NombreDeUsuario == TxtUsuario.Text
                                && u.Contraseña == TxtContraseña.Text 
                                && u.IdCargo == 3 
                                select u;

                    if (query2.SingleOrDefault() != null)
                    {
                            MENU MN = new MENU();
                            MN.Show();
                            //AdminD.admin = query2;

                            TxtContraseña.Clear();
                            TxtUsuario.Clear();             
                    }
                    else if (query.SingleOrDefault() != null)
                    {
                        Menu2 MN2 = new Menu2();
                        MN2.Show();
                        //AdminD.admin = query;
                        TxtContraseña.Clear();
                        TxtUsuario.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o Contraseña Incorrecta", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                TxtContraseña.Focus();
        }

        private void TxtContraseñad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                BtnIniciar.PerformClick();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //MENU MN = new MENU();
            //MN.Show();
            DeskLogin();
        }
    }
}
