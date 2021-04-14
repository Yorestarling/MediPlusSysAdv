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
using System.Net.Mail;

namespace SysMediPlus.InsideForms.Citas
{
    public partial class FrmCrearCitas : Form
    {
        public FrmCrearCitas()
        {
            InitializeComponent();
        }

        private void FrmCrearCitas_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        
        private void InsertarCita()
        {

            using (var context = new MediPlusSysContext())
            {
                
                if (CbPaciente.SelectedIndex == 0 || CbDoctor.SelectedIndex == 0)
                {
                    MessageBox.Show("AUN NO SE HA SELECCIONADO UN PACIENTE O DOCTOR", "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (LbBoxInicio.Text == lbboxFin.Text)
                {
                    MessageBox.Show("LA FECHA DE INICIO ES IGUAL A LA DE FIN", "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                   

                    var Cidb = new Cita()
                    {
                        
                        IdPaciente = (int)Convert.ToUInt32(CbPaciente.SelectedValue),
                        IdDoctor = (int)Convert.ToUInt32(CbDoctor.SelectedValue),                     
                        FechaCita =DateFechaCita.Value.Date,
                        HoraInicio = LbBoxInicio.Text,
                        HoraFin = lbboxFin.Text,
                        Comentario = TxtComentario.Text,
                        Motivo = TxtMotivo.Text,
                        IdEstado = (int)Convert.ToUInt32(CBEstado.SelectedValue),
                        Tanda = RbManana.Checked == true ? "Mañana" : "Tarde",

                    };

                    var query = from o in context.Citas
                                where o.FechaCita == DateFechaCita.Value.Date 
                                && o.HoraInicio == LbBoxInicio.Text                           
                                select o;

                   

                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("NO SE PUEDE REGISTRAR UNA CITA A ESTA HORA", "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        context.Citas.Add(Cidb);
                        context.SaveChanges();
                        MessageBox.Show("CITA AGREGADA", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void llenarCombo()
        {

            using var db = new MediPlusSysContext();

            var paci = db.Pacientes.ToList();

            var doc = db.Doctores.ToList();

            var stat = db.Estados.ToList();

            foreach (var i in paci)
            {
                i.Nombres += "  " + i.Apellidos;
            }

            var obj = new Paciente { IdPaciente = 0, Nombres = "SELECCIONE" };
            paci.Insert(0, obj);
            CbPaciente.DataSource = paci;
            CbPaciente.DisplayMember = "Nombres";
            CbPaciente.ValueMember = "IdPaciente";



            foreach (var i in doc)
            {
                i.Nombres += "  " + i.Apellidos;
            }

            var obj2 = new Doctore { IdDoctor = 0, Nombres = "SELECCIONE" };
            doc.Insert(0, obj2);
            CbDoctor.DataSource = doc;
            CbDoctor.DisplayMember = "Nombres";
            CbDoctor.ValueMember = "IdDoctor";



            var obj3 = new Estado { IdEstados = 1, NombreEstado = "SELECCIONE" };
            stat.Insert(1, obj3);
            CBEstado.DataSource = stat;
            CBEstado.DisplayMember = "NombreEstado";
            CBEstado.ValueMember = "IdEstados";



        }

        private void limpiar()
        {

            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

                RbManana.Checked = true;
                //OBJALQUI = null;
                CbDoctor.SelectedIndex = 0;
                CBEstado.SelectedIndex = 0;
                CbPaciente.SelectedIndex = 0;
                DateFechaCita.Value = DateTime.Now;
            }

        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            InsertarCita();
            Correo();
            limpiar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Correo()
        {
            using var context = new MediPlusSysContext();
           

                var query = from o in context.Pacientes
                        where o.IdPaciente == (int)CbPaciente.SelectedValue
                        select o.CorreoElectronico;

            string CorreoO = "Mediplusadv@outlook.com";
            string CorreoD = query.SingleOrDefault();
            string Pass = "medi1234";


            MailMessage oMailMessage = new MailMessage(CorreoO, CorreoD, "Hola, Medi Plus confirma su cita", $"<p> Con el Doctor {CbDoctor.Text}</p>  ");

            oMailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(CorreoO, Pass);

            smtpClient.Send(oMailMessage);

            smtpClient.Dispose();


        }

    }
}
