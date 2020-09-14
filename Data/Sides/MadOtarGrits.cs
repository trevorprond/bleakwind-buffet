using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: MadOtarGrits.cs
 * Purpose: To allow ordering and customization of the item Mad Otar Grits
 */
namespace BleakwindBuffet.Data.Sides
{
    
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the Cheesy Grits
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the Cheesy Grits based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 1.58;
                }
                if (Size == Size.Large)
                {
                    return price = 1.93;
                }
                else return price = 1.22;
            }

        }
        /// <summary>
        /// Gets the Size of the Cheesy Grits with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the Cheesy Grits based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 142;
                }
                if (Size == Size.Large)
                {
                    return calories = 179;
                }
                else return calories = 105;
            }
        }



        /// <summary>
        /// Allows customizations on the Cheesy Grits even though there isn't any
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the Cheesy Grits and its sizes
        /// </summary>
        /// <returns>name of Cheesy Grits and sizea</returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }

    }
}
