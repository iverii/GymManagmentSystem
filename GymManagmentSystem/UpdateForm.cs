using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagmentSystem
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=IVERI\SQLEXPRESS;Initial Catalog=GymManagmentSystem_DB;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "Select * from Members_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UpdateMembersDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void UpdateMembersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = UpdateMembersDGV.Rows[e.RowIndex];
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
                MemberNameTB.Text = row.Cells[1].Value.ToString();
                NumberTB.Text = row.Cells[2].Value.ToString();
                GenderCB.Text = row.Cells[3].Value.ToString();
                AgeTB.Text = row.Cells[4].Value.ToString();
                AmountTB.Text = row.Cells[5].Value.ToString();
                TimingCB.Text = row.Cells[6].Value.ToString();
            }
            /*MemberNameTB.Text = UpdateMembersDGV.SelectedRows[0].Cells[1].Value.ToString();
            NumberTB.Text = UpdateMembersDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCB.Text = UpdateMembersDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTB.Text = UpdateMembersDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTB.Text = UpdateMembersDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCB.Text = UpdateMembersDGV.SelectedRows[0].Cells[6].Value.ToString()*//*;
                                                                                         * */

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            MemberNameTB.Text = "";
            NumberTB.Text = "";
            GenderCB.Text = "";
            AgeTB.Text = "";
            AmountTB.Text = "";
            TimingCB.Text = "";
        }

        private void BackBTN1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The member to be delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Members_TB where id = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (key == 0 || MemberNameTB.Text =="" || NumberTB.Text == "" || GenderCB.Text == "" || AgeTB.Text == "" || AmountTB.Text == "" || TimingCB.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Members_TB set Name = '" + MemberNameTB.Text + "',Phone = '" + NumberTB.Text + "',Gender = '" + GenderCB.Text + "',Age = '" + AgeTB.Text + "',Amount = '" + AmountTB.Text + "',Timinge = '" + TimingCB.Text + "' Where id = "+ key +";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
