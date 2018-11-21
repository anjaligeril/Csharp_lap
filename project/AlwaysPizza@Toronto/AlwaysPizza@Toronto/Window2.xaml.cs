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
using MySql.Data.MySqlClient;

namespace AlwaysPizza_Toronto
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public static int totalCost = 0;
        public int sizePrice = 0;
        int toppingCount = 0;
        public static string size = "";
        public static string toppingDetails = "";
        public static string addOnDetails = "";
        public static string crest = "";
        public Window2()
        {
            InitializeComponent();
            string name1 = MainWindow.name;
            welcomeNote.Content = "Welcome  " + name1.ToUpper()+" !!!";
            
        }
   
        private void checkOutBtn_Click(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
            this.Hide();
            Console.WriteLine(size + "\n" + crest);
            if (ft)
            {
                toppingDetails = toppingDetails + "fetaCheese,";

            }
            if (ct)
            {
                toppingDetails = toppingDetails + "cheddarCheese,";

            }
            if (gt)
            {
                toppingDetails = toppingDetails + "grilledChicken,";

            }
            if (bot)
            {
                toppingDetails = toppingDetails + "blackOlive,";

            }
            if (got)
            {
                toppingDetails = toppingDetails + "greenOlive,";
            }

                if (dct)
                {
                    toppingDetails = toppingDetails + "dryChilliPepper,";

                }
                if (jt)
                {
                    toppingDetails = toppingDetails + "jalapenos,";

                }
                if (mt)
                {
                    toppingDetails = toppingDetails + "mushrooms,";

                }
                if (pt)
                {
                    toppingDetails = toppingDetails + "pineapple,";

                }
                if (st)
                {
                    toppingDetails = toppingDetails + "spinach,";

                }
                if (zt)
                {
                    toppingDetails = toppingDetails + "zucchini.";

                }
                //Console.WriteLine(toppingDetails);
                if (cao)
                {
                    addOnDetails = addOnDetails + "Coke,";
                }
                if (rbao)
                {
                    addOnDetails = addOnDetails + "rootBeer,";
                }
                if (pwao)
                {
                addOnDetails = addOnDetails + "potatoWedges,";
            }
            if (gbao)
            {
                addOnDetails = addOnDetails + "garlicBread,";
            }
            if (hgao)
            {
                addOnDetails = addOnDetails + "honeyGarlic,";
            }
            if (bao)
            {
                addOnDetails = addOnDetails + "barbeque,";
            }
            if (cwao)
            {
                addOnDetails = addOnDetails + "chickenWings,";
            }
            if (pao)
            {
                addOnDetails = addOnDetails + "pesto,";
            }
            if (cpao)
            {
                addOnDetails = addOnDetails + "chickenPollini.";
            }
          //  Console.WriteLine(addOnDetails);


            //store in database

            string connectionString = "datasource=127.0.0.1;port=3308;username=root;password=;database=alwayspizza;";
            string query = "INSERT INTO orderdetails(`order_id`, `size`, `crest`, `topping`,`addons`,`total_price`) VALUES (NULL, '" + size + "', '" + crest + "', '" + toppingDetails + "','" + addOnDetails + "','" + totalCost + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("order succesfully placed..");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

        }
        

        private void smallSize_Checked(object sender, RoutedEventArgs e)
        {
           
            size = "Small";
            sizePrice = 5;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        private void mediumSize_Checked(object sender, RoutedEventArgs e)
        {
            
            size = "Medium";
            sizePrice=7;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        private void largeSize_Checked(object sender, RoutedEventArgs e)
        {
           
            size = "Large";
            sizePrice=10;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }


        
        public int crestPrice = 0;
        private void normalCrest_Checked(object sender, RoutedEventArgs e)
        {
            crest = "Normal";
        }

        private void thinCrest_Checked(object sender, RoutedEventArgs e)
        {
            crest = "Thin";
        }

        private void thickCrest_Checked(object sender, RoutedEventArgs e)
        {
            crest = "Thick";
        }


        private void panCrest_Checked(object sender, RoutedEventArgs e)
        {
            crest = "Pan Fried";
            crestPrice = 2;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        public int toppingPrice = 0;
        bool ft = false;
        private void fetaTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (fetaTopping.IsChecked == true)
            {
                ft = true;
                updateTotalWithTopping();
            }
            else
            {
                updateTotalRemoveTopping();
                ft = false;
            }
               
        }
        bool ct = false;
        private void cheddarTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (cheddarTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                ct = true;
            }

            else
            {
                updateTotalRemoveTopping();
                ct = false;
            }
                
        }
        bool gt = false;
        private void grilledTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (grilledTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                gt = true;
            }

            else
            {
                updateTotalRemoveTopping();
                gt = false;
            }
               
        }
        bool bot = false;
        private void blackOlivesTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (blackOlivesTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                bot = true;
            }

            else
            {
                updateTotalRemoveTopping();
                bot = true;
            }
                
        }

        bool got = false;
        private void greenOlivesTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (greenOlivesTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                got = true;
            }

            else
            {
                updateTotalRemoveTopping();
                got = true;
            }
               
        }

        bool dct = false;

        private void dryChilliTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (dryChilliTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                dct = true;
            }

            else
            {
                dct = false;
                updateTotalRemoveTopping();
            }
               
        }

        bool jt = false;
        private void jalapenos_Checked(object sender, RoutedEventArgs e)
        {
            if (jalapenos.IsChecked == true)
            {
                updateTotalWithTopping();
                jt = true;
            }

            else
            {
                updateTotalRemoveTopping();
                jt = false;
            }
                
        }

        bool mt = false;
        private void mushroomTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (mushroomTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                mt = true;
            }

            else
            {
                updateTotalRemoveTopping();
                mt = false;
            }
               
        }

        bool pt = false;
        private void pineappleTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (pineappleTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                pt = true;
            }

            else
            {
                updateTotalRemoveTopping();
                pt = false;
            }
               
        }

        bool st = false;

        private void spinachTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (spinachTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                st = true;
            }

            else
            {
                updateTotalRemoveTopping();
                st = false;
            }
                
        }

        bool zt = false;
        private void zucchiniTopping_Checked(object sender, RoutedEventArgs e)
        {
            if (zucchiniTopping.IsChecked == true)
            {
                updateTotalWithTopping();
                zt = true;
            }

            else
            {
                updateTotalRemoveTopping();
                zt = false;
            }
                
        }


        private void updateTotalWithTopping()
        {
            toppingCount++;
            if (toppingCount > 3)
            {
                int extra = toppingCount - 3;
                toppingPrice = extra;
            }else
            {
                toppingPrice = 0;
            }
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        private void updateTotalRemoveTopping()
        {
            toppingCount--;
            if (toppingCount > 3)
            {
                int extra = toppingCount - 3;
                toppingPrice = extra;
            }
            else
            {
                toppingPrice = 0;
            }
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        public int addOnprice=0;
        bool cao = false;
        private void cokeAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 2;
            if (cokeAddon.IsChecked == true)
            {
                cao = true;
                updateTotaladdAddOn(costItem);
            }else
            {
                cao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool rbao = false;
        private void rootBeerAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 2;
            if (rootBeerAddon.IsChecked == true)
            {
                rbao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                rbao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool pwao = false;
        private void potatoWedgesAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 4;
            if (potatoWedgesAddon.IsChecked == true)
            {
                pwao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                pwao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool gbao = false;
        private void garlicBreadAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 3;
            if (garlicBreadAddon.IsChecked == true)
            {
                gbao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                gbao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool hgao = false;
        private void honeygarlicAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 2;
            if (honeygarlicAddon.IsChecked == true)
            {
                hgao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                hgao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool bao = false;

        private void barbequeaddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 2;
            if (barbequeaddon.IsChecked == true)
            {
                bao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                bao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }
        bool cwao = false;
        private void chickenWingsAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 5;
            if (chickenWingsAddon.IsChecked == true)
            {
                cwao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                cwao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool pao = false;
        private void pestoAddon_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 2;
            if (pestoAddon.IsChecked == true)
            {
                pao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                pao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

        bool cpao=false;
        private void chickenPolliniAddOn_Checked(object sender, RoutedEventArgs e)
        {
            int costItem = 5;
            if (chickenPolliniAddOn.IsChecked == true)
            {
                cpao = true;
                updateTotaladdAddOn(costItem);
            }
            else
            {
                cpao = false;
                updateTotalRemoveAddOn(costItem);
            }
        }

       private void updateTotaladdAddOn(int cost)
        {
            addOnprice = addOnprice + cost;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }

        private void updateTotalRemoveAddOn(int cost)
        {
            addOnprice = addOnprice - cost;
            totalCost = sizePrice + crestPrice + toppingPrice + addOnprice;
            currentTotal.Content = totalCost;
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            smallSize.IsChecked = false;
            mediumSize.IsChecked = false;
            largeSize.IsChecked = false;
            normalCrest.IsChecked = false;
            thinCrest.IsChecked = false;
            thickCrest.IsChecked = false;
            panCrest.IsChecked = false;
            fetaTopping.IsChecked = false;
            cheddarTopping.IsChecked = false;
            grilledTopping.IsChecked = false;
            blackOlivesTopping.IsChecked = false;
            greenOlivesTopping.IsChecked = false;
            dryChilliTopping.IsChecked = false;
            jalapenos.IsChecked = false;
            mushroomTopping.IsChecked = false;
            pineappleTopping.IsChecked = false;
            spinachTopping.IsChecked = false;
            zucchiniTopping.IsChecked = false;
            cokeAddon.IsChecked = false;
            rootBeerAddon.IsChecked = false;
            potatoWedgesAddon.IsChecked = false;
            garlicBreadAddon.IsChecked = false;
            honeygarlicAddon.IsChecked = false;
            barbequeaddon.IsChecked = false;
            chickenWingsAddon.IsChecked = false;
            pestoAddon.IsChecked = false;
            chickenPolliniAddOn.IsChecked = false; 
        }
    }
}
