using System;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        public Task HeavyWorkAsyn()
        {
            //run HeavyWork asynchronously
            return Task.Run(() => HeavyWork());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "Heavy Work has started at " + DateTime.Now.ToLongTimeString() + "! \n";

            Parallel.Invoke(
                            () =>
                            {
                                Console.WriteLine("TASK 1 STARTED!");
                                HeavyWork();
                                Console.WriteLine("TASK 1 DONE!");
                            },
                            () =>
                            {
                                Console.WriteLine("TASK 2 STARTED!");
                                HeavyWork();
                                Console.WriteLine("TASK 2 DONE!");
                            },
                            () =>
                            {
                                Console.WriteLine("TASK 3 STARTED!");
                                HeavyWork();
                                Console.WriteLine("TASK 3 DONE!");
                            }
                         );
            label.Content += "All Heavy Work has ended " + DateTime.Now.ToLongTimeString() + "!\n";

            //await HeavyWorkAsyn();


            label.Content += "\n";

        }

        #region PARALLEL EXECUTION
            //All the task start at the same time as they are been exected at parallelly. 
            //They end at different time because their is a random number of sleep for the heavywork().
            //Output can been seen in the output console.
        #endregion
    }
}
