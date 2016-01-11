/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//define the connection reference and initialize it
MySql.Data.MySqlClient.MySqlConnection mySqlConnection = null;
*/
namespace Mastermind
{
    class Highscore
    {
        /*
            public Highscore(int score, string speler)
            {
                string speler = speler;
                int score = score;
            }

            MySqlConnection con = new MySqlConnection("server = localhost; User Id = root; password = password; database = mastermind; Persist Security Info = True");
            public void get()
            {
                get(false);
            }

            public void get(bool all)
            {

            }

            public void all()
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from highscore", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView.DataSource data = dt;
                con.Clone();
                return data;
            }
            public void firstFive()
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from highscore top 5", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView.DataSource data = dt;
                con.Clone();
                return data;
            }
        }

        public void setHighscore(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into highscore values(?, ?)", con);
            int success = cmd.ExecuteNonQuery();
            Console.WriteLine(success);
            MessageBox.Show("Inserted");
            con.Close();
        }
        /*commented out the modify and delete record functions because they're not needed yet.
        public void modifyRecord(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("update highscore set score = ? and naam = ? where id = ?", con);
            int success = cmd.ExecuteNonQuery();
            Console.WriteLine(success);
            MessageBox.Show("Updated");
            con.Close();
        }
        public void deleteRecord(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from highscore where id = ?", con);
            int success = cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            con.Close();
        */
    }
}
