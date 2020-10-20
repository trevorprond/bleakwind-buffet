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
 * Class name: NumberBox.xamlcs
 * Purpose: To allow values of change to go up or down
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for NumberBox.xaml
    /// </summary>
    public partial class NumberBox : UserControl
    {
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumberBox));

        /// <summary>
        /// gets Value of certain value
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(NumberBox.ValueProperty); }
            set { SetValue(NumberBox.ValueProperty, value); }
        }
       
        /// <summary>
        /// NumberBox constructor
        /// </summary>
        public NumberBox()
        {
            InitializeComponent();
            CheckIfZero();
        }


        /// <summary>
        /// Increments the click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;
            CheckIfZero();
        }


        /// <summary>
        /// Disables the decrement if zero
        /// </summary>
        void CheckIfZero()
        {
            if (Value == 0) Decrement.IsEnabled = false;
            else Decrement.IsEnabled = true;
        }

        /// <summary>
        /// subtracts click event from value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            Value--;
            e.Handled = true;
            CheckIfZero();
        }
    }
}
