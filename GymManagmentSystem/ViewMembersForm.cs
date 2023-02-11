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
    public partial class ViewMembersForm : Form
    {
        public ViewMembersForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=IVERI\SQLEXPRESS;Initial Catalog=GymManagmentSystem_DB;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "Select * from Members_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            ViewMembersDGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void ViewMembersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void ViewMembersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Fillter()
        {
            con.Open();
            string query = "Select * from Members_TB where Name = '" + MemberNameTB.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            ViewMembersDGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Fillter();
            MemberNameTB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
