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

namespace DopolZadanie2
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
                int a = n / 100;
                int b = (n / 10) % 10;
                int c = n % 10;
                string String = "";
                switch (a)
                {
                    case 1:
                        String += "сто";
                        break;
                    case 2:
                        String += "двести";
                        break;
                    case 3:
                        String += "триста";
                        break;
                    case 4:
                        String += "четырести";
                        break;
                    case 5:
                        String += "пятьсот";
                        break;
                    case 6:
                        String += "шестьсот";
                        break;
                    case 7:
                        String += "семьсот";
                        break;
                    case 8:
                        String += "восемьсот";
                        break;
                    case 9:
                        String += "девятьсот";
                        break;
                }
                switch (b)
                {
                    case 1:
                        switch (c)
                        {
                            case 0:
                                String += " десять";
                                return;
                            case 1:
                                String += " одиннадцать";
                                return;
                            case 2:
                                String += " двенадцать";
                                return;
                            case 3:
                                String += " тринадцать";
                                return;
                            case 4:
                                String += " четырнадцать";
                                return;
                            case 5:
                                String += " пятнадцать";
                                return;
                            case 6:
                                String += " шестнадцать";
                                return;
                            case 7:
                                String += " семнадцать";
                                return;
                            case 8:
                                String += " восемнадцать";
                                return;
                            case 9:
                                String += " девятнадцать";
                                return;
                        }
                        break;
                    case 2:
                        String += " двадцать";
                        break;
                    case 3:
                        String += " тридцать";
                        break;
                    case 4:
                        String += " сорок";
                        break;
                    case 5:
                        String += " пятьдесят";
                        break;
                    case 6:
                        String += " шестьдесят";
                        break;
                    case 7:
                        String += " семьдесят";
                        break;
                    case 8:
                        String += " восемдесят";
                        break;
                    case 9:
                        String += " девяносто";
                        break;
                }
                if (b != 1)
                {
                    switch (c)
                    {
                        case 1:
                            String += " один";
                            break;
                        case 2:
                            String += " два";
                            break;
                        case 3:
                            String += " три";
                            break;
                        case 4:
                            String += " четыре";
                            break;
                        case 5:
                            String += " пять";
                            break;
                        case 6:
                            String += " шесть";
                            break;
                        case 7:
                            String += " семь";
                            break;
                        case 8:
                            String += " восемь";
                            break;
                        case 9:
                            String += " девять";
                            break; ;
                    }
                }
                Otvet.Text = $"Ответ:\n {String}"; 
            }
            catch (FormatException)
            {
                Otvet.Text = ("Введены некорректные данные");
            }


        }
    }
}
