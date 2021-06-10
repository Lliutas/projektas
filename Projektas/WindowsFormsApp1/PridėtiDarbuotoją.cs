using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pridėti_darbuotoją : Form
    {
        public void Pridėti()
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO darbuotojai (Vardas, Pavadė, PareigųId, EtatoDalis) values ('" + txtPVardas.Text + "','"+ txtPPavardė.Text +"',"+ cmbxPPareigųId.SelectedItem +", "+ Int32.Parse(txtPEtatoDalis.Text) +");";
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Darbuotojas buvo pridėtas prie duomenų bazės.");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }
        public Pridėti_darbuotoją()
        {
            InitializeComponent();
            GautiDId();
        }
        public void GautiDId()
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from pareigos";
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (cmbxPPareigųId != null)
                {
                    cmbxPPareigųId.Items.Clear();
                    while (reader.Read())
                    {
                        cmbxPPareigųId.Items.Add(reader["Id"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        private void btnPridėti_Click(object sender, EventArgs e)
        {
            Pridėti();
        }
    }
}
