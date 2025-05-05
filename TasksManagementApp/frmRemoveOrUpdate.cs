using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksManagementApp
{
    public partial class frmRemoveOrUpdate : Form
    {
        clsDataHandler DH = new clsDataHandler();
        public frmRemoveOrUpdate()
        {
            InitializeComponent();
        }

        private void frmRemoveOrUpdate_Load(object sender, EventArgs e)
        {
            lblRemovingTitle.Text = "REMOVE A TASK";
            lblUpdateTitle.Text = "UPDATE TASK INFORMATION";
            lblRemove.Text = "Choose the task";
            lblUpdate.Text = "Choose the property you want to change";
            lblNewData.Text = "Enter the updated data";
            lblSelectTask.Text = "Select the task";

            btnRemove.Text = "Remove";
            btnUpdate.Text = "Update";

            cboTask.Items.Clear();
            cboTask.DisplayMember = "Titulo";
            cboTask.ValueMember = "Id";
            cboTask.DataSource = DH.DS.Tables["Tasks"];
            cboTask.SelectedIndex = -1;

            cboField.Items.Clear();
            cboField.Items.Add("Titulo");
            cboField.Items.Add("Descripcion");
            cboField.Items.Add("Categoria");
            cboField.Items.Add("Prioridad");
            cboField.Items.Add("FechaVencimiento");
            cboField.Items.Add("Estado");

            cboRemove.Items.Clear();
            cboRemove.DisplayMember = "Titulo";
            cboRemove.ValueMember = "Id";
            cboRemove.DataSource = DH.DS.Tables["Tasks"];
            cboRemove.SelectedIndex = -1;

            txtNewData.Enabled = false;
            cboGral.Enabled = false;
            dtpNewDate.Enabled = false;

        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboField.Text == "Titulo" || cboField.Text == "Descripcion")
            {
                txtNewData.Enabled = true;
                cboGral.Enabled = false;
                dtpNewDate.Enabled = false;
            }
            else if (cboField.Text == "Categoria" || cboField.Text == "Prioridad" || cboField.Text == "Estado")
            {
                txtNewData.Enabled = false;
                cboGral.Enabled = true;
                dtpNewDate.Enabled = false;

                switch (cboField.Text)
                {
                    case "Categoria":
                        cboGral.Items.Clear();
                        cboGral.Items.Add("Soporte");
                        cboGral.Items.Add("Ventas");
                        cboGral.Items.Add("Deposito");
                        cboGral.Items.Add("Logistica");
                        cboGral.Items.Add("Mantenimiento");
                        cboGral.Items.Add("IT");
                        cboGral.Items.Add("Suministros");
                        cboGral.Items.Add("Finanzas");
                        cboGral.Items.Add("RRHH");
                        cboGral.Items.Add("Marketing");
                        cboGral.Items.Add("Gerencia");
                        break;

                    case "Prioridad":
                        cboGral.Items.Clear();
                        cboGral.Items.Add("Alta");
                        cboGral.Items.Add("Baja");
                        cboGral.Items.Add("Media");
                        break;

                    case "Estado":
                        cboGral.Items.Clear();
                        cboGral.Items.Add("Pendiente");
                        cboGral.Items.Add("En progreso");
                        cboGral.Items.Add("Completada");
                        break;

                    default:
                        cboGral.Items.Clear();
                        cboGral.Items.Add("Pendiente");
                        cboGral.Items.Add("En progreso");
                        cboGral.Items.Add("Completada");
                        break;
                }
            }
            else
            {
                txtNewData.Enabled = false;
                cboGral.Enabled = false;
                dtpNewDate.Enabled = true;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboField.SelectedIndex < 0 || cboTask.SelectedIndex < 0)
                {
                    MessageBox.Show("You must enter valid data", "Data Entry Information: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cboField.Text == "Titulo" || cboField.Text == "Descripcion")
                    {
                        DH.TaskUpdate(cboTask.Text, cboField.Text, txtNewData.Text);
                    }
                    else if (cboField.Text == "Categoria" || cboField.Text == "Prioridad" || cboField.Text == "Estado")
                    {
                        DH.TaskUpdate(cboTask.Text, cboField.Text, cboGral.Text);
                    }
                    else
                    {
                        DH.TaskUpdate(cboTask.Text, cboField.Text, dtpNewDate.Text);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Fail to update task: " + ex.Message, "Error Information: Task Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cleaning();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DH.RemoveTask(cboRemove.Text);
            Cleaning();
        }

        private void Cleaning()
        {
            cboTask.SelectedIndex = -1;
            cboField.SelectedIndex = -1;
            cboRemove.SelectedIndex = -1;
            cboGral.SelectedIndex = -1;
            dtpNewDate.Value = DateTime.Now;
            txtNewData.Text = string.Empty;
        }
    }
}
