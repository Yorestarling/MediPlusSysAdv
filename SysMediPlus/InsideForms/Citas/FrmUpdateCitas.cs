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

namespace SysMediPlus.InsideForms.Citas
{
    public partial class FrmUpdateCitas : Form
    {
        public FrmUpdateCitas()
        {
            InitializeComponent();
        }
        private int idcitas = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar()
        {

            using (var context = new MediPlusSysContext())
            {

                var Doc = context.Citas.ToList().Find(e => e.IdCita == idcitas);
                Doc.IdPaciente = (int)(CbPaciente.SelectedValue);
                Doc.IdDoctor = (int)(CbDoctor.SelectedValue);
                Doc.FechaSolicitud = (DateTime)DateSolicitud.Value;
                Doc.FechaCita = (DateTime)DateFechaCita.Value;
                Doc.Tanda = RbManana.Checked == true ? "Mañana" : "Tarde";
                Doc.Comentario = TxtComentario.Text;
                Doc.Motivo = TxtMotivo.Text;              
                Doc.IdEstado = (int?)(CBEstado.SelectedValue);
                
          
                context.SaveChanges();

                MessageBox.Show("CITA ACTUALIZADA", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridActuali_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToTxt();
        }


        private void BuscaGrid()
        {

            using var db = new MediPlusSysContext();

            var pac2 = db.Citas.Include(x => x.IdDoctorNavigation)
                .Include(x => x.IdPacienteNavigation).Include(x => x.IdEstadoNavigation).ToList();

            var List = (from p in pac2
                        where p.IdDoctor.ToString().Contains(TxtBuscar.Text)
                        select new
                        {
                            id = p.IdCita,
                            Doctor  = p.IdDoctorNavigation.Nombres+' '+p.IdDoctorNavigation.Apellidos,
                            Paciente = p.IdPacienteNavigation.Nombres+' '+p.IdPacienteNavigation.Apellidos,
                            FechaSolicitud = p.FechaSolicitud,
                            FechaCita = p.FechaCita,
                            Comentario = p.Comentario,
                            Motivo = p.Motivo,
                            Estado = p.IdEstadoNavigation.NombreEstado        
                        }).ToList();

            dataGridActuali.DataSource = List;
            dataGridActuali.Columns[0].Visible = false;

        }

        private void GridToTxt()
        {
            try
            {
                using var db = new MediPlusSysContext();

                idcitas = Convert.ToInt32(dataGridActuali[0, dataGridActuali.CurrentRow.Index].Value);

                var resultando = (from p in db.Citas
                                  where p.IdCita == idcitas
                                  select p).SingleOrDefault();
                TxtComentario.Text = resultando.Comentario;
                TxtMotivo.Text = resultando.Motivo;
                CbPaciente.SelectedValue = Convert.ToInt32(resultando.IdPaciente);
                CbDoctor.SelectedValue = Convert.ToInt32(resultando.IdDoctor);
                CBEstado.SelectedValue = Convert.ToInt32(resultando.IdEstado);
                DateFechaCita.Value = resultando.FechaCita;
                DateSolicitud.Value = (DateTime)resultando.FechaSolicitud;

                if (dataGridActuali[3, dataGridActuali.CurrentRow.Index].Value.ToString() == "Mañana")
                    RbManana.Checked = true;
                else
                    RbTarde.Checked = true;

            }
            catch
            {

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

        private void Limpiar()
        {

            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }

                RbManana.Checked = true;
                //OBJALQUI = null;
                CbPaciente.SelectedIndex = 0;
                CBEstado.SelectedIndex = 0;
                CbDoctor.SelectedIndex = 0;
            }

        }

        private void FrmUpdateCitas_Load(object sender, EventArgs e)
        {
            llenarCombo();
            Limpiar();
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

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            Actualizar();
            Limpiar();
            BuscaGrid();
        }



        private void Eliminar()
        {



            if (MessageBox.Show(@"¿QUIERES ELIMINAR ESTA CITA?", @"Atención",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show(@"¿EN REALIDAD ESTAS LO QUIERES HACER?", @"Atención",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new MediPlusSysContext())
                    {
                        var cit = db.Citas.ToList().Find(e => e.IdCita == idcitas);
                        db.Citas.Remove(cit);

                        db.SaveChanges();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
