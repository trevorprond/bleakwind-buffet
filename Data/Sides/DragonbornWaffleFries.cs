using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: DragonbornWaffleFries.cs
 * Purpose: To allow ordering and customization of the item Dragonborn Waffle Fries
 */
namespace BleakwindBuffet.Data.Sides
{
    
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the Cajun fries
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the Cajun fries based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = .76;
                }
                if (Size == Size.Large)
                {
                    return price = .96;
                }
                else return price = .42;
            }

        }
        /// <summary>
        /// Gets the Size of the Cajun fries with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the Cajun fries based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 89;
                }
                if (Size == Size.Large)
                {
                    return calories = 100;
                }
                else return calories = 77;
            }
        }



        /// <summary>
        /// Allows customizations on the Cajun fries even though there isn't any
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
        /// Gets the name of the Cajun fries and its sizes
        /// </summary>
        /// <returns>name of Cajun fries and sizea</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }

    }
}
