namespace FormMainMenu
{
    partial class FormAdminMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMainMenu));
            this.lblTitleText = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.btnInformation = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnRx = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnListOfPatients = new System.Windows.Forms.Button();
            this.panelRecordsSubMenu = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panelDatabaseSubMenu = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.panelBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelRecordsSubMenu.SuspendLayout();
            this.panelDatabaseSubMenu.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitleText.Location = new System.Drawing.Point(608, 17);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(248, 46);
            this.lblTitleText.TabIndex = 1;
            this.lblTitleText.Text = "MAIN MENU";
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 81);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBar.Controls.Add(this.lblTitleText);
            this.panelBar.Controls.Add(this.btnCloseChildForm);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(293, 0);
            this.panelBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1381, 81);
            this.panelBar.TabIndex = 4;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.panelShadow.Location = new System.Drawing.Point(0, 79);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(293, 2);
            this.panelShadow.TabIndex = 0;
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInformation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInformation.Image = global::FormMainMenu.Properties.Resources.iconInformation232;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 160);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnInformation.Size = new System.Drawing.Size(293, 55);
            this.btnInformation.TabIndex = 2;
            this.btnInformation.Text = "  Information";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panelLogo.Controls.Add(this.panelShadow);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 160);
            this.panelLogo.TabIndex = 1;
            // 
            // btnRx
            // 
            this.btnRx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRx.FlatAppearance.BorderSize = 0;
            this.btnRx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRx.Location = new System.Drawing.Point(0, 55);
            this.btnRx.Margin = new System.Windows.Forms.Padding(4);
            this.btnRx.Name = "btnRx";
            this.btnRx.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnRx.Size = new System.Drawing.Size(293, 55);
            this.btnRx.TabIndex = 1;
            this.btnRx.Text = "Rx";
            this.btnRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRx.UseVisualStyleBackColor = true;
            this.btnRx.Click += new System.EventHandler(this.btnRx_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecords.Image = global::FormMainMenu.Properties.Resources.iconPatientRecord232;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(0, 215);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnRecords.Size = new System.Drawing.Size(293, 55);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.Text = "  Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(101)))), ((int)(((byte)(105)))));
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPatient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPatient.Location = new System.Drawing.Point(0, 0);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnPatient.Size = new System.Drawing.Size(293, 55);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatabase.FlatAppearance.BorderSize = 0;
            this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDatabase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatabase.Image = global::FormMainMenu.Properties.Resources.iconDatabase32;
            this.btnDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.Location = new System.Drawing.Point(0, 449);
            this.btnDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDatabase.Size = new System.Drawing.Size(293, 55);
            this.btnDatabase.TabIndex = 6;
            this.btnDatabase.Text = "  Database";
            this.btnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnListOfPatients
            // 
            this.btnListOfPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListOfPatients.FlatAppearance.BorderSize = 0;
            this.btnListOfPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListOfPatients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListOfPatients.Image = global::FormMainMenu.Properties.Resources.iconListOfPatients32;
            this.btnListOfPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfPatients.Location = new System.Drawing.Point(0, 394);
            this.btnListOfPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btnListOfPatients.Name = "btnListOfPatients";
            this.btnListOfPatients.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnListOfPatients.Size = new System.Drawing.Size(293, 55);
            this.btnListOfPatients.TabIndex = 5;
            this.btnListOfPatients.Text = "   List of Patients";
            this.btnListOfPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListOfPatients.UseVisualStyleBackColor = true;
            this.btnListOfPatients.Click += new System.EventHandler(this.btnListOfPatients_Click);
            // 
            // panelRecordsSubMenu
            // 
            this.panelRecordsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(101)))), ((int)(((byte)(105)))));
            this.panelRecordsSubMenu.Controls.Add(this.btnRx);
            this.panelRecordsSubMenu.Controls.Add(this.btnPatient);
            this.panelRecordsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecordsSubMenu.Location = new System.Drawing.Point(0, 270);
            this.panelRecordsSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelRecordsSubMenu.Name = "panelRecordsSubMenu";
            this.panelRecordsSubMenu.Size = new System.Drawing.Size(293, 124);
            this.panelRecordsSubMenu.TabIndex = 4;
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRestore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestore.Location = new System.Drawing.Point(0, 55);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnRestore.Size = new System.Drawing.Size(293, 55);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackup.Location = new System.Drawing.Point(0, 0);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(293, 55);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Back up";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // panelDatabaseSubMenu
            // 
            this.panelDatabaseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(101)))), ((int)(((byte)(105)))));
            this.panelDatabaseSubMenu.Controls.Add(this.btnRestore);
            this.panelDatabaseSubMenu.Controls.Add(this.btnBackup);
            this.panelDatabaseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatabaseSubMenu.Location = new System.Drawing.Point(0, 504);
            this.panelDatabaseSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatabaseSubMenu.Name = "panelDatabaseSubMenu";
            this.panelDatabaseSubMenu.Size = new System.Drawing.Size(293, 124);
            this.panelDatabaseSubMenu.TabIndex = 7;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(293, 81);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1381, 822);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panelMenu.Controls.Add(this.btnAccounts);
            this.panelMenu.Controls.Add(this.panelDatabaseSubMenu);
            this.panelMenu.Controls.Add(this.btnDatabase);
            this.panelMenu.Controls.Add(this.btnListOfPatients);
            this.panelMenu.Controls.Add(this.panelRecordsSubMenu);
            this.panelMenu.Controls.Add(this.btnRecords);
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 903);
            this.panelMenu.TabIndex = 3;
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAccounts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccounts.Image = global::FormMainMenu.Properties.Resources.iconUserAccounts32;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 628);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAccounts.Size = new System.Drawing.Size(293, 55);
            this.btnAccounts.TabIndex = 9;
            this.btnAccounts.Text = "  Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // FormAdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 903);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormAdminMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu (Admin) - ABC Optical Clinic";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelRecordsSubMenu.ResumeLayout(false);
            this.panelDatabaseSubMenu.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRx;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Button btnListOfPatients;
        private System.Windows.Forms.Panel panelRecordsSubMenu;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Panel panelDatabaseSubMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAccounts;
    }
}