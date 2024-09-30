using Registro.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Persona>();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.FirstName = tbFirstName.Text;
            persona.LastName = tbLastName.Text;
            persona.Birthdate = dtmBirthdate.Value;
            persona.CalcularEdad();
            people.Add(persona);
            showPeople();
            ClearTb();
        }

        public void showPeople()
        {
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = people;

        }

        private void ClearTb()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            dtmBirthdate.Value = DateTime.Now;
            tbFirstName.Focus();
        }
    }
}
