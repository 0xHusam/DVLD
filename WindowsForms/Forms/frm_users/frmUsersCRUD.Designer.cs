using BaseCRUD;

namespace WindowsForms
{
    partial class frmUsersCRUD : frmBaseCRUD
    {

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersCRUD));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActive_InActive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsForms.Properties.Resources.team;
            this.pbLogo.Location = new System.Drawing.Point(303, 4);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pbLogo.Size = new System.Drawing.Size(455, 194);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(392, 194);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Size = new System.Drawing.Size(280, 36);
            this.lblTitle.Text = "Users Management ";
            // 
            // txtFilter
            // 
            this.txtFilter.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pbAddNew
            // 
            this.pbAddNew.Image = global::WindowsForms.Properties.Resources.add_user;
            this.pbAddNew.Location = new System.Drawing.Point(926, 184);
            this.pbAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.pbAddNew.Size = new System.Drawing.Size(177, 76);
            this.pbAddNew.Click += new System.EventHandler(this.tsmiAddNew_Click);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddNew,
            this.tsmiUpdate,
            this.tsmiDelete,
            this.tsmiActive_InActive,
            this.toolStripSeparator2,
            this.tsmiSendEmail,
            this.toolStripSeparator3,
            this.tsmiChangePassword});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(198, 204);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = global::WindowsForms.Properties.Resources.resume1;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(197, 26);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = global::WindowsForms.Properties.Resources.add_user1;
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(197, 26);
            this.tsmiAddNew.Text = "Add IssueLocalLicense";
            this.tsmiAddNew.Click += new System.EventHandler(this.tsmiAddNew_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = global::WindowsForms.Properties.Resources.edit_info;
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(197, 26);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::WindowsForms.Properties.Resources.delete_user1;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(197, 26);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiActive_InActive
            // 
            this.tsmiActive_InActive.Name = "tsmiActive_InActive";
            this.tsmiActive_InActive.Size = new System.Drawing.Size(197, 26);
            this.tsmiActive_InActive.Text = "Active_InActive";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiSendEmail
            // 
            this.tsmiSendEmail.Image = global::WindowsForms.Properties.Resources.communication1;
            this.tsmiSendEmail.Name = "tsmiSendEmail";
            this.tsmiSendEmail.Size = new System.Drawing.Size(197, 26);
            this.tsmiSendEmail.Text = "Send Email";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Image = global::WindowsForms.Properties.Resources.rotation_lock;
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(197, 26);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // frmUsersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUsersCRUD";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersCRUD_Load);
            this.Controls.SetChildIndex(this.ctrl_txtDate, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.txtFilter, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbColumns, 0);
            this.Controls.SetChildIndex(this.pbAddNew, 0);
            this.Controls.SetChildIndex(this.cbOperations, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ContextMenuStrip cms;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiActive_InActive;
    }
}