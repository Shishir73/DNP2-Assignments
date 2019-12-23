using System.ComponentModel;

namespace Assignment5
{
    public class Multimedia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public enum MediaType { CD, DVD };

        private string _title;
        private string _artist;
        private string _genre;
        private MediaType _type;

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChange("Title");
                }
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                if (_artist != value)
                {
                    _artist = value;
                    OnPropertyChange("Artist");
                }
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChange("Genre");
                }
            }
        }

        public MediaType Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChange("Type");
                }
            }
        }

        public void OnPropertyChange(string multimedia)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(multimedia));
            }
        }
    }
}
