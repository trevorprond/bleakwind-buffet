using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author: Trevor Prondzinski
 * Class name: Menu.cs
 * Purpose: Provide a static menu class of the sides, drinks, and entrees
 */
namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all available entrees by BleakwindBuffet
        /// </summary>
        /// <returns>a list of type IOrderItem of all the entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            BriarheartBurger briarBurger = new BriarheartBurger();
            entreeList.Add(briarBurger);

            DoubleDraugr doubleBurger = new DoubleDraugr();
            entreeList.Add(doubleBurger);

            GardenOrcOmelette orcOmelette = new GardenOrcOmelette();
            entreeList.Add(orcOmelette);

            PhillyPoacher philly = new PhillyPoacher();
            entreeList.Add(philly);

            SmokehouseSkeleton smokehouse = new SmokehouseSkeleton();
            entreeList.Add(smokehouse);

            ThalmorTriple thalmorBurger = new ThalmorTriple();
            entreeList.Add(thalmorBurger);

            ThugsTBone tBone = new ThugsTBone();
            entreeList.Add(tBone);

            return entreeList;
        }

        /// <summary>
        /// Creates a list of all available sides by BleakwindBuffet
        /// </summary>
        /// <returns>a list of type IOrderItem of all the sides with respect to size</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries waffleFries = new DragonbornWaffleFries();
                waffleFries.Size = s;
                sides.Add(waffleFries);

                FriedMiraak miraak = new FriedMiraak();
                miraak.Size = s;
                sides.Add(miraak);

                MadOtarGrits grits = new MadOtarGrits();
                grits.Size = s;
                sides.Add(grits);

                VokunSalad salad = new VokunSalad();
                salad.Size = s;
                sides.Add(salad);
               
            }
            return sides;
        }

        /// <summary>
        /// Creates a list of all available drinks by BleakwindBuffet
        /// </summary>
        /// <returns>a list of type IOrderItem of all the drinks with respect to flavor and size</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice appleJuice = new AretinoAppleJuice();
                appleJuice.Size = s;
                drinks.Add((IOrderItem)appleJuice);

                CandlehearthCoffee coffee = new CandlehearthCoffee();
                coffee.Size = s;
                drinks.Add(coffee);

                MarkarthMilk milk = new MarkarthMilk();
                milk.Size = s;
                drinks.Add(milk);

                foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda soda = new SailorSoda();
                    soda.Size = s;
                    soda.Flavor = f;
                    drinks.Add(soda);
                }

                WarriorWater water = new WarriorWater();
                water.Size = s;
                drinks.Add(water);
                
            }
            return drinks;
        }

        /// <summary>
        /// Creates a list of all available menu items by BleakwindBuffet
        /// </summary>
        /// <returns>a list of type IOrderItem of all the menu items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            List<IOrderItem> drinks = new List<IOrderItem>();
            List<IOrderItem> sides = new List<IOrderItem>();
            List<IOrderItem> entrees = new List<IOrderItem>();

            drinks = (List<IOrderItem>)Drinks();
            menu.AddRange(drinks);

            sides = (List<IOrderItem>)Sides();
            menu.AddRange(sides);

            entrees = (List<IOrderItem>)Entrees();
            menu.AddRange(entrees);

            return menu;
        }
      
        /// <summary>
        /// Searches the menu
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of movies</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> curMenu, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return FullMenu();
            foreach (IOrderItem item in FullMenu())
            {
               
                if (item.ToString() != null && item.ToString().ToLower().Contains(terms.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible Category
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }

        /// <summary>
        /// Gets the items within the category selected
        /// </summary>
        /// <param name="all"></param>
        /// <param name="categories">the category to search in</param>
        /// <returns>the current items in the specific categories</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> curMenu, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return curMenu;
          
            List<IOrderItem> menuFiltered = new List<IOrderItem>();
            foreach (IOrderItem curItem in curMenu)
            {
               foreach (string curCategory in categories)
                {
                    if (curCategory.Equals("Entrees") && curItem is Entree)
                    {
                            menuFiltered.Add(curItem);
                    }

                    if (curCategory.Equals("Sides") && curItem is Side)
                    {
                           menuFiltered.Add(curItem);
                    }

                    if (curCategory.Equals("Drinks") && curItem is Drink)
                    {
                            menuFiltered.Add(curItem);
                    }
                }
            }
            return menuFiltered;
        }

        /// <summary>
        /// returns menu items in between calorie filterd
        /// </summary>
        /// <param name="curMenu"></param>
        /// <param name="Calmin"></param>
        /// <param name="Calmax"></param>
        /// <returns>the current menu items in between the calorie filters</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> curMenu, int? Calmin, int? Calmax)
        {
            if (Calmin == null && Calmax == null) return curMenu;
            var menuFiltered = new List<IOrderItem>();
           
            if (Calmax == null)
            {
                foreach (IOrderItem i in curMenu)
                {
                    if (i.Calories >= Calmin) menuFiltered.Add(i);
                }
                return menuFiltered;
            }

            if (Calmin == null)
            {
                foreach (IOrderItem i in curMenu)
                {
                    if (i.Calories <= Calmax) menuFiltered.Add(i);
                }
                return menuFiltered;
            }

            foreach (IOrderItem i in curMenu)
            {
                if (i.Calories >= Calmin && i.Calories <= Calmax)
                {
                    menuFiltered.Add(i);
                }
            }
            return menuFiltered;
        }

        /// <summary>
        /// return menu items in between price filters
        /// </summary>
        /// <param name="curMenu">the current menu</param>
        /// <param name="priceMin"> the current price min</param>
        /// <param name="priceMax">the current price max</param>
        /// <returns>the menu items that fall in the range</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> curMenu, double? priceMin, double? priceMax)
        {
            if (priceMin == null && priceMax == null) return curMenu;
            var menuFiltered = new List<IOrderItem>();

            
            if (priceMin == null)
            {
                foreach (IOrderItem i in curMenu)
                {
                    if (i.Price <= priceMax) menuFiltered.Add(i);
                }
                return menuFiltered;
            }
           
            if (priceMax == null)
            {
                foreach (IOrderItem i in curMenu)
                {
                    if (i.Price >= priceMin) menuFiltered.Add(i);
                }
                return menuFiltered;
            }
         
            foreach (IOrderItem i in curMenu)
            {
                if (i.Price >= priceMin && i.Price <= priceMax)
                {
                    menuFiltered.Add(i);
                }
            }
            return menuFiltered;
        }

    }
}
