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
            items.Add(new Multimedia() { _title = "Manche Ko Jeewan", _artist = "1974", _genre = "Rhythm and Blues", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia(){ _title = "Hollywoods Bleeding", _artist = "Post Malone", _genre = "R&B", _type = Multimedia.MediaType.DVD});
            items.Add(new Multimedia() { _title = "Maya Bisaune", _artist = "1974", _genre = "Instrumental", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Old Town Road", _artist = "Lil Nas X ft. Bill", _genre = "Musical", _type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { _title = "Looking for America", _artist = "Lana Del Rey", _genre = "Jazz", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Jiuna Deu", _artist = "1974", _genre = "Blues", _type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { _title = "I Can't Get Enough", _artist = "Benny, Selena Gomex", _genre = "Pop", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Goodbye", _artist = "Post Malone", _genre = "Rap", _type = Multimedia.MediaType.DVD });

            listsB.ItemsSource = items;
            //updateUI();
        }

        private void ListsB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = listsB.SelectedIndex;
            MessageBox.Show("Title : " + items[index]._title + "\n" 
                + "Artist : " + items[index]._artist + "\n" 
                + "Genre : " + items[index]._genre + "\n" 
                + "MediaType : " + items[index]._type);
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            var ny = new AddNewTitle();
            ny.ShowDialog();
        }
    }
}
