namespace WindowsForms
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.brnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlAddUpdateUser1 = new WindowsForms.ctrlAddUpdateUser();
            this.SuspendLayout();
            // 
            // brnClose
            // 
            this.brnClose.Location = new System.Drawing.Point(713, 637);
            this.brnClose.Margin = new System.Windows.Forms.Padding(4);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(208, 41);
            this.brnClose.TabIndex = 4;
            this.brnClose.Text = "Close";
            this.brnClose.UseVisualStyleBackColor = true;
            this.brnClose.Click += new System.EventHandler(this.brnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(929, 637);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlAddUpdateUser1
            // 
            this.ctrlAddUpdateUser1.Location = new System.Drawing.Point(4, 3);
            this.ctrlAddUpdateUser1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAddUpdateUser1.Name = "ctrlAddUpdateUser1";
            this.ctrlAddUpdateUser1.Size = new System.Drawing.Size(1140, 628);
            this.ctrlAddUpdateUser1.TabIndex = 5;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 679);
            this.Controls.Add(this.ctrlAddUpdateUser1);
            this.Controls.Add(this.brnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddUpdateUser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button brnClose;
        private System.Windows.Forms.Button btnSave;
        private ctrlAddUpdateUser ctrlAddUpdateUser1;
    }
}