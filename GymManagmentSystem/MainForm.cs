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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm= new AddMemberForm();
            addMemberForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymantForm paymantForm= new PaymantForm();
            paymantForm.Show();
            this.Hide();
        }

        private void ViewMembersBTN_Click(object sender, EventArgs e)
        {
            ViewMembersForm viewMembersForm = new ViewMembersForm();
            viewMembersForm.Show();
            this.Hide();
        }

        private void CloseLBL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }
    }
}
