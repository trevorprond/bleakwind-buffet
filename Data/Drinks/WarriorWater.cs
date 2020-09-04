using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: WarriorWater.cs
 * Purpose: To allow ordering and customization of the item Warrior Water
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class WarriorWater
    {

        /// <summary>
        /// Gets the price of the water
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the water based on size
        /// </summary>
        public double Price
        {
            get
            {
                return price = 0;
            }

        }

        /// <summary>
        /// Gets the Size of the water with it being a default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the calories of the water based on size
        /// </summary>
        uint calories;
        public uint Calories
        {
            get
            {
               return calories = 0;
            }
        }



        /// <summary>
        /// Gets whether or not to add ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// gets whether or not to add lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

      

        /// <summary>
        /// Allows customization on the water
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the water and its
        /// </summary>
        /// <returns>name of water and sizes</returns>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}
