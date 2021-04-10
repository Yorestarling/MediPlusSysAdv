using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Linq;

namespace SysMediPlus.InsideForms.Doctores
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BuscaGrid()
        {

            using var db = new MediPlusSysContext();

            var pac = db.Doctores.ToList();

            var List = (from p in pac
                        where p.Nombres.ToLower().Contains(TxtBuscar.Text)
                        select new
                        {

                            Nombre = p.Nombres,
                            Apellido = p.Apellidos,
                            Sexo = p.Sexo,
                            Telefono = p.Telefono,
                            Celular = p.Celular,
                            //Especialidad = p.IdEspecialidadNavigation.NombreEspecialidad,

                        }).ToList();
            dataGridActuali.DataSource = List;

        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            BuscaGrid();
            LlenarCombo();
        }

        private void Actualizar()
        {

            using (var context = new MediPlusSysContext())
            {
                var std = context.Doctores.First<Doctore>();
                std.Nombres = TxtNombres.Text;
                std.Apellidos = TxtApellidosD.Text;
                std.Telefono = MaskTelefono.Text;
                std.Celular = MaskCelular.Text;
                std.IdEspecialidad = (int?)Convert.ToUInt32(CbEspecialidade.SelectedValue);
                std.Iddia = (int?)Convert.ToUInt32(CBDiasLabor.SelectedValue);
                std.IdCargo = (int)Convert.ToUInt32(CbTipoUsuario.SelectedValue);
                std.Sexo = RbMasculino.Checked == true ? "M" : "F";

                context.SaveChanges();
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscaGrid();
        }

        private void dataGridActuali_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "REGISTROS: " + dataGridActuali.RowCount;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void dataGridActuali_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtNombres.Text = dataGridActuali.CurrentRow.Cells[0].Value.ToString();
                TxtApellidosD.Text = dataGridActuali.CurrentRow.Cells[1].Value.ToString();
                MaskTelefono.Text = dataGridActuali.CurrentRow.Cells[2].Value.ToString();
                MaskCelular.Text = dataGridActuali.CurrentRow.Cells[3].Value.ToString();            
                CbEspecialidade.SelectedValue = dataGridActuali.CurrentRow.Cells[4].Value.ToString();
                CBDiasLabor.SelectedValue = dataGridActuali.CurrentRow.Cells[5].Value.ToString();
                CbTipoUsuario.SelectedValue = dataGridActuali.CurrentRow.Cells[6].Value.ToString();

                //RbFemenino.Checked  == 'F' ? true : false;
                //RbMasculino.Checked == 'M' ? true : false;

            }
            catch
            {

            }
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
