namespace WindowsForms.ctrl.ctrl_person
{
    partial class ctrlFindPersonAndShowInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlFindPerson1 = new WindowsForms.ctrlFindPerson();
            this.ctrlPersonInfo1 = new WindowsForms.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.Location = new System.Drawing.Point(4, 4);
            this.ctrlFindPerson1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.Size = new System.Drawing.Size(429, 30);
            this.ctrlFindPerson1.TabIndex = 0;
            this.ctrlFindPerson1.FindPerson += (this.OnFindPerson);
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(4, 42);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(640, 360);
            this.ctrlPersonInfo1.TabIndex = 1;
            // 
            // ctrlFindPersonAndShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.ctrlFindPerson1);
            this.Name = "ctrlFindPersonAndShowInfo";
            this.Size = new System.Drawing.Size(647, 409);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFindPerson ctrlFindPerson1;
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}
