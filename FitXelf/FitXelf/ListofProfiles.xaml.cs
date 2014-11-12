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

namespace FitXelf
{
    public partial class ListofProfiles : PhoneApplicationPage
    {
        private string[] names = new string[3];
        public ListofProfiles()
        {
            InitializeComponent();
            System.IO.IsolatedStorage.IsolatedStorageFile local =
                        System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
            if (local.FileExists("\\DataFile2.txt"))
            {
                local.DeleteFile("\\DataFile2.txt");
                MessageBox.Show("Profile deselected!");
            }
            names = converttostringarray();
            button1.Content = names[0];
            button2.Content = names[1];
            button3.Content = names[2];

            if (button2.Content.ToString() == "")
                button2.IsEnabled = false;
            if (button3.Content.ToString() == "")
                button3.IsEnabled = false;

        }
        private string[] converttostringarray()
        {
            string[]name = new string[3];
            Read x = new Read("");
            string org = x.filenames();
            string temp = "";
            int i = 0;
            foreach (char c in org)
            {
                if (c != '\n')
                    temp += c;
                else
                {
                    name[i] = temp;
                    temp = "";
                    i++;
                }
            }
            for (int j = i; j < 3; j++)
                name[j] = "";
            return name;
        }
        private void profile1_Click(object sender, RoutedEventArgs e)
        {
            Read x = new Read(names[0].Remove(names[0].IndexOf('.'), 4));
            string data = x.reader();
            string[] workouts = data.Split('|');
            Write wr = new Write(names[0].Remove(names[0].IndexOf('.'), 4), "DataFile2");
            wr.writer();
        }

        private void profile2_Click(object sender, RoutedEventArgs e)
        {
            Read x = new Read(names[1].Remove(names[1].IndexOf('.'), 4));
            string data = x.reader();
            string[] workouts = data.Split('|');
            Write wr = new Write(names[1].Remove(names[1].IndexOf('.'), 4), "DataFile2");
            wr.writer();
        }

        private void profile3_Click(object sender, RoutedEventArgs e)
        {
            Read x = new Read(names[2].Remove(names[2].IndexOf('.'), 4));
            string data = x.reader();
            string[] workouts = data.Split('|');
            Write wr = new Write(names[2].Remove(names[2].IndexOf('.'), 4), "DataFile2");
            wr.writer();
        }
    }
}