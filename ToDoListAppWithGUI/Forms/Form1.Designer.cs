namespace ToDoListAppWithGUI.Forms
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnDeleteTask;

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
            txtTaskDescription = new TextBox();
            lstTasks = new ListBox();
            btnAddTask = new Button();
            btnEditTask = new Button();
            btnCompleteTask = new Button();
            btnDeleteTask = new Button();
            btnSaveTasks = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(14, 16);
            txtTaskDescription.Margin = new Padding(3, 4, 3, 4);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(342, 27);
            txtTaskDescription.TabIndex = 0;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(14, 76);
            lstTasks.Margin = new Padding(3, 4, 3, 4);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(342, 204);
            lstTasks.TabIndex = 1;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(366, 16);
            btnAddTask.Margin = new Padding(3, 4, 3, 4);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(114, 31);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(366, 76);
            btnEditTask.Margin = new Padding(3, 4, 3, 4);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(114, 31);
            btnEditTask.TabIndex = 3;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(366, 129);
            btnCompleteTask.Margin = new Padding(3, 4, 3, 4);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(114, 31);
            btnCompleteTask.TabIndex = 4;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(366, 182);
            btnDeleteTask.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(114, 31);
            btnDeleteTask.TabIndex = 5;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnSaveTasks
            // 
            btnSaveTasks.Location = new Point(366, 236);
            btnSaveTasks.Name = "btnSaveTasks";
            btnSaveTasks.Size = new Size(114, 29);
            btnSaveTasks.TabIndex = 6;
            btnSaveTasks.Text = "Save Tasks";
            btnSaveTasks.UseVisualStyleBackColor = true;
            btnSaveTasks.Click += btnSaveTasks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "List of Tasks";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 293);
            Controls.Add(label1);
            Controls.Add(btnSaveTasks);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnCompleteTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Controls.Add(lstTasks);
            Controls.Add(txtTaskDescription);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "To-Do List";
            FormClosing += Form1_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTasks;
        private Label label1;
    }
}
