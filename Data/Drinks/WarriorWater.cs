using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: WarriorWater.cs
 * Purpose: To allow ordering and customization of the item Warrior Water
 */
namespace BleakwindBuffet.Data.Drinks
{
    
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
       

        /// <summary>
        /// Gets the price of the water
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the water based on size
        /// </summary>
        public override double Price
        {
            get
            {
                return price = 0;
            }

        }

        /// <summary>
        /// Gets the Size of the water with it being a default of small
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
        /// Gets the calories of the water based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
               return calories = 0;
            }
        }



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
        /// gets whether or not to add lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
            set
            {
                if(value != this.lemon)
                {
                    this.lemon = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private bool lemon = false;
      

        /// <summary>
        /// Allows customization on the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                NotifyPropertyChanged();
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

        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("It’s water. Just water.");
            }
        }
    }
}
