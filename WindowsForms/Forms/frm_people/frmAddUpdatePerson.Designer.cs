namespace WindowsForms
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.btnSave = new System.Windows.Forms.Button();
            this.brnClose = new System.Windows.Forms.Button();
            this.ctrlAddUpdatePerson1 = new WindowsForms.ctrlAddUpdatePerson();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(613, 497);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // brnClose
            // 
            this.brnClose.Location = new System.Drawing.Point(324, 497);
            this.brnClose.Margin = new System.Windows.Forms.Padding(4);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(208, 41);
            this.brnClose.TabIndex = 2;
            this.brnClose.Text = "Close";
            this.brnClose.UseVisualStyleBackColor = true;
            this.brnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlAddUpdatePerson1
            // 
            this.ctrlAddUpdatePerson1.BackColor = System.Drawing.Color.White;
            this.ctrlAddUpdatePerson1.Location = new System.Drawing.Point(16, 13);
            this.ctrlAddUpdatePerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAddUpdatePerson1.Name = "ctrlAddUpdatePerson1";
            this.ctrlAddUpdatePerson1.Size = new System.Drawing.Size(1139, 443);
            this.ctrlAddUpdatePerson1.TabIndex = 3;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 567);
            this.Controls.Add(this.ctrlAddUpdatePerson1);
            this.Controls.Add(this.brnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUpdatePerson";
            this.Text = "frmAddUpdatePerson";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button brnClose;
        private ctrlAddUpdatePerson ctrlAddUpdatePerson1;
    }
}