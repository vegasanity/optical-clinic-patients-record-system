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
    public partial class FormEditContactLens : Form
    {
        MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
        public FormEditContactLens()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to 'Edit' this records?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Update Query
                dbContext.UpdatePatientContactLens(txtSerialNo.Text, cmbCLRS.Text, cmbCLRC.Text, cmbCLRA.Text, cmbCLRBC.Text, cmbCLRDptr.Text,
                 cmbCLLS.Text, cmbCLLC.Text, cmbCLLA.Text, cmbCLLBC.Text, cmbCLLDptr.Text);
                dbContext.UpdatePatientCLDoctors(txtSerialNo.Text, txtOpthometrist.Text, txtOptician.Text);
                dbContext.UpdatePatientsCLRemakrs(txtSerialNo.Text, txtRemarks.Text);
                MessageBox.Show("Patient Contact Lens has been updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
