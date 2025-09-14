using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class MainForm : Form
    {
        private Context db;
        private Operations ops;
        private List<Tasks> currentTasks;

        // Элементы интерфейса (теперь объявлены в Designer.cs, но оставлены для ясности)
        // private SplitContainer splitContainer; // и т.д. — удалены, так как в Designer

        public MainForm()
        {
            InitializeComponent(); // Инициализация из Designer.cs
            InitializeDatabase();
            SetupUI(); // Удалено — теперь в Designer
            LoadTasks();
            this.Resize += MainForm_Resize; // Добавлено для масштабируемости сплиттера
            // Новые строки для размещения формы выше на экране
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(60, 15);
        }

        private void InitializeDatabase()
        {
            db = new Context();
            db.Database.EnsureCreated(); // Создает базу, если не существует
            ops = new Operations(db);
        }

        // SetupUI() удален — геометрия в Designer.cs
        private void SetupUI()
        {
            this.Text = "Планировщик задач";
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(600, 400);

        }


        private void LoadTasks()
        {
            try
            {
                currentTasks = ops.GetAllTasks();
                taskListBox.Items.Clear();
                foreach (var task in currentTasks)
                {
                    taskListBox.Items.Add($"{task.Id}: {task.Category} - {task.Description}");
                }
                UpdateTaskCount();
                statusLabel.Text = "Задачи загружены";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки задач: " + ex.Message);
            }
        }

        private void UpdateTaskCount()
        {
            taskCountLabel.Text = $"Задач: {currentTasks.Count}";
        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                var selectedTask = currentTasks[taskListBox.SelectedIndex];
                categoryTextBox.Text = selectedTask.Category;
                descriptionTextBox.Text = selectedTask.Description;
                priorityComboBox.SelectedIndex = selectedTask.Priority - 1;
                if (DateTime.TryParse(selectedTask.DateTime, out DateTime dt))
                {
                    dueDatePicker.Value = dt;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string category = categoryTextBox.Text;
                int priority = priorityComboBox.SelectedIndex + 1;
                string description = descriptionTextBox.Text;
                string dateTime = dueDatePicker.Value.ToString("yyyy-MM-dd HH:mm");

                if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Заполните категорию и описание!");
                    return;
                }

                ops.AddTask(category, priority, description, dateTime);
                LoadTasks();
                ClearFields();
                statusLabel.Text = "Задача добавлена";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления задачи: " + ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                try
                {
                    var selectedTask = currentTasks[taskListBox.SelectedIndex];
                    ops.RemoveTask(selectedTask.Id);
                    LoadTasks();
                    ClearFields();
                    statusLabel.Text = "Задача удалена";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления задачи: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу для удаления!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                try
                {
                    var selectedTask = currentTasks[taskListBox.SelectedIndex];
                    string category = categoryTextBox.Text;
                    int priority = priorityComboBox.SelectedIndex + 1;
                    string description = descriptionTextBox.Text;
                    string dateTime = dueDatePicker.Value.ToString("yyyy-MM-dd HH:mm");

                    if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
                    {
                        MessageBox.Show("Заполните категорию и описание!");
                        return;
                    }

                    ops.UpdateTask(selectedTask.Id, category, priority, description, dateTime);
                    LoadTasks();
                    statusLabel.Text = "Задача обновлена";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обновления задачи: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу для редактирования!");
            }
        }

        private void ClearFields()
        {
            categoryTextBox.Clear();
            descriptionTextBox.Clear();
            priorityComboBox.SelectedIndex = -1;
            dueDatePicker.Value = DateTime.Now;
        }

        // Метод для обновления SplitterDistance (30% ширины)
        private void UpdateSplitterDistance()
        {
            if (splitContainer != null)
            {
                splitContainer.SplitterDistance = (int)(splitContainer.Width * 0.3);
            }
        }

        // Обработчик события изменения размера формы для масштабируемости сплиттера
        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdateSplitterDistance();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db?.Dispose();
            base.OnFormClosing(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void basicInfoGroup_Enter(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
