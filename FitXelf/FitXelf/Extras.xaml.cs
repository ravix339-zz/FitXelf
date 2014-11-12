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
using Microsoft.Phone.Tasks;

namespace FitXelf
{
    public partial class Extras : PhoneApplicationPage
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void website_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Webrowser.xaml", UriKind.Relative));
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://team2rar.wix.com/fitxelf", UriKind.Absolute);

            webBrowserTask.Show();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }
    }
}