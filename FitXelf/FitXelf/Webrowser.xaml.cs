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
    public partial class Webrowser : PhoneApplicationPage
    {
        public Webrowser()
        {
            InitializeComponent();
            webBrowser1.Navigate(new Uri("http://www.team2rar.wix.com/fitxelf", UriKind.Absolute));
        }
    }
}