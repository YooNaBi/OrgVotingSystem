using System;
using MySql.Data.MySqlClient;
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
    public partial class AdminAddCadidates : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;user = root;password =;database =stica_voters;");

        string Name, Yearlevel, Course, Position;
        string fileName = string.Empty;

        public AdminAddCadidates()
        {
            InitializeComponent();
        }

        private void AdminAddCadidates_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (MessageBox.Show("Database Connection is successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Display();
                }
            }
            catch (Exception ex)
            {
                //if the connection isn't successful the data inside the database will not show in the DataGridView Table
                MessageBox.Show("Connection wasn't successful!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            //when the Form Loads there will already be Dropdown List / Values inside the ComboBox
            cbFilter.Items.Add("Name");
            cbFilter.Items.Add("Course");
            cbFilter.Items.Add("Position");

            //When the Form Loads the default selection of the ComboBox will be the "Search by" which is the index = 0
            cbFilter.SelectedIndex = 0;
        }


        public void Clear()
        {
            tbNameCandidates.Text = string.Empty;
            tbYealLevelCandidates.Text = string.Empty;
            tbCourseCandidate.Text = string.Empty;
            tbPositionCandidate.Text = string.Empty;
        }




        //Displays the data from the table inside your database
        public void Display()
        {
            DBcandidates.DisplayAndSearchTable("SELECT cds_name, cds_year_level, cds_course, cds_position FROM candidates", dataGridView);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Validation of the filter when you select the values inside the ComboBox
        public void filterValidation()
        {
            if (cbFilter.SelectedIndex == 1)
            {
                //if you select Student ID the txtSearch will be enabled so you can search
                txtSearch.Enabled = true;
                txtSearch.Focus();

            }
            else if (cbFilter.SelectedIndex == 2)
            {
                //if you select Name the txtSearch will be enabled so you can search
                txtSearch.Enabled = true;
                txtSearch.Focus();
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (cbFilter.SelectedIndex == 1)
            {

                DBcandidates.DisplayAndSearchTable("SELECT cds_name, cds_year_level, cds_course, cds_position FROM candidates WHERE cds_name LIKE '%" + txtSearch.Text + "%'", dataGridView);

            }
            else if (cbFilter.SelectedIndex == 2)
            {

                DBcandidates.DisplayAndSearchTable("SELECT cds_name, cds_year_level, cds_course, cds_position FROM candidates WHERE (CONCAT(cds_year_level, ' ' ,cds_course) LIKE '%" + txtSearch.Text + "%')", dataGridView);
            }
            else
            {

                txtSearch.Enabled = false;
                MessageBox.Show("Please select if you want to search by Name / Course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterValidation();
        }

        public void UpdateInfo()
        {
            btnCreate.Text = "Update Record";
            tbNameCandidates.Text = Name;
            tbYealLevelCandidates.Text = Yearlevel;
            tbCourseCandidate.Text = Course;
            tbPositionCandidate.Text = Position;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if you click the Update Cell
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to update this data?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //clears the txtBox first before calling the selected cell/row's values to the txtBox
                    Clear();

                    Name = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(); //Student ID
                    Yearlevel = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(); //First Name
                    Course = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString(); //Last Name
                    Position = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(); //Contact

                    UpdateInfo(); //Calls the UpdateInfo method to show the selected cell/row's values to the txtBox

                }
            }
            //if you click the Delete Cell
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete this data?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Identifies the row that you want to delete by its Student ID
                    DBcandidates.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()); // Student ID
                    Display();
                }
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            this.tbNameCandidates.Text = "";
            this.tbYealLevelCandidates.Text = "";
            this.tbCourseCandidate.Text = "";
            this.tbPositionCandidate.Text = "";
            cbFilter.SelectedIndex = -1;
            pictureBox2.Image = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (checkValidation() == true && btnCreate.Text == "Create")
            {

                Name = tbNameCandidates.Text;
                Yearlevel = tbYealLevelCandidates.Text;
                Course = tbCourseCandidate.Text;
                Position = tbPositionCandidate.Text;

                CandidatesInfo info = new CandidatesInfo(Name, Yearlevel, Course, Position);
                DBcandidates.AddStudent(info);
                Clear();
                Display();
            }
            else if (btnCreate.Text == "Update Record")
            {
                Name = tbNameCandidates.Text;
                Yearlevel = tbYealLevelCandidates.Text;
                Course = tbCourseCandidate.Text;
                Position = tbPositionCandidate.Text;

                CandidatesInfo info = new CandidatesInfo(Name, Yearlevel, Course, Position);
                DBcandidates.UpdateStudent(info, Name);
                Clear();
                Display();
                btnCreate.Text = "Create";
            }
        }

        //validates if the textBox has values in it
        public bool checkValidation()
        {

            if (fileName == "")
            {
                MessageBox.Show("Please input the image of candidate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (tbNameCandidates.Text == "")
            {
                MessageBox.Show("Please input Name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNameCandidates.Focus();
                return false;
            }
            else if (tbYealLevelCandidates.Text == "")
            {
                MessageBox.Show("Please input Year Level.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbYealLevelCandidates.Focus();
                return false;
            }
            else if (tbCourseCandidate.Text == "")
            {
                MessageBox.Show("Please input Course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCourseCandidate.Focus();
                return false;
            }
            else if (tbPositionCandidate.Text == "")
            {
                MessageBox.Show("Please input Position.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPositionCandidate.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Info_Show(object sender, EventArgs e)
        {
            Display();
        }
    }

    }

