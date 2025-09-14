namespace ToDoApp
{
    partial class MainForm
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.detailsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.basicInfoGroup = new System.Windows.Forms.GroupBox();
            this.basicLayout = new System.Windows.Forms.TableLayoutPanel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoGroup = new System.Windows.Forms.GroupBox();
            this.additionalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.basicInfoGroup.SuspendLayout();
            this.basicLayout.SuspendLayout();
            this.additionalInfoGroup.SuspendLayout();
            this.additionalLayout.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonPanel);
            this.splitContainer.Panel1.Controls.Add(this.taskListBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.saveButton);
            this.splitContainer.Panel2.Controls.Add(this.detailsPanel);
            this.splitContainer.Size = new System.Drawing.Size(1600, 1112);
            this.splitContainer.SplitterDistance = 495;
            this.splitContainer.SplitterWidth = 18;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Controls.Add(this.removeButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 1052);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(495, 60);
            this.buttonPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(220, 60);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeButton.Location = new System.Drawing.Point(275, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(220, 60);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // taskListBox
            // 
            this.taskListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListBox.Font = new System.Drawing.Font("Arial", 11F);
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 38;
            this.taskListBox.Location = new System.Drawing.Point(0, 0);
            this.taskListBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(495, 1112);
            this.taskListBox.TabIndex = 0;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.TaskListBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 1052);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1087, 60);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.ColumnCount = 1;
            this.detailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailsPanel.Controls.Add(this.basicInfoGroup, 0, 0);
            this.detailsPanel.Controls.Add(this.additionalInfoGroup, 0, 1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.RowCount = 2;
            this.detailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.detailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.detailsPanel.Size = new System.Drawing.Size(1087, 1112);
            this.detailsPanel.TabIndex = 0;
            // 
            // basicInfoGroup
            // 
            this.basicInfoGroup.Controls.Add(this.basicLayout);
            this.basicInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicInfoGroup.Location = new System.Drawing.Point(8, 8);
            this.basicInfoGroup.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.basicInfoGroup.Name = "basicInfoGroup";
            this.basicInfoGroup.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.basicInfoGroup.Size = new System.Drawing.Size(1071, 651);
            this.basicInfoGroup.TabIndex = 0;
            this.basicInfoGroup.TabStop = false;
            this.basicInfoGroup.Text = "Основные данные";
            // 
            // basicLayout
            // 
            this.basicLayout.ColumnCount = 1;
            this.basicLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.basicLayout.Controls.Add(this.categoryLabel, 0, 0);
            this.basicLayout.Controls.Add(this.categoryTextBox, 0, 1);
            this.basicLayout.Controls.Add(this.descLabel, 0, 2);
            this.basicLayout.Controls.Add(this.descriptionTextBox, 0, 3);
            this.basicLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicLayout.Location = new System.Drawing.Point(8, 36);
            this.basicLayout.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.basicLayout.Name = "basicLayout";
            this.basicLayout.RowCount = 4;
            this.basicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.basicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.basicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.basicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.basicLayout.Size = new System.Drawing.Size(1055, 607);
            this.basicLayout.TabIndex = 0;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Location = new System.Drawing.Point(8, 0);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(1039, 56);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Категория:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTextBox.Location = new System.Drawing.Point(8, 64);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(1039, 35);
            this.categoryTextBox.TabIndex = 1;
            // 
            // descLabel
            // 
            this.descLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descLabel.Location = new System.Drawing.Point(8, 112);
            this.descLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(1039, 56);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Описание:";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(8, 176);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(1039, 423);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // additionalInfoGroup
            // 
            this.additionalInfoGroup.Controls.Add(this.additionalLayout);
            this.additionalInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalInfoGroup.Location = new System.Drawing.Point(8, 675);
            this.additionalInfoGroup.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.additionalInfoGroup.Name = "additionalInfoGroup";
            this.additionalInfoGroup.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.additionalInfoGroup.Size = new System.Drawing.Size(1071, 429);
            this.additionalInfoGroup.TabIndex = 1;
            this.additionalInfoGroup.TabStop = false;
            this.additionalInfoGroup.Text = "Дополнительные параметры";
            // 
            // additionalLayout
            // 
            this.additionalLayout.ColumnCount = 1;
            this.additionalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.additionalLayout.Controls.Add(this.priorityLabel, 0, 0);
            this.additionalLayout.Controls.Add(this.priorityComboBox, 0, 1);
            this.additionalLayout.Controls.Add(this.dateLabel, 0, 2);
            this.additionalLayout.Controls.Add(this.dueDatePicker, 0, 3);
            this.additionalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalLayout.Location = new System.Drawing.Point(8, 36);
            this.additionalLayout.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.additionalLayout.Name = "additionalLayout";
            this.additionalLayout.RowCount = 4;
            this.additionalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.additionalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.additionalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.additionalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.additionalLayout.Size = new System.Drawing.Size(1055, 385);
            this.additionalLayout.TabIndex = 0;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityLabel.Location = new System.Drawing.Point(8, 0);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(1039, 56);
            this.priorityLabel.TabIndex = 0;
            this.priorityLabel.Text = "Приоритет:";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1 - Высокий",
            "2 - Средний",
            "3 - Низкий"});
            this.priorityComboBox.Location = new System.Drawing.Point(8, 64);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(1039, 37);
            this.priorityComboBox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Location = new System.Drawing.Point(8, 112);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(1039, 56);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Срок выполнения:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dueDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDatePicker.Location = new System.Drawing.Point(8, 176);
            this.dueDatePicker.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(1039, 35);
            this.dueDatePicker.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.taskCountLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1112);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(4, 0, 36, 0);
            this.statusStrip.Size = new System.Drawing.Size(1600, 48);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(103, 37);
            this.statusLabel.Text = "Готово";
            // 
            // taskCountLabel
            // 
            this.taskCountLabel.Name = "taskCountLabel";
            this.taskCountLabel.Size = new System.Drawing.Size(118, 37);
            this.taskCountLabel.Text = "Задач: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1160);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(772, 506);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Планировщик задач";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.basicInfoGroup.ResumeLayout(false);
            this.basicLayout.ResumeLayout(false);
            this.basicLayout.PerformLayout();
            this.additionalInfoGroup.ResumeLayout(false);
            this.additionalLayout.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel detailsPanel;
        private System.Windows.Forms.GroupBox basicInfoGroup;
        private System.Windows.Forms.TableLayoutPanel basicLayout;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.GroupBox additionalInfoGroup;
        private System.Windows.Forms.TableLayoutPanel additionalLayout;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel taskCountLabel;
    }
}
