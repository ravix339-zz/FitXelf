﻿#pragma checksum "C:\Users\Ravi Sinha\Documents\Visual Studio 2010\Projects\FitXelf\FitXelf\FitXelf\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B1953509245B0665CD743A522E731D9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FitXelf {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.Button profiles;
        
        internal System.Windows.Controls.Button workouts;
        
        internal System.Windows.Controls.Button trainer;
        
        internal System.Windows.Controls.Button extra;
        
        internal System.Windows.Controls.Button settings;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FitXelf;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.profiles = ((System.Windows.Controls.Button)(this.FindName("profiles")));
            this.workouts = ((System.Windows.Controls.Button)(this.FindName("workouts")));
            this.trainer = ((System.Windows.Controls.Button)(this.FindName("trainer")));
            this.extra = ((System.Windows.Controls.Button)(this.FindName("extra")));
            this.settings = ((System.Windows.Controls.Button)(this.FindName("settings")));
        }
    }
}
