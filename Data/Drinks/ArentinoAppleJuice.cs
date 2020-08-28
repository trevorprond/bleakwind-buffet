using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: ArentinoAppleJuice.cs
 * Purpose: To allow ordering and customization of the item Arentino Apple Juice 
 */
namespace BleakwindBuffet.Data.Drinks
{
   
    class ArentinoAppleJuice
    {

        /// <summary>
        /// Gets the price of the juice
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the juice based on size
        /// </summary>
        public double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = .87;
                }
                if (Size == Size.Large)
                {
                    return price = 1.01;
                }
                else return price = .62;
            }

        }

        /// <summary>
        /// Gets the Size of the juice with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the juice based on size
        /// </summary>
        uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 88;
                }
                if (Size == Size.Large)
                {
                    return calories = 132;
                }
                else return calories = 44;
            }
        }



        /// <summary>
        /// Gets whether or not to add ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Allows customization on the juice
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the juice and sizes
        /// </summary>
        /// <returns>name of juice and sizes</returns>
        public override string ToString()
        {
            return @"""[Size] Arentino Apple Juice"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
