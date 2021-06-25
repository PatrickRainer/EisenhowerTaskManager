using System.Windows;
using System.Windows.Controls;
using EisenhowerTaskManager.Models;
using EisenhowerTaskManager.Windows;

namespace EisenhowerTaskManager.Controls
{
    /// <summary>
    ///     Interaction logic for TaskControl.xaml
    /// </summary>
    public partial class TaskControl : UserControl
    {
        public static readonly DependencyProperty EmTaskProperty = DependencyProperty.Register(
            nameof(EmTask), typeof(EmTask), typeof(TaskControl),
            new PropertyMetadata(default(EmTask), EmTaskPropertyChangedCallback));

        public TaskControl()
        {
            InitializeComponent();
        }

        public EmTask EmTask
        {
            get => (EmTask) GetValue(EmTaskProperty);
            set => SetValue(EmTaskProperty, value);
        }

        static void EmTaskPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as TaskControl;
            var task = e.NewValue as EmTask;
            if (control == null) return;

            control.TaskNameTextBlock.Text = task?.TaskName;
            control.DescriptionTextBlock.Text = task?.Description;
        }

        void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            var ownerWindow = Window.GetWindow(this) as MainWindow;
            var window = new TaskWindow(EmTask, ownerWindow);
            window.ShowDialog();
        }
    }
}