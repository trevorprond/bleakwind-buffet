using BleakwindBuffet.Data;
using RoundRegister;
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
 * Class name: CashRegister.xaml.cs
 * Purpose: To allow transactions to be complete
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FinishOrder.xaml
    /// </summary>
    public partial class FinishOrder : UserControl
    {
        MainWindow ancestor;

        Order usethisOrder = new Order();
        public FinishOrder(MainWindow ancestor, Order newOrder)
        {
            InitializeComponent();
            this.ancestor = ancestor;

            usethisOrder = newOrder;
        }



        /// <summary>
        /// click event handler for switching screens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.welcomePage);
        }

        /// <summary>
        /// Click event for CREDIT/DEBIT button for payment type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayByCard_Click(object sender, RoutedEventArgs e)
        {
            switch (CardReader.RunCard(ancestor.newOrder.Total))
            {
                case CardTransactionResult.Approved:
                    //print receipt
                    //OrderListView.Items.Clear();
                    Order order = new Order();
                    DataContext = order;
                    break;
                case CardTransactionResult.Declined:
                    PayByCard.IsEnabled = false;
                    MessageBox.Show("Error: Card Declined, please select another payment method.");
                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Error: Card Read Error! \n\t Please try swiping card again!");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    PayByCard.IsEnabled = false;
                    MessageBox.Show("Error: Insufficient funds on card. \n\t Please select another payment method.");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Error: Incorrect Pin. \n\t Please try entering again.");
                    break;
                default:
                    throw new NotImplementedException("Should never be reached");
            }




        }
        MainWindow window = (MainWindow)Application.Current.MainWindow;
        
        /// <summary>
        /// click event for cash registrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.cashRegistar);

        }


        /// <summary>
        /// Prints the receipt to the dll
        /// </summary>
        /// <param name="typeofPayment"></param>
        /// <param name="totalChange"></param>
        public void PrintReciept(string typeofPayment, double totalChange)
        {
            RecieptPrinter.PrintLine("Order # " + usethisOrder.OrderNumber.ToString());
            RecieptPrinter.PrintLine(DateTime.Now.ToString());

            foreach (IOrderItem item in window.newOrder.Items)
            {
                RecieptPrinter.PrintLine(item.ToString() + " $" + item.Price);
                foreach (string specialstruc in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("-" + specialstruc);
                }
            }
            RecieptPrinter.PrintLine("SubTotal: $" + window.newOrder.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax: $" + window.newOrder.SalesTax.ToString());
            RecieptPrinter.PrintLine("Total: $" + window.newOrder.Total.ToString());
            RecieptPrinter.PrintLine("Payment Type:  " + typeofPayment);
            RecieptPrinter.PrintLine("Change:   $" + totalChange.ToString());
            RecieptPrinter.CutTape();

        }
    }
}
