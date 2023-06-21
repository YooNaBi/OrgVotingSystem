using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrgVotingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public bool CheckValidation() // for log in
        {
            if (tbStudentID.Text == "")
            {
                MessageBox.Show("Please enter Student ID"); return false;
            }
            else if (tbUserPassword.Text == "")
            {
                MessageBox.Show("Please enter your Code");
                tbUserPassword.Focus();
                return false;
            }
            else { return true; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (CheckValidation() == true)
            {
               VotersMaintenanceAdmin voting = new VotersMaintenanceAdmin();
                addUserControl(voting);
               
            }
        }

       
    }
}
