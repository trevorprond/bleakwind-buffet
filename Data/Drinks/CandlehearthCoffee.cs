using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: CandlehearthCoffee.cs
 * Purpose: To allow ordering and customization of the item Candlehearth Coffee
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class CandlehearthCoffee
    {

        /// <summary>
        /// Gets the price of the coffee
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the coffee based on size
        /// </summary>
        public double Price
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
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the coffee based on size
        /// </summary>
        uint calories;
        public uint Calories
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
        public bool Ice { get; set; } = false;

        /// <summary>
        /// gets whether or not leave room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// gets whether they want it Decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Allows customization on the coffee
        /// </summary>
        public List<string> SpecialInstructions
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
                return Size + " Candlehearth Decaf Coffee";
            }
            else return Size + " Candlehearth Coffee";
        }
    }
}
