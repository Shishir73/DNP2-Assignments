using System;
using System.Windows;

namespace Assignment5
{

    public partial class AddNewTitle : Window
    {
        MainWindow mww = new MainWindow();

        public AddNewTitle()
        {
            InitializeComponent();
            comboBox.ItemsSource = Enum.GetValues(typeof(Multimedia.MediaType));
        }

        private void Button_done_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.items.Add(new Multimedia() {
                _title = textBox_title.Text,
                _artist = textBox_artist.Text,
                _genre = textBox_genre.Text,
                _type = (Multimedia.MediaType) comboBox.SelectedValue
            });

            //mww.listsB.ItemsSource = MainWindow.items;

            updatedata();

        }

        private void updatedata()
        {
            textBox_title.Text = "";
            textBox_artist.Text = "";
            textBox_genre.Text = "";
            comboBox.Text = "";

        }
    }
}
