﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: VokunSalad.cs
 * Purpose: To allow ordering and customization of the item Vokun Salad
 */
namespace BleakwindBuffet.Data.Sides
{
    
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        
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
        private Size size = Size.Small;
        /// <summary>
        /// Gets the price of the fruit salad
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the fruit salad based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 1.28;
                }
                if (Size == Size.Large)
                {
                    return price = 1.82;
                }
                else return price = .93;
            }

        }

        /// <summary>
        /// Gets the calories of the fruit salad based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 52;
                }
                if (Size == Size.Large)
                {
                    return calories = 73;
                }
                else return calories = 41; 
            }
        }



        /// <summary>
        /// Allows customizations on the fruit salad even though there isn't any
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
        /// Gets the name of the fruit salad and its sizes
        /// </summary>
        /// <returns>name of fruit salad and sizea</returns>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }

        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.");
            }
        }

    }
}
