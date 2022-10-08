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
using System.Configuration;
namespace Adminstrator
{
    public partial class Departments_manager : Form
    {
        public static string Constr = @"Data Source ;initial catalog =HR;User ID=sa;Password=";

        public Departments_manager()
        {
            InitializeComponent();
        }



        private void Departments_manager_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridView2.Rows.Clear();

                //dataGridView1.BackgroundColor = Color.LightGray;

                SqlConnection con = new SqlConnection(Constr);




                string select_dep = @"select  t1.[department_id],
t1.[department_name]
       ,t1.[town]
	  , t2.[city]
	,t3.[country_name]
	,t4.[region_name]
	  from [HR].[dbo].[departments] t1 
	   
	       join [HR].[dbo].[locations] t2 on (t1.[location_id]=t2.[location_id])
		 join  [HR].[dbo].[countries] t3 on ( t2.[country_id]= t3.[country_id])   
		   join  [HR].[dbo].[regions] t4 on ( t3.[region_id]= t4.[region_id])";







                SqlDataAdapter adapter = new SqlDataAdapter(select_dep, con);
                DataTable table1 = new DataTable();

                adapter.Fill(table1);

                //dataGridView1.DataSource = table1;

                if (table1.Rows.Count != 0)
                {
                    foreach (DataRow row in table1.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[1].Value = row["department_id"].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = row["department_name"].ToString();
                        dataGridView2.Rows[n].Cells[3].Value = row["town"].ToString();
                        dataGridView2.Rows[n].Cells[4].Value = row["city"].ToString();
                        dataGridView2.Rows[n].Cells[5].Value = row["country_name"].ToString();
                        dataGridView2.Rows[n].Cells[6].Value = row["region_name"].ToString();




                    }
                }




                string Sqllocation = @"select * from [HR].[dbo].[locations]";
                SqlDataAdapter adapter5 = new SqlDataAdapter(Sqllocation, con);
                DataTable table5 = new DataTable();
                adapter5.Fill(table5);

                if (table5.Rows.Count != 0)
                {
                    foreach (DataRow row in table5.Rows)
                    {
                        //int n = dataGridView2.Rows.Add();

                        locationCombo.Items.Add(row["city"].ToString());
                        locationCombo_id.Items.Add(row["location_id"].ToString());

                        //dataGridView2.Rows[n].Cells[7].Value = row["city"].ToString();
                    }
                    locationCombo.SelectedIndex = 0;
                    locationCombo_id.SelectedIndex = 0;

                }



            }
            catch (Exception EX)
            {
                MessageBox.Show("error");
            }




















        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adddeptBTn_Click(object sender, EventArgs e)
        {
            fatherdept_pnl.Visible = true;
            adddept_pnl.Visible = true;
            editedept_pnl.Visible = false;
            adddept_pnl.Dock = DockStyle.Fill;
        }

        private void editedeptBTn_Click(object sender, EventArgs e)
        {
            try
            {



                foreach (DataGridViewRow row in dataGridView2.Rows)
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
                fatherdept_pnl.Visible = true;
                adddept_pnl.Visible = false;
                editedept_pnl.Visible = true;
            }


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            //dataGridView1.BackgroundColor = Color.LightGray;

            SqlConnection con = new SqlConnection(Constr);




            string select_dep = @"select t1.[department_id],
t1.[department_name]
       ,t1.[town]
	  , t2.[city]
	,t3.[country_name]
	,t4.[region_name]
	  from [HR].[dbo].[departments] t1 
	   
	       join [HR].[dbo].[locations] t2 on (t1.[location_id]=t2.[location_id])
		 join  [HR].[dbo].[countries] t3 on ( t2.[country_id]= t3.[country_id])   
		   join  [HR].[dbo].[regions] t4 on ( t3.[region_id]= t4.[region_id])";







            SqlDataAdapter adapter = new SqlDataAdapter(select_dep, con);
            DataTable table1 = new DataTable();

            adapter.Fill(table1);

            //dataGridView1.DataSource = table1;

            if (table1.Rows.Count != 0)
            {
                foreach (DataRow row in table1.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[1].Value = row["department_id"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = row["department_name"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = row["town"].ToString();
                    dataGridView2.Rows[n].Cells[4].Value = row["city"].ToString();
                    dataGridView2.Rows[n].Cells[5].Value = row["country_name"].ToString();
                    dataGridView2.Rows[n].Cells[6].Value = row["region_name"].ToString();


                }
            }



            //string Sqlcountry = @"select * from [HR].[dbo].[countries]";
            //SqlDataAdapter adapter3 = new SqlDataAdapter(Sqlcountry, con);
            //DataTable table3 = new DataTable();
            //adapter3.Fill(table3);

            //if (table3.Rows.Count != 0)
            //{
            //    foreach (DataRow row in table3.Rows)
            //    {
            //        countrycombo.Items.Add(row["country_name"].ToString());
            //        countrycombo_id.Items.Add(row["country_id"].ToString());
            //    }
            //    countrycombo.SelectedIndex = 0;
            //    countrycombo_id.SelectedIndex = 0;

            //}



            //string Sqlregion = @"select * from [HR].[dbo].[regions]";
            //SqlDataAdapter adapter4 = new SqlDataAdapter(Sqlregion, con);
            //DataTable table4 = new DataTable();
            //adapter4.Fill(table4);

            //if (table4.Rows.Count != 0)
            //{
            //    foreach (DataRow row in table4.Rows)
            //    {
            //        regioncombo.Items.Add(row["region_name"].ToString());
            //        regioncombo_id.Items.Add(row["region_id"].ToString());
            //    }
            //    regioncombo.SelectedIndex = 0;
            //    regioncombo_id.SelectedIndex = 0;
            //}





















        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string townname = Towntxt.Text;

                string deptname = departmentnameTxt.Text;

                int locationID = 0;

                locationID = Convert.ToInt32(locationCombo_id.SelectedItem.ToString());

                SqlConnection con = new SqlConnection(Constr);
                con.Open();
                string SqlAdddep = String.Format(@"INSERT INTO [dbo].[departments]
                ([department_name],[location_id],[town])
                 VALUES ('{0}',{1},'{2}')", deptname, locationID, townname);






                SqlCommand AdddepCmd = new SqlCommand(SqlAdddep, con);
                int x = AdddepCmd.ExecuteNonQuery();

                if (x == 1)
                {
                    MessageBox.Show("department add succssfly");


                }



                refreshbtn.PerformClick();


            }

            catch (Exception EX)
            {
                MessageBox.Show("this department alrady existing");
            }
        }

        private void changedep_Click(object sender, EventArgs e)
        {
            try
            {

                string id = "";

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    DataGridViewCheckBoxCell cells = row.Cells[0] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cells.Value) == true)
                    {

                        id = row.Cells[1].Value.ToString();
                        SqlConnection con = new SqlConnection(Constr);
                        con.Open();
                        string deptname = row.Cells[2].Value.ToString();
                        string town = row.Cells[3].Value.ToString();
                        string Sql = String.Format("update  [HR].[dbo].[departments] set [department_name] = '{0}', [town] = '{1}' Where [department_id] IN ({2})", deptname, town, id);
                        SqlCommand changedepCmd = new SqlCommand(Sql, con);

                        int x = changedepCmd.ExecuteNonQuery();




                        con.Close();

                        refreshbtn.PerformClick();

                        throw new Exception();

                    }







                }
                MessageBox.Show("please select department to change!");


            }
            catch (Exception EX)
            {
                MessageBox.Show("department name changed sucssesfully!");
            }


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            try
            {
                string idies = "";


                foreach (DataGridViewRow roow in dataGridView2.Rows)//طبينة باول سطر//متغير من نوع داتا كرد روز على داتاكرد2
                {
                    DataGridViewCheckBoxCell chkchecking = roow.Cells[0] as DataGridViewCheckBoxCell;//حددنه الكولوم الاول من الرو الاول //عرفنة متغير من نوع جيكبوكس 

                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        idies = idies + "'" + roow.Cells[1].Value.ToString() + "'" + ",";
                    }


                }

