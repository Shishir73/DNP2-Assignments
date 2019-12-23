using System;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment7
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Random m_Random = new Random();

        public void HeavyWork()
        {
            //generate value betweeen 0 to 10
            double secondsToSleep = m_Random.NextDouble() * 10;

            //simulate important work
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }

        public Task HeavyWorkAsync()
        {
            //run HeavyWork asynchronously
            return Task.Run(() => HeavyWork());
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "Heavy Work has started at " + DateTime.Now.ToLongTimeString() + "! \n";

            Task delay = Task.Delay(8000);
            Task task1 = HeavyWorkAsync();
            Task task2 = HeavyWorkAsync();
            Task task3 = HeavyWorkAsync();
            Task allTasks = Task.WhenAll(task1, task2, task3);

            Task completed = await Task.WhenAny(allTasks, delay);

            if (allTasks != completed)
            {
                label.Content += "The tasks are still in progress \n";

                await Task.WhenAll(allTasks);
            }

            label.Content += "All Heavy Work has ended " + DateTime.Now.ToLongTimeString() + "!\n";
            label.Content += "\n";
        }
    }
}
