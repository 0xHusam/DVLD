namespace WindowsForms.Forms.frm_Application.LicensingServiceOrders
{
    partial class frmAddLocalOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlFindPersonAndShowInfo1 = new WindowsForms.ctrl.ctrl_person.ctrlFindPersonAndShowInfo();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCrytedBy = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLicenseTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrl_ShowLicense1 = new WindowsForms.ctrl.ctrl_Application.ctrl_ShowLicense();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlFindPersonAndShowInfo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPersonAndShowInfo1
            // 
            this.ctrlFindPersonAndShowInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlFindPersonAndShowInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFindPersonAndShowInfo1.Name = "ctrlFindPersonAndShowInfo1";
            this.ctrlFindPersonAndShowInfo1.Size = new System.Drawing.Size(765, 427);
            this.ctrlFindPersonAndShowInfo1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCansel);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cbLicenseTypes);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(451, 387);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(146, 39);
            this.btnCansel.TabIndex = 7;
            this.btnCansel.Text = "Close";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            this.btnCansel.MouseEnter += new System.EventHandler(this.btnCansel_MouseEnter);
            this.btnCansel.MouseLeave += new System.EventHandler(this.btnCansel_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCrytedBy);
            this.groupBox2.Controls.Add(this.lblServiceFee);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service Info";
            // 
            // lblCrytedBy
            // 
            this.lblCrytedBy.AutoSize = true;
            this.lblCrytedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrytedBy.Location = new System.Drawing.Point(115, 79);
            this.lblCrytedBy.Name = "lblCrytedBy";
            this.lblCrytedBy.Size = new System.Drawing.Size(27, 20);
            this.lblCrytedBy.TabIndex = 5;
            this.lblCrytedBy.Text = "??";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceFee.Location = new System.Drawing.Point(115, 35);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(27, 20);
            this.lblServiceFee.TabIndex = 6;
            this.lblServiceFee.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "created by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service Fee:";
            // 
            // cbLicenseTypes
            // 
            this.cbLicenseTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseTypes.FormattingEnabled = true;
            this.cbLicenseTypes.Location = new System.Drawing.Point(190, 17);
            this.cbLicenseTypes.Name = "cbLicenseTypes";
            this.cbLicenseTypes.Size = new System.Drawing.Size(575, 28);
            this.cbLicenseTypes.TabIndex = 2;
            this.cbLicenseTypes.SelectedIndexChanged += new System.EventHandler(this.cbLicenseTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose License Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrl_ShowLicense1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 255);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License Info";
            // 
            // ctrl_ShowLicense1
            // 
            this.ctrl_ShowLicense1.Location = new System.Drawing.Point(0, 27);
            this.ctrl_ShowLicense1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrl_ShowLicense1.Name = "ctrl_ShowLicense1";
            this.ctrl_ShowLicense1.Size = new System.Drawing.Size(746, 227);
            this.ctrl_ShowLicense1.TabIndex = 0;
            // 
            // frmAddLocalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddLocalOrder";
            this.Text = "frmAddLocalOrder";
            this.Load += new System.EventHandler(this.frmAddLocalOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ctrl.ctrl_person.ctrlFindPersonAndShowInfo ctrlFindPersonAndShowInfo1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLicenseTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrl.ctrl_Application.ctrl_ShowLicense ctrl_ShowLicense1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrytedBy;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSave;
    }
}