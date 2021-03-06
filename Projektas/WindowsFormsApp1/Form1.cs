using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPajamos_Click(object sender, EventArgs e)
        {
            
            DarbuotojųPajamos darbuotojųPajamos = new DarbuotojųPajamos();
            darbuotojųPajamos.ShowDialog();
        }

        private void btnDemoPajamos_Click(object sender, EventArgs e)
        {
            PajamosPagalPareigas pajamosPagalPareigas = new PajamosPagalPareigas();
            pajamosPagalPareigas.ShowDialog();
        }

        private void btnPridėti_Click(object sender, EventArgs e)
        {
            Pridėti_darbuotoją pridėti_Darbuotoją = new Pridėti_darbuotoją();
            pridėti_Darbuotoją.ShowDialog();
        }

        private void btnIštrinti_Click(object sender, EventArgs e)
        {
            IštrintiDarbuotoją ištrintiDarbuotoją = new IštrintiDarbuotoją();
            ištrintiDarbuotoją.ShowDialog();
        }
    }
}
