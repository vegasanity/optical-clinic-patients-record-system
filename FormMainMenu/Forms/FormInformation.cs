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
    public partial class FormInformation : Form
    {
        MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();
        int[] count = new int[1];

        public FormInformation()
        {
            InitializeComponent();
        }


        private void FormInformation_Load(object sender, EventArgs e)
        {
            CountAllPatients();
            CountTodayPatients();
        }

        private void CountAllPatients()
        {
            var countTotalPatients = dbContext.GetTotalPatients();
            foreach (var countTotal in countTotalPatients)
                count[0] = (int)countTotal;
            lblTotalPatients.Text = count[0].ToString();
        }

        private void CountTodayPatients()
        {
            FormListOfPatients frmListOfPatients = new FormListOfPatients();
            var countTodayPatients = dbContext.GetTodayPatients(frmListOfPatients.dtpSearch.Value.Date.ToShortDateString());
            foreach (var countToday in countTodayPatients)
                count[0] = (int)countToday;
            lblTodayPatients.Text = count[0].ToString();
        }
    }
}
