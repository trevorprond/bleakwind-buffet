using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
     /*
     * Author: Trevor Prondzinski
     * Class name: IOrderItem.cs
     * Purpose: Provide a IOrderItem interface for all the drinks, sides, and entrees
     */
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
