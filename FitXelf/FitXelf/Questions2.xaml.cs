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
    public partial class Questions2 : PhoneApplicationPage
    {
        public Questions2()
        {
            InitializeComponent();
        }
        public Read r = new Read("DataFile");
        private void submit_Click(object sender, RoutedEventArgs e)
        {

            if (isValid())
            {
                System.IO.IsolatedStorage.IsolatedStorageFile local =
                        System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
                int[] responses = new int[10];
                string x = r.nodreader();
                int j = 0;
                string[] y =x.Split(' ');
                foreach (string i in y)
                {
                    if (i != "")
                        responses[j] = Convert.ToInt32(i);
                    else ;
                    j++;
                }
                Algor workout = new Algor(textBox1.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox2.Text), responses);
                local.DeleteFile("\\DataFile.txt");
                string[] workouts = workout.createWorkout();
                string[] everything = { workout.getReps(),workouts[0], workouts[1], workouts[2], workouts[3], workouts[4], workouts[5], workouts[6], workouts[7], workouts[8], workouts[9] };
                Write wr = new Write(everything,workout.getName());
                wr.writer();
                MessageBox.Show("Profile Created!");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }
        private bool isValid()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter a name");
                return false;
            }
            foreach (char c in textBox1.Text)
            {
                if ((int)(c) > 122)
                {
                    MessageBox.Show("Name: Enter only letters");
                    return false;
                }
                else if ((int)(c) > 90 && (int)(c) < 97)
                {
                    MessageBox.Show("Name: Enter only letters");
                    return false;
                }
                else if ((int)(c) < 65)
                {
                    MessageBox.Show("Name: Enter only letters");
                    return false;
                }
            }
            int temp;
            if (int.TryParse(textBox2.Text, out temp))
            {
                if (temp <= 0)
                {
                    MessageBox.Show("Age: Enter a positive whole number!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Age: Enter a positive whole number!");
                return false;
            }
            if(int.TryParse(textBox3.Text, out temp))
            {
                if (temp <= 0)
                {
                    MessageBox.Show("Weight: Enter a positive whole number!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Weight: Enter a positive whole number!");
                return false;
            }
            if(int.TryParse(textBox4.Text, out temp))
            {
                if (temp <= 0)
                {
                    MessageBox.Show("Height: Enter a positive whole number!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Height: Enter a positive whole number!");
                return false;
            }
            return true;
        }
    }
}