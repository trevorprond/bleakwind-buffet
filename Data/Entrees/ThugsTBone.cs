using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: ThugsTBone.cs
 * Purpose: To allow ordering and customization of the item Thugs T-Bone
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class ThugsTBone: Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the T-Bone
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories => 982;

       

        /// <summary>
        /// Allows customizations on the T-Bone even though there isn't any
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
        /// Gets the name of the T-Bone
        /// </summary>
        /// <returns>name of T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("Juicy T-Bone, not much else to say.");
            }
        }

    }
}
