using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: ThugsTBone.cs
 * Purpose: To allow ordering and customization of the item Thugs T-Bone
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the T-Bone
        public double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public uint Calories => 982;

       

        /// <summary>
        /// Allows customizations on the T-Bone even though there isn't any
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
        /// Gets the name of the T-Bone
        /// </summary>
        /// <returns>name of T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
