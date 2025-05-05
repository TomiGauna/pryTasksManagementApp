using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Data.Common;
using System.Windows.Forms;

namespace TasksManagementApp
{
    internal class clsDataHandler
    {
        public DataSet DS;
        OleDbDataAdapter TasksDA;
        OleDbDataAdapter UsersDA;

        public clsDataHandler()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Tasks.mdb";
            connection.Open();

            DS = new DataSet();

            OleDbCommand command = new OleDbCommand();
            
            command.CommandType = CommandType.TableDirect;
            command.CommandText = "Tasks";
            command.Connection = connection;

            TasksDA = new OleDbDataAdapter();
            TasksDA.SelectCommand = command;
            TasksDA.Fill(DS, "Tasks");

            DataColumn[] DC = new DataColumn[1];
            DC[0] = DS.Tables["Tasks"].Columns["Id"];
            DS.Tables["Tasks"].PrimaryKey = DC;


            OleDbCommand usersCmd = new OleDbCommand();
            usersCmd.CommandType = CommandType.TableDirect;
            usersCmd.CommandText = "Users";
            usersCmd.Connection = connection;

            UsersDA = new OleDbDataAdapter();
            UsersDA.SelectCommand = usersCmd;
            UsersDA.Fill(DS, "Users");

            DataColumn[] DCC = new DataColumn[1];
            DCC[0] = DS.Tables["Users"].Columns["Id"];
            DS.Tables["Users"].PrimaryKey = DCC;

            OleDbCommandBuilder cb = new OleDbCommandBuilder(TasksDA);
            OleDbCommandBuilder usersCB = new OleDbCommandBuilder(UsersDA);

            connection.Close();
        }

        public void NewTask(
                string title, 
                string description,
                string priority, 
                string category,
                DateTime date
                )
        {
            try
            {
                DataRow newTask = DS.Tables["Tasks"].NewRow();
                newTask["Titulo"] = title;
                newTask["Descripcion"] = description;
                newTask["Prioridad"] = priority;
                newTask["Estado"] = "Pendiente";
                newTask["Categoria"] = category;
                newTask["FechaVencimiento"] = date.ToShortDateString();

                int n = DS.Tables["Tasks"].Rows.Count;
                newTask["Id"] = n + 1;

                DS.Tables["Tasks"].Rows.Add(newTask);
                TasksDA.Update(DS, "Tasks");

                MessageBox.Show("Task registered successfully!", "Task Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Fail to create new task: " + ex.Message, "Error Information: Task Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void TaskDesignation(int userNumber)
        {
            try
            {
                DataRow row = DS.Tables["Users"].Rows.Find(userNumber);
                row["TareasAsignadas"] = DS.Tables["Tasks"].Rows.Count;
                UsersDA.Update(DS, "Users");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error in the designation of the task: " + ex.Message, "Error Information: Task Designation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void TaskUpdate(string task, string field, string data)
        {
            try
            {
                for (int i = 0; i < DS.Tables["Tasks"].Rows.Count; i++)
                {
                    DataRow row = DS.Tables["Tasks"].Rows[i];

                    if (row["Titulo"].ToString() == task.ToString())
                    {
                        row.BeginEdit();
                        if (field == "FechaVencimiento")
                        {
                            DateTime date = DateTime.Parse(data);
                            row[field] = date;
                        }
                        else
                        {
                            row[field] = data;
                        }
                        row.EndEdit();
                        break;
                    }      
                }
                TasksDA.Update(DS, "Tasks");
                MessageBox.Show("Task updated successfully!", "Task Information: Task Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to update the task: " + ex.Message, "Error Information: Task Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveTask(string task) 
        {
            try
            {
                for (int i = 0; i < DS.Tables["Tasks"].Rows.Count; i++)
                {
                    DataRow row = DS.Tables["Tasks"].Rows[i];
                    if (row["Titulo"].ToString() == task.ToString())
                    {
                        row.Delete();
                        break;
                    }
                }
                TasksDA.Update(DS, "Tasks");
                MessageBox.Show("Task removed successfully", "Task Information: Task Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to delete task: " + ex.Message, "Task Information: Task Removal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<DataRow> QuestByCategory(string category)
        {
            List<DataRow> list = new List<DataRow>();
            foreach (DataRow row in DS.Tables["Tasks"].Rows)
            {
                if (row["Estado"].ToString() == category)
                {
                    list.Add(row);
                }
            }
            //Console.WriteLine(list);
            return list;
        }
    }
}
