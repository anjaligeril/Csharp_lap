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

namespace Calculator
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(num1.Text);
            int secondNumber = Convert.ToInt32(num2.Text);
            int sum = firstNumber + secondNumber;
            result.Content = sum.ToString();
        }

        private void subButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(num1.Text);
            int secondNumber = Convert.ToInt32(num2.Text);
            int sub = firstNumber - secondNumber;
            result.Content = sub.ToString();
        }

        private void mulButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(num1.Text);
            int secondNumber = Convert.ToInt32(num2.Text);
            int mul = firstNumber * secondNumber;
            result.Content = mul.ToString();
        }

        private void divButton_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(num1.Text);
            double secondNumber = Convert.ToInt32(num2.Text);
            double div = firstNumber / secondNumber;
            Console.WriteLine(div);
            result.Content = div.ToString();
        }
    }
}
