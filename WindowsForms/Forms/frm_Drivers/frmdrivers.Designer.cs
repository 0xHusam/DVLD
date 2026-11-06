namespace WindowsForms.Forms.frm_Drivers
{
    partial class frmdrivers
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
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNew)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsForms.Properties.Resources.driver;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(341, 177);
            this.lblTitle.Size = new System.Drawing.Size(388, 36);
            this.lblTitle.Text = "Drivers Management";
            // 
            // pbAddNew
            // 
            this.pbAddNew.Visible = false;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(211, 56);
            // 
            // shToolStripMenuItem
            // 
            this.shToolStripMenuItem.Name = "shToolStripMenuItem";
            this.shToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.shToolStripMenuItem.Text = "Show All Licenses";
            this.shToolStripMenuItem.Click += new System.EventHandler(this.shToolStripMenuItem_Click);
            // 
            // frmdrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Name = "frmdrivers";
            this.Text = "drivers";
            this.Load += new System.EventHandler(this.frmdrivers_Load);
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
        private System.Windows.Forms.ToolStripMenuItem shToolStripMenuItem;
    }
}