namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ActivePanel = new Panel();
            ActiveDelete = new Button();
            ActiveList = new CheckedListBox();
            ActiveDate = new Label();
            ActiveName = new Label();
            NewActiveDate = new TextBox();
            NewActiveName = new TextBox();
            CreateNewActive = new Button();
            CompletedPanel = new Panel();
            CompletedList = new CheckedListBox();
            RemoveCompletedItem = new Button();
            ActiveButton = new Button();
            button1 = new Button();
            ActivePanel.SuspendLayout();
            CompletedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ActivePanel
            // 
            ActivePanel.AccessibleName = "ActivePanel";
            ActivePanel.BackColor = Color.AliceBlue;
            ActivePanel.Controls.Add(ActiveDelete);
            ActivePanel.Controls.Add(ActiveList);
            ActivePanel.Controls.Add(ActiveDate);
            ActivePanel.Controls.Add(ActiveName);
            ActivePanel.Controls.Add(NewActiveDate);
            ActivePanel.Controls.Add(NewActiveName);
            ActivePanel.Controls.Add(CreateNewActive);
            ActivePanel.Location = new Point(193, 12);
            ActivePanel.Name = "ActivePanel";
            ActivePanel.Size = new Size(845, 560);
            ActivePanel.TabIndex = 2;
            ActivePanel.Visible = false;
            // 
            // ActiveDelete
            // 
            ActiveDelete.BackColor = Color.DarkOrange;
            ActiveDelete.Location = new Point(52, 68);
            ActiveDelete.Name = "ActiveDelete";
            ActiveDelete.Size = new Size(120, 34);
            ActiveDelete.TabIndex = 7;
            ActiveDelete.Text = "Remove";
            ActiveDelete.UseVisualStyleBackColor = false;
            ActiveDelete.Click += button2_Click;
            // 
            // ActiveList
            // 
            ActiveList.FormattingEnabled = true;
            ActiveList.Items.AddRange(new object[] { "Example: Homework (10/24/24)" });
            ActiveList.Location = new Point(52, 130);
            ActiveList.Name = "ActiveList";
            ActiveList.Size = new Size(392, 364);
            ActiveList.TabIndex = 6;
            // 
            // ActiveDate
            // 
            ActiveDate.AutoSize = true;
            ActiveDate.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveDate.Location = new Point(503, 31);
            ActiveDate.Name = "ActiveDate";
            ActiveDate.Size = new Size(86, 25);
            ActiveDate.TabIndex = 5;
            ActiveDate.Text = "Date Due";
            // 
            // ActiveName
            // 
            ActiveName.AutoSize = true;
            ActiveName.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveName.Location = new Point(252, 31);
            ActiveName.Name = "ActiveName";
            ActiveName.Size = new Size(59, 25);
            ActiveName.TabIndex = 4;
            ActiveName.Text = "Name";
            // 
            // NewActiveDate
            // 
            NewActiveDate.Location = new Point(595, 31);
            NewActiveDate.Name = "NewActiveDate";
            NewActiveDate.Size = new Size(127, 25);
            NewActiveDate.TabIndex = 3;
            // 
            // NewActiveName
            // 
            NewActiveName.Location = new Point(317, 31);
            NewActiveName.Name = "NewActiveName";
            NewActiveName.Size = new Size(127, 25);
            NewActiveName.TabIndex = 2;
            // 
            // CreateNewActive
            // 
            CreateNewActive.BackColor = Color.PaleTurquoise;
            CreateNewActive.Location = new Point(52, 28);
            CreateNewActive.Name = "CreateNewActive";
            CreateNewActive.Size = new Size(120, 34);
            CreateNewActive.TabIndex = 0;
            CreateNewActive.Text = "Create new task";
            CreateNewActive.UseVisualStyleBackColor = false;
            CreateNewActive.Click += CreateNewActive_Click;
            // 
            // CompletedPanel
            // 
            CompletedPanel.AccessibleName = "CompletedPanel";
            CompletedPanel.BackColor = Color.AliceBlue;
            CompletedPanel.Controls.Add(CompletedList);
            CompletedPanel.Controls.Add(RemoveCompletedItem);
            CompletedPanel.Location = new Point(193, 12);
            CompletedPanel.Name = "CompletedPanel";
            CompletedPanel.Size = new Size(845, 619);
            CompletedPanel.TabIndex = 7;
            CompletedPanel.Visible = false;
            // 
            // CompletedList
            // 
            CompletedList.ForeColor = SystemColors.ActiveCaptionText;
            CompletedList.FormattingEnabled = true;
            CompletedList.Items.AddRange(new object[] { "CompletedList" });
            CompletedList.Location = new Point(52, 130);
            CompletedList.Name = "CompletedList";
            CompletedList.Size = new Size(392, 364);
            CompletedList.TabIndex = 6;
            // 
            // RemoveCompletedItem
            // 
            RemoveCompletedItem.BackColor = Color.DarkOrange;
            RemoveCompletedItem.Location = new Point(52, 28);
            RemoveCompletedItem.Name = "RemoveCompletedItem";
            RemoveCompletedItem.Size = new Size(120, 34);
            RemoveCompletedItem.TabIndex = 0;
            RemoveCompletedItem.Text = "Delete";
            RemoveCompletedItem.UseVisualStyleBackColor = false;
            RemoveCompletedItem.Click += RemoveCompletedItem_Click;
            // 
            // ActiveButton
            // 
            ActiveButton.BackColor = Color.Transparent;
            ActiveButton.Font = new Font("Verdana", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveButton.Location = new Point(12, 37);
            ActiveButton.Name = "ActiveButton";
            ActiveButton.Size = new Size(118, 41);
            ActiveButton.TabIndex = 3;
            ActiveButton.Text = "Active";
            ActiveButton.UseVisualStyleBackColor = false;
            ActiveButton.Click += ActiveButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 117);
            button1.Name = "button1";
            button1.Size = new Size(156, 41);
            button1.TabIndex = 4;
            button1.Text = "Completed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CompleteButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1050, 557);
            Controls.Add(button1);
            Controls.Add(CompletedPanel);
            Controls.Add(ActiveButton);
            Controls.Add(ActivePanel);
            Name = "Form1";
            Text = "Task Manager";
            Load += Form1_Load;
            ActivePanel.ResumeLayout(false);
            ActivePanel.PerformLayout();
            CompletedPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel ActivePanel;
        private Button ActiveButton;
        private Button button1;
        private Button CreateNewActive;
        private Label ActiveDate;
        private Label ActiveName;
        private TextBox NewActiveDate;
        private TextBox NewActiveName;
        private CheckedListBox ActiveList;
        private Panel CompletedPanel;
        private CheckedListBox CompletedList;
        private Button RemoveCompletedItem;
        private Button ActiveDelete;
    }
}
