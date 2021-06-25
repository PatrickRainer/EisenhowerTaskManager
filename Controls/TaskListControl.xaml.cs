using System;
using System.Windows;
using System.Windows.Controls;
using EisenhowerTaskManager.Models;
using EisenhowerTaskManager.Windows;

namespace EisenhowerTaskManager.Controls
{
    /// <summary>
    ///     Interaction logic for TaskListControl.xaml
    /// </summary>
    public partial class TaskListControl : UserControl
    {
        string _boxTitle;

        public TaskListControl()
        {
            InitializeComponent();
        }

        public string BoxTitle
        {
            get => _boxTitle;
            set
            {
                _boxTitle = value;
                BoxTitleLabel.Content = _boxTitle;
            }
        }

        void NewTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            var newTask = new EmTask
            {
                TaskName = "",
                Description = "",
                DueDate = DateTime.Now.AddDays(7),
                EisenhowerType = EisenhowerType.A
            };

            var ownerWindow = Window.GetWindow(this) as MainWindow;

            new TaskWindow(newTask, ownerWindow).ShowDialog();
        }
    }
}