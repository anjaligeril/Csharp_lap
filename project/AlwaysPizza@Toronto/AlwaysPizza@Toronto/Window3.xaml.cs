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
using System.Windows.Shapes;

namespace AlwaysPizza_Toronto
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            sizePizza.Content = Window2.size;
            crestPizza.Content = Window2.crest;
            Console.WriteLine("window3"+Window2.toppingDetails);
           Console.WriteLine("window3"+Window2.addOnDetails);
            toppingPizza.Content = Window2.toppingDetails;
            addOnsPizza.Content = Window2.addOnDetails;
            int price = Window2.totalCost;
            totalPrice.Content = (price).ToString();
            float tax = (price * 13.00f) / 100;
            Console.WriteLine("price"+price);
            hst.Content = (tax).ToString();
            grandTotal.Content = (price + tax).ToString();
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeOrder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Hide();
        }
    }
}
