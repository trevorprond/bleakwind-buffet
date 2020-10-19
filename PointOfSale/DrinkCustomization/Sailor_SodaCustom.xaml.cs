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
 * Class name: Sailor_Soda.xaml.cs
 * Purpose: To allow ordering and customization of the item Sailor soda
 */
namespace PointOfSale.DrinkCustomization
{
    /// <summary>
    /// Interaction logic for Sailor_Soda.xaml
    /// </summary>
    public partial class Sailor_SodaCustom : UserControl
    {
        MainWindow ancestor;
        /// <summary>
        /// initializes sailor soda page
        /// </summary>
        public Sailor_SodaCustom(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        //MainWindow window = (MainWindow)Application.Current.MainWindow;
        /// <summary>
        /// navigates to the welcome page
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BacktoBeginning(object sender, RoutedEventArgs e)
        {
           // this.NavigationService.Navigate(new WelcomePage());
            //window.DisplayCurrentOrder();
        }
    }
}
