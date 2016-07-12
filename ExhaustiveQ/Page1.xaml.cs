using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ExhaustiveQ
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       

        public void GettingDataFromPage1(object sender, RoutedEventArgs e)
        {
            
        
        }

        private void categorybackbttn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void lifebttn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Plife.xaml", UriKind.Relative));
            

        }

        private void inspire_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PivotPage1.xaml", UriKind.Relative));
        }

        private void success_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Panoramasuccess2.xaml", UriKind.Relative));
        }

        private void motivation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pmotivational.xaml", UriKind.Relative));
        }

      

       
    }
}