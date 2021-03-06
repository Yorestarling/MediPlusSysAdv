using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace SysMediPlus.InsideForms
{
    public partial class VerPacientesFRm : Form
    {
        public VerPacientesFRm()
        {
            InitializeComponent();
        }

        private void VerPacientesFRm_Load(object sender, EventArgs e)
        {
            Buscar();    
        }

        private void Buscar()
        {
            using var db = new MediPlusSysContext();

            var pac2 = db.Pacientes.Include(x => x.IdCargoNavigation).ToList();

            var List = (from p in pac2
                        where p.Nombres.ToLower().Contains(TxtBuscar.Text)
                          select new
                          {
                              //ID = p.IdPaciente,
                              Nombre = p.Nombres,
                              Apellido = p.Apellidos,
                              Sexo = p.Sexo,
                              Correo = p.CorreoElectronico,
                              Cedula = p.Cedula,
                              Telefono = p.Telefono,
                              Provincia = p.Provincia,
                              Sector = p.Sector,
                              Calle = p.Calle,
                              Tipo_Usuario = p.IdCargoNavigation.NombreCargo,

                          }).ToList();
            dataGridViewPacientes.DataSource = List;
            //dataGridViewPacientes.Columns[0].Visible = true;


        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dataGridViewPacientes_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "REGISTROS: " + dataGridViewPacientes.RowCount;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
