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
    public partial class Workout : PhoneApplicationPage
    {
        private string[] everything;
        public Workout()
        {
            InitializeComponent();
            Read re = new Read("DataFile2");
            string filename = re.reader();
            Read data = new Read(filename);
            everything = data.reader().Split('|');
            button1.Content = everything[1];
            button2.Content = everything[2];
            button3.Content = everything[3];
            button4.Content = everything[4];
            button5.Content = everything[5];
            button6.Content = everything[6];
            button7.Content = everything[7];
            button8.Content = everything[8];
            button9.Content = everything[9];
            button10.Content = everything[10];

        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0]);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0]);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0]);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0]);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }

        private void image1_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(everything[0] );
        }


    }
}