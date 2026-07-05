using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace music_list
{
    /// <summary>
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Window
    {
        public ObservableCollection<Music> all_Music { get; set; }

        public add()
        {
            InitializeComponent();
        }

        private void Add_Music_Click(object sender, RoutedEventArgs e)
        {
            int year = Convert.ToInt32(textYear.Text);
            int myRating = Convert.ToInt32(textMyRating.Text);

            Music music = new Music(textTitle.Text, textArtist.Text, textAlbum.Text, year, myRating);
            all_Music.Add(music);
        }
    }
}
