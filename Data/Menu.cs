using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
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




    }
}
