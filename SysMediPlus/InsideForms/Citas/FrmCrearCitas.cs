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

        int cout = 0;
        private void InsertarCita()
        {

            using (var context = new MediPlusSysContext())
            {
                
                if (CbPaciente.SelectedIndex == 0 || CbDoctor.SelectedIndex == 0)
                {
                    MessageBox.Show("AUN NO SE HA SELECCIONADO UN PACIENTE O DOCTOR");
                    return;
                }           
                else
                {
                   

                    var Cidb = new Cita()
                    {
                        
                        IdPaciente = (int)Convert.ToUInt32(CbPaciente.SelectedValue),
                        IdDoctor = (int)Convert.ToUInt32(CbDoctor.SelectedValue),                     
                        FechaCita =DateFechaCita.Value.Date,
                        HoraInicio = TxtHoraInicio.Text,
                        HoraFin = TxtFin.Text,
                        Comentario = TxtComentario.Text,
                        Motivo = TxtMotivo.Text,
                        IdEstado = (int)Convert.ToUInt32(CBEstado.SelectedValue),
                        Tanda = RbManana.Checked == true ? "Mañana" : "Tarde",

                    };

                    if (DateFechaCita.Value.Date == Cidb.FechaCita && TxtHoraInicio.Text == Cidb.HoraInicio)
                    {
                        MessageBox.Show("NO SE PUEDE");
                    }
                    else
                    {
                        cout++;
                        context.Citas.Add(Cidb);
                        context.SaveChanges();
                        MessageBox.Show("CITA AGREGADO", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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



            var obj3 = new Estado { IdEstados = 0, NombreEstado = "SELECCIONE" };
            stat.Insert(0, obj3);
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
            }

        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            InsertarCita();
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
    }
}
