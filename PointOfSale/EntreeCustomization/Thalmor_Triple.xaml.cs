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
 * Class name: Thalmor_Triple.xaml.cs
 * Purpose: To allow ordering and customization of the item Thalmor Triple
 */
namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for Thalmor_Triple.xaml
    /// </summary>
    public partial class Thalmor_Triple : Page
    {
        /// <summary>
        /// initializes thalmor triple page
        /// </summary>
        public Thalmor_Triple()
        {
            InitializeComponent();
        }

        /// <summary>
        /// navigates to the welcome page
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BacktoBeginning(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WelcomePage());
        }
    }
}
