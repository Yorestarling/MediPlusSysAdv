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
    public partial class VerDoctoresFrm : Form
    {
        public VerDoctoresFrm()
        {
            InitializeComponent();
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
                            Celular = p.Celular ,
                            //Especialidad = p.IdEspecialidadNavigation.NombreEspecialidad,

                        }).ToList();
            dataGridViewPacientes.DataSource = List;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscaGrid();
        }

        private void VerDoctoresFrm_Load(object sender, EventArgs e)
        {
            BuscaGrid();
        }

        private void dataGridViewPacientes_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "REGISTROS: " + dataGridViewPacientes.RowCount;
        }
    }
}
