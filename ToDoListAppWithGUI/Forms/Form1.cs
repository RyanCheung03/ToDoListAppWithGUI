using System;
using System.Windows.Forms;
using ToDoListAppWithGUI.Models;
using ToDoListAppWithGUI.Services;

namespace ToDoListAppWithGUI.Forms
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager;

        public Form1()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            UpdateTaskList();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaskDescription.Text))
            {
                taskManager.AddTask(txtTaskDescription.Text);
                txtTaskDescription.Clear();
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please enter a task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is ToDoListAppWithGUI.Models.Task selectedTask)
            {
                string newDescription = txtTaskDescription.Text;
                if (!string.IsNullOrWhiteSpace(newDescription))
                {
                    taskManager.EditTask(selectedTask.Id, newDescription);
                    UpdateTaskList();
                }
                else
                {
                    MessageBox.Show("Please enter a new task description.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Error");
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is ToDoListAppWithGUI.Models.Task selectedTask)
            {
                taskManager.CompleteTask(selectedTask.Id);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "Error");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is ToDoListAppWithGUI.Models.Task selectedTask)
            {
                taskManager.DeleteTask(selectedTask.Id);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error");
            }
        }

        private void UpdateTaskList()
        {
            lstTasks.DataSource = null; // Reset the data source
            lstTasks.DataSource = taskManager.Tasks; // Assign updated task list
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            try
            {
                taskManager.SaveTasksToFile(); // Save tasks to the file
                MessageBox.Show("Tasks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Show a dialog with Save, Don't Save, and Cancel options
            DialogResult result = MessageBox.Show(
                "Do you want to save your tasks before exiting?",
                "Exit Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // Handle the user's choice
            if (result == DialogResult.Yes)
            {
                // Save tasks and allow the form to close
                taskManager.SaveTasksToFile();
                MessageBox.Show("Tasks saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                // Don't save tasks and allow the form to close
                e.Cancel = false; // Continue with closing
            }
            else if (result == DialogResult.Cancel)
            {
                // Cancel the closing operation
                e.Cancel = true;
            }
        }
    }
}
