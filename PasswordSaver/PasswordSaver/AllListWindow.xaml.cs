﻿using System;
using System.IO;
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
using System.Windows.Shapes;

namespace PasswordSaver
{
    /// <summary>
    /// Interaction logic for AllListWindow.xaml
    /// </summary>
    /// 
    public partial class AllListWindow : Window
    {
        public AllListWindow()
        {
            InitializeComponent();
        }

        private void AllList_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
            
        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
