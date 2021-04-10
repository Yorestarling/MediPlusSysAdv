using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace SysMediPlus.InsideForms.Citas
{
    public partial class VerCitasFRm : Form
    {
        public VerCitasFRm()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            using var db = new MediPlusSysContext();

            var pac = db.Citas.ToList();

            var List = (from p in pac
                        where p.Tanda.ToLower().Contains(TxtBuscar.Text)
                        select new
                        {
                            // ID = p.IdPaciente,
                            Paciente = p.IdPaciente,
                            Doctor = p.IdDoctor,
                            Fecha_De_La_Cita = p.FechaCita,
                            Fecha_Solicitud = p.FechaSolicitud,
                            Motivo = p.Motivo,
                            Comentario = p.Comentario,             
                            //Estado = p.IdCargo.NombreCargo,

                        }).ToList();
            dataGridViewPacientes.DataSource = List;


        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dataGridViewPacientes_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "REGISTROS: " + dataGridViewPacientes.RowCount;
        }

        private void VerCitasFRm_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
