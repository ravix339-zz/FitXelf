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
using System.Diagnostics;
using System.Windows.Threading;

namespace FitXelf
{
    public partial class Exercise : PhoneApplicationPage
    {
        public Exercise()
        {
            InitializeComponent();
        }
        public int y = 0;
        public Stopwatch x = new Stopwatch();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string yolo = "0123456789";
            textBlock2.Text = Convert.ToString(yolo.IndexOf(Convert.ToString(2))); //find index and display it.
            if (y == 0)
            {
                x.Reset();
                x.Start();
                y += 1;
            }
            else
            {
                x.Stop();
                displaytime();
                y = 0;
            }
        }
        private void displaytime()
        {
            TimeSpan ts = x.Elapsed;
            string yo = String.Format("{0:00}:{1:00}.{2:00}",ts.Minutes, ts.Seconds, ts.Milliseconds/10);
            textBlock1.Text = yo;
        }

    }
}