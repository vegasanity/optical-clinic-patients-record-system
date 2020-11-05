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
    public partial class FormBackupDatabase : Form
    {
        
        public FormBackupDatabase()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=VEGA; Initial Catalog=MarikinaOptical; Integrated Security=True");
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = fbd.SelectedPath;
                btnBackup.Enabled = true;

            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String database = con.Database.ToString();
                if (txtBackup.Text == string.Empty)
                {

                    MessageBox.Show("Please enter the backup file location");
                }
                else
                {
                    string backupQuery = "BACKUP DATABASE [" + database + "] TO DISK='" + txtBackup.Text + "\\" + "MarikinaOptical" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(backupQuery, con);
                    scmd.ExecuteNonQuery();
                    MessageBox.Show("Backup database successfully", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void FormBackupDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
