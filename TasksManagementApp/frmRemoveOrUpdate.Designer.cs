namespace TasksManagementApp
{
    partial class frmRemoveOrUpdate
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
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblRemovingTitle = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblNewData = new System.Windows.Forms.Label();
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.cboGral = new System.Windows.Forms.ComboBox();
            this.cboRemove = new System.Windows.Forms.ComboBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectTask = new System.Windows.Forms.Label();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(64, 26);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "label1";
            // 
            // lblRemovingTitle
            // 
            this.lblRemovingTitle.AutoSize = true;
            this.lblRemovingTitle.Location = new System.Drawing.Point(342, 26);
            this.lblRemovingTitle.Name = "lblRemovingTitle";
            this.lblRemovingTitle.Size = new System.Drawing.Size(35, 13);
            this.lblRemovingTitle.TabIndex = 1;
            this.lblRemovingTitle.Text = "label2";
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(33, 125);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(221, 21);
            this.cboField.TabIndex = 2;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(30, 109);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "label3";
            // 
            // lblNewData
            // 
            this.lblNewData.AutoSize = true;
            this.lblNewData.Location = new System.Drawing.Point(30, 159);
            this.lblNewData.Name = "lblNewData";
            this.lblNewData.Size = new System.Drawing.Size(35, 13);
            this.lblNewData.TabIndex = 4;
            this.lblNewData.Text = "label4";
            // 
            // txtNewData
            // 
            this.txtNewData.Location = new System.Drawing.Point(33, 175);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(221, 20);
            this.txtNewData.TabIndex = 5;
            // 
            // cboGral
            // 
            this.cboGral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGral.FormattingEnabled = true;
            this.cboGral.Location = new System.Drawing.Point(33, 201);
            this.cboGral.Name = "cboGral";
            this.cboGral.Size = new System.Drawing.Size(221, 21);
            this.cboGral.TabIndex = 6;
            // 
            // cboRemove
            // 
            this.cboRemove.FormattingEnabled = true;
            this.cboRemove.Location = new System.Drawing.Point(286, 76);
            this.cboRemove.Name = "cboRemove";
            this.cboRemove.Size = new System.Drawing.Size(226, 21);
            this.cboRemove.TabIndex = 7;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(283, 60);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(35, 13);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "label5";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(437, 109);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "button1";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "button2";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Location = new System.Drawing.Point(33, 228);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(221, 20);
            this.dtpNewDate.TabIndex = 11;
            // 
            // lblSelectTask
            // 
            this.lblSelectTask.AutoSize = true;
            this.lblSelectTask.Location = new System.Drawing.Point(30, 60);
            this.lblSelectTask.Name = "lblSelectTask";
            this.lblSelectTask.Size = new System.Drawing.Size(35, 13);
            this.lblSelectTask.TabIndex = 12;
            this.lblSelectTask.Text = "label1";
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(33, 76);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(221, 21);
            this.cboTask.TabIndex = 13;
            // 
            // frmRemoveOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 357);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.lblSelectTask);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.cboRemove);
            this.Controls.Add(this.cboGral);
            this.Controls.Add(this.txtNewData);
            this.Controls.Add(this.lblNewData);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.lblRemovingTitle);
            this.Controls.Add(this.lblUpdateTitle);
            this.Name = "frmRemoveOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRemoveOrUpdate";
            this.Load += new System.EventHandler(this.frmRemoveOrUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblRemovingTitle;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblNewData;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.ComboBox cboGral;
        private System.Windows.Forms.ComboBox cboRemove;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label lblSelectTask;
        private System.Windows.Forms.ComboBox cboTask;
    }
}