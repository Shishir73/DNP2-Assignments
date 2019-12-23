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
            MainWindow.items.Add(new Multimedia()
            {
                Title = textBox_title.Text,
                Artist = textBox_artist.Text,
                Genre = textBox_genre.Text,
                Type = (Multimedia.MediaType)comboBox.SelectedValue
            });

            //mww.listsB.ItemsSource = MainWindow.items;
            //Application.Current.MainWindow

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
