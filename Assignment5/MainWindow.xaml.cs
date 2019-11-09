using System;
using System.Collections.Generic;
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

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Multimedia> items = new List<Multimedia>();
            items.Add(new Multimedia() { _title = "Manche Ko Jeewan", _artist = "1974", _genre = "Rhythm and Blues", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia(){ _title = "Hollywoods Bleeding", _artist = "Post Malone", _genre = "R&B", _type = Multimedia.MediaType.DVD});
            items.Add(new Multimedia() { _title = "Maya Bisaune", _artist = "1974", _genre = "Instrumental", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Yo Jindagi", _artist = "1974", _genre = "Musical", _type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { _title = "SapanaKo", _artist = "1974", _genre = "Jazz", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Jiuna Deu", _artist = "1974", _genre = "Blues", _type = Multimedia.MediaType.DVD });
            items.Add(new Multimedia() { _title = "SaaniKo", _artist = "1974", _genre = "Rhythm", _type = Multimedia.MediaType.CD });
            items.Add(new Multimedia() { _title = "Goodbye", _artist = "Post Malone", _genre = "Rap", _type = Multimedia.MediaType.DVD });


            listsB.ItemsSource = items;

        }
    }
}
