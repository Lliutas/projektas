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

        }
    }
}
