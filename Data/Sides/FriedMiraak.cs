using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data.Enums;

/*
 * Author: Trevor Prondzinski
 * Class name: FriedMiraak.cs
 * Purpose: To allow ordering and customization of the item Fried Miraak
 */
namespace BleakwindBuffet.Data.Sides
{
    
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
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
        /// Gets the price of the Hash brown pancakes
        /// </summary>
        double price;

        /// <summary>
        /// Gets the price of the Hash brown pancakes based on size
        /// </summary>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium)
                {
                    return price = 2.01;
                }
                if (Size == Size.Large)
                {
                    return price = 2.88;
                }
                else return price = 1.78;
            }

        }

        /// <summary>
        /// Gets the calories of the Hash brown pancakes based on size
        /// </summary>
        uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 236;
                }
                if (Size == Size.Large)
                {
                    return calories = 306;
                }
                else return calories = 151; 
            }
        }



        /// <summary>
        /// Allows customizations on the Hash brown pancakes even though there isn't any
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
        /// Gets the name of the Hash brown pancakes and its sizes
        /// </summary>
        /// <returns>name of Hash brown pancakes and sizea</returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }

    }
}
