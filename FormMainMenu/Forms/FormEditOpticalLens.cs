using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu
{
    public partial class FormEditOpticalLens : Form
    {
        MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
        public FormEditOpticalLens()
        {
            InitializeComponent();
        }

        private void FormEditOpticalLens_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to 'Edit' this records?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Update Query
                dbContext.UpdatePatientOpticalLens(txtSerialNo.Text, cmbOLRS.Text, cmbOLRC.Text, cmbOLRA.Text, cmbOLRPD.Text, 
                    cmbOLRADD.Text, cmbOLRPRISM.Text, cmbOLRBASE.Text, cmbOLROH.Text, cmbOLLS.Text, cmbOLLC.Text, cmbOLLA.Text,
                    cmbOLLPD.Text, cmbOLLADD.Text, cmbOLLPRISM.Text, cmbOLLBASE.Text, cmbOLLOH.Text);
                dbContext.UpdatePatientDoctors(txtSerialNo.Text, txtOpthometrist.Text, txtOptician.Text);
                dbContext.UpatePatientRemarks(txtSerialNo.Text, txtRemarks.Text);
                MessageBox.Show("Patient Optical Lens has been updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
