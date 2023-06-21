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
    public partial class Candidates : UserControl
    {
        public Candidates()
        {
            InitializeComponent();

            this.cbCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCandidates.Items.Add("Candidate1");
            cbCandidates.Items.Add("Candidate2");
            cbCandidates.Items.Add("Candidate3");

            this.cbOrganization.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrganization.Items.Add("Org1");
            cbOrganization.Items.Add("Org2");
            cbOrganization.Items.Add("Org3");

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Submission submission = new Submission();
            submission.Show();
        }

        
     
    }
}
