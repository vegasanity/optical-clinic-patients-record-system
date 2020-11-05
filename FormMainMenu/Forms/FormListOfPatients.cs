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
    public partial class FormListOfPatients : Form
    {
        //Forms.FormPatient formPatient;
        //Forms.FormPatientRecords formPatientRecords;
        int[] count = new int[1];
        object[] date = new object[1];
        public FormListOfPatients()
        {
            InitializeComponent();
        }
        
        public void PatientLoad()
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            cmbSearch.SelectedIndex = 0;
            dgvListOfPatient.DataSource = dbContext.GetPatients();
            dgvListOfPatient.Columns[0].HeaderCell.Value = "Id";
            dgvListOfPatient.Columns[0].Visible = false;
            dgvListOfPatient.Columns[1].HeaderCell.Value = "Date and Time";
            dgvListOfPatient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[2].HeaderCell.Value = "Patient No.";
            dgvListOfPatient.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[3].HeaderCell.Value = "Full Name";
            dgvListOfPatient.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOfPatient.Columns[4].HeaderCell.Value = "Gender";
            dgvListOfPatient.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[5].HeaderCell.Value = "Birthday";
            dgvListOfPatient.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[6].HeaderCell.Value = "Age";
            dgvListOfPatient.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[7].HeaderCell.Value = "Mobile No.";
            dgvListOfPatient.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[8].HeaderCell.Value = "Telephone No.";
            dgvListOfPatient.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[9].HeaderCell.Value = "Address";
            dgvListOfPatient.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[10].HeaderCell.Value = "Status";
            dgvListOfPatient.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[11].Visible = false;
            dgvListOfPatient.Columns[12].Visible = false;
            dgvListOfPatient.Columns[13].Visible = false;
            dgvListOfPatient.Columns[14].Visible = false;
            dgvListOfPatient.Columns[15].Visible = false;
            dgvListOfPatient.Columns[16].Visible = false;
            dgvListOfPatient.Columns[17].Visible = false;
        }

        private void FormListOfPatients_Load(object sender, EventArgs e)
        {
            PatientLoad();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            switch (cmbSearch.SelectedIndex)
            {
                case 0:
                    dgvListOfPatient.DataSource = dbContext.GetPatients();
                    txtSearch.Enabled = false;
                    dtpSearch.Enabled = false;
                    txtSearch.Visible = true;
                    break;
                case 1:
                    dgvListOfPatient.DataSource = dbContext.SearchDatePatient(dtpSearch.Value.Date.ToShortDateString());
                    dtpSearch.Enabled = true;
                    dtpSearch.Visible = true;
                    txtSearch.Text = null;
                    txtSearch.Visible = false;
                    txtSearch.Enabled = false;
                    break;
                case 2:
                    dgvListOfPatient.DataSource = dbContext.SearchIdPatient(txtSearch.Text);
                    txtSearch.Text = null;
                    txtSearch.Visible = true;
                    txtSearch.Enabled = true;
                    dtpSearch.Enabled = false;
                    dtpSearch.Visible = false;
                    break;
                case 3:
                    dgvListOfPatient.DataSource = dbContext.SearchFullNamePatient(txtSearch.Text);
                    txtSearch.Text = null;
                    txtSearch.Visible = true;
                    txtSearch.Enabled = true;
                    dtpSearch.Enabled = false;
                    dtpSearch.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            dgvListOfPatient.DataSource = dbContext.SearchDatePatient(dtpSearch.Value.Date.ToShortDateString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            switch (cmbSearch.SelectedIndex)
            {
                case 1:
                    dgvListOfPatient.DataSource = dbContext.SearchDatePatient(dtpSearch.Value.Date.ToShortDateString());
                    dtpSearch.Enabled = true;
                    txtSearch.Visible = false;
                    txtSearch.Enabled = false;
                    break;
                case 2:
                    dgvListOfPatient.DataSource = dbContext.SearchIdPatient(txtSearch.Text);
                    txtSearch.Visible = true;
                    dtpSearch.Enabled = false;
                    dtpSearch.Visible = false;
                    break;
                case 3:
                    dgvListOfPatient.DataSource = dbContext.SearchFullNamePatient(txtSearch.Text);
                    txtSearch.Visible = true;
                    dtpSearch.Enabled = false;
                    dtpSearch.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void dgvListOfPatient_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListOfPatient.Rows[e.RowIndex];
            lblPatientId.Text = row.Cells[0].Value.ToString();
            lblSerialNo.Text = row.Cells[2].Value.ToString();
            lblPatientName.Text = row.Cells[3].Value.ToString();
            lblGender.Text = row.Cells[4].Value.ToString();
            dtpBirthday.Text = row.Cells[5].Value.ToString();
            lblMobileNo.Text = row.Cells[7].Value.ToString();
            lblTelephoneNo.Text = row.Cells[8].Value.ToString();
            lblFirstName.Text = row.Cells[11].Value.ToString();
            lblMiddleName.Text = row.Cells[12].Value.ToString();
            lblLastName.Text = row.Cells[13].Value.ToString();
            lblHouseNo.Text = row.Cells[14].Value.ToString();
            lblStreet.Text = row.Cells[15].Value.ToString();
            lblBarangay.Text = row.Cells[16].Value.ToString();
            lblCity.Text = row.Cells[17].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            DialogResult result = MessageBox.Show("Are you sure you want to remove this Patient - " + lblPatientName.Text + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                dbContext.RemovePatientInformation(Convert.ToInt32(lblPatientId.Text));
                PatientLoad();
                MessageBox.Show("Patient is already removed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            Forms.FormPatient formPatient = new Forms.FormPatient();
            formPatient.btnSubmitPatient.Text = "Update";
            formPatient.lblPatientId.Text = lblPatientId.Text;
            formPatient.txtPatientNo.Text = lblSerialNo.Text;
            formPatient.txtFirstName.Text = lblFirstName.Text;
            formPatient.txtMiddleName.Text = lblMiddleName.Text;
            formPatient.txtLastName.Text = lblLastName.Text;
            if (lblGender.Text == "Male")
                formPatient.rbMale.Checked = true;
            else
                formPatient.rbFemale.Checked = true;
            formPatient.dtpBirthday.Value = dtpBirthday.Value;
            formPatient.txtMobileNo.Text = lblMobileNo.Text;
            formPatient.txtTelephoneNo.Text = lblTelephoneNo.Text;
            formPatient.txtHouseNo.Text = lblHouseNo.Text;
            formPatient.txtStreet.Text = lblStreet.Text;
            formPatient.txtBarangay.Text = lblBarangay.Text;
            formPatient.txtCity.Text = lblCity.Text;
            formPatient.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PatientLoad();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            Forms.FormPatientRecords formPatientRecords = new Forms.FormPatientRecords();
            formPatientRecords.txtName.Text = lblPatientName.Text;
            formPatientRecords.txtAddress.Text = lblHouseNo.Text + " " + lblStreet.Text + " " + lblBarangay.Text + " " + lblCity.Text;
            formPatientRecords.txtMobile.Text = lblMobileNo.Text;
            formPatientRecords.txtTelephone.Text = lblTelephoneNo.Text;
            formPatientRecords.txtBirthdate.Text = dtpBirthday.Value.Date.ToShortDateString();
            formPatientRecords.txtGender.Text = lblGender.Text;

            var countOpticalLens = dbContext.CountPatientOpticalLens(Convert.ToInt32(lblPatientId.Text));
            foreach (var countPatientOpticalLens in countOpticalLens)
                count[0] = (int)countPatientOpticalLens;
            formPatientRecords.lblCountOptical.Text = count[0].ToString();

            var countContactLens = dbContext.CountPatientContactLens(Convert.ToInt32(lblPatientId.Text));
            foreach(var countPatientContactLens in countContactLens)
                count[0] = (int)countPatientContactLens;
            formPatientRecords.lblCountContact.Text = count[0].ToString();

            var getPatientLastCheckUpDateOptical = dbContext.GetLastCheckUpDateOpticalLens(Convert.ToInt32(lblPatientId.Text));
            foreach(var patientLastCheckUpDateOptical in getPatientLastCheckUpDateOptical)
                date[0] = patientLastCheckUpDateOptical.ToString();
            formPatientRecords.lblLastCheckUpDateOptical.Text = date[0].ToString();

            var getPatientLastCheckUpDatContact = dbContext.GetLastCheckUpDateContactLens(Convert.ToInt32(lblPatientId.Text));
            foreach (var patientLastCheckUpDateContact in getPatientLastCheckUpDatContact)
                date[0] = patientLastCheckUpDateContact.ToString();
            formPatientRecords.lblLastCheckUpDateContact.Text = date[0].ToString();

            formPatientRecords.dgvPatientOpticalLens.DataSource = dbContext.GetPatientOpticalLens(Convert.ToInt32(lblPatientId.Text));
            formPatientRecords.dgvPatientContactLens.DataSource = dbContext.GetPatientContactLens(Convert.ToInt32(lblPatientId.Text));
            formPatientRecords.ShowDialog();
        }
    }
}
