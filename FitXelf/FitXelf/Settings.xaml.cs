using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace FitXelf
{
    public partial class Settings : PhoneApplicationPage
    {
        public Settings()
        {
            InitializeComponent();
        }
        public bool playing = false;
        private void songs_Click(object sender, RoutedEventArgs e)
        {
            ContentManager contentManager = (App.Current as App).Content;

            startmusic(contentManager);
        }
        private void startmusic(ContentManager x)
        {
            playing = !playing;
            if (playing)
            {
                Song sound = x.Load<Song>("Audio");
                MediaPlayer.Play(sound);
                MediaPlayer.IsRepeating = true;
                MessageBox.Show("Now playing:\nIron - Woodkid\nEdge of The Earth - Thirty Seconds to Mars");
            }
            else
            {
                MediaPlayer.Stop();
            }
        }

    }
}