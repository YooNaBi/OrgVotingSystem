using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgVotingSystem
{
    public partial class Submission : Form
    {
        public Submission()
        {
            InitializeComponent();
        }

        private void btnSumbitVote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOTE SUCCESSFULLY");
            this.Close();
        
        }

        private void btnChangeVote_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
