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

namespace WPF_repitison
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
        
        private void Click_ok(object sender, RoutedEventArgs e)
        {
            if(e.Source is Button button)
            {
                if(textbock.Text == "Allt är helt okej")
                {
                    textbock.Text = button.Content; // problem vet inte varför

                }

                textbock.Text = "Allt är helt okej";

            }
            

        }
    }
}
