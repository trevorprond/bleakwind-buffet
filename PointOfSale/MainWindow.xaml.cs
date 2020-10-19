using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.DrinkCustomization;
using PointOfSale.EntreeCustomization;
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

        /// <summary>
        /// Declares the main window with homepage
        /// </summary>
        /// 

        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();




        public Order newOrder = new Order();

       

        public MainWindow()
        {
            InitializeComponent();
            // DisplayCurrentOrder();
            // frame.NavigationService.Navigate(new WelcomePage());
            DataContext = newOrder;


            // drinklist.currentSelection += FoodButtonClick;
            //finallist.Add((IOrderItem)drinklists.drinklist);
            /*StringBuilder sb = new StringBuilder();
            for (int i = 0; i < finallist.Count; i++)
            {
               
                sb.Append(finallist[i]);
            }

            orderdetails.Text = sb.ToString();*/

            DataContext = newOrder;
            descendant.Ancestor = this;
            screens.Add(Screen.welcomePage, descendant);
            // screens.Add(Screen.completeOrder, new CompleteOrder(this));
            screens.Add(Screen.custBriarheart, new Briarhear_Burgers(this));
            screens.Add(Screen.custDoubleDraugr, new Double_Draugr(this)); ;
            screens.Add(Screen.custGardenOrc, new GardenOrc_Omelette(this));
            screens.Add(Screen.custPhillyPoach, new Philly_Poacher(this));
            screens.Add(Screen.custSmokehouse, new Smokehouse_Skeleton(this));
            screens.Add(Screen.custThalmor, new Thalmor_Triple(this));
            screens.Add(Screen.custAretino, new AretinoApple_Juice(this));
            screens.Add(Screen.custCandlehearth, new Candlehearth_Coffee(this));
            screens.Add(Screen.custMarkarth, new Markarth_Milk(this));
            screens.Add(Screen.custSailor, new Sailor_SodaCustom(this));
            screens.Add(Screen.custWarrior, new Warrior_Water(this));
            screens.Add(Screen.custDragonborn, new DragonbornWaffleFriesCustom(this));
            screens.Add(Screen.custFried, new FriedMiraakCustom(this));
            screens.Add(Screen.custMad, new MadOtarGritsCustom(this));
            screens.Add(Screen.custVokun, new VokunSaladCustom(this));
            screens.Add(Screen.entreeList, new EntreeLists(this));
            screens.Add(Screen.drinkList, new DrinkList(this));
            screens.Add(Screen.sideList, new SideList(this));
            screens.Add(Screen.finishOrder, new FinishOrder(this, newOrder));
            screens.Add(Screen.cashRegistar, new CashRegister(this, newOrder));


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
            //frame.NavigationService.Navigate(new EntreeLists());
            // DisplayCurrentOrder();

            // descendant.SwitchScreen(Screen.entreeList);


        }

        /// <summary>
        /// Shows all the entrees available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void EntreesClick(object sender, RoutedEventArgs e)
        {
            //frame.NavigationService.Navigate(new EntreeLists());
            // DisplayCurrentOrder();
            // ancestor.SwitchScreen(Screen.entreeList);
            descendant.Ancestor.SwitchScreen(Screen.entreeList);
        }

        /// <summary>
        /// Shows all the drink buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //frame.NavigationService.Navigate(new DrinkList());
            // DisplayCurrentOrder();
            descendant.Ancestor.SwitchScreen(Screen.drinkList);
        }

        /// <summary>
        /// Shows all the side buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //frame.NavigationService.Navigate(new SideList());
            // DisplayCurrentOrder();

            descendant.Ancestor.SwitchScreen(Screen.sideList);
        }


        /// <summary>
        /// Displays the order being made at the time
        /// </summary>
        public void DisplayCurrentOrder()
        {
            finalorderlist.Items.Clear();
            finalpricelist.Items.Clear();

            finalorderlist.Items.Add("  Order #" + newOrder.OrderNumber);

            foreach (IOrderItem item in newOrder.Items)
            {
                finalorderlist.Items.Add(item.ToString() + " $" + item.Price);
                foreach (string specialstruc in item.SpecialInstructions)
                {
                    finalorderlist.Items.Add("-" + specialstruc);
                }
            }

            finalpricelist.Items.Add("Subtotal:   $" + newOrder.Subtotal);
            finalpricelist.Items.Add("Tax:   $" + newOrder.SalesTax);
            finalpricelist.Items.Add("Total:   $" + newOrder.Total);

        }

        private void finalorderlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //IOrderItem curItem = (IOrderItem)finalorderlist.SelectedItem;


            //this.frame.Navigate(curItem);

        }

        /// <summary>
        /// method that switches to the correct screen.
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen, IOrderItem item = null)
        {
            screens[screen].DataContext = item;
            switching.Child = screens[screen];
        }

        /// <summary>
        /// Click event for the CANCEL ORDER BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancleOrder_Click(object sender, RoutedEventArgs e)
        {
            finalorderlist.Items.Clear();
            finalpricelist.Items.Clear();

            newOrder = new Order();
            DataContext = newOrder;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            descendant.Ancestor.SwitchScreen(Screen.finishOrder);
        }

        private void Complete_Combo(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
