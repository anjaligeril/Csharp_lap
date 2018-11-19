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
using MySql.Data.MySqlClient;
namespace app
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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string firstName = fName.Text;
            string lastName = lName.Text;
            string childAddress = address.Text;
            string phoneNo = phone.Text;
            var gender = "";
            var preference = "";
            if (maleBtn.IsChecked == true)
            {
                gender = "male";
            }
            if (femaleBtn.IsChecked == true)
            {
                gender = "female";
            }
            if (fullBtn.IsChecked == true)
            {
                preference = "full time";
            }
            if (partBtn.IsChecked == true)
            {
                preference = "part time";
            }
            Console.Write(firstName + lastName + childAddress + phoneNo + gender + preference);
            if (firstName != "" && lastName != "" && childAddress != "" && phoneNo != ""&&gender!="" && preference!="")
            {
                Console.Write(firstName + lastName + childAddress + phoneNo + gender + preference);
                if (phoneNo.Length != 10)
                {
                    MessageBox.Show("Please enter valid phone number");
                }
                else
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=childrenshappyplace;";
                    string query = "INSERT INTO student(`student_id`, `firstName`, `lastName`, `address`,`phone`,`gender`,`mode`) VALUES (NULL, '" + firstName + "', '" + lastName + "', '" + childAddress + "','" + phoneNo + "','" + gender + "','" + preference + "')";
                    // Which could be translated manually to :
                    // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();

                        MessageBox.Show("User succesfully registered");

                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            fName.Text = "";
            lName.Text = "";
            phone.Text = "";
            address.Text = "";
            maleBtn.IsChecked = false;
            femaleBtn.IsChecked = false;
            fullBtn.IsChecked = false;
            partBtn.IsChecked = false;
        }

        private void maleBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
            this.Hide();
        }
    }
}
