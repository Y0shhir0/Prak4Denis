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

namespace Zadanie6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        private void Button_Click(object sender, RoutedEventArgs e)
        {

           
            int n = Convert.ToInt32(Vvod.Text);
          

            bool m = false;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit == 1)
                {
                    m = true;
                    break;
                }
                n = n / 10;
            }

            Otvet.Text = m ? "true" : "false";
        }
    }

}
