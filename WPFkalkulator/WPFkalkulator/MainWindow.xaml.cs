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
using System.Diagnostics;

namespace WPFkalkulator
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += button.Content;
            }



        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            List<double> Holare = new List<double>();
            List<char> symbol = new List<char>();

            if (e.Source is Button button)
            {
                
                string num = "";
                numerblock.Text.ToCharArray();
                
                

                foreach (var kunter in numerblock.Text)
                {

                    if (kunter != '+' && kunter != '-' && kunter != '*' && kunter != '/')
                    {

                        num += kunter;
                    }
                    else
                    {
                        Holare.Add(Convert.ToDouble(num));

                        symbol.Add(kunter);

                        num = "";

                        continue;                        
                    }
                }

                Holare.Add(Convert.ToDouble(num));

                int indexS = 0;
                    int indexH = 0;
                    double sum = 0;

                    sum = Holare[indexH];
                    symbol.Add('C');

                    bool condition = true;

                    while (condition)
                    {
                        indexH++;

                        char caseSwitch = symbol[indexS];

                        if (symbol[indexS] ==  'C')
                        {
                            break;
                        }

                        switch (caseSwitch)
                        {
                            case '+':

                                sum += Holare[indexH];

                                break;

                            case '-':

                                sum -= Holare[indexH];

                                break;

                            case '/':

                                sum /= Holare[indexH];

                                break;

                            case '*':

                                sum *= Holare[indexH];

                                break;


                            default:

                                Console.WriteLine("Default case");

                                break;
                        }
                    indexS++;
                    

                    }

                    numerblock.Text = sum.ToString();

                

            }
        }
    }
}
