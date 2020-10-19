using BleakwindBuffet.Data;
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
    public partial class DrinkList : UserControl
    {


        public MainWindow ancestor;

        /* public List<IOrderItem> drinklist
        {
            get { return drinklist;  }
        }*/
        /// <summary>
        /// intitializes drinklist xaml
        /// </summary>
        public DrinkList(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            
        }
       

         MainWindow window = (MainWindow)Application.Current.MainWindow;

        public event EventHandler<CustomizationSelector> currentSelection;
        /// <summary>
        /// navigates to the sailor soda cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            var ss = new SailorSoda();


            Sailor_SodaCustom Soda = new Sailor_SodaCustom(ancestor);


           // this.NavigationService.Navigate(Soda);
            Soda.DataContext = ss;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ss });
            window.newOrder.Add(ss);
            ancestor.SwitchScreen(Screen.custSailor, ss);

        }

        /// <summary>
        /// navigates to the markarth milk cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilk();


            Markarth_Milk Milk = new Markarth_Milk(ancestor);


           // this.NavigationService.Navigate(Milk);
            Milk.DataContext = mm;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = mm });
            window.newOrder.Add(mm);
            ancestor.SwitchScreen(Screen.custMarkarth, mm);
        }

         
        /// <summary>
        /// navigates to the aretino apple juice cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            var Aj = new AretinoAppleJuice();


            AretinoApple_Juice AppleJuice = new AretinoApple_Juice(ancestor);

            
            //this.NavigationService.Navigate(AppleJuice);
            AppleJuice.DataContext = Aj;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = Aj });
            window.newOrder.Add(Aj);
            ancestor.SwitchScreen(Screen.custAretino, Aj);


        }

        /// <summary>
        /// navigates to the candlehearth coffee cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void CandlehearthCoffe_Click(object sender, RoutedEventArgs e)
        {
             var cc = new CandlehearthCoffee();


            Candlehearth_Coffee Coffee = new Candlehearth_Coffee(ancestor);

            
           // this.NavigationService.Navigate(Coffee);
            Coffee.DataContext = cc;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = cc });
            window.newOrder.Add(cc);
            ancestor.SwitchScreen(Screen.custCandlehearth, cc);
        }

        /// <summary>
        /// navigates to the warrior water cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void WarriorWater(object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWater();


            Warrior_Water Water = new Warrior_Water(ancestor);


            //this.NavigationService.Navigate(Water);
            Water.DataContext = ww;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ww });
            window.newOrder.Add(ww);
            ancestor.SwitchScreen(Screen.custWarrior, ww);
        }
    }
}
