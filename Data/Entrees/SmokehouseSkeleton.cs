using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: SmokehouseSkeleton.cs
 * Purpose: To allow ordering and customization of the item Smokehouse Skeleton
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class SmokehouseSkeleton: Entree, IOrderItem, INotifyPropertyChanged
    {
        
        /// <summary>
        /// Gets the price of the Breakfast Combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the Breakfast Combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets whether or not to add Sausage Link
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return this.sausagelink;
            }
            set
            {
                if (value != this.sausagelink)
                {
                    this.sausagelink = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool sausagelink = true;

        /// <summary>
        /// Gets whether or not to add Egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return this.egg;
            }
            set
            {
                if (value != this.egg)
                {
                    this.egg = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool egg = true;

        /// <summary>
        /// Gets whether or not to add Tomato
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return this.hashbrowns;
            }
            set
            {
                if (value != this.hashbrowns)
                {
                    this.hashbrowns = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool hashbrowns = true;

        /// <summary>
        /// Gets whether or not to add Pancake
        /// </summary>
        public bool Pancake
        {
            get
            {
                return this.pancake;
            }
            set
            {
                if (value != this.pancake)
                {
                    this.pancake = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool pancake = true;



        /// <summary>
        /// Allows customizations on the Breakfast Combo
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                NotifyPropertyChanged();
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
