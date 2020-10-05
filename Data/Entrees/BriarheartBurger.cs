using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: BriarheartBurger.cs
 * Purpose: To allow ordering and customization of the item Briarheart Burger
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class BriarheartBurger: Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// propertychanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// notify property helper method
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets whether or not to add ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return this.ketchup;
            }
            set
            {
                if (value != this.ketchup)
                {
                    this.ketchup = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;
        
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;



        /// <summary>
        /// Gets whether or not to add Bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return this.bun;
            }
            set
            {
                if (value != this.bun)
                {
                    this.bun = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool bun = true;


        /// <summary>
        /// Gets whether or not to add mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return this.mustard;
            }
            set
            {
                if (value != this.mustard)
                {
                    this.mustard = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mustard = true;

        /// <summary>
        /// Gets whether or not to add Pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return this.pickle;
            }
            set
            {
                if (value != this.pickle)
                {
                    this.pickle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool pickle = true;

        /// <summary>
        /// Gets whether or not to add Cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return this.cheese;
            }
            set
            {
                if (value != this.cheese)
                {
                    this.cheese = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool cheese = true;

        /// <summary>
        /// Allows customizations on the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get 
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the burger
        /// </summary>
        /// <returns>name of burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
