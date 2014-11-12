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
using System.Text;
namespace FitXelf
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        { 
            InitializeComponent();
       }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        }

        private void profiles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile1.xaml", UriKind.Relative));
        }

        private void workouts_Click(object sender, RoutedEventArgs e)
        {
            System.IO.IsolatedStorage.IsolatedStorageFile local =
                System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
            if(local.FileExists("\\DataFile2.txt"))
                NavigationService.Navigate(new Uri("/Workout.xaml", UriKind.Relative));
            else
                MessageBox.Show("Please select a profile");
        }

        private void trainer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coming soon!");
            //NavigationService.Navigate(new Uri("/Trainer.xaml", UriKind.Relative));
        }

        private void extra_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/Extras.xaml", UriKind.Relative));
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }
    }
    public class Write
    {
        public string data;
        public bool exist;
        string filename;
        private Crypt cipher = new Crypt();
        public Write(string[] writematerial,string filename)
        {
            cipher.setData(writematerial);
            this.filename = filename;
        }
        public Write(string writematerial,string filename)
        {
            cipher.setData(writematerial);
            this.filename = filename;
        }
        public Write(string writematerial, bool en,string filename)
        {
            data = writematerial;
            exist = true;
            this.filename = filename;
        }
        public void writer()
        {
            if (!exist) 
            {
                cipher.encrypt();
                data = cipher.getCodedData();
            }
            // Get the local folder.
            System.IO.IsolatedStorage.IsolatedStorageFile local =
                System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
            // Create a new file named DataFile.txt.
            using (var isoFileStream =
                    new System.IO.IsolatedStorage.IsolatedStorageFileStream(
                        filename+".txt",
                        System.IO.FileMode.OpenOrCreate,
                            local))
            {
                using (var isoFileWriter = new System.IO.StreamWriter(isoFileStream))
                {
                    isoFileWriter.WriteLine(data);
                }
            }
        }
    }

    public class Read
    {
        string filename;
        public Read(string filename)
        {
            this.filename = filename; 
        }
        public string reader()
        {
            System.IO.IsolatedStorage.IsolatedStorageFile local =
            System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();

            // Specify the file path and options.
            using (var isoFileStream =
                    new System.IO.IsolatedStorage.IsolatedStorageFileStream
                        (filename+".txt", System.IO.FileMode.Open, local))
            {
                // Read the data.
                using (var isoFileReader = new System.IO.StreamReader(isoFileStream))
                {
                    String text = "";
                    while (isoFileReader.Peek() >= 0)
                    {
                        text += isoFileReader.ReadLine();
                    }
                    Crypt de = new Crypt();
                    de.setData(text);
                    de.decrypt();
                    text = de.getCodedData();
                    return text;
                }
            }
        }
        public string nodreader()
        {
            System.IO.IsolatedStorage.IsolatedStorageFile local =
            System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();

            // Specify the file path and options.
            using (var isoFileStream =
                    new System.IO.IsolatedStorage.IsolatedStorageFileStream
                        ("DataFile.txt", System.IO.FileMode.Open, local))
            {
                // Read the data.
                using (var isoFileReader = new System.IO.StreamReader(isoFileStream))
                {
                    String text = "";
                    while (isoFileReader.Peek() >= 0)
                    {
                        text += isoFileReader.ReadLine();
                    }
                    return text;
                }
            }
        }
        public string filenames()
        {
            System.IO.IsolatedStorage.IsolatedStorageFile local =
            System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication();
            string[] files = local.GetFileNames();
            if (files.Length == 0)
                return "No files";
            StringBuilder builder = new StringBuilder();
            foreach (string value in files)
            {
                builder.Append(value + '\n');
            }
            return builder.ToString();
        }
    }
    public class Crypt
    {
        string initialData, codedData;
        string key = "5wXFN12AoCmDoNCZJ3ryJ1bfDZMjbCzfOCWGIQgKZ8W1EksvWjWzArW2nwyi";

        public void setData(string[] d)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string word in d)
                builder.Append(word);

            initialData = builder.ToString();
        }

        public void setData(string d)
        {
            initialData = d;
        }

        public string getCodedData()
        {
            return codedData;
        }

        public void xorString()
        {
            StringBuilder builder = new StringBuilder();

            int i = 0;

            foreach (char x in initialData)
            {
                builder.Append((char)(x ^ key[i]));
                if (i < key.Length - 1)
                    ++i;
                else
                    i = 0;
            }

            codedData = builder.ToString();

        }

        public void encrypt()
        {
            xorString();

            StringBuilder builder = new StringBuilder();

            foreach (char a in codedData)
                builder.Append((char)(a + 37));

            codedData = builder.ToString();
        }

        public void decrypt()
        {
            StringBuilder builder = new StringBuilder();

            foreach (char a in initialData)
                builder.Append((char)(a - 37));

            initialData = builder.ToString();

            xorString();

        }
    }
    class Algor
    {
        private string[] allw = new string[10];
        private int[] answer = new int[10];
        private string name;
        private int weight;
        private int height;
        private int age;
        private int healthnum;
        private string rep;
        private string w1;
        private string w2;
        private string w3;
        private string w4;
        private string w5;
        private string w6;
        private string w7;
        private string w8;
        private string w9;
        private string w10;

        public Algor(string n, int w, int h, int a, int[] ar)
        {
            name = n;
            weight = w ;
            height = h;
            age = a;
            for (int i = 0; i < 10; ++i)
            {
                answer[i] = ar[i];
            }
        }
        public string[] createWorkout()
        {
            if (answer[0] == 0)
            {
                w1 = "Step Ups";
                rep = "10 reps";
            }
            else if (answer[0] == 1)
            {
                w1 = "Jumping Jacks";
                rep = "15 reps";
            }
            else if (answer[0] == 2)
            {
                rep = "15 reps";
                w1 = "Lunges";
            }
            else
            {
                rep = "20 reps";
                w1 = "Jumping Jacks"; //Question 1 
            }
            if (answer[1] == 0)
                w2 = "Squat Thrust";
            else if (answer[1] == 1)
                w2 = "Push Ups";
            else if (answer[1] == 2)
                w2 = "Mountain Climbers";
            else
                w2 = "Jumping Squat"; //Question 2

            if (answer[2] == 0)
                w3 = "Jog";
            else if (answer[2] == 1)
                w3 = "Sit Ups";
            else if (answer[2] == 2)
                w3 = "Leg Lifts";
            else
                w3 = "Plank"; // Question 3

            if (answer[3] == 0)
                w4 = "Marching";
            else if (answer[3] == 1)
                w4 = "Dips";
            else if (answer[3] == 2)
                w4 = "In and Outs";
            else
                w4 = "Bicycle Sit Ups"; // Question 4

            if (answer[4] == 0)
                w5 = "High Knees";
            else if (answer[4] == 1)
                w5 = "Wall Sit";
            else if (answer[4] == 2)
                w5 = "High Jumps";
            else
                w5 = "Arm Circles"; //Question 5;

            if (answer[5] == 0)
                w6 = "Knee To Chest";
            else if (answer[5] == 1)
                w6 = "Crunches";
            else if (answer[5] == 2)
                w6 = "Siscor Kick";
            else
                w6 = "Side Bridge"; //Question 6;

            if (answer[6] == 0)
                w7 = "Lift Weights/Machine";
            else if (answer[6] == 1)
                w7 = "Run Treadmill/Machine";
            else if (answer[6] == 2)
                w7 = "Run Treadmill & Lift Weights";
            else
                w7 = "Squats"; //Question 7

            if (answer[7] == 0)
                w8 = "Blurpies";
            else if (answer[7] == 1)
                w8 = "Tuck Jump";
            else if (answer[7] == 2)
                w8 = "Blurpies";
            else
                w8 = "Tuck Jump"; //Question 8


            if (answer[8] == 0)
                w9 = "Box Jump";
            else if (answer[8] == 1)
                w9 = "Shoulder Circle";
            else if (answer[8] == 2)
                w9 = "Box Jump";
            else
                w9 = "Shoulder Circle"; //Question 9

            if (answer[9] == 0)
                w10 = "Handstand Pushup";
            else if (answer[9] == 1)
                w10 = "Cross-Over Reverse Lunge";
            else if (answer[9] == 2)
                w10 = "Handstand Pushup";
            else
                w10 = "Cross-Over Reverse Lunge"; //Question 10

            allw[0] = w1  + "|";
            allw[1] = w2  + "|";
            allw[2] = w3  + "|";
            allw[3] = w4  + "|";
            allw[4] = w5  + "|";
            allw[5] = w6  + "|";
            allw[6] = w7  + "|";
            allw[7] = w8  + "|";
            allw[8] = w9  + "|";
            allw[9] = w10 + "|";

            return allw;
        }

        public string getName()
        {
            return name;
        }

        public string getReps()
        {
            return rep+"|";
        }

        public int createHealthNum()
        {
            healthnum = age + height + weight;
            return healthnum;
        }
    }
}