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
    public partial class FormRx : Form
    {
        public FormRx()
        {
            InitializeComponent();
            
        }
        public void PatientLoad()
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            cmbSearch.SelectedIndex = 0;
            dgvListOfPatient.DataSource = dbContext.GetPatientsId();
            dgvListOfPatient.Columns[0].HeaderCell.Value = "Id";
            dgvListOfPatient.Columns[0].Visible = false;
            dgvListOfPatient.Columns[1].HeaderCell.Value = "Patient No.";
            dgvListOfPatient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListOfPatient.Columns[2].HeaderCell.Value = "Full Name";
            dgvListOfPatient.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void Clear()
        {
            txtSerialNo.Text = String.Empty;
            cmbOLRS.Text = String.Empty;
            cmbOLRC.Text = String.Empty;
            cmbOLRA.Text = String.Empty;
            cmbOLRPD.Text = String.Empty;
            cmbOLRADD.Text = String.Empty;
            cmbOLRPRISM.Text = String.Empty;
            cmbOLRBASE.Text = String.Empty;
            cmbOLROH.Text = String.Empty;
            cmbOLLS.Text = String.Empty;
            cmbOLLC.Text = String.Empty;
            cmbOLLA.Text = String.Empty;
            cmbOLLPD.Text = String.Empty;
            cmbOLLADD.Text = String.Empty;
            cmbOLLPRISM.Text = String.Empty;
            cmbOLLBASE.Text = String.Empty;
            cmbOLLOH.Text = String.Empty;
            cmbCLRS.Text = String.Empty;
            cmbCLRC.Text = String.Empty;
            cmbCLRA.Text = String.Empty;
            cmbCLRBC.Text = String.Empty;
            cmbCLRDptr.Text = String.Empty;
            cmbCLLS.Text = String.Empty;
            cmbCLLC.Text = String.Empty;
            cmbCLLA.Text = String.Empty;
            cmbCLLBC.Text = String.Empty;
            cmbCLLDptr.Text = String.Empty;
            cbOpticalLens.Checked = false;
            cbContactLens.Checked = false;
            txtOpthometrist.Text = String.Empty;
            txtOptician.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }
        private void FormRx_Load(object sender, EventArgs e)
        {
            PatientLoad();
        }
        private void dgvListOfPatient_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListOfPatient.Rows[e.RowIndex];
            lblPatientId.Text = row.Cells[0].Value.ToString();
            txtPatientNo.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
        }
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            switch (cmbSearch.SelectedIndex)
            {
                case 0:
                    dgvListOfPatient.DataSource = dbContext.GetPatientsId();
                    txtSearch.Enabled = false;
                    break;
                case 1:
                    dgvListOfPatient.DataSource = dbContext.SearchSerialNoRx(txtSearch.Text);
                    txtSearch.Enabled = true;
                    break;
                case 2:
                    dgvListOfPatient.DataSource = dbContext.SearchNameRx(txtSearch.Text);
                    txtSearch.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            switch (cmbSearch.SelectedIndex)
            {
                case 1:
                    dgvListOfPatient.DataSource = dbContext.SearchSerialNoRx(txtSearch.Text);
                    txtSearch.Enabled = true;
                    break;
                case 2:
                    dgvListOfPatient.DataSource = dbContext.SearchNameRx(txtSearch.Text);
                    txtSearch.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void cbOpticalLens_CheckedChanged(object sender, EventArgs e)
        {
            if(cbOpticalLens.Checked == true)
            {
                cmbOLRS.Enabled = true;
                cmbOLRC.Enabled = true;
                cmbOLRA.Enabled = true;
                cmbOLRPD.Enabled = true;
                cmbOLRADD.Enabled = true;
                cmbOLRPRISM.Enabled = true;
                cmbOLRBASE.Enabled = true;
                cmbOLROH.Enabled = true;
                cmbOLLS.Enabled = true;
                cmbOLLC.Enabled = true;
                cmbOLLA.Enabled = true;
                cmbOLLPD.Enabled = true;
                cmbOLLADD.Enabled = true;
                cmbOLLPRISM.Enabled = true;
                cmbOLLBASE.Enabled = true;
                cmbOLLOH.Enabled = true;
            }
            else
            {
                cmbOLRS.Enabled = false;
                cmbOLRC.Enabled = false;
                cmbOLRA.Enabled = false;
                cmbOLRPD.Enabled = false;
                cmbOLRADD.Enabled = false;
                cmbOLRPRISM.Enabled = false;
                cmbOLRBASE.Enabled = false;
                cmbOLROH.Enabled = false;
                cmbOLLS.Enabled = false;
                cmbOLLC.Enabled = false;
                cmbOLLA.Enabled = false;
                cmbOLLPD.Enabled = false;
                cmbOLLADD.Enabled = false;
                cmbOLLPRISM.Enabled = false;
                cmbOLLBASE.Enabled = false;
                cmbOLLOH.Enabled = false;
                //
                cmbOLRS.SelectedIndex = 0;
                cmbOLRC.SelectedIndex = 0;
                cmbOLRA.SelectedIndex = 0;
                cmbOLRPD.SelectedIndex = 0;
                cmbOLRADD.SelectedIndex = 0;
                cmbOLRPRISM.SelectedIndex = 0;
                cmbOLRBASE.SelectedIndex = 0;
                cmbOLROH.SelectedIndex = 0;
                cmbOLLS.SelectedIndex = 0;
                cmbOLLC.SelectedIndex = 0;
                cmbOLLA.SelectedIndex = 0;
                cmbOLLPD.SelectedIndex = 0;
                cmbOLLADD.SelectedIndex = 0;
                cmbOLLPRISM.SelectedIndex = 0;
                cmbOLLBASE.SelectedIndex = 0;
                cmbOLLOH.SelectedIndex = 0;
            }
        }
        private void cbContactLens_CheckedChanged(object sender, EventArgs e)
        {
            if(cbContactLens.Checked == true)
            {
                cmbCLRS.Enabled = true;
                cmbCLRC.Enabled = true;
                cmbCLRA.Enabled = true;
                cmbCLRBC.Enabled = true;
                cmbCLRDptr.Enabled = true;
                cmbCLLS.Enabled = true;
                cmbCLLC.Enabled = true;
                cmbCLLA.Enabled = true;
                cmbCLLBC.Enabled = true;
                cmbCLLDptr.Enabled = true;
            }
            else
            {
                cmbCLRS.Enabled = false;
                cmbCLRC.Enabled = false;
                cmbCLRA.Enabled = false;
                cmbCLRBC.Enabled = false;
                cmbCLRDptr.Enabled = false;
                cmbCLLS.Enabled = false;
                cmbCLLC.Enabled = false;
                cmbCLLA.Enabled = false;
                cmbCLLBC.Enabled = false;
                cmbCLLDptr.Enabled = false;
                //
                cmbCLRS.SelectedIndex = 0;
                cmbCLRC.SelectedIndex = 0;
                cmbCLRA.SelectedIndex = 0;
                cmbCLRBC.SelectedIndex = 0;
                cmbCLRDptr.SelectedIndex = 0;
                cmbCLLS.SelectedIndex = 0;
                cmbCLLC.SelectedIndex = 0;
                cmbCLLA.SelectedIndex = 0;
                cmbCLLBC.SelectedIndex = 0;
                cmbCLLDptr.SelectedIndex = 0;
            }
        }
        public bool IsOpticalSerialNoExisting(bool isOpticalSerialNoExisting = false)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            var opticalSerialNo = dbContext.GetSerialNumberOpticalRx(txtSerialNo.Text);

            foreach (var number in opticalSerialNo)
            {
                isOpticalSerialNoExisting = true;
            }

            return isOpticalSerialNoExisting;
        }

        public bool IsContactSerialNoExisting(bool isContactSerialNoExisting = false)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            var contactSerialNo = dbContext.GetSerialNumberContactRx(txtSerialNo.Text);

            foreach (var number in contactSerialNo)
            {
                isContactSerialNoExisting = true;
            }

            return isContactSerialNoExisting;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
            var patientLens = "";
            var isOpticalLens = false;
            var isContactLens = false;

            if(String.IsNullOrWhiteSpace(txtSerialNo.Text))
            {
                MessageBox.Show("Please input Rx - Serial No.!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsOpticalSerialNoExisting() || IsContactSerialNoExisting())
            {
                MessageBox.Show("Serial No. is already used!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbOpticalLens.Checked == true || cbContactLens.Checked == true)
            {
                if (cbOpticalLens.Checked == true)
                {
                    if (String.IsNullOrWhiteSpace(cmbOLRS.Text) && String.IsNullOrWhiteSpace(cmbOLRC.Text) && String.IsNullOrWhiteSpace(cmbOLRA.Text) &&
                        String.IsNullOrWhiteSpace(cmbOLRPD.Text) && String.IsNullOrWhiteSpace(cmbOLRADD.Text) && String.IsNullOrWhiteSpace(cmbOLRPRISM.Text) &&
                        String.IsNullOrWhiteSpace(cmbOLRBASE.Text) && String.IsNullOrWhiteSpace(cmbOLROH.Text) && String.IsNullOrWhiteSpace(cmbOLLS.Text) &&
                        String.IsNullOrWhiteSpace(cmbOLLC.Text) && String.IsNullOrWhiteSpace(cmbOLLA.Text) && String.IsNullOrWhiteSpace(cmbOLLPD.Text) &&
                        String.IsNullOrWhiteSpace(cmbOLLADD.Text) && String.IsNullOrWhiteSpace(cmbOLLPRISM.Text) && String.IsNullOrWhiteSpace(cmbOLLBASE.Text) &&
                        String.IsNullOrWhiteSpace(cmbOLLOH.Text))
                    {
                        MessageBox.Show("Please select a valid value in the box!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    isOpticalLens = true;
                }

                if (cbContactLens.Checked == true)
                {
                    if (String.IsNullOrWhiteSpace(cmbCLRS.Text) && String.IsNullOrWhiteSpace(cmbCLRC.Text) && String.IsNullOrWhiteSpace(cmbCLRA.Text) &&
                        String.IsNullOrWhiteSpace(cmbCLRBC.Text) && String.IsNullOrWhiteSpace(cmbCLRDptr.Text) && String.IsNullOrWhiteSpace(cmbCLLS.Text) &&
                        String.IsNullOrWhiteSpace(cmbCLLC.Text) && String.IsNullOrWhiteSpace(cmbCLLA.Text) && String.IsNullOrWhiteSpace(cmbCLLBC.Text) &&
                        String.IsNullOrWhiteSpace(cmbCLLDptr.Text))
                    {
                        MessageBox.Show("Please select a valid value in the box!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    isContactLens = true;
                }

                DialogResult result = MessageBox.Show("Do you want to 'Submit' this Rx to" + txtSerialNo.Text + " - " + txtName.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if(isOpticalLens == true)
                    {
                        patientLens = " Optical Lens ";
                        dbContext.InsertOpticalLensDoctors(txtSerialNo.Text, txtOpthometrist.Text, txtOptician.Text);

                        dbContext.InsertOpticalLensRemarks(txtSerialNo.Text, txtRemarks.Text);

                        dbContext.InsertOpticalLens(txtSerialNo.Text, cmbOLRS.Text, cmbOLRC.Text, cmbOLRA.Text, cmbOLRPD.Text,
                                        cmbOLRADD.Text, cmbOLRPRISM.Text, cmbOLRBASE.Text, cmbOLROH.Text, cmbOLLS.Text,
                                        cmbOLLC.Text, cmbOLLA.Text, cmbOLLPD.Text, cmbOLLADD.Text, cmbOLLPRISM.Text, cmbOLLBASE.Text,
                                        cmbOLLOH.Text, DateTime.Now);

                        dbContext.InsertPatientsOpticalLens(txtSerialNo.Text, Convert.ToInt32(lblPatientId.Text));
                    }

                    if(isContactLens == true)
                    {
                        patientLens = " Contact Lens ";
                        dbContext.InsertContactLensDoctors(txtSerialNo.Text, txtOpthometrist.Text, txtOptician.Text);

                        dbContext.InsertContactLensRemarks(txtSerialNo.Text, txtRemarks.Text);

                        dbContext.InsertContactLens(txtSerialNo.Text, cmbCLRS.Text, cmbCLRC.Text, cmbCLRA.Text,
                            cmbCLRBC.Text, cmbCLRDptr.Text, cmbCLLS.Text, cmbCLLC.Text,
                            cmbCLLA.Text, cmbCLLBC.Text, cmbCLLDptr.Text, DateTime.Now);

                        dbContext.InsertPatientsContactLens(txtSerialNo.Text, Convert.ToInt32(lblPatientId.Text));
                    }

                    if (cbOpticalLens.Checked == true && cbContactLens.Checked == true)
                    {
                        patientLens = " Optical and Contact Lens ";
                    }

                    MessageBox.Show("Patient Rx" + patientLens + "has been saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select lens for Patient!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
