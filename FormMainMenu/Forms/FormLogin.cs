using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormMainMenu.Forms
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=VEGA; Initial Catalog=MarikinaOptical; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        FormAdminMainMenu frmAdminMainMenu = new FormAdminMainMenu();
        FormMainMenu frmStaffMainMenu = new FormMainMenu();

        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            if (String.IsNullOrWhiteSpace(txtPassword.Text) || String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please fill in required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT UserName, Position, isActive FROM tblUserAccounts WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToInt32(dr["Position"]) == 1 && Convert.ToInt32(dr["isActive"]) == 1)
                {
                    this.Hide();
                    frmAdminMainMenu.ShowDialog();
                    this.Close();
                }
                else if(Convert.ToInt32(dr["Position"]) == 2 && Convert.ToInt32(dr["isActive"]) == 1)
                {
                    this.Hide();
                    frmStaffMainMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Account is has been blocked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("User Account is not existing!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
