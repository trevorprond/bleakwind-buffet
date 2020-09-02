using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: PhillyPoacher.cs
 * Purpose: To allow ordering and customization of the item Philly Poacher
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the Philly cheesesteak sandwich
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the Philly cheesesteak sandwich
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets whether or not to add Sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Onion
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets whether or not to add Roll
        /// </summary>
        public bool Roll { get; set; } = true;


        /// <summary>
        /// Allows customizations on the Philly cheesesteak sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the Philly cheesesteak sandwich
        /// </summary>
        /// <returns>name of Philly cheesesteak sandwich</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
