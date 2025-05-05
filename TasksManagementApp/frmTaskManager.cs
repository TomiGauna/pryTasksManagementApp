using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TasksManagementApp
{
    public partial class frmTaskManager : Form
    {
        public frmTaskManager()
        {
            InitializeComponent();
        }

        clsDataHandler DH = new clsDataHandler();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaskName.Text = "Create a new task";
            lblDesignation.Text = "Assign to:";
            lblPriority.Text = "Choose level of priority";
            lblSearch.Text = "Make a report according to status";
            lblDueDate.Text = "Due Date";
            lblDesc.Text = "Description";
            lblCategory.Text = "Category";
            lblRemoveorUpdate.Text = "Do you want to remove or update a task?";

            btnAdd.Text = "Create Task";
            btnReport.Text = "Generate Report";
            btnOpenForm.Text = "Open Form";

            cboDesignation.Items.Clear();
            cboDesignation.DisplayMember = "Usuarios";
            cboDesignation.ValueMember = "Id";
            cboDesignation.DataSource = DH.DS.Tables["Users"];
            cboDesignation.SelectedValue = -1;

            cboCategory.Items.Clear();
            cboCategory.Items.Add("Support");
            cboCategory.Items.Add("IT");
            cboCategory.Items.Add("Maintenance");
            cboCategory.Items.Add("Finance");
            cboCategory.Items.Add("Management");
            cboCategory.Items.Add("HR");
            cboCategory.Items.Add("Sales");
            cboCategory.Items.Add("Marketing");
            cboCategory.Items.Add("Supplies");
            cboCategory.Items.Add("Logistics");
            cboCategory.Items.Add("Storage");
            cboCategory.SelectedValue = -1;

            cboPriority.Items.Clear();
            cboPriority.Items.Add("High");
            cboPriority.Items.Add("Medium");
            cboPriority.Items.Add("Low");
            cboPriority.SelectedValue = -1;

            cboSearch.Items.Clear();
            cboSearch.Items.Add("Pendiente");
            cboSearch.Items.Add("En progreso");
            cboSearch.Items.Add("Completeda");
            cboSearch.SelectedValue = -1;
            this.reportViewer1.RefreshReport();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DH.NewTask(txtNewTask.Text, 
                    rtxtDesc.Text, 
                    cboPriority.Text,
                    cboCategory.Text,
                    dtpDate.Value
                    );
                DH.TaskDesignation(cboDesignation.SelectedIndex + 1);
            }
            else
            {
                MessageBox.Show("Error due to incorrect data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Validation()
        {
            bool flag = false;
            if (txtNewTask.Text != "" && 
                cboDesignation.Text != "" &&
                cboPriority.Text != "" &&
                rtxtDesc.Text != "" &&
                dtpDate.Value > DateTime.Now &&
                cboDesignation.SelectedIndex > 0)
            {
                flag = true;
            }

            return flag;
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            frmRemoveOrUpdate form = new frmRemoveOrUpdate();
            form.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            List<DataRow> list = DH.QuestByCategory(cboSearch.Text);

            foreach (DataRow row in list)
            {
                lstTest.Text = row["Descripcion"].ToString();
                Console.WriteLine(lstTest.Text);
            }
        }
    }
}
