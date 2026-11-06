namespace WindowsForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AppTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.driveingLicenceServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reNewDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaeceLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppTsmi,
            this.PeopleTsmi,
            this.DriversTsmi,
            this.UsersTsmi,
            this.PaymentTsmi,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AppTsmi
            // 
            this.AppTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveingLicenceServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.AppTsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTsmi.Name = "AppTsmi";
            this.AppTsmi.Size = new System.Drawing.Size(135, 32);
            this.AppTsmi.Text = "Applications";
            // 
            // driveingLicenceServicesToolStripMenuItem
            // 
            this.driveingLicenceServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenceToolStripMenuItem,
            this.reNewDrivingLicenceToolStripMenuItem,
            this.replaceForToolStripMenuItem,
            this.toolStripMenuItem1,
            this.retakeTestToolStripMenuItem,
            this.relaeceLicenseToolStripMenuItem});
            this.driveingLicenceServicesToolStripMenuItem.Name = "driveingLicenceServicesToolStripMenuItem";
            this.driveingLicenceServicesToolStripMenuItem.Size = new System.Drawing.Size(333, 32);
            this.driveingLicenceServicesToolStripMenuItem.Text = "Manage Driving Licenses";
            this.driveingLicenceServicesToolStripMenuItem.Click += new System.EventHandler(this.driveingLicenceServicesToolStripMenuItem_Click);
            // 
            // newDrivingLicenceToolStripMenuItem
            // 
            this.newDrivingLicenceToolStripMenuItem.Name = "newDrivingLicenceToolStripMenuItem";
            this.newDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(466, 32);
            this.newDrivingLicenceToolStripMenuItem.Tag = "";
            this.newDrivingLicenceToolStripMenuItem.Text = "Issue Internalional Licence Driving";
            this.newDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenceToolStripMenuItem_Click);
            // 
            // reNewDrivingLicenceToolStripMenuItem
            // 
            this.reNewDrivingLicenceToolStripMenuItem.Name = "reNewDrivingLicenceToolStripMenuItem";
            this.reNewDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(466, 32);
            this.reNewDrivingLicenceToolStripMenuItem.Text = "Renew License Driving License";
            this.reNewDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.reNewDrivingLicenceToolStripMenuItem_Click);
            // 
            // replaceForToolStripMenuItem
            // 
            this.replaceForToolStripMenuItem.Name = "replaceForToolStripMenuItem";
            this.replaceForToolStripMenuItem.Size = new System.Drawing.Size(466, 32);
            this.replaceForToolStripMenuItem.Text = "Replacement for Lost Driving License";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(466, 32);
            this.toolStripMenuItem1.Text = "Replacement for Damaged Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(466, 32);
            this.retakeTestToolStripMenuItem.Text = "Detain Driving License";
            // 
            // relaeceLicenseToolStripMenuItem
            // 
            this.relaeceLicenseToolStripMenuItem.Name = "relaeceLicenseToolStripMenuItem";
            this.relaeceLicenseToolStripMenuItem.Size = new System.Drawing.Size(466, 32);
            this.relaeceLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(333, 32);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Issue Local License";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(333, 32);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(333, 32);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // PeopleTsmi
            // 
            this.PeopleTsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleTsmi.Image = global::WindowsForms.Properties.Resources.group;
            this.PeopleTsmi.Name = "PeopleTsmi";
            this.PeopleTsmi.Size = new System.Drawing.Size(105, 32);
            this.PeopleTsmi.Text = "People";
            this.PeopleTsmi.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // DriversTsmi
            // 
            this.DriversTsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversTsmi.Image = global::WindowsForms.Properties.Resources.driver;
            this.DriversTsmi.Name = "DriversTsmi";
            this.DriversTsmi.Size = new System.Drawing.Size(107, 32);
            this.DriversTsmi.Text = "Drivers";
            this.DriversTsmi.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // UsersTsmi
            // 
            this.UsersTsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersTsmi.Image = global::WindowsForms.Properties.Resources.team;
            this.UsersTsmi.Name = "UsersTsmi";
            this.UsersTsmi.Size = new System.Drawing.Size(93, 32);
            this.UsersTsmi.Text = "Users";
            this.UsersTsmi.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // PaymentTsmi
            // 
            this.PaymentTsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTsmi.Name = "PaymentTsmi";
            this.PaymentTsmi.Size = new System.Drawing.Size(109, 32);
            this.PaymentTsmi.Text = "Payments";
            this.PaymentTsmi.Click += new System.EventHandler(this.PaymentsToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.people;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.cToolStripMenuItem.Text = "Current User Info";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::WindowsForms.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.logOutToolStripMenuItem.Text = "Sign Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(567, 368);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsForms.Properties.Resources.DVLD;
            this.pictureBox2.Location = new System.Drawing.Point(544, 419);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 326);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AppTsmi;
        private System.Windows.Forms.ToolStripMenuItem PeopleTsmi;
        private System.Windows.Forms.ToolStripMenuItem DriversTsmi;
        private System.Windows.Forms.ToolStripMenuItem UsersTsmi;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveingLicenceServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reNewDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem relaeceLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentTsmi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}