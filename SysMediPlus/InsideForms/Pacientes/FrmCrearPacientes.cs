using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace SysMediPlus.InsideForms.Pacientes
{
    public partial class FrmCrearPacientes : Form
    {
        public FrmCrearPacientes()
        {
            InitializeComponent();
        }

        private void InsertPacientes()
        {

            using (var context = new MediPlusSysContext())
            {

                if (TxtNombresP.Text.Length == 0 || TxtApellidosP.Text.Length == 0)
                {
                    MessageBox.Show("AUN NO SE HA LLENADO LOS DATOS PERSONALES");
                    return;
                }
                else if (MaskCedula.Text.Length == 0)
                {
                    MessageBox.Show("AUN NO SE HA LLENADO EL CAMPO CEDULA");
                }
                else
                {

                    var Cidb = new Paciente()
                    {
                        Nombres = TxtNombresP.Text,
                        Apellidos = TxtApellidosP.Text,
                        Sexo = RbMasculino.Checked == true ? "M" : "F",
                        CorreoElectronico = TxtCorreo.Text,
                        Cedula = MaskCedula.Text,
                        Provincia = txtProvincia.Text,
                        Ciudad = TxtCiudad.Text,
                        Sector = TxtSector.Text,
                        Calle = TxtCalle.Text,
                        Celular = MaskCelular.Text,
                        Telefono = MaskTelefono.Text,
                        IdCargo = (int)Convert.ToUInt32(CbtipodeUsuario.SelectedValue),

                    };
                    context.Pacientes.Add(Cidb);
                    context.SaveChanges();

                    MessageBox.Show("PACIENTE AGREGADO", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }


        private void LlenarCombo()
        {

            using var db = new MediPlusSysContext();


            var USER = db.Cargos.ToList();

            var obj3 = new Cargo { IdCargo = 0, NombreCargo = "SELECCIONE" };
            USER.Insert(0, obj3);
            CbtipodeUsuario.DataSource = USER;
            CbtipodeUsuario.DisplayMember = "NombreCargo";
            CbtipodeUsuario.ValueMember = "IdCargo";


        }

        private void limpiar()
        {
            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

                RbMasculino.Checked = true;
                //OBJALQUI = null;
                CbtipodeUsuario.SelectedIndex = 0;
                
            }
        }

        private void FrmCrearPacientes_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            InsertPacientes();
            limpiar();
            //Correo();
        }


        private void Correo()
        {
            string CorreoO = "mediplusadv@gmail.com";
            string CorreoD = "mediplusadv@gmail.com";
            string Pass = "MediPlus2021";


            MailMessage oMailMessage = new MailMessage(CorreoO, CorreoD, "Hola, Medi Plus le da la bienvenida", "<p> Su Usuario y contraseña es </p>");

            oMailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(CorreoO, Pass);

            smtpClient.Send(oMailMessage);

            smtpClient.Dispose();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
