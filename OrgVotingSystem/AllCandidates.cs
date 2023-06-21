using MySql.Data.MySqlClient;
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


namespace OrgVotingSystem
{
    public partial class AllCandidates : UserControl
    {
        public AllCandidates()
        {
            InitializeComponent();
        }

        private void AllCandidates_Load(object sender, EventArgs e)
        {
            CandidatedataGridView.DataSource = GetCandidatesList();
        }


        private DataTable GetCandidatesList()
        {
            DataTable dtCandidates = new DataTable();

            string conn = ConfigurationManager.ConnectionStrings["dbC"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM candidates", con))
                {
                    con.Open();

                    MySqlDataReader read = cmd.ExecuteReader();


                    dtCandidates.Load(read);
                }
            }

            return dtCandidates;
        }
    }
}
