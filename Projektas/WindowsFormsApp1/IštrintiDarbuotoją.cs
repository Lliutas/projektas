using MySql.Data.MySqlClient;
using MySql.Data;
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
    public partial class IštrintiDarbuotoją : Form
    {
        public void TGauti()
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from darbuotojai";
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (cmbxTDarbuotojoId != null)
                {
                    cmbxTDarbuotojoId.Items.Clear();
                    while (reader.Read())
                    {
                        cmbxTDarbuotojoId.Items.Add(reader["Id"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }
        public IštrintiDarbuotoją()
        {
            InitializeComponent();
            TGauti();
        }

        private void btnIštrinti_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            int comboReiksme = (int)cmbxTDarbuotojoId.SelectedItem;
            cmd.CommandText = "select * from darbuotojai where Id = " + comboReiksme + ";";
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtTVardas.Text = reader.GetString(1);
                    txtTPavardė.Text = reader.GetString(2);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Ar tikrai norite ištrintį šį darbuotoją iš duomenų bazės?", "Ar esate įsitikinę?",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand com;
                com = con.CreateCommand();
                com.CommandText = "DELETE  from darbuotojai where Id =" + cmbxTDarbuotojoId.SelectedItem + ";";
                
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Darbuotojas buvo ištrintas iš duomenų bazės.");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }
    }
}
