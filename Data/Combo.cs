using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BleakwindBuffet.Data
{
    /*
     * Author: Trevor Prondzinski
     * Class name: Combo.cs
     * Purpose: Provide a Combo interface for all the drinks, sides, and entrees
     */
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets the constuctor for the combo along with event listeners
        /// </summary>
        public uint calories;
        public Combo(Entree entree, Drink drink, Side side)
        {
            Entree = entree;
            Side = side;
            Drink = drink;

           Drink.PropertyChanged += ChangesinCombo;
           Entree.PropertyChanged += ChangesinCombo;
           Side.PropertyChanged += ChangesinCombo;

        }

        /// <summary>
        /// backing variable for entree
        /// </summary>
        private Entree entree;
        /// <summary>
        /// notify property helper method
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the notifypropertchanged for when a entree is customized
        /// </summary>
        public Entree Entree
        {
            get
            {
                return this.entree;
            }

            set
            {
                if(value != this.entree)
                {
                    this.entree = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Price");
                    NotifyPropertyChanged("Calories");
                    NotifyPropertyChanged("SpecialInstructions");

                }

            }
        }

        /// <summary>
        /// Sets the notifypropertchanged for when a drink is customized
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get
            {
                return this.drink;
            }

            set
            {
                if (value != this.drink)
                {
                    this.drink = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Price");
                    NotifyPropertyChanged("Calories");
                    NotifyPropertyChanged("SpecialInstructions");

                }

            }
        }


        /// <summary>
        /// Sets the notifypropertchanged for when a side is customized
        /// </summary>
        private Side side;

        public Side Side
        {
            get
            {
                return this.side;
            }

            set
            {
                if (value != this.side)
                {
                    this.side = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Price");
                    NotifyPropertyChanged("Calories");
                    NotifyPropertyChanged("SpecialInstructions");

                }

            }
        }

        /// <summary>
        /// gets the overall calories for the order
        /// </summary>
        public uint Calories
        {
            get
            {
                return Side.Calories + Entree.Calories + Drink.Calories;
            }
        }


        /// <summary>
        /// creates the specialinstructions for each item in combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> combinedInstruct = new List<string>();
                combinedInstruct.Add(Entree.ToString());
                combinedInstruct.AddRange(Entree.SpecialInstructions);
                combinedInstruct.Add(Drink.ToString());
                combinedInstruct.AddRange(Drink.SpecialInstructions);
                combinedInstruct.Add(Side.ToString());
                combinedInstruct.AddRange(Side.SpecialInstructions);
                return combinedInstruct;
            }
        }

        /// <summary>
        /// sets the price of the combo wth a discount
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = (Side.Price + Entree.Price + Drink.Price) - 1.00;
                price = Math.Round(price, 2);
                return price;
            }
        }

        /// <summary>
        /// Notifys when the property changes for any side, entree, or drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangesinCombo(object sender, PropertyChangedEventArgs e)
        {
          
            NotifyPropertyChanged();
            NotifyPropertyChanged("Price");
            NotifyPropertyChanged("Calories");
            NotifyPropertyChanged("SpecialInstructions");

            this.PropertyChanged -= ChangesinCombo;
        }

    }
}
