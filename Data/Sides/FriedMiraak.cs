using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: FriedMiraak.cs
 * Purpose: To allow ordering and customization of the item Fried Miraak
 */
namespace BleakwindBuffet.Data.Sides
{
    
    public class FriedMiraak
    {
        /// <summary>
        /// Gets the price of the Hash brown pancakes
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the Hash brown pancakes based on size
        /// </summary>
        public double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 2.01;
                }
                if (Size == Size.Large)
                {
                    return price = 2.88;
                }
                else return price = 1.78;
            }

        }
        /// <summary>
        /// Gets the Size of the Hash brown pancakes with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the Hash brown pancakes based on size
        /// </summary>
        uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 236;
                }
                if (Size == Size.Large)
                {
                    return calories = 306;
                }
                else return calories = 151; 
            }
        }



        /// <summary>
        /// Allows customizations on the Hash brown pancakes even though there isn't any
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the Hash brown pancakes and its sizes
        /// </summary>
        /// <returns>name of Hash brown pancakes and sizea</returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }

    }
}
