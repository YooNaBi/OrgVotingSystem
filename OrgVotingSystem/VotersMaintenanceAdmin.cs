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
    public partial class VotersMaintenanceAdmin : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;user = root;password =;database =stica_voters;");
        public VotersMaintenanceAdmin()
        {
            InitializeComponent();
            show();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String StudentID = TBstudentID.Text.ToString();
                long id = Int64.Parse(StudentID);
                String FName = TBfullname.Text.ToString();
                String YearLevel = TByearlevel.Text.ToString();
                int sem = Int32.Parse(YearLevel);
                String course = CBcourse.SelectedItem.ToString();


                String qry = "insert into students values('" + StudentID + "','" + FName + "','" + course + "','" + YearLevel + "')";
                MySqlCommand sc = new MySqlCommand(qry, con);

                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show(i + " Student Registered Successfully : " + StudentID + FName);
                else
                    MessageBox.Show(" Student is not Registered: ");
                btnClear_Click(sender, e);
                show();
                con.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is " + exp.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVM.SelectedRows.Count > 0)
                {
                 String StudentID = TBstudentID.Text.ToString();
                long id = Int64.Parse(StudentID);
                String FName = TBfullname.Text.ToString();
                String YearLevel = TByearlevel.Text.ToString();
                int sem = Int32.Parse(YearLevel);
                String course = CBcourse.Text.ToString();

                    con.Open();

                    string qry = "UPDATE students SET STU_FNAME = @Fname, STU_course = @course, STU_Year_Level = @yearLevel WHERE STU_studentID = @studentID";
                    MySqlCommand sc = new MySqlCommand(qry, con);
                    sc.Parameters.AddWithValue("@StudentID", StudentID);
                    sc.Parameters.AddWithValue("@FullName", FName);
                    sc.Parameters.AddWithValue("@Course", course);
                    sc.Parameters.AddWithValue("@YearLevel", YearLevel);
                    

                    int i = sc.ExecuteNonQuery();

                    if (i >= 1)
                        MessageBox.Show("Student updated successfully.");
                    else
                        MessageBox.Show("Failed to update the student.");
                    show();
                    con.Close();

                }

            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error: " + exp.ToString());
            }
        }

        void show()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from students", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridViewVM.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridViewVM.Rows.Add();
                dataGridViewVM.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridViewVM.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridViewVM.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridViewVM.Rows[n].Cells[3].Value = dr[3].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (dataGridViewVM.SelectedRows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            con.Open();
                            string studentID = dataGridViewVM.SelectedRows[0].Cells[0].Value.ToString();
                            

                            string qry = "DELETE FROM students WHERE STU_studentID = '" + studentID + "'" ;
                            MySqlCommand sc = new MySqlCommand(qry, con);
                            int i = sc.ExecuteNonQuery();

                            if (i >= 1)
                            {
                                MessageBox.Show("Student deleted successfully.");
                                show();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the student.");
                            }

                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a student to delete.");
                    }
                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Error: " + exp.ToString());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.TBstudentID.Text = "";
            this.TBfullname.Text = "";
            CBcourse.SelectedIndex = -1;
            this.TByearlevel.Text = "";
        }

        private void dataGridViewVM_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TBstudentID.Text = dataGridViewVM.SelectedRows[0].Cells[0].Value.ToString();
            TBfullname.Text = dataGridViewVM.SelectedRows[0].Cells[1].Value.ToString();
            CBcourse.Text = dataGridViewVM.SelectedRows[0].Cells[2].Value.ToString();
            TByearlevel.Text = dataGridViewVM.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
