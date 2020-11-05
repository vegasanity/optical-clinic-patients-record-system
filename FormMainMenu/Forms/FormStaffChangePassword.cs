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
    public partial class FormStaffChangePassword : Form
    {
        MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();

        public FormStaffChangePassword()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtNewPassword.Text = String.Empty;
            txtConfirmPassword.Text = String.Empty;
        }

        public bool IsUsernameAndPasswordExist(bool isUsernameAndPasswordExist = false)
        {
            var isExist = dbContext.GetUsernamePassword(txtUsername.Text, txtPassword.Text);

            foreach (var number in isExist)
            {
                isUsernameAndPasswordExist = true;
            }
            return isUsernameAndPasswordExist;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsUsernameAndPasswordExist())
            {
                if(txtConfirmPassword.Text == txtNewPassword.Text)
                {
                    dbContext.UpdateUserPassword(txtUsername.Text, txtNewPassword.Text);
                    MessageBox.Show("User Password has been saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please confirm your password!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("User account is not exist!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
