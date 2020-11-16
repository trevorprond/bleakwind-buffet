using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: GardenOrcOmelette.cs
 * Purpose: To allow ordering and customization of the item Garden Orc Omelette
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class GardenOrcOmelette: Entree, IOrderItem, INotifyPropertyChanged
    {
         /// <summary>
        /// Gets the price of the Vegetarian omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the Vegetarian omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets whether or not to add Broccoli
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return this.broccoli;
            }
            set
            {
                if (value != this.broccoli)
                {
                    this.broccoli = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool broccoli = true;

        /// <summary>
        /// Gets whether or not to add Mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return this.mushrooms;
            }
            set
            {
                if (value != this.mushrooms)
                {
                    this.mushrooms = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mushrooms = true;

        /// <summary>
        /// Gets whether or not to add Tomato
        /// </summary>
        public bool Tomato
        {
            get
            {
                return this.tomato;
            }
            set
            {
                if (value != this.tomato)
                {
                    this.tomato = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Gets whether or not to add cheddar
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return this.cheddar;
            }
            set
            {
                if (value != this.cheddar)
                {
                    this.cheddar = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool cheddar = true;



        /// <summary>
        /// Allows customizations on the Vegetarian omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                NotifyPropertyChanged();
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
        /// <summary>
        /// gets the description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.");
            }
        }

    }
}
