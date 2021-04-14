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

namespace SysMediPlus.InsideForms.Doctores
{
    public partial class FrmCrearDoctores : Form
    {
        public FrmCrearDoctores()
        {
            InitializeComponent();
        }

        private void FrmCrearDoctores_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void BtnCrearD_Click(object sender, EventArgs e)
        {
            Insert();
            Limpiar();
        }

        private void Insert()
        {
            

            using (var context = new MediPlusSysContext())
            {

                if (TxtNombres.Text.Length == 0 || TxtApellidosD.Text.Length == 0)
                {
                    MessageBox.Show("DEBE LLENAR SUS CREDENCIALES");
                }
                else if (CbEspecialidade.SelectedIndex == 0 )
                {
                    MessageBox.Show("DEBE DE SELECCIONAR SU ESPECIALIDAD");

                    return;
                }
                else
                {

                    var doc = new Doctore()
                    {
                        Nombres = TxtNombres.Text,
                        Apellidos = TxtApellidosD.Text,
                        Telefono = MaskTelefono.Text,
                        Celular = MaskCelular.Text,
                        IdEspecialidad = (int?)Convert.ToUInt32(CbEspecialidade.SelectedValue),
                        Iddia = (int?)Convert.ToUInt32(CBDiasLabor.SelectedValue),
                        IdCargo = (int)Convert.ToUInt32(CbTipoUsuario.SelectedValue),
                        Sexo = RbMasculino.Checked == true ? "M" : "F",

                    };
                    context.Doctores.Add(doc);
                    context.SaveChanges();


                    MessageBox.Show("El Usuario y su contraseña para acceder al sistema se le envio a su correo", "Doctor Creado Con Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
        }



        private void LlenarCombo()
        {

            using var db = new MediPlusSysContext();

            var Esp = db.Especialidades.ToList();

            var dia = db.Dias.ToList();

            var USER = db.Cargos.ToList();

            var obj = new Especialidade { IdEspecialidad = 0, NombreEspecialidad = "SELECCIONE" };
            Esp.Insert(0, obj);
            CbEspecialidade.DataSource = Esp;
            CbEspecialidade.DisplayMember = "NombreEspecialidad";
            CbEspecialidade.ValueMember = "IdEspecialidad";

            var obj2 = new Dia { IdDia = 0, NombreDia = "SELECCIONE" };
            dia.Insert(0, obj2);
            CBDiasLabor.DataSource = dia;
            CBDiasLabor.DisplayMember = "NombreDia";
            CBDiasLabor.ValueMember = "IdDia";

            var obj3 = new Cargo { IdCargo = 0, NombreCargo = "SELECCIONE" };
            USER.Insert(0, obj3);
            CbTipoUsuario.DataSource = USER;
            CbTipoUsuario.DisplayMember = "NombreCargo";
            CbTipoUsuario.ValueMember = "IdCargo";


        }



        private void Limpiar()
        {

            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

                RbMasculino.Checked = true;
                //OBJALQUI = null;
                CbEspecialidade.SelectedIndex = 0;
                CBDiasLabor.SelectedIndex = 0;
                CbTipoUsuario.SelectedIndex = 0;
                
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
