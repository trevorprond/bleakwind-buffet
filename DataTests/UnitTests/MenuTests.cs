using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using NuGet.Frameworks;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{

    public class MenuTests
    {
        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]
        
        [InlineData("Small Fried Miraak")]
        [InlineData( "Medium Fried Miraak")]
        [InlineData( "Large Fried Miraak")]
        
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData( "Large Mad Otar Grits")]
        
        [InlineData( "Small Vokun Salad")]
        [InlineData( "Medium Vokun Salad")]
        [InlineData( "Large Vokun Salad")]
        public void ReturnsAllSides(string s)
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides = (List<IOrderItem>)Menu.Sides();

            Assert.Contains<IOrderItem>(sides, (item)  => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData( "Small Aretino Apple Juice")]
        [InlineData( "Medium Aretino Apple Juice")]
        [InlineData( "Large Aretino Apple Juice")]
        
        [InlineData( "Small Candlehearth Coffee")]
        [InlineData( "Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]
        
        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData( "Large Markarth Milk")]

        [InlineData("Small Cherry Sailor Soda")]
        [InlineData( "Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]

        [InlineData( "Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData( "Large Blackberry Sailor Soda")]

        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData( "Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]

        [InlineData( "Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData( "Large Lemon Sailor Soda")]


        [InlineData( "Small Peach Sailor Soda")]
        [InlineData( "Medium Peach Sailor Soda")]
        [InlineData( "Large Peach Sailor Soda")]


        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData( "Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]

        [InlineData( "Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        public void ReturnAllDrinks(string s)
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks = (List<IOrderItem>)Menu.Drinks();

            Assert.Contains<IOrderItem>(drinks, (item) => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        public void ReturnAllEntrees(string s)
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees = (List<IOrderItem>)Menu.Entrees();

            Assert.Contains<IOrderItem>(entrees, (item) => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Medium Aretino Apple Juice")]
        [InlineData("Large Aretino Apple Juice")]

        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]

        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Large Markarth Milk")]

        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]

        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Large Blackberry Sailor Soda")]

        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]

        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]


        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]


        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]

        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]

        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]

        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]

        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]
        public void ReturnEntireMenu(string s)
        {
            List<IOrderItem> fullmenu = new List<IOrderItem>();
            fullmenu = (List<IOrderItem>)Menu.FullMenu();

            Assert.Contains<IOrderItem>(fullmenu, (item) => item.ToString().Equals(s));
        }
    }
}

