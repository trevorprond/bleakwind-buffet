using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properties of sides
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
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
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Description of entree
        /// </summary>
        public abstract string Description { get; }
    }
}
