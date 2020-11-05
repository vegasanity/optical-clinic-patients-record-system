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
    public partial class FormMainMenu : Form
    {


        //Fields
        private Button currentButton;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            CustomizeDesign();
            this.MinimumSize = new System.Drawing.Size(1450, 900);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Methods
        private void CustomizeDesign()
        {
            panelRecordsSubMenu.Visible = false;
            panelDatabaseSubMenu.Visible = false;
        }

        private void HideSubMenuPanel()
        {
            if (panelRecordsSubMenu.Visible == true)
                panelRecordsSubMenu.Visible = false;
            if (panelDatabaseSubMenu.Visible == true)
                panelDatabaseSubMenu.Visible = false;
        }

        private void ShowSubMenuPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenuPanel();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            lblTitleText.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(237, 24, 32);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                }
            }

            foreach (Control previousBtn in panelRecordsSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(243, 101, 105);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                }
            }

            foreach (Control previousBtn in panelDatabaseSubMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(243, 101, 105);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                }
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            OpenChildForm(new Forms.FormInformation(), sender);
            //...
            HideSubMenuPanel();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenuPanel(panelRecordsSubMenu);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            OpenChildForm(new Forms.FormPatient(), sender);
            //...
            HideSubMenuPanel();
        }

        private void btnRx_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            OpenChildForm(new Forms.FormRx(), sender);
            //...
            HideSubMenuPanel();
        }

        private void btnListOfPatients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //...
            //Your Code
            OpenChildForm(new Forms.FormListOfPatients(), sender);
            //...
            HideSubMenuPanel();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenuPanel(panelDatabaseSubMenu);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            OpenChildForm(new Forms.FormBackupDatabase(), sender);
            //...
            HideSubMenuPanel();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //...
            //Your Code
            OpenChildForm(new Forms.FormRestoreDatabase(), sender);
            //...
            HideSubMenuPanel();
        }
        

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            Forms.FormStaffChangePassword frmStaffChangePassword = new Forms.FormStaffChangePassword();
            frmStaffChangePassword.ShowDialog();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                btnCloseChildForm.Visible = false;
                lblTitleText.Text = "MAIN MENU";
                activeForm.Close();
            }
        }
    }
}
