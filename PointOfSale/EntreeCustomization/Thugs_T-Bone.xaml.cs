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
 * Class name: Thugs_T-Bone.xaml.cs
 * Purpose: To allow ordering and customization of the item Thugs T-Bone
 */
namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for Thugs_T_Bone.xaml
    /// </summary>
    public partial class Thugs_T_Bone : Page
    {
        /// <summary>
        /// initializes the thugs t-bone page
        /// </summary>
        public Thugs_T_Bone()
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
