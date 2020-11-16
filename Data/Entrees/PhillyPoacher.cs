using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: PhillyPoacher.cs
 * Purpose: To allow ordering and customization of the item Philly Poacher
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
       

        /// <summary>
        /// Gets the price of the Philly cheesesteak sandwich
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the Philly cheesesteak sandwich
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets whether or not to add Sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return this.sirloin;
            }
            set
            {
                if (value != this.sirloin)
                {
                    this.sirloin = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool sirloin = true;

        /// <summary>
        /// Gets whether or not to add Onion
        /// </summary>
        public bool Onion
        {
            get
            {
                return this.onion;
            }
            set
            {
                if (value != this.onion)
                {
                    this.onion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool onion = true;

        /// <summary>
        /// Gets whether or not to add Roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return this.roll;
            }
            set
            {
                if (value != this.roll)
                {
                    this.roll = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool roll = true;


        /// <summary>
        /// Allows customizations on the Philly cheesesteak sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                NotifyPropertyChanged();
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

        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll");
            }
        }

    }
}
