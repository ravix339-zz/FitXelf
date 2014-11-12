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
using System.Text;

namespace FitXelf
{
    
    public partial class Questions : PhoneApplicationPage
    {
        public Questions()
        {
            InitializeComponent();
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            textBlock1.Text = questions[0];
            button1.Content = lettera[0];
            button2.Content = letterb[0];
            button3.Content = letterc[0];
            button4.Content = letterd[0];
        }
        public Questions(int x)
        {
        }
        private string[] questions = { "How would you \ndescribe your fitness?", "Why do you want to \nwork out?", "What is your focus?", "What previous health/physical \nconditions do you have?", "How many times do you wish\nto work out per week?", "For how long do you want to \nwork out for?", "Do you have equipment?", "Have you ever worked \nout before?", "Do you go to your local gym?", "Would you like to challenge \nyourself with the exercises?" };
        private string[] lettera = { "Unfit", "Lose Weight", "Cardio", "Health Condition", "Once", "Less Than 30 Minutes", "Yes: Lifting Weights/Machine", "Yes", "Yes", "Yes" };
        private string[] letterb = { "Average", "Gain Muscle", "Upper Body", "Physical Injury", "Twice", "30 Minutes to 1 Hour", "Yes: Treadmill/Cardio Machine", "No", "No", "No" };
        private string[] letterc = { "Very Fit", "For Fun/Recreation", "Lower Body", "Health Condition and Physical Injury", "Three Times", "1 to 3 Hours", "All of the Above", "N/A", "N/A", "N/A" };
        private string[] letterd = { "Unsure", "Other", "General/Unsure", "No Previous Condition nor Injury", "Four Or More Times", "More Than 3 Hours", "None of the above", "N/A", "N/A", "N/A" };
        private int i = 0;
        public int[] responses = new int[10];


        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void storedata()
        {
            StringBuilder x = new StringBuilder();
            foreach (int y in responses)
            {
                x.Append(y.ToString() + ' ');
            }
            Write wr = new Write(x.ToString(),true,"DataFile");
            wr.writer();
        }
        private void choicea_Click(object sender, RoutedEventArgs e)
        {
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                responses[i] = 0;
                i++;
            }
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                textBlock1.Text = questions[i];
                button1.Content = lettera[i];
                button2.Content = letterb[i];
                button3.Content = letterc[i];
                button4.Content = letterd[i];
            }
            if (i == 7)
            {
                button3.IsEnabled = false;
                button4.IsEnabled = false;
            }
        }

        private void choiceb_Click(object sender, RoutedEventArgs e)
        {
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                responses[i] = 1;
                i++;
            }  
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml?parameter", UriKind.Relative));
                return;
            }
            else
            {
                textBlock1.Text = questions[i];
                button1.Content = lettera[i];
                button2.Content = letterb[i];
                button3.Content = letterc[i];
                button4.Content = letterd[i];
            }
            if (i == 7)
            {
                button3.IsEnabled = false;
                button4.IsEnabled = false;
            }
        }

        private void choicec_Click(object sender, RoutedEventArgs e)
        {
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                responses[i] = 2;
                i++;
            }
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                textBlock1.Text = questions[i];
                button1.Content = lettera[i];
                button2.Content = letterb[i];
                button3.Content = letterc[i];
                button4.Content = letterd[i];
            }
            if (i == 7)
            {
                button3.IsEnabled = false;
                button4.IsEnabled = false;
            }
        }
        private void choiced_Click(object sender, RoutedEventArgs e)
        {
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                responses[i] = 3;
                i++;
            }
            if (i >= 10)
            {
                storedata();
                NavigationService.Navigate(new Uri("/Questions2.xaml", UriKind.Relative));
                return;
            }
            else
            {
                textBlock1.Text = questions[i];
                button1.Content = lettera[i];
                button2.Content = letterb[i];
                button3.Content = letterc[i];
                button4.Content = letterd[i];
            }
            if (i == 7)
            {
                button3.IsEnabled = false;
                button4.IsEnabled = false;
            }
        }
    }
}