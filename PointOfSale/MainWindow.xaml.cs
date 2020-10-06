using BleakwindBuffet.Data;
using PointOfSale.SideCustomization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
 * Class name: MainWindow.xaml.cs
 * Purpose: To allow ordering and customization of the entire menu
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       DrinkList drinklists = new DrinkList();
        EntreeLists entreelists = new EntreeLists();
        SideList sidelist = new SideList();
        /// <summary>
        /// Declares the main window with homepage
        /// </summary>
        /// 
        public List<IOrderItem> finallist = new List<IOrderItem>();

      
        public MainWindow()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new WelcomePage());
            // drinklist.currentSelection += FoodButtonClick;
            //finallist.Add((IOrderItem)drinklists.drinklist);
            /*StringBuilder sb = new StringBuilder();
            for (int i = 0; i < finallist.Count; i++)
            {
               
                sb.Append(finallist[i]);
            }

            orderdetails.Text = sb.ToString();*/
        }

        public void FoodButtonClick(object sender, CustomizationSelector e)
        {
            //finallist.Add(e.orderItem);
            
        }

       
        /// <summary>
        /// Shows all the entrees available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Entrees_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new EntreeLists());
        }

        /// <summary>
        /// Shows all the entrees available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void EntreesClick(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new EntreeLists());
        }

        /// <summary>
        /// Shows all the drink buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new DrinkList());
        }

        /// <summary>
        /// Shows all the side buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new SideList());
        }

        
    }
}
