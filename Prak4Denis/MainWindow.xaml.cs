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

namespace Prak4Denis
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
            if (d < 1 || d > 31 || m < 1 || m > 12)
            {
                Otvet.Text = "Некорректная дата!";
                return;
            }

            switch (d)
            {
                case 31:
                    switch (m)
                    {
                        case 12:
                            d = 1;
                            m = 1;
                            break;
                        default:
                            d = 1;
                            m++;
                            break;
                    }
                    break;
                case 29:
                    switch (m)  
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            d = 1;
                            m++;
                            break;
                        default:
                            d++;
                            break;
                    }
                    break;
                case 28:
                    switch (m)
                    {
                        case 2:
                            d = 1;
                            m++;
                            break;
                        default:
                            d++;
                            break;
                    }
                    break;
                default:
                    d++;
                    break;
            }
            Otvet.Text = $" Дней = {d} \n Месяц = {m}";
        }
    }
}
