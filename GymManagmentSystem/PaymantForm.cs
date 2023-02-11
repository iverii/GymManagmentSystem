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
    public partial class PaymantForm : Form
    {
        public PaymantForm()
        {
            InitializeComponent();
        }
        int key = 1;
        SqlConnection con = new SqlConnection(@"Data Source=IVERI\SQLEXPRESS;Initial Catalog=GymManagmentSystem_DB;Integrated Security=True");
        void FillNames()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name From Members_TB",con);
            SqlDataReader sdr;
            sdr= cmd.ExecuteReader();
            DataTable dataTable= new DataTable();
            dataTable.Columns.Add("Name",typeof(string));
            dataTable.Load(sdr);
            MemberNamesCB.ValueMember = "Name";
            MemberNamesCB.DataSource= dataTable;
            con.Close();
        }
        private void PaymantForm_Load(object sender, EventArgs e)
        {
            FillNames();
            populate();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            MemberNamesCB.Text = "";
            AmountTB.Text = "";
        }
        private void BackBTN_Click(object sender, EventArgs e)
        {
            MainForm mainForm= new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void Fillter()
        {
            con.Open();
            string query = "Select * from Payment_TB where Member = '"+ MebmberNameTB.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        void populate()
        {
            con.Open();
            string query = "Select * from Payment_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void PayBTN_Click(object sender, EventArgs e)
        {
            if (MemberNamesCB.Text == "" || AmountTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string payPeriod = dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Year.ToString();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Payment_TB where Member = '"+MemberNamesCB.SelectedValue.ToString()+"' and Month = '"+payPeriod+"'",con);
                    DataTable dataTable= new DataTable();
                    sda.Fill(dataTable);
                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Already Paied in this month");
                    }
                    else
                    {
                        string query = "insert into Payment_TB values ('"+payPeriod+"','"+MemberNamesCB.SelectedValue.ToString()+"','"+AmountTB.Text+"')";
                        SqlCommand cmd = new SqlCommand(query,con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done");
                    }
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            Fillter();
            MebmberNameTB.Text = "";
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
