using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace to_do_list
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }

        public Music(string title, string artist, string album, int year)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Year = year;
        }

    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Music> allMusic;

        public MainWindow()
        {
            InitializeComponent();

            allMusic = new ObservableCollection<Music>
            {
                new Music("No Surprises", "Radiohead", "OK Computer", 1997),
                new Music("Song 2", "Artist 2", "Album 2", 2021),
                new Music("Song 3", "Artist 3", "Album 3", 2022),
            };

            MusicListView.ItemsSource = allMusic;
        }

        

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}