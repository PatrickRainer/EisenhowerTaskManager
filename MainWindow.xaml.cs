using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EisenhowerTaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<EmTask> EmTasks { get; set; }
        public ObservableCollection<EmTask> ATasks { get; set; }
        public ObservableCollection<EmTask> BTasks { get; set; }
        public ObservableCollection<EmTask> DTasks { get; set; }
        public ObservableCollection<EmTask> CTasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            EmTasks = new ObservableCollection<EmTask>(CreateSampleTasks());
            ATasks = new ObservableCollection<EmTask>(EmTasks.Where(x => x.EisenhowerType == EisenhowerType.A));
            BTasks = new ObservableCollection<EmTask>(EmTasks.Where(x => x.EisenhowerType == EisenhowerType.B));
            CTasks = new ObservableCollection<EmTask>(EmTasks.Where(x => x.EisenhowerType == EisenhowerType.C));
            DTasks = new ObservableCollection<EmTask>(EmTasks.Where(x => x.EisenhowerType == EisenhowerType.D));
            ABoxListView.ItemsSource = ATasks;
            BBoxListView.ItemsSource = BTasks;
            CBoxListView.ItemsSource = CTasks;
            DBoxListView.ItemsSource = DTasks;
        }

        List<EmTask> CreateSampleTasks()
        {
            var rnd = new Random();
            var task1 = new EmTask()
            {
                Id = 1,
                TaskName = "Task 1",
                Description = "Description of Task 1",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task2 = new EmTask()
            {
                Id = 2,
                TaskName = "Task 2",
                Description = "Description of Task 2",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task3 = new EmTask()
            {
                Id = 3,
                TaskName = "Task 3",
                Description = "Description of Task 3",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task4 = new EmTask()
            {
                Id = 4,
                TaskName = "Task 4",
                Description = "Description of Task 4",
                EisenhowerType = EisenhowerType.A,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task5 = new EmTask()
            {
                Id = 5,
                TaskName = "Task 5",
                Description = "Description of Task 5",
                EisenhowerType = EisenhowerType.B,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task6 = new EmTask()
            {
                Id = 6,
                TaskName = "Task 6",
                Description = "Description of Task 6",
                EisenhowerType = EisenhowerType.C,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };
            var task7 = new EmTask()
            {
                Id = 7,
                TaskName = "Task 7",
                Description = "Description of Task 7",
                EisenhowerType = EisenhowerType.D,
                DueDate = DateTime.Now.AddDays(rnd.Next(1, 100))
            };


            var value = new List<EmTask>() {task1, task2, task3, task4, task5, task6, task7};

            return value;
        }
    }

    public class EmTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public EisenhowerType EisenhowerType { get; set; }
        public DateTime DueDate { get; set; }
    }

    public enum EisenhowerType
    {
        A,
        B,
        C,
        D
    }
}