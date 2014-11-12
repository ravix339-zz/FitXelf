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
using System.IO.IsolatedStorage;

namespace FitXelf
{
    public partial class Profile1 : PhoneApplicationPage
    {
        public Profile1()
        {
            InitializeComponent();
        }
        public Read y = new Read("");
        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void choose_Click(object sender, RoutedEventArgs e)
        {

            System.IO.IsolatedStorage.IsolatedStorageFile local =
                System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
            if(y.filenames() == "No files")
                MessageBox.Show("Please create a profile!");
            else
                NavigationService.Navigate(new Uri("/ListofProfiles.xaml", UriKind.Relative));
        }
        private string[] converttostringarray()
        {
            string[] name = new string[3];
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
                name[j] = ".txt";
            return name;
        }
        private void questions_Click(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new Uri("/Questions.xaml", UriKind.Relative));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }
    }

}