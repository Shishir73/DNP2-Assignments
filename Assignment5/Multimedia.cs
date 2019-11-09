using System.ComponentModel;

namespace Assignment5
{
    public class Multimedia : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public enum MediaType { CD, DVD };

        public string _title { get; set; }
        public string _artist { get; set; }
        public string _genre { get; set; }
        public MediaType _type { get; set; }

        //public Multimedia() { }

        //public Multimedia(string _title, string _artist, string _genre, MediaType _type)
        //{
        //    this._title = _title;
        //    this._artist = _artist;
        //    this._genre = _genre;
        //    this._type = _type;
        //}




    }
}
