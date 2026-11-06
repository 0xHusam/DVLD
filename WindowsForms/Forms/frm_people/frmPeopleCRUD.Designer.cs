namespace WindowsForms
{
    partial class frmPeopleCRUD : BaseCRUD.frmBaseCRUD
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleCRUD));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(349, -23);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pbLogo.Size = new System.Drawing.Size(368, 187);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(340, 126);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Size = new System.Drawing.Size(387, 46);
            this.lblTitle.Text = "People Management";
            // 
            // txtFilter
            // 
            this.txtFilter.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pbAddNew
            // 
            this.pbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("pbAddNew.Image")));
            this.pbAddNew.Location = new System.Drawing.Point(934, 180);
            this.pbAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.pbAddNew.Size = new System.Drawing.Size(177, 76);
            this.pbAddNew.Click += new System.EventHandler(this.AddNew_Click);
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
            this.toolStripSeparator2,
            this.tsmiSendEmail});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(230, 146);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowDetails.Image")));
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(229, 26);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.Details_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNew.Image")));
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(229, 26);
            this.tsmiAddNew.Text = "Add IssueLocalLicense";
            this.tsmiAddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdate.Image")));
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(229, 26);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(229, 26);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // tsmiSendEmail
            // 
            this.tsmiSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSendEmail.Image")));
            this.tsmiSendEmail.Name = "tsmiSendEmail";
            this.tsmiSendEmail.Size = new System.Drawing.Size(229, 26);
            this.tsmiSendEmail.Text = "Send Email";
            // 
            // frmPeopleCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPeopleCRUD";
            this.Text = "People Management";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.Controls.SetChildIndex(this.ctrl_txtDate, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.cbOperations, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbColumns, 0);
            this.Controls.SetChildIndex(this.txtFilter, 0);
            this.Controls.SetChildIndex(this.pbAddNew, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ContextMenuStrip cms;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}