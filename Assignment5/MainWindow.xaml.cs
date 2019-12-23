using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int index;
        public static List<Multimedia> items;

        public MainWindow()
        {
            InitializeComponent();
            items = new List<Multimedia>();
            items.Add(new Multimedia() { Title = "Manche Ko Jeewan", Artist = "1974", Genre = "Rhythm and Blues", Type = Multimedia.MediaType.CD });
            items.Add(new Multimedia(){ Title = "Hollywoods Bleeding", Artist = "Post Malone", Genre = "R&B", Type = Multimedia.MediaType.DVD});
            items.Add(new Multimedia() { Title = "Maya Bisaune", Artist = "1974", Genre = "Instrumental", Type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { Title = "Old Town Road", Artist = "Lil Nas X ft. Bill", Genre = "Musical", Type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { Title = "Looking for America", Artist = "Lana Del Rey", Genre = "Jazz", Type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { Title = "Jiuna Deu", Artist = "1974", Genre = "Blues", Type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { Title = "I Can't Get Enough", Artist = "Benny, Selena Gomex", Genre = "Pop", Type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { Title = "Goodbye", Artist = "Post Malone", Genre = "Rap", Type = Multimedia.MediaType.DVD });

            listsB.ItemsSource = items;
            //DataContext = items;
        }

        private void ViewDetailsOFSongs(object sender, SelectionChangedEventArgs e)
        {
            index = listsB.SelectedIndex;
            MessageBox.Show("Title : " + items[index].Title + "\n" 
                + "Artist : " + items[index].Artist + "\n" 
                + "Genre : " + items[index].Genre + "\n" 
                + "MediaType : " + items[index].Type);
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            var ny = new AddNewTitle();
            ny.ShowDialog();
        }
    }
}
