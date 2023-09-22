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
using System.Text.RegularExpressions;

namespace Formatter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtBox1.Text;
            string pattern = @"^[A-Za-z0-9_]+@+[\S]*\.\S\D{1,4}$";
            Regex regularExpression = new Regex(pattern);

            string emailCheckMessage = regularExpression.IsMatch(email) ? "Email is correct" : "Incorrect email";
            MessageBox.Show(emailCheckMessage);

        }
    }
}
