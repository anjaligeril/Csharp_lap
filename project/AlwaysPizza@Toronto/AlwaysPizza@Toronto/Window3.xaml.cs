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
            //Console.WriteLine(Window2.toppingDetails);
           // Console.WriteLine(Window2.addOnDetails);
            toppingPizza.Content = Window2.toppingDetails;
            addOnsPizza.Content = Window2.addOnDetails;
            int price = Window2.totalCost;
            totalPrice.Content = (price).ToString();
            double tax = (price * 13) / 100;
            hst.Content = (tax).ToString();
            grandTotal.Content = (price + tax).ToString();
        }
    }
}
