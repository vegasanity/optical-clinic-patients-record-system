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
    public partial class FormPatient : Form
    {
        //FormMainMenu frm;
        public FormPatient()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtPatientNo.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            rbMale.Checked = true;
            dtpBirthday.Value = DateTime.Now;
            lblAge.Text = "0";
            txtMobileNo.Text = String.Empty;
            txtTelephoneNo.Text = String.Empty;
            txtHouseNo.Text = String.Empty;
            txtStreet.Text = String.Empty;
            txtBarangay.Text = String.Empty;
            txtCity.Text = String.Empty;

        }
        public bool IsPatientNoExisting(bool isPatientNoExisting = false)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            var serialNo = dbContext.GetSerialNumber(txtPatientNo.Text);

            foreach (var number in serialNo)
            {
                isPatientNoExisting = true;
            }
            return isPatientNoExisting;
        }
        private void btnSubmitPatient_Click(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            if(btnSubmitPatient.Text == "Submit")
            {
                //Check if serial is existing
                if (IsPatientNoExisting())
                {
                    MessageBox.Show("Patient No. is already used!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (String.IsNullOrWhiteSpace(txtPatientNo.Text) || String.IsNullOrWhiteSpace(txtFirstName.Text)
                        || Convert.ToInt32(lblAge.Text) <= 0 || String.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill in required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to 'Sumbit' this patient?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Insert Query
                    byte gender = rbMale.Checked ? (byte)Enums.Gender.Male : (byte)Enums.Gender.Female;
                    byte isActive = 1;
                    dbContext.InsertPatient(txtPatientNo.Text, txtFirstName.Text, txtMiddleName.Text,
                        gender, dtpBirthday.Value, Convert.ToByte(lblAge.Text), txtMobileNo.Text, txtTelephoneNo.Text, txtHouseNo.Text,
                        txtStreet.Text, txtBarangay.Text, txtCity.Text, DateTime.Now, txtLastName.Text, isActive);
                    MessageBox.Show("Patient Information has been saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }

            if(btnSubmitPatient.Text == "Update")
            {
                if (String.IsNullOrWhiteSpace(txtPatientNo.Text) || String.IsNullOrWhiteSpace(txtFirstName.Text)
                        || Convert.ToInt32(lblAge.Text) <= 0 || String.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Please fill in required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to 'Update' this patient?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Update Query
                    byte gender = rbMale.Checked ? (byte)Enums.Gender.Male : (byte)Enums.Gender.Female;
                    dbContext.UpdatePatientInformation(Convert.ToInt32(lblPatientId.Text), txtPatientNo.Text, txtFirstName.Text,
                        txtMiddleName.Text, txtLastName.Text, gender, dtpBirthday.Value, Convert.ToByte(lblAge.Text), txtMobileNo.Text,
                        txtTelephoneNo.Text, txtHouseNo.Text, txtStreet.Text, txtBarangay.Text, txtCity.Text);
                    MessageBox.Show("Patient Information has been updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Close();
                }
            }
        }
            
        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var today = DateTime.Now; //Save date today
                var birthdate = dtpBirthday.Value; //Get patient birthdate
                var age = today.Year - birthdate.Year; //Compute patient age by years

                if (birthdate.AddYears(age) > DateTime.Now)
                    age--; //Age that not yet taking

                lblAge.Text = age.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void lblSerialNoReq_MouseEnter(object sender, EventArgs e)
        {
            tTipFormPatient.SetToolTip(lblSerialNoReq, "Input Serial No (0 - 1)");
        }
        private void lblFirstNameReq_MouseEnter(object sender, EventArgs e)
        {
            tTipFormPatient.SetToolTip(lblFirstNameReq, "Input First Name (A-Z or a-z)");
        }
    }
}
