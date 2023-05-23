using System;
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

namespace Zadanie2
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
            int d = Convert.ToInt32(Vvod.Text);
            int m = Convert.ToInt32(Vod.Text);
            if (d < 6 || d > 14 || m < 1 || m > 4)
            {
                Otvet.Text = "Некорректное значение достоинства или масти!";
                return;
            }

            string dName;
            switch (d)
            {
                case 6:
                    dName = "шестерка";
                    break;
                case 7:
                    dName = "семерка";
                    break;
                case 8:
                    dName = "восьмерка";
                    break;
                case 9:
                    dName = "девятка";
                    break;
                case 10:
                    dName = "десятка";
                    break;
                case 11:
                    dName = "валет";
                    break;
                case 12:
                    dName = "дама";
                    break;
                case 13:
                    dName = "король";
                    break;
                default: 
                    dName = "туз";
                    break;
            }

            string mName;
            switch (m)
            {
                case 1:
                    mName = "пик";
                    break;
                case 2:
                    mName = "треф";
                    break;
                case 3:
                    mName = "бубен";
                    break;
                default:
                    mName = "червей";
                    break;
            }

            Otvet.Text = $"{dName} {mName}";

        }

    }
}

