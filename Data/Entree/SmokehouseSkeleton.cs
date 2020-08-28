using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: SmokehouseSkeleton.cs
 * Purpose: To allow ordering and customization of the item Smokehouse Skeleton
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the Breakfast Combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the Breakfast Combo
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Gets whether or not to add Sausage Link
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Tomato
        /// </summary>
        public bool Hashbrowns { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Pancake
        /// </summary>
        public bool Pancake { get; set; } = true;



        /// <summary>
        /// Allows customizations on the Breakfast Combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!Hashbrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the Breakfast Combo
        /// </summary>
        /// <returns>name of the Breakfast Combo</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
