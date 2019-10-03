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
    }
}
