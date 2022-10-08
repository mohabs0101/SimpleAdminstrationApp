using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adminstrator
{
    public partial class Users_Managment : Form
    {
        public static string Constr = @"Data Source=DESKTOP-7JIFNRJ\INSTANCE2;initial catalog =HR;User ID=sa;Password=mohammedalwan1";

        public Users_Managment()
        {
            InitializeComponent();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void changedep_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {

        }

        private void editedeptBTn_Click(object sender, EventArgs e)
        {

        }

        private void adddeptBTn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void Users_Managment_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                //dataGridView1.BackgroundColor = Color.LightGray;

                SqlConnection con = new SqlConnection(Constr);




                string select_user = @"
 SELECT [user_id]
      ,t1.[username]
      ,t1.[first_name]
      ,t1.[last_name]
      ,t1.[password]
      ,t1.[email]
      ,t2.[privilege_name] from [HR].[dbo].[users] t1
                     
                 join [HR].[dbo].[privileges] t2 on (t1.[privilege_id] = t2.[privilege_id])



";







                SqlDataAdapter adapter = new SqlDataAdapter(select_user, con);
                DataTable table1 = new DataTable();

                adapter.Fill(table1);

                //dataGridView1.DataSource = table1;

                if (table1.Rows.Count != 0)
                {
                    foreach (DataRow row in table1.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[1].Value = row["user_id"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = row["username"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = row["first_name"].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = row["last_name"].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = row["password"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = row["email"].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = row["privilege_name"].ToString();



                    }
                }



                string sqlprivilege = @"select * from [HR].[dbo].[privileges]";
                SqlDataAdapter adapter5 = new SqlDataAdapter(sqlprivilege, con);
                DataTable table5 = new DataTable();
                adapter5.Fill(table5);

                if (table5.Rows.Count != 0)
                {
                    foreach (DataRow row in table5.Rows)
                    {
                        //int n = dataGridView2.Rows.Add();

                        previligecombo.Items.Add(row["privilege_name"].ToString());
                        privilegecombo_id.Items.Add(row["privilege_id"].ToString());

                        //dataGridView2.Rows[n].Cells[7].Value = row["city"].ToString();
                    }
                    previligecombo.SelectedIndex = 0;
                    privilegecombo_id.SelectedIndex = 0;

                }










            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string Password = textBox4.Text;
            string email = textBox5.Text;



            int privilege_id = 0;

            privilege_id = Convert.ToInt32(privilegecombo_id.SelectedItem.ToString());

            SqlConnection con = new SqlConnection(Constr);

            con.Open();

            string Sql = (@"
insert into [HR].[dbo].[users]
     (
      [username],
      [first_name],
      [last_name],
      [password],
[email],
[privilege_id]

       )
 values 
( '" + username + "','" + firstname + "','" + lastname + "','" + Password + "','" + email + "','" + privilege_id + "') ");




            SqlCommand Comand = new SqlCommand(Sql, con);

            if (Comand.ExecuteNonQuery().Equals(1))
            {
                MessageBox.Show("you are sign up successfuly", "dwadwad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                refreshBTn.PerformClick();
            }
            else
            {
                MessageBox.Show("this username available ", "wadwa");
            }
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox5.Clear();
 

            refreshBTn.PerformClick();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {



                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cells = row.Cells[0] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cells.Value) == true)
                    {



                        throw new Exception();




                    }







                }
                MessageBox.Show("please select user's to edite!");



            }
            catch (Exception EX)
            {
                edite_pnl.Visible = true;

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string idies = "";
                foreach (DataGridViewRow roow in dataGridView1.Rows)//طبينة باول سطر//متغير من نوع داتا كرد روز على داتاكرد2
                {
                    DataGridViewCheckBoxCell chkchecking = roow.Cells[0] as DataGridViewCheckBoxCell;//حددنه الكولوم الاول من الرو الاول //عرفنة متغير من نوع جيكبوكس 

                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        idies = idies + "'" + roow.Cells[1].Value.ToString() + "'" + ",";
                    }


                }


                // use tracking to understand how its work
                idies = idies.Substring(0, idies.Length - 1);

                SqlConnection con = new SqlConnection(Constr);
                con.Open();
                string Sql = String.Format("Delete From [HR].[dbo].[users] Where user_id IN ({0})", idies);
                SqlCommand DeleteuserCmd = new SqlCommand(Sql, con);

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure?", "department Will Be Deleted", buttons);
                if (result == DialogResult.Yes)
                {
                    int x = DeleteuserCmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        dataGridView1.Rows.Clear();

                     }
                    refreshBTn.PerformClick();

                }
                else
                {
                }
                con.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("please select user(s) to delete!");
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            try
            {

                string id = "";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cells = row.Cells[0] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cells.Value) == true)
                    {

                        id = row.Cells[1].Value.ToString();
                        SqlConnection con = new SqlConnection(Constr);
                        con.Open();
                        string username = row.Cells[2].Value.ToString();
                        string firstname = row.Cells[3].Value.ToString();
                        string lastname = row.Cells[4].Value.ToString();
                        string password = row.Cells[5].Value.ToString();
                        string email = row.Cells[6].Value.ToString();


                        string Sql = String.Format("update  [HR].[dbo].[users] set [username] = '{0}', [first_name] = '{1}' ,[last_name] = '{2}', [password] = '{3}' ,[email] = '{4}' Where [user_id] IN ({5})", username, firstname
                            , lastname, password, email, id);
                        SqlCommand changedepCmd = new SqlCommand(Sql, con);

                        changedepCmd.ExecuteNonQuery();






                        con.Close();

                        throw new Exception();

                    }







                }
                MessageBox.Show("please select user's to change!");


            }
            catch (Exception EX)
            {
                MessageBox.Show("user's  changed sucssesfully!");
                refreshBTn.PerformClick();

            }

        }

        private void previligecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            privilegecombo_id.SelectedIndex = previligecombo.SelectedIndex;

        }

        private void refreshBTn_Click_1(object sender, EventArgs e)
        {
            
                try
                {
                    dataGridView1.Rows.Clear();

                    //dataGridView1.BackgroundColor = Color.LightGray;

                    SqlConnection con = new SqlConnection(Constr);



                string select_user = @"
 SELECT [user_id]
      ,t1.[username]
      ,t1.[first_name]
      ,t1.[last_name]
      ,t1.[password]
      ,t1.[email]
      ,t2.[privilege_name] from [HR].[dbo].[users] t1
                     
                 join [HR].[dbo].[privileges] t2 on (t1.[privilege_id] = t2.[privilege_id])



";







                SqlDataAdapter adapter = new SqlDataAdapter(select_user, con);
                DataTable table1 = new DataTable();

                adapter.Fill(table1);

                //dataGridView1.DataSource = table1;

                if (table1.Rows.Count != 0)
                {
                    foreach (DataRow row in table1.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[1].Value = row["user_id"].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = row["username"].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = row["first_name"].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = row["last_name"].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = row["password"].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = row["email"].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = row["privilege_name"].ToString();



                    }
                }



                string sqlprivilege = @"select * from [HR].[dbo].[privileges]";
                SqlDataAdapter adapter5 = new SqlDataAdapter(sqlprivilege, con);
                DataTable table5 = new DataTable();
                adapter5.Fill(table5);

                if (table5.Rows.Count != 0)
                {
                    foreach (DataRow row in table5.Rows)
                    {
                        //int n = dataGridView2.Rows.Add();

                        previligecombo.Items.Add(row["privilege_name"].ToString());
                        privilegecombo_id.Items.Add(row["privilege_id"].ToString());

                        //dataGridView2.Rows[n].Cells[7].Value = row["city"].ToString();
                    }
                    previligecombo.SelectedIndex = 0;
                    privilegecombo_id.SelectedIndex = 0;

                }





            }
            catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }

            
        }

        private void back_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();

        }

        private void UsersDataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell cells = row.Cells[0] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cells.Value) == true)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void backBTn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}