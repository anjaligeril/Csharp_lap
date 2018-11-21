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

namespace AlwaysPizza
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

        private void calculateBtn_Click(object sender, RoutedEventArgs e)
        {
            int totalCost=0;
            var size = "";
            var crest = "";
            if (smallSize.IsChecked == true) 
            {
                size = "Small";
                totalCost = totalCost + 7;
            }else if (mediumSize.IsChecked == true)
            {
                size = "Medium";
                totalCost = totalCost + 9;
            }else if (largeSize.IsChecked == true)
            {
                size = "Large";
                totalCost = totalCost + 12;
            }

            if (normalCrest.IsChecked == true)
            {
                crest = "Normal";
                                   
            }else if (thinCrest.IsChecked == true)
            {
                crest = "Thin";
            }else if (thickCrest.IsChecked == true)
            {
                crest = "Thick";
            }else if (panCrest.IsChecked == true)
            {
                crest = "Pan Fried";
                totalCost = totalCost + 2;
            }
            String[] topping= { };
            int i = 0;
            int toppingCount = 0;
            if (fetaTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Feta Cheese";
                i++;
            }
            if (cheddarTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Cheddar Cheese";
                i++;
            }
            if (paneerTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Paneer";
                i++;
            }
            if (blackOlivesTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Black Olives";
                i++;
            }
            if (greenOlivesTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Green Olives";
                i++;
            }
            if (dryChilliTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Dry Chiili Peppar";
                i++;
            }
            if (jalapenos.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Jalapenos";
                i++;
            }
            if (mushroomTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Mushrooms";
                i++;
            }
            if (pineappleTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Pineapple";
                i++;
            }
            if (spinachTopping.IsChecked == true)
            {
                toppingCount++;
                topping[i] = "Spinach";
                i++;
            }
           // if(zucchini)
            
        }
    }
}
