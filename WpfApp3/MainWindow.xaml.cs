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

namespace WpfApp3
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
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {   //If fields are empty, tells user to enter number instead of crashing the program.
            if (string.IsNullOrWhiteSpace(txtNumberOne.Text) == true)
            {
                MessageBox.Show("Please Enter a Number");
                return; // this is important, return if true
            }
            if (string.IsNullOrWhiteSpace(txtNumberTwo.Text) == true)
            {
                MessageBox.Show("Please Enter a Number");
                return; // this is important, return if true
            }

            //converts text boxes to 32bit integer values.
            int numberone;
            numberone = Convert.ToInt32(txtNumberOne.Text);
            int numbertwo;
            numbertwo = Convert.ToInt32(txtNumberTwo.Text);

            


            //if number meets condition, return messagebox with message when button is pressed.
            if (numberone == numbertwo)
            {
                MessageBox.Show("The numbers are Equal");
                //lblAnswer.Content = "Numbers are equal";
            }
            if (numberone > numbertwo)
            {
                MessageBox.Show("Number one is greater than number two");
                //lblAnswer.Content = "Number one is bigger than number two";
            }
            if (numbertwo > numberone)
            {
                MessageBox.Show("Number two is greater than number one");
                //lblAnswer.Content = "Number two is bigger than number one";
            }
        }

        private void txtNumberOne_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNumberTwo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
