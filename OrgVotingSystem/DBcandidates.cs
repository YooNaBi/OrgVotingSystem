using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgVotingSystem
{
    internal class DBcandidates
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;user = root;password =;database =stica_voters;");

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        //Adds the data to the database
        public static void AddStudent(CandidatesInfo info)
        {
            string sql = "INSERT INTO candidates VALUES (@Name, @YearLevel, @Course, @Position)";
            MySqlConnection con = GetConnection(); //fetch the connection of the database
            MySqlCommand cmd = new MySqlCommand(sql, con); //creates new command where we will insert a data in the database

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 200).Value = info.name;
            cmd.Parameters.Add("@YearLevel", MySqlDbType.VarChar, 200).Value = info.yearlevel;
            cmd.Parameters.Add("@Course", MySqlDbType.VarChar, 200).Value = info.course;
            cmd.Parameters.Add("@Position", MySqlDbType.VarChar, 200).Value = info.position;
            //cmd.Parameters.AddWithValue("@cds_pictures", getPhoto());


            try
            {
                cmd.ExecuteNonQuery(); //executes the command to insert the data inside the database
                MessageBox.Show("It has been added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No data added! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }




        public static void UpdateStudent(CandidatesInfo info, string sID)
        {
            Candidates f1 = new Candidates(); //calls the FormDBSample class as an object


            string sql = "UPDATE candidates SET cds_year_level = @YearLevel, cds_course = @Course, cds_position = @Position WHERE cds_name = @Name";
            MySqlConnection con = GetConnection(); //fetches the connection
            MySqlCommand cmd = new MySqlCommand(sql, con); //creates new command where we will insert a data in the database

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 200).Value = info.name;
            cmd.Parameters.Add("@YearLevel", MySqlDbType.VarChar, 200).Value = info.yearlevel;
            cmd.Parameters.Add("@Course", MySqlDbType.VarChar, 200).Value = info.course;
            cmd.Parameters.Add("@Position", MySqlDbType.VarChar, 200).Value = info.position;
            //cmd.Parameters.AddWithValue("@cds_pictures", getPhoto());


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("It has been updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No data updated! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }




        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM candidates WHERE cds_name = @Name";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 200).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("It has been deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No data deleted! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //Displays and Search method where it displays the data/displays the data that is being searched from the database to the DataGridView
        public static void DisplayAndSearchTable(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);


            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
