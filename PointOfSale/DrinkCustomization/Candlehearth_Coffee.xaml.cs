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
 * Class name: Candhearth_Coffee.xaml.cs
 * Purpose: To allow ordering and customization of the item Candleheart coffee
 */
namespace PointOfSale.DrinkCustomization
{
    /// <summary>
    /// Interaction logic for Candlehearth_Coffee.xaml
    /// </summary>
    public partial class Candlehearth_Coffee : UserControl
    {
        MainWindow ancestor;
        public Candlehearth_Coffee(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        MainWindow window = (MainWindow)Application.Current.MainWindow;
        /// <summary>
        /// navigates to the welcome page
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BacktoBegin(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new WelcomePage());
            window.DisplayCurrentOrder();
        }
    }
}
