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
    public partial class FormPatientRecords : Form
    {
       // FormEditOpticalLens frmEditOpticalLens;
       // FormEditContactLens frmEditContactLens;
        public FormPatientRecords()
        {
            InitializeComponent();
        }
        private void FormPatientRecords_Load(object sender, EventArgs e)
        {
            //Optical Lens
            dgvPatientOpticalLens.Columns[0].Visible = false;
            dgvPatientOpticalLens.Columns[1].HeaderCell.Value = "Serial Number";
            dgvPatientOpticalLens.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPatientOpticalLens.Columns[2].Visible = false;
            dgvPatientOpticalLens.Columns[3].Visible = false;
            dgvPatientOpticalLens.Columns[4].Visible = false;
            dgvPatientOpticalLens.Columns[5].Visible = false;
            dgvPatientOpticalLens.Columns[6].Visible = false;
            dgvPatientOpticalLens.Columns[7].Visible = false;
            dgvPatientOpticalLens.Columns[8].Visible = false;
            dgvPatientOpticalLens.Columns[9].Visible = false;
            dgvPatientOpticalLens.Columns[10].Visible = false;
            dgvPatientOpticalLens.Columns[11].Visible = false;
            dgvPatientOpticalLens.Columns[12].Visible = false;
            dgvPatientOpticalLens.Columns[13].Visible = false;
            dgvPatientOpticalLens.Columns[14].Visible = false;
            dgvPatientOpticalLens.Columns[15].Visible = false;
            dgvPatientOpticalLens.Columns[16].Visible = false;
            dgvPatientOpticalLens.Columns[17].Visible = false;
            dgvPatientOpticalLens.Columns[18].Visible = false;
            dgvPatientOpticalLens.Columns[19].Visible = false;
            dgvPatientOpticalLens.Columns[20].Visible = false;
            dgvPatientOpticalLens.Columns[21].Visible = false;
            dgvPatientOpticalLens.Columns[22].Visible = false;
            dgvPatientOpticalLens.Columns[23].Visible = false;
            dgvPatientOpticalLens.Columns[24].Visible = false;

            //Contact Lens
            dgvPatientContactLens.Columns[0].Visible = false;
            dgvPatientContactLens.Columns[1].HeaderCell.Value = "Serial Number";
            dgvPatientContactLens.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPatientContactLens.Columns[2].Visible = false;
            dgvPatientContactLens.Columns[3].Visible = false;
            dgvPatientContactLens.Columns[4].Visible = false;
            dgvPatientContactLens.Columns[5].Visible = false;
            dgvPatientContactLens.Columns[6].Visible = false;
            dgvPatientContactLens.Columns[7].Visible = false;
            dgvPatientContactLens.Columns[8].Visible = false;
            dgvPatientContactLens.Columns[9].Visible = false;
            dgvPatientContactLens.Columns[10].Visible = false;
            dgvPatientContactLens.Columns[11].Visible = false;
            dgvPatientContactLens.Columns[12].Visible = false;
            dgvPatientContactLens.Columns[13].Visible = false;
            dgvPatientContactLens.Columns[14].Visible = false;
            dgvPatientContactLens.Columns[15].Visible = false;
            dgvPatientContactLens.Columns[16].Visible = false;
            dgvPatientContactLens.Columns[17].Visible = false;
            dgvPatientContactLens.Columns[18].Visible = false;
        }   

        private void dgvPatientOpticalLens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPatientOpticalLens.Rows[e.RowIndex];
            lblOLRS.Text = row.Cells[2].Value.ToString();
            lblOLRC.Text = row.Cells[3].Value.ToString();
            lblOLRA.Text = row.Cells[4].Value.ToString();
            lblOLRPD.Text = row.Cells[5].Value.ToString();
            lblOLRADD.Text = row.Cells[6].Value.ToString();
            lblOLRPRISM.Text = row.Cells[7].Value.ToString();
            lblOLRBASE.Text = row.Cells[8].Value.ToString();
            lblOLROH.Text = row.Cells[9].Value.ToString();
            lblOLLS.Text = row.Cells[10].Value.ToString();
            lblOLLC.Text = row.Cells[11].Value.ToString();
            lblOLLA.Text = row.Cells[12].Value.ToString();
            lblOLLPD.Text = row.Cells[13].Value.ToString();
            lblOLLADD.Text = row.Cells[14].Value.ToString();
            lblOLLPRISM.Text = row.Cells[15].Value.ToString();
            lblOLLBASE.Text = row.Cells[16].Value.ToString();
            lblOLLOH.Text = row.Cells[17].Value.ToString();
            txtOLRemarks.Text = row.Cells[18].Value.ToString();
            lblOLOptometrist.Text = row.Cells[19].Value.ToString();
            lblOLOptician.Text = row.Cells[20].Value.ToString();
            lblPatientId.Text = row.Cells[21].Value.ToString();
            lblSerialOpticalLens.Text = row.Cells[22].Value.ToString();
            lblPatientSerial.Text = row.Cells[23].Value.ToString();
        }

        private void dgvPatientContactLens_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPatientContactLens.Rows[e.RowIndex];
            lblCLRS.Text = row.Cells[2].Value.ToString();
            lblCLRC.Text = row.Cells[3].Value.ToString();
            lblCLRA.Text = row.Cells[4].Value.ToString();
            lblCLRBC.Text = row.Cells[5].Value.ToString();
            lblCLRDptr.Text = row.Cells[6].Value.ToString();
            lblCLLS.Text = row.Cells[7].Value.ToString();
            lblCLLC.Text = row.Cells[8].Value.ToString();
            lblCLLA.Text = row.Cells[9].Value.ToString();
            lblCLLBC.Text = row.Cells[10].Value.ToString();
            lblCLLDptr.Text = row.Cells[11].Value.ToString();
            txtCLRemarks.Text = row.Cells[12].Value.ToString();
            lblCLOptometrist.Text = row.Cells[13].Value.ToString();
            lblCLOptician.Text = row.Cells[14].Value.ToString();
            lblSerialContactLens.Text = row.Cells[16].Value.ToString();
        }

        private void btnEditOpticalLens_Click(object sender, EventArgs e)
        {
            FormEditOpticalLens frmEditOpticalLens = new FormEditOpticalLens();
            frmEditOpticalLens.txtSerialNo.Text = lblSerialOpticalLens.Text;
            frmEditOpticalLens.txtPatientNo.Text = lblPatientSerial.Text;
            frmEditOpticalLens.txtName.Text = txtName.Text;
            frmEditOpticalLens.cmbOLRS.Text = lblOLRS.Text;
            frmEditOpticalLens.cmbOLRC.Text = lblOLRC.Text;
            frmEditOpticalLens.cmbOLRA.Text = lblOLRA.Text;
            frmEditOpticalLens.cmbOLRPD.Text = lblOLRPD.Text;
            frmEditOpticalLens.cmbOLRADD.Text = lblOLRADD.Text;
            frmEditOpticalLens.cmbOLRPRISM.Text = lblOLRPRISM.Text;
            frmEditOpticalLens.cmbOLRBASE.Text = lblOLRBASE.Text;
            frmEditOpticalLens.cmbOLROH.Text = lblOLROH.Text;
            frmEditOpticalLens.cmbOLLS.Text = lblOLLS.Text;
            frmEditOpticalLens.cmbOLLC.Text = lblOLLC.Text;
            frmEditOpticalLens.cmbOLLA.Text = lblOLLA.Text;
            frmEditOpticalLens.cmbOLLPD.Text = lblOLLPD.Text;
            frmEditOpticalLens.cmbOLLADD.Text = lblOLLADD.Text;
            frmEditOpticalLens.cmbOLLPRISM.Text = lblOLLPRISM.Text;
            frmEditOpticalLens.cmbOLLBASE.Text = lblOLLBASE.Text;
            frmEditOpticalLens.cmbOLLOH.Text = lblOLLOH.Text;
            frmEditOpticalLens.txtOpthometrist.Text = lblOLOptometrist.Text;
            frmEditOpticalLens.txtOptician.Text = lblOLOptician.Text;
            frmEditOpticalLens.txtRemarks.Text = txtOLRemarks.Text;
            this.Close();
            frmEditOpticalLens.ShowDialog();
        }

        private void btnEditContactLens_Click(object sender, EventArgs e)
        {
            FormEditContactLens frmEditContactLens = new FormEditContactLens();
            frmEditContactLens.txtSerialNo.Text = lblSerialContactLens.Text;
            frmEditContactLens.txtPatientNo.Text = lblPatientSerial.Text;
            frmEditContactLens.txtName.Text = txtName.Text;
            frmEditContactLens.cmbCLRS.Text = lblCLRS.Text;
            frmEditContactLens.cmbCLRC.Text = lblCLRC.Text;
            frmEditContactLens.cmbCLRA.Text = lblCLRA.Text;
            frmEditContactLens.cmbCLRBC.Text = lblCLRBC.Text;
            frmEditContactLens.cmbCLRDptr.Text = lblCLRDptr.Text;
            frmEditContactLens.cmbCLLS.Text = lblCLLS.Text;
            frmEditContactLens.cmbCLLC.Text = lblCLLC.Text;
            frmEditContactLens.cmbCLLA.Text = lblCLLA.Text;
            frmEditContactLens.cmbCLLBC.Text = lblCLLBC.Text;
            frmEditContactLens.cmbCLLDptr.Text = lblCLLDptr.Text;
            frmEditContactLens.txtOpthometrist.Text = lblCLOptometrist.Text;
            frmEditContactLens.txtOptician.Text = lblCLOptician.Text;
            frmEditContactLens.txtRemarks.Text = txtCLRemarks.Text;
            this.Close();
            frmEditContactLens.ShowDialog();
        }
    }
}
