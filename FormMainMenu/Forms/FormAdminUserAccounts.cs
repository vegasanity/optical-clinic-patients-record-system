using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu.Forms
{
    public partial class FormAdminUserAccounts : Form
    {
        MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
        public FormAdminUserAccounts()
        {
            InitializeComponent();
        }

        public bool IsUsernameExisting(bool isUsernameExisting = false)
        {
            var serialNo = dbContext.GetAccountsUsername(txtUsername.Text);

            foreach (var number in serialNo)
            {
                isUsernameExisting = true;
            }
            return isUsernameExisting;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check if username is existing
            if (IsUsernameExisting())
            {
                MessageBox.Show("Username is already used!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtUsername.Text)
                        || String.IsNullOrWhiteSpace(txtLastName.Text) || String.IsNullOrWhiteSpace(cmbPosition.Text))
            {
                MessageBox.Show("Please fill in required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to 'Create' this account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Insert Query
                byte gender = rbMale.Checked ? (byte)Enums.Gender.Male : (byte)Enums.Gender.Female;
                dbContext.InsertUserAccounts(txtFirstName.Text,txtLastName.Text, gender, (byte)cmbPosition.SelectedIndex, txtUsername.Text, "123456", 1);
                MessageBox.Show("User Account has been saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAdminUserAccounts_Load(object sender, EventArgs e)
        {
            UserAccountLoad();
        }

        public void UserAccountLoad()
        {
            dgvListOfUserAccounts.DataSource = dbContext.GetUserAccounts();
            dgvListOfUserAccounts.Columns[0].HeaderCell.Value = "Username";
            dgvListOfUserAccounts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOfUserAccounts.Columns[1].HeaderCell.Value = "First Name";
            dgvListOfUserAccounts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfUserAccounts.Columns[2].HeaderCell.Value = "Last Name";
            dgvListOfUserAccounts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfUserAccounts.Columns[3].HeaderCell.Value = "Gender";
            dgvListOfUserAccounts.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfUserAccounts.Columns[4].HeaderCell.Value = "Position";
            dgvListOfUserAccounts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfUserAccounts.Columns[5].Visible = false;

        }
        private void dgvListOfUserAccounts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvListOfUserAccounts.Rows[e.RowIndex];
            //txtUsername.Text = row.Cells[0].Value.ToString();
            //txtFirstName.Text = row.Cells[1].Value.ToString();
            //txtLastName.Text = row.Cells[2].Value.ToString();
            //lblGender.Text = row.Cells[3].Value.ToString();
            //cmbPosition.Text = row.Cells[4].Value.ToString();
            //lblUserId.Text = row.Cells[5].Value.ToString();
            //if(lblGender.Text == "Male")
            //{
            //    rbMale.Checked = true;
            //}
            //else
            //{
            //    rbFemale.Checked = true;
            //}
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to 'Block' this account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //Block account query
                dbContext.BlockUserAccount(Convert.ToInt32(lblUserId.Text), 0);
                MessageBox.Show("User Account has been blocked successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListOfUserAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListOfUserAccounts.Rows[e.RowIndex];
            txtUsername.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            lblGender.Text = row.Cells[3].Value.ToString();
            cmbPosition.Text = row.Cells[4].Value.ToString();
            lblUserId.Text = row.Cells[5].Value.ToString();
            if (lblGender.Text == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UserAccountLoad();
            txtUsername.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            lblGender.Text = string.Empty;
            cmbPosition.Text = string.Empty;
            lblUserId.Text = string.Empty;
        }
    }
}
