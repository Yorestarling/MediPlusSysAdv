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
        private int iddoctores = 0;
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
                            id = p.IdDoctor,
                            Nombre = p.Nombres,
                            Apellido = p.Apellidos,
                            Sexo = p.Sexo,
                            Telefono = p.Telefono,
                            Celular = p.Celular,
                            //Especialidad = p.IdEspecialidadNavigation.NombreEspecialidad,

                        }).ToList();
            dataGridActuali.DataSource = List;
            dataGridActuali.Columns[0].Visible = false;

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

                //iddoctores =Convert.ToInt32(dataGridActuali.SelectedCells[0].Value);


                var Doc = context.Doctores.ToList().Find(e => e.IdDoctor == iddoctores);
                Doc.Nombres = TxtNombres.Text;
                Doc.Apellidos = TxtApellidosD.Text;
                Doc.Telefono = MaskTelefono.Text;
                Doc.Celular = MaskCelular.Text;
                Doc.IdEspecialidad = (int?)Convert.ToUInt32(CbEspecialidade.SelectedValue);
                Doc.Iddia = (int?)Convert.ToUInt32(CBDiasLabor.SelectedValue);
                Doc.IdCargo = (int)Convert.ToUInt32(CbCargo.SelectedValue);
                Doc.Sexo = RbMasculino.Checked == true ? "M" : "F";

               // context.Doctores.Update(Doc);
                context.SaveChanges();

                MessageBox.Show("DOCTOR ACTUALIZADO", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        

        private void dataGridActuali_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            try
            {
                using var db = new MediPlusSysContext();

                iddoctores = Convert.ToInt32(dataGridActuali[0, dataGridActuali.CurrentRow.Index].Value);

                var resultando = (from p in db.Doctores
                                  where p.IdDoctor == iddoctores
                                  select p).SingleOrDefault();

                TxtNombres.Text = resultando.Nombres;
                TxtApellidosD.Text = resultando.Apellidos;
                MaskTelefono.Text = resultando.Telefono;
                MaskCelular.Text = resultando.Celular;
                CbEspecialidade.SelectedIndex = Convert.ToInt32(resultando.IdEspecialidad);
                CBDiasLabor.SelectedIndex = Convert.ToInt32(resultando.Iddia);
                CbCargo.SelectedIndex = Convert.ToInt32(resultando.IdCargo);

                if (dataGridActuali[3, dataGridActuali.CurrentRow.Index].Value.ToString() == "M")
                    RbMasculino.Checked = true;              
                else
                    RbFemenino.Checked = true;

            }
            catch
            {

            }
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
            BuscaGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Eliminar()
        {
            using (var db = new MediPlusSysContext())
            {
                var Doc = db.Doctores.ToList().Find(e => e.IdDoctor == iddoctores);
                db.Doctores.Remove(Doc);

                db.SaveChanges();
            }
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
                CbCargo.SelectedIndex = 0;
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
            CbCargo.DataSource = USER;
            CbCargo.DisplayMember = "NombreCargo";
            CbCargo.ValueMember = "IdCargo";


        }
    }
}
