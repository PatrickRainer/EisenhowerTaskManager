using System;
using System.Windows;
using System.Windows.Controls;
using EisenhowerTaskManager.Models;

namespace EisenhowerTaskManager.Windows
{
    /// <summary>
    ///     Interaction logic for TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : Window
    {
        readonly MainWindow _mainWindow;
        readonly EmTask _task;

        public TaskWindow()
        {
            InitializeComponent();
        }

        public TaskWindow(EmTask task, MainWindow mainWindow)
        {
            InitializeComponent();

            EmComboBox.SelectedValuePath = "Content";
            StatusComboBox.SelectedValuePath = "Content";
            StatusComboBox.Items.Add(EmTaskStatus.Open);
            StatusComboBox.Items.Add(EmTaskStatus.InProgress);
            StatusComboBox.Items.Add(EmTaskStatus.Done);

            TaskNameTextBox.Text = task.TaskName;
            DescriptionTextBox.Text = task.Description;
            EmComboBox.SelectedValue = task.EisenhowerType.ToString();
            StatusComboBox.SelectedItem = task.Status;
            DueDatePicker.SelectedDate = task.DueDate;

            _mainWindow = mainWindow;
            _task = task;

        }

        void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            SaveControlValuesToMember();

            if (!ValidateTask()) return;

            SaveTaskToMainWindow();

            Close();
        }

        void SaveTaskToMainWindow()
        {
            if (_mainWindow.EmTasks.Contains(_task))
            {
                Console.WriteLine("Task is already existing in Task List. Update ...");
                _mainWindow.RefreshBindings();
            }
            else
            {
                Console.WriteLine("Task New. Add new ...");
                _mainWindow.EmTasks.Add(_task);
            }
        }

        void SaveControlValuesToMember()
        {
            _task.TaskName = TaskNameTextBox.Text;
            _task.Description = DescriptionTextBox.Text;
            _task.DueDate = DueDatePicker.SelectedDate;
            _task.EisenhowerType =
                (EisenhowerType) Enum.Parse(typeof(EisenhowerType), EmComboBox.SelectedValue.ToString());
            _task.Status = StatusComboBox.SelectedItem.ToString();
        }

        bool ValidateTask()
        {
            if (string.IsNullOrEmpty(_task.TaskName))
            {
                MessageBox.Show("Validation Error");
                return false;
            }

            return true;
        }

        void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void FinishButton_OnClick(object sender, RoutedEventArgs e)
        {
            SaveControlValuesToMember();
            if(!ValidateTask()) return;

            _task.Status = EmTaskStatus.Done;
            SaveTaskToMainWindow();

            Close();
        }
    }
}