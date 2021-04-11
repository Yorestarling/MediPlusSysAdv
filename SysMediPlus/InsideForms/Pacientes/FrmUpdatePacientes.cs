using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using System.Linq;

namespace SysMediPlus.InsideForms.Pacientes
{
    public partial class FrmUpdatePacientes : Form
    {
        public FrmUpdatePacientes()
        {
            InitializeComponent();
        }

        private int Idpacientes = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar()
        {

            using (var context = new MediPlusSysContext())
            {


                var Doc = context.Pacientes.ToList().Find(e => e.IdPaciente == Idpacientes);
                Doc.Nombres = TxtNombresP.Text;
                Doc.Apellidos = TxtApellidosP.Text;
                Doc.Sexo = RbMasculino.Checked == true ? "M" : "F";
                Doc.CorreoElectronico = TxtCorreo.Text;
                Doc.Cedula = MaskCedula.Text;
                Doc.Telefono = MaskTelefono.Text;
                Doc.Celular = MaskCelular.Text;
                Doc.Provincia = txtProvincia.Text;
                Doc.Ciudad = TxtCiudad.Text;
                Doc.Sector = TxtSector.Text;
                Doc.Calle = TxtCalle.Text;
                Doc.IdCargo = (int?)Convert.ToUInt32(CbtipodeUsuario.SelectedValue);

               
                context.SaveChanges();

                MessageBox.Show("PACIENTE ACTUALIZADO", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BuscaGrid()
        {

            using var db = new MediPlusSysContext();

            var pac = db.Pacientes.ToList();

            var List = (from p in pac
                        where p.Nombres.ToLower().Contains(TxtBuscar.Text)
                        select new
                        {
                            id = p.IdPaciente,
                            Nombre = p.Nombres,
                            Apellido = p.Apellidos,
                            Sexo = p.Sexo,
                            Correo = p.CorreoElectronico,
                            Cedula = p.Cedula,
                            Provincia = p.Provincia,
                            Ciudad = p.Ciudad,
                            Sector = p.Sector,
                            Calle = p.Calle,
                            Telefono = p.Telefono,
                            Celular = p.Celular,
                            TipoDUsuario = p.IdCargo

                        }).ToList();
            dataGridActuali.DataSource = List;
            dataGridActuali.Columns[0].Visible = false;

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

        private void FrmUpdatePacientes_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            BuscaGrid();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            Actualizar();
            limpiar();
            BuscaGrid();
        }



        private void dataGridActuali_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Double();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscaGrid();
        }

        private void dataGridActuali_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "REGISTROS: " + dataGridActuali.RowCount;
        }



        private void Double()
        {
            try
            {
                using var db = new MediPlusSysContext();

                Idpacientes = Convert.ToInt32(dataGridActuali[0, dataGridActuali.CurrentRow.Index].Value);

                var resultando = (from p in db.Pacientes
                                  where p.IdPaciente == Idpacientes
                                  select p).SingleOrDefault();

                TxtNombresP.Text = resultando.Nombres;
                TxtApellidosP.Text = resultando.Apellidos;
                if (dataGridActuali[3, dataGridActuali.CurrentRow.Index].Value.ToString() == "M")
                    RbMasculino.Checked = true;
                else
                    RbFemenino.Checked = true;
                MaskCedula.Text = resultando.Cedula;
                MaskTelefono.Text = resultando.Telefono;
                MaskCelular.Text = resultando.Celular;
                TxtCorreo.Text = resultando.CorreoElectronico;
                txtProvincia.Text = resultando.Provincia;
                TxtCiudad.Text = resultando.Ciudad;
                TxtSector.Text = resultando.Sector;
                TxtCalle.Text = resultando.Calle;
                CbtipodeUsuario.SelectedIndex = Convert.ToInt32(resultando.IdCargo);
    

            }
            catch
            {

            }
        }
    }
}
