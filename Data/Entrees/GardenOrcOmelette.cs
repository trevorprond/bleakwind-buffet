using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: GardenOrcOmelette.cs
 * Purpose: To allow ordering and customization of the item Garden Orc Omelette
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the Vegetarian omelette
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the Vegetarian omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Gets whether or not to add Broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;



        /// <summary>
        /// Allows customizations on the Vegetarian omelette
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the Vegetarian omelette
        /// </summary>
        /// <returns>name of the Vegetarian omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
