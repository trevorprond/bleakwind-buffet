using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: ThalmorTriple.cs
 * Purpose: To allow ordering and customization of the item ThalmorTriple
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Gets whether or not to add ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Allows customizations on the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the burger
        /// </summary>
        /// <returns>name of burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
