using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ExhaustiveQ
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void category_Click_bttn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void Authors_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/stories.xaml", UriKind.Relative));


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/aboutpage.xaml", UriKind.Relative));
        }
    }
}