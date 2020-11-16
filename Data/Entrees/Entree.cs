using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Trevor Prondzinski
    * Class name: Entree.cs
    * Purpose: A base class representing common properties of Entrees
    */
    public abstract class Entree : INotifyPropertyChanged
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
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Description of entree
        /// </summary>
        public abstract string Description { get; }
    }
}
