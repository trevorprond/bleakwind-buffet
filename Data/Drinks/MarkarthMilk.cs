using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: MarkarthMilk.cs
 * Purpose: To allow ordering and customization of the item Markarth Milk
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {


        /// <summary>
        /// propertychanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// notify property helper method
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the price of the milk
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the milk based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 1.11;
                }
                if (Size == Size.Large)
                {
                    return price = 1.22;
                }
                else return price = 1.05;
            }

        }

        /// <summary>
        /// Gets the Size of the milk with it being a default of small
        /// </summary>
        public Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value != this.size)
                {
                    this.size = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// private variable declaration
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the calories of the milk based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 72;
                }
                if (Size == Size.Large)
                {
                    return calories = 93;
                }
                else return calories = 56;
            }
        }



        /// <summary>
        /// Gets whether or not to add ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return this.ice;
            }
            set
            {
                if (value != this.ice)
                {
                    this.ice = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private bool ice = false;

        /// <summary>
        /// Allows customization on the milk
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the milk and sizes
        /// </summary>
        /// <returns>name of milk and sizes</returns>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}
