using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DarbuotojųPajamos : Form
    {
        public static void Conn()
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
                cmbId.Items.Clear();
                while (reader.Read())
                {
                    cmbId.Items.Add(reader["country"]);
                }

                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public DarbuotojųPajamos()
        {
            InitializeComponent();
        }
        

        private void btnParodytiInfo_Click(object sender, EventArgs e)
        {

        }

        private void cmbId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
