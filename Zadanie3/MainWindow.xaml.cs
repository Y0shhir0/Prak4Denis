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

namespace Zadanie3
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
            double a, R1 ,R2 , S;
     
            switch (d)
            {
                case 1:
                    a = m;
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 2:
                    R1 = m;
                    a = R1 * 4 / Math.Sqrt(3);
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 3:
                    R2 = m;
                    R1 = R2 / 2;
                    a = R1 * 4 / Math.Sqrt(3);
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                default:
                    S = m;
                    a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                    R1 = a * Math.Sqrt(3) / 4;
                    R2 = 2 * R1;
                    break;
            }

            Otvet.Text = $"a = {a:F2}, R1 = {R1:F2}, R2 = {R2:F2}, S = {S:F2}";

        }
         
    }
}

