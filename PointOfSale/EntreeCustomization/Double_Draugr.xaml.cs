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
 * Class name: Double_Draugr.xaml.cs
 * Purpose: To allow ordering and customization of the item Double Draugr
 */
namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for Double_Draugr.xaml
    /// </summary>
    public partial class Double_Draugr : Page
    {
        /// <summary>
        /// initializes the double draugr page
        /// </summary>
        public Double_Draugr()
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
