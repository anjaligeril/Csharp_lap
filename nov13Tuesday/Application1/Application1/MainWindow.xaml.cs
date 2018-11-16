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

namespace Application1
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
            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(num1.Text);
            secondNumber = Convert.ToInt32(num2.Text);
            int sum = firstNumber + secondNumber;
            result.Text = sum.ToString();

        }

        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
