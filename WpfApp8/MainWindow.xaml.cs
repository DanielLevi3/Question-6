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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
    public partial class MainWindow : Window
    {

        public const int NONE = 0;
        public const int CORRECT = 1; // green
        public const int WRONG = 2; // red

      
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int LoginStatus
        {
            get => (int)GetValue(dependencyProperty);
            set => SetValue(dependencyProperty, value);
        }

        public static readonly DependencyProperty dependencyProperty =
           DependencyProperty.Register("LoginStatus", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clicked!");
        }

        private void log1_Click(object sender, RoutedEventArgs e)
        {
            if(Password=="9999"&&UserName=="admin")
            {
                LoginStatus = 1;
            }
            else
            {
                LoginStatus = 2;
            }
            MessageBox.Show("clicked!");
        }
    }
   
     
}
