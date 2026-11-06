namespace WindowsForms.Forms.frm_Application.ManageDrivingLicense
{
    partial class frmShowLicense
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
            this.ctrlLicense1 = new WindowsForms.ctrl.ctrl_Application.ctrlLicense();
            this.SuspendLayout();
            // 
            // ctrlLicense1
            // 
            this.ctrlLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLicense1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLicense1.Name = "ctrlLicense1";
            this.ctrlLicense1.Size = new System.Drawing.Size(816, 416);
            this.ctrlLicense1.TabIndex = 0;
            // 
            // frmShowLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 416);
            this.Controls.Add(this.ctrlLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLicense";
            this.Text = "Show License";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl.ctrl_Application.ctrlLicense ctrlLicense1;
    }
}