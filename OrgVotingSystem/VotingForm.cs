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
    public partial class VotingForm : UserControl
    {
        public VotingForm()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            VotingPanel.Controls.Clear();
            VotingPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            Candidates candidates = new Candidates();
            addUserControl(candidates);
        }

        private void btnAllCandidates_Click(object sender, EventArgs e)
        {
            AllCandidates allCandidates = new AllCandidates();
            addUserControl(allCandidates);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

       

        

    }
}
