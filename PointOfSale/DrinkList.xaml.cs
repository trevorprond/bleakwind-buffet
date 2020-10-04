using BleakwindBuffet.Data.Drinks;
using PointOfSale.DrinkCustomization;
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
 * Class name: drinklist.xaml.cs
 * Purpose: To allow ordering and customization of the drinks
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkList.xaml
    /// </summary>
    public partial class DrinkList : Page
    {
        /// <summary>
        /// intitializes drinklist xaml
        /// </summary>
        public DrinkList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// navigates to the sailor soda cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Sailor_Soda());
        }

        /// <summary>
        /// navigates to the markarth milk cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Markarth_Milk());
        }

        /// <summary>
        /// navigates to the aretino apple juice cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            var Aj = new AretinoAppleJuice();

            this.NavigationService.Navigate(new AretinoApple_Juice());

        }

        /// <summary>
        /// navigates to the candlehearth coffee cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void CandlehearthCoffe_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Candlehearth_Coffee());
        }

        /// <summary>
        /// navigates to the warrior water cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void WarriorWater(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Warrior_Water());
        }
    }
}
