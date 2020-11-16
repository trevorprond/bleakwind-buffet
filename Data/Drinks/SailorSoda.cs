using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;


/*
 * Author: Trevor Prondzinski
 * Class name: SailorSoda.cs
 * Purpose: To allow ordering and customization of the item Sailor's soda
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class SailorSoda: Drink, IOrderItem, INotifyPropertyChanged
    {
     


 
        /// <summary>
        /// Gets the price of the soda
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the soda based on size
        /// </summary>
        public override double Price
        {
            get 
            {
                
                if (Size == Size.Medium)
                {
                    return price = 1.74;
                }
                if (Size == Size.Large)
                {
                    return price = 2.07;
                }
                else return price = 1.42;
            }
            
        }

        /// <summary>
        /// Gets the Size of the soda with it being a default of small
        /// </summary>
        public Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value != this.size)
                {
                    this.size = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Price");
                    NotifyPropertyChanged("Calories");
                    NotifyPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// private variable declaration
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the calories of the soda based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 153;
                }
                if (Size == Size.Large)
                {
                    return calories = 205;
                }
                else return calories = 117;
            }
        }

        /// <summary>
        /// Gets the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return this.flavor;
            }

            set
            {
                if(value != this.flavor)
                {
                    this.flavor = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Gets whether or not to add ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return this.ice;
            }
            set
            {
                if (value != this.ice)
                {
                    this.ice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool ice = true;

        /// <summary>
        /// Allows customization on the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                NotifyPropertyChanged();
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the soda and the flavors to be added
        /// </summary>
        /// <returns>name of soda and flavors</returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }

        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.");
            }
        }
    }
}
