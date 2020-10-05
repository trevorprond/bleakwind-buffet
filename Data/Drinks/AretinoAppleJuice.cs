using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: ArentinoAppleJuice.cs
 * Purpose: To allow ordering and customization of the item Arentino Apple Juice 
 */
namespace BleakwindBuffet.Data.Drinks
{

    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged

     
    {
        /// <summary>
        /// propertychanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// notify property helper method
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "" )
        { 
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
        /// <summary>
        /// Gets the price of the juice
        /// </summary>
        double price;

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
                }
            }
        }

        /// <summary>
        /// private variable declaration
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the price of the juice based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = .87;
                }
                if (Size == Size.Large)
                {
                    return price = 1.01;
                }
                else return price = .62;
            }

        }

       

        /// <summary>
        /// Gets the calories of the juice based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 88;
                }
                if (Size == Size.Large)
                {
                    return calories = 132;
                }
                else return calories = 44;
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



        private bool ice = false;
        /// <summary>
        /// Allows customization on the juice
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the name of the juice and sizes
        /// </summary>
        /// <returns>name of juice and sizes</returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}