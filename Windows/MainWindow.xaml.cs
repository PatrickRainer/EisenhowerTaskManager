using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using EisenhowerTaskManager.Models;

namespace EisenhowerTaskManager.Windows
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EmTasks = new ObservableCollection<EmTask>(CreateSampleTasks());
            RefreshBindings();

            EmTasks.CollectionChanged += (sender, args) => RefreshBindings();
        }

        public ObservableCollection<EmTask> EmTasks { get; set; }
        public ObservableCollection<EmTask> ATasks { get; set; }
        public ObservableCollection<EmTask> BTasks { get; set; }
        public ObservableCollection<EmTask> DTasks { get; set; }
        public ObservableCollection<EmTask> CTasks { get; set; }

        internal void RefreshBindings()
        {
            ATasks = GetTaskCollection(EisenhowerType.A);
            BTasks = GetTaskCollection(EisenhowerType.B);
            CTasks = GetTaskCollection(EisenhowerType.C);
            DTasks = GetTaskCollection(EisenhowerType.D);

            ABoxTaskList.BoxListView.ItemsSource = ATasks;
            BBoxTaskList.BoxListView.ItemsSource = BTasks;
            CBoxTaskList.BoxListView.ItemsSource = CTasks;
            DBoxTaskList.BoxListView.ItemsSource = DTasks;
        }

        ObservableCollection<EmTask> GetTaskCollection(EisenhowerType eisenhowerType, bool excludeFinishedTasks = true)
        {
            var value = new ObservableCollection<EmTask>(EmTasks.Where(x => x.EisenhowerType == eisenhowerType));

            if (excludeFinishedTasks)
            {
                value = new ObservableCollection<EmTask>(value.Where(x => x.Status != EmTaskStatus.Done));
            }

            return value;
        }

        List<EmTask> CreateSampleTasks()
        {
            var rnd = new Random();
            var task1 = new EmTask
            {
                Id = 1,
                TaskName = "Task 1",
                Description = "Description of Task 1",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task2 = new EmTask
            {
                Id = 2,
                TaskName = "Task 2",
                Description = "Description of Task 2",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task3 = new EmTask
            {
                Id = 3,
                TaskName = "Task 3",
                Description = "Description of Task 3",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task4 = new EmTask
            {
                Id = 4,
                TaskName = "Task 4",
                Description = "Description of Task 4",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task5 = new EmTask
            {
                Id = 5,
                TaskName = "Task 5",
                Description = "Description of Task 5",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task6 = new EmTask
            {
                Id = 6,
                TaskName = "Task 6",
                Description = "Description of Task 6",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task7 = new EmTask
            {
                Id = 7,
                TaskName = "Task 7",
                Description = "Description of Task 7",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };


            var value = new List<EmTask> {task1, task2, task3, task4, task5, task6, task7};

            return value;
        }
    }
}