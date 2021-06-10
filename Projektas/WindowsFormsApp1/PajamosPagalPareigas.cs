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
    public partial class PajamosPagalPareigas : Form
    {
        public void PajamosIdGavimas()
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
                if (cmbxPareigosId != null)
                {
                    cmbxPareigosId.Items.Clear();
                    while (reader.Read())
                    {
                        cmbxPareigosId.Items.Add(reader["Pavadinimas"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        public PajamosPagalPareigas()
        {
            InitializeComponent();
            PajamosIdGavimas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnParodytiGalimasPajamas_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from pareigos where Id = " + (cmbxPareigosId.SelectedIndex+1) + ";";
            int pajamos=0;
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pajamos = Int32.Parse(reader.GetString(3));
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            connection.Close();
            try 
            { 
                txtApskaiciuotosPajamos.Text = Convert.ToString(pajamos * Convert.ToDouble(txtĮvestisEtatoDalis.Text)); 
            }
            catch (Exception i)
            { 
                MessageBox.Show(i.Message); 
            }
        }
    }
}
