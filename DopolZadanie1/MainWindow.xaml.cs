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

namespace DopolZadanie1
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
            try
            {
                int n = Convert.ToInt32(Vvod.Text); 
                int b = (n / 10) % 10;
                int c = n % 10;
                string String = "";
                string s = "учебных заданий";
                string s1 = "учебных задания";
                string s2 = "учебное задание";
                switch (b)
                {
                    case 1:
                        switch (c) 
                        {
                            case 0:
                                String += " десять " + s;
                                break;
                            case 1:
                                String += " одиннадцать " + s;
                                break;
                            case 2:
                                String += " двенадцать " + s;
                                break;
                            case 3:
                                String += " тринадцать " + s;
                                break;
                            case 4:
                                String += " четырнадцать " + s;
                                break;
                            case 5:
                                String += " пятнадцать " + s;
                                break;
                            case 6:
                                String += " шестнадцать " + s;
                                break;
                            case 7:
                                String += " семнадцать " + s;
                                break;
                            case 8:
                                String += " восемнадцать " + s;
                                break;
                            case 9:
                                String += " девятнадцать " + s;
                                break;
                        }
                        break;
                    case 2:
                        String += " двадцать ";
                        break;
                    case 3:
                        String += " тридцать " ;
                        break;
                    case 4:
                        String += " сорок " ;
                        break;
                }
                if (b != 1)
                {
                    switch (c)
                    {
                        case 1:
                            String += " одно " + s2;
                            break;
                        case 2:
                            String += " два " + s1;
                            break;
                        case 3:
                            String += " три " + s1;
                            break;
                        case 4:
                            String += " четыре " + s1;
                            break;
                        case 5:
                            String += " пять " + s;
                            break;
                        case 6:
                            String += " шесть " + s;
                            break;
                        case 7:
                            String += " семь " + s;
                            break;
                        case 8:
                            String += " восемь " + s;
                            break;
                        case 9:
                            String += " девять " + s;
                            break; ;
                    }
                }
                Otvet.Text = $"Ответ:\n {String}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
