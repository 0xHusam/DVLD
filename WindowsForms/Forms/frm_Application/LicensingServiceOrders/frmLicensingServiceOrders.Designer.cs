namespace WindowsForms.Forms.frm_Application
{
    partial class frmLicensingServiceOrders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicensingServiceOrders));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSechduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisonTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiwritenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStreatTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiissueLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsForms.Properties.Resources.Application_Types_Icon;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(319, 177);
            this.lblTitle.Size = new System.Drawing.Size(419, 36);
            this.lblTitle.Text = "Licensing Service Oreders";
            // 
            // pbAddNew
            // 
            this.pbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("pbAddNew.Image")));
            this.pbAddNew.Location = new System.Drawing.Point(958, 194);
            this.pbAddNew.Click += new System.EventHandler(this.pbAddNew_Click);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancel,
            this.tsmiSechduleTest,
            this.tsmiissueLicense});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(175, 76);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(174, 24);
            this.tsmiCancel.Text = "Cancel";
            this.tsmiCancel.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // tsmiSechduleTest
            // 
            this.tsmiSechduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisonTest,
            this.tsmiwritenTest,
            this.tsmiStreatTest});
            this.tsmiSechduleTest.Name = "tsmiSechduleTest";
            this.tsmiSechduleTest.Size = new System.Drawing.Size(174, 24);
            this.tsmiSechduleTest.Text = "Sechdule Tests";
            // 
            // tsmiVisonTest
            // 
            this.tsmiVisonTest.Name = "tsmiVisonTest";
            this.tsmiVisonTest.Size = new System.Drawing.Size(224, 26);
            this.tsmiVisonTest.Text = "Vison Test";
            this.tsmiVisonTest.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiwritenTest
            // 
            this.tsmiwritenTest.Name = "tsmiwritenTest";
            this.tsmiwritenTest.Size = new System.Drawing.Size(224, 26);
            this.tsmiwritenTest.Text = "Writen Test";
            this.tsmiwritenTest.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmiStreatTest
            // 
            this.tsmiStreatTest.Name = "tsmiStreatTest";
            this.tsmiStreatTest.Size = new System.Drawing.Size(224, 26);
            this.tsmiStreatTest.Text = "Streat Test";
            this.tsmiStreatTest.Click += new System.EventHandler(this.driveTestToolStripMenuItem_Click);
            // 
            // tsmiissueLicense
            // 
            this.tsmiissueLicense.Name = "tsmiissueLicense";
            this.tsmiissueLicense.Size = new System.Drawing.Size(174, 24);
            this.tsmiissueLicense.Text = "Issue License";
            this.tsmiissueLicense.Click += new System.EventHandler(this.tsmiissueLicense_Click);
            // 
            // frmLicensingServiceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Name = "frmLicensingServiceOrders";
            this.Text = "Licensing Service Orders";
            this.Load += new System.EventHandler(this.frmLicensingServiceOrders_Load);
            this.Controls.SetChildIndex(this.txtFilter, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.lblFilter, 0);
            this.Controls.SetChildIndex(this.cbColumns, 0);
            this.Controls.SetChildIndex(this.pbAddNew, 0);
            this.Controls.SetChildIndex(this.cbOperations, 0);
            this.Controls.SetChildIndex(this.ctrl_txtDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSechduleTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisonTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiwritenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiStreatTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiissueLicense;
    }
}