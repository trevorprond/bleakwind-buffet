using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: ThalmorTriple.cs
 * Purpose: To allow ordering and customization of the item ThalmorTriple
 */
namespace BleakwindBuffet.Data.Entrees
{
    
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
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
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

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
        /// Gets whether or not to add Lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return this.lettuce;
            }
            set
            {
                if (value != this.lettuce)
                {
                    this.lettuce = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool lettuce = true;

        /// <summary>
        /// Gets whether or not to add Mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return this.mayo;
            }
            set
            {
                if (value != this.mayo)
                {
                    this.mayo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool mayo = true;

        /// <summary>
        /// Gets whether or not to add Bacon
        /// </summary>
        public bool Bacon
        {
            get
            {
                return this.bacon;
            }
            set
            {
                if (value != this.bacon)
                {
                    this.bacon = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool bacon = true;

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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");

                return instructions;
            }
        }
        /// <summary>
        /// Gets the name of the burger
        /// </summary>
        /// <returns>name of burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
