using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Trevor Prondzinski
    * Class name: Drink.cs
    * Purpose: A base class representing common properties of Drinks
    */
    public abstract class Drink : INotifyPropertyChanged
    {

        /// <summary>
        /// propertychanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// notify property helper method
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare drink
        /// </summary>
        public abstract List<string> SpecialInstructions 
        
        {  get; }

        /// <summary>
        /// Description of entree
        /// </summary>
        public abstract string Description { get; }


        //public event PropertyChangedEventHandler PropertyChanged;

        /* protected void NotifyOfPropertyChange(string propertyName)
         {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
         }*/
    }
}
