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
namespace GymManagmentSystem
{
    public partial class AddMemberForm : Form
    {
         
        public AddMemberForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=IVERI\SQLEXPRESS;Initial Catalog=GymManagmentSystem_DB;Integrated Security=True");

        

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void AddMemberBTN_Click(object sender, EventArgs e)
        {
            if(MemberNameTB.Text == "" || PhoneNumberTB.Text == "" || AgeTB.Text == "" || AmountTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Members_TB values ('"+MemberNameTB.Text+"','"+PhoneNumberTB.Text+"','"+GenderCB.SelectedItem.ToString()+"', '"+AgeTB.Text+"','"+AmountTB.Text+"','"+TimingCB.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    con.Close();
                    MemberNameTB.Text = "";
                    PhoneNumberTB.Text = "";
                    GenderCB.Text = "";
                    AgeTB.Text = "";
                    AmountTB.Text = "";
                    TimingCB.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            MemberNameTB.Text = "";
            PhoneNumberTB.Text = "";
            GenderCB.Text = "";
            AgeTB.Text = "";
            AmountTB.Text = "";
            TimingCB.Text = "";
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBTN1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
