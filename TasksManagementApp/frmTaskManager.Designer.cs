namespace TasksManagementApp
{
    partial class frmTaskManager
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDesignation = new System.Windows.Forms.ComboBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtNewTask = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.lblRemoveorUpdate = new System.Windows.Forms.Label();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboDesignation
            // 
            this.cboDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Location = new System.Drawing.Point(34, 76);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(200, 21);
            this.cboDesignation.TabIndex = 0;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(31, 9);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(35, 13);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "label1";
            // 
            // txtNewTask
            // 
            this.txtNewTask.Location = new System.Drawing.Point(34, 27);
            this.txtNewTask.Name = "txtNewTask";
            this.txtNewTask.Size = new System.Drawing.Size(200, 20);
            this.txtNewTask.TabIndex = 2;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(31, 60);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(35, 13);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "label2";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(31, 249);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(35, 13);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "label3";
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(34, 265);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(200, 21);
            this.cboPriority.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(31, 300);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(35, 13);
            this.lblDueDate.TabIndex = 7;
            this.lblDueDate.Text = "label4";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(247, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(35, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "label5";
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(250, 52);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(450, 21);
            this.cboSearch.TabIndex = 10;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(625, 79);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 42);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "button2";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(34, 316);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(34, 168);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(200, 66);
            this.rtxtDesc.TabIndex = 13;
            this.rtxtDesc.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(34, 149);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "label1";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(31, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(35, 13);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "label1";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(34, 122);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 21);
            this.cboCategory.TabIndex = 16;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(250, 127);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(450, 159);
            this.reportViewer1.TabIndex = 17;
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(34, 503);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(200, 23);
            this.btnOpenForm.TabIndex = 18;
            this.btnOpenForm.Text = "button1";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // lblRemoveorUpdate
            // 
            this.lblRemoveorUpdate.AutoSize = true;
            this.lblRemoveorUpdate.Location = new System.Drawing.Point(34, 471);
            this.lblRemoveorUpdate.Name = "lblRemoveorUpdate";
            this.lblRemoveorUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblRemoveorUpdate.TabIndex = 20;
            this.lblRemoveorUpdate.Text = "label1";
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.Location = new System.Drawing.Point(250, 316);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(450, 251);
            this.lstTest.TabIndex = 21;
            // 
            // frmTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 574);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.lblRemoveorUpdate);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.txtNewTask);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.cboDesignation);
            this.Name = "frmTaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creation and Designation of Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDesignation;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Label lblRemoveorUpdate;
        private System.Windows.Forms.ListBox lstTest;
    }
}

