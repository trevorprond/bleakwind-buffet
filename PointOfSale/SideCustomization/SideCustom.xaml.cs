using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Author: Trevor Prondzinski
 * Class name: sidecustom.xaml.cs
 * Purpose: To allow ordering and customization of the sides
 */
namespace PointOfSale.SideCustomization
{
    /// <summary>
    /// Interaction logic for SideCustom.xaml
    /// </summary>
    public partial class SideCustom : Page
    {
        public SideCustom()
        {
            InitializeComponent();
        }

        private void BacktoBegin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WelcomePage());
        }
    }
}
