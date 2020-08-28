using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: SailorSoda.cs
 * Purpose: To allow ordering and customization of the item Sailor's soda
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    class SailorSoda
    {

        /// <summary>
        /// Gets the price of the soda
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the soda based on size
        /// </summary>
        public double Price
        {
            get 
            {
                
                if (Size == Size.Medium)
                {
                    return price = 1.74;
                }
                if (Size == Size.Large)
                {
                    return price = 2.07;
                }
                else return price = 1.42;
            }
            
        }

        /// <summary>
        /// Gets the Size of the soda with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        
        /// <summary>
        /// Gets the calories of the soda based on size
        /// </summary>
        uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 153;
                }
                if (Size == Size.Large)
                {
                    return calories = 205;
                }
                else return calories = 117;
            }
        }

        /// <summary>
        /// Gets the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <summary>
        /// Gets whether or not to add ice
        /// </summary>
        public bool Ice { get; set; } = true;
        
        /// <summary>
        /// Allows customization on the soda
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the soda and the flavors to be added
        /// </summary>
        /// <returns>name of soda and flavors</returns>
        public override string ToString()
        {
            return @"""[Size][Flavor] Sailor Soda"" where [Size] is ""Large"", ""Medium"", or ""Small"" and [Flavor] is ""Blackberry"", ""Cherry"", ""Grapefruit"", ""Lemon"", ""Peach"", or ""Watermellon""";
        }
    }
}
