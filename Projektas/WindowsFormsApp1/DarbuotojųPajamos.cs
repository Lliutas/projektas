using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DarbuotojųPajamos : Form
    {
        public void Gauti()
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
                if(cmbxDarbuotojoId != null)
                {
                    cmbxDarbuotojoId.Items.Clear();
                    while (reader.Read())
                    {
                        cmbxDarbuotojoId.Items.Add(reader["Id"]);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }
        
        public DarbuotojųPajamos()
        {
            InitializeComponent();
            Gauti();
        }
        

        private void btnParodytiInfo_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=pajamos;port=3305;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            int comboReiksme = cmbxDarbuotojoId.SelectedIndex + 1;
            cmd.CommandText = "select * from darbuotojai where Id = "+ comboReiksme +";";
            int intPareigosId=0;
            int intPareigosPajamos = 0;
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtVardas.Text = reader.GetString(1);
                    txtPavardė.Text = reader.GetString(2);
                    intPareigosId = Int32.Parse(reader.GetString(3));
                    txtEtatoDalis.Text = Convert.ToString(reader.GetString(4));
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            connection.Close();
            cmd.CommandText = $"select * from Pareigos where Id = {intPareigosId}";
            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtPareigos.Text = Convert.ToString(reader.GetString(1));
                    intPareigosPajamos = Int32.Parse(reader.GetString(3));
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            connection.Close();

            txtPajamos.Text = Convert.ToString(intPareigosPajamos * Convert.ToDouble(txtEtatoDalis.Text));
            
        }

        private void cmbId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