                // use tracking to understand how its work
                if (idies.Length != 0)
                {
                    idies = idies.Substring(0, idies.Length - 1);

                    SqlConnection con = new SqlConnection(Constr);
                    con.Open();

                    string Sql = String.Format("Delete From [HR].[dbo].[departments] Where department_id IN ({0})", idies);
                    SqlCommand DeleteEmpCmd = new SqlCommand(Sql, con);






                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure?", "department Will Be Deleted", buttons);






                    if (result == DialogResult.Yes)
                    {
                        int x = DeleteEmpCmd.ExecuteNonQuery();
                        if (x == 1)
                        {
                            dataGridView2.Rows.Clear();
                        }
                        refreshbtn.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("ok");

                    }
                    con.Close();

                }
                else if (idies.Length == 0)
                {
                    MessageBox.Show("please select department(s) to delete ");

                }

            }


            catch (Exception EX)
            {



                //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //DialogResult result = MessageBox.Show("delete all ?", " update", buttons);




                try
                {

                    del2.Visible = true;








                }

                catch (Exception ex)
                {
                    MessageBox.Show(EX.ToString());


                }




            }
        }

        private void backBTn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin f1 = new Admin();
            f1.Show();
        }

        private void locationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationCombo_id.SelectedIndex = locationCombo.SelectedIndex;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                string idies2 = "";


                foreach (DataGridViewRow roow in dataGridView2.Rows)//طبينة باول سطر//متغير من نوع داتا كرد روز على داتاكرد2
                {
                    DataGridViewCheckBoxCell chkchecking = roow.Cells[0] as DataGridViewCheckBoxCell;//حددنه الكولوم الاول من الرو الاول //عرفنة متغير من نوع جيكبوكس 

                    if (Convert.ToBoolean(chkchecking.Value) == true)
                    {
                        idies2 = idies2 + "'" + roow.Cells[1].Value.ToString() + "'" + ",";
                    }


                }

                // use tracking to understand how its work
                if (idies2.Length != 0)
                {
                    idies2 = idies2.Substring(0, idies2.Length - 1);

                    SqlConnection con = new SqlConnection(Constr);
                    con.Open();

                    string Sql = String.Format("Delete From [HR].[dbo].[employees] Where [department_id] IN ({0})", idies2);
                    SqlCommand DeleteuserCmd = new SqlCommand(Sql, con);
                    MessageBox.Show("user  deleted");

                    DeleteuserCmd.ExecuteNonQuery();




                    string Sql2 = String.Format("Delete From [HR].[dbo].[departments] Where [department_id] IN ({0})", idies2);
                    SqlCommand DeleteuserCmd2 = new SqlCommand(Sql2, con);

                    DeleteuserCmd2.ExecuteNonQuery();
                    MessageBox.Show("department deleted deleted");
                    refreshbtn.PerformClick();
                    del2.Hide();


                }


            }

            catch (Exception EX)
            {
                EX.ToString();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}

