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

            int year;
            int myRating;

            if (string.IsNullOrWhiteSpace(textTitle.Text) || string.IsNullOrWhiteSpace(textArtist.Text) || string.IsNullOrWhiteSpace(textAlbum.Text) || string.IsNullOrWhiteSpace(textYear.Text) || string.IsNullOrWhiteSpace(textMyRating.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                year = Convert.ToInt32(textYear.Text);
                myRating = Convert.ToInt32(textMyRating.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Year and Rating must be numbers.");
                return;
            }

            Music music = new Music(textTitle.Text, textArtist.Text, textAlbum.Text, year, myRating);
            all_Music.Add(music);
            this.Close();
                
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
