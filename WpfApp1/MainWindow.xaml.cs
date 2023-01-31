﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Controls;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
  

        }
        private void lbox_NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lbox_NavMenu_SelectedItem as NavButton;
            frame_PageFrame.Navigate(selected?.NavLink);
        }
    }
}