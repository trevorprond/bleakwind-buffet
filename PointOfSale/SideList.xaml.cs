using PointOfSale.SideCustomization;
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
 * Class name: SideList.xaml.cs
 * Purpose: To allow ordering and customization of the sides
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideList.xaml
    /// </summary>
    public partial class SideList : Page
    {
        /// <summary>
        /// initializes sidelist xaml
        /// </summary>
        public SideList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// navigates to the vokun salad cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SideCustom());
        }

        /// <summary>
        /// navigates to the fried miraak cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SideCustom());
        }

        /// <summary>
        /// navigates to the mad otar grits cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SideCustom());
        }

        /// <summary>
        /// navigates to the dragonborn waffle fries cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SideCustom());
        }
    }
}
