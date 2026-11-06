namespace WindowsForms.Forms.frm_Application.frm_ApplicationTypes
{
    partial class frmUpdateApplicationType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.nudFees = new System.Windows.Forms.NumericUpDown();
            this.txtApplicationType = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fees";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(136, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "?";
            // 
            // nudFees
            // 
            this.nudFees.Location = new System.Drawing.Point(139, 169);
            this.nudFees.Name = "nudFees";
            this.nudFees.Size = new System.Drawing.Size(131, 22);
            this.nudFees.TabIndex = 4;
            // 
            // txtApplicationType
            // 
            this.txtApplicationType.Location = new System.Drawing.Point(139, 98);
            this.txtApplicationType.Name = "txtApplicationType";
            this.txtApplicationType.Size = new System.Drawing.Size(270, 22);
            this.txtApplicationType.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(308, 165);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 26);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 199);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtApplicationType);
            this.Controls.Add(this.nudFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateApplicationType";
            this.Text = "Update Application Type";
            ((System.ComponentModel.ISupportInitialize)(this.nudFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown nudFees;
        private System.Windows.Forms.TextBox txtApplicationType;
        private System.Windows.Forms.Button btnsave;
    }
}