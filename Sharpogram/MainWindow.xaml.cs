﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sharpogram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    // Sharpogram 
    // Author (github.com/egor-st-dev)
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try {
                ///new RequestApiId().run();
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
            }
        }
    }
}
