using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: CandlehearthCoffee.cs
 * Purpose: To allow ordering and customization of the item Candlehearth Coffee
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
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
        /// Gets the price of the coffee
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the coffee based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 1.25;
                }
                if (Size == Size.Large)
                {
                    return price = 1.75;
                }
                else return price = .75;
            }

        }

        /// <summary>
        /// Gets the Size of the coffee with it being a default of small
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
        /// Gets the calories of the coffee based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 10;
                }
                if (Size == Size.Large)
                {
                    return calories = 20;
                }
                else return calories = 7;
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
        /// gets whether or not leave room for cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return this.roomForcream;
            }
            set
            {
                if (value != this.roomForcream)
                {
                    this.roomForcream = value;
                    NotifyPropertyChanged();
                }
            }
        }



        private bool roomForcream = false;
        /// <summary>
        /// gets whether they want it Decaf or not
        /// </summary>
        public bool Decaf
        {
            get
            {
                return this.decaf;
            }
            set
            {
                if (value != this.decaf)
                {
                    this.decaf = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private bool decaf = false;

        /// <summary>
        /// Allows customization on the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the coffee, sizes, and decaf
        /// </summary>
        /// <returns>name of coffee, sizes, and decaf version</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            else return Size + " Candlehearth Coffee";
        }
    }
}
