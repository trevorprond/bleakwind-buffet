using System;
using System.Collections.Generic;
using System.Text;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using NuGet.Frameworks;
using System.Linq;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class WebsiteTestscs
    {
        [Fact]
        public void SearchFilterReturnsEntireMenuWhenNull()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> CurrentMenu = Menu.Search(fullMenu, "");
            Assert.Equal<int>(fullMenu.Count(), CurrentMenu.Count());
        }

        [Fact]
        public void CategoryFilterReturnsEntireMenuWhenNull()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> CurrentMenu = Menu.FilterByCategory(fullMenu, null);
            Assert.Equal<int>(fullMenu.Count(), CurrentMenu.Count());
        }

        [Fact]
        public void PriceFilterReturnsEntireMenuWhenNull()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> CurrentMenu = Menu.FilterByPrice(fullMenu, null, null);
            Assert.Equal<int>(fullMenu.Count(), CurrentMenu.Count());
        }

        [Fact]
        public void CalorieFilterReturnsEntireMenuWhenNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            IEnumerable<IOrderItem> EntireMenu = Menu.FullMenu();
            Assert.Equal<int>(EntireMenu.Count(), curMenu.Count());
        }
        [Fact]
        public void SearchFilterWorks()
        {
            IEnumerable<IOrderItem> curMenu = Menu.Search(Menu.FullMenu(), "burger");
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            bool itworks = false;
            foreach (IOrderItem fullMenuitem in fullMenu)
            {
                foreach (IOrderItem curMenuitem in curMenu)
                {
                    if (fullMenuitem.ToString().Equals(curMenuitem.ToString()))
                    {
                        itworks = true;
                    }

                }
            }
            Assert.True(itworks);
        }

        [Fact]
        public void CategoryFilterForEntrees()
        {
            string[] category = new string[] { "Entrees" };
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCategory(Menu.FullMenu(), category);
            Assert.Equal<int>(7, curMenu.Count());
        }

        [Fact]
        public void CategoryFilterForDrinks()
        {
            string[] category = new string[] { "Drinks" };
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCategory(Menu.FullMenu(), category);
            Assert.Equal<int>(30, curMenu.Count());
        }

        [Fact]
        public void CategoryFilterForSides()
        {
            string[] category = new string[] { "Sides" };
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCategory(Menu.FullMenu(), category);
            Assert.Equal<int>(12, curMenu.Count());
        }
        [Fact]
        public void OnlyCalorieMinNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCalories(Menu.FullMenu(), 900, null);
            Assert.Equal<int>(2, curMenu.Count());
        }

        [Fact]
        public void OnlyCalorieMaxNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCalories(Menu.FullMenu(), null, 60);
            Assert.Equal<int>(10, curMenu.Count());
        }

        [Fact]
        public void CalMaxAndCalMinNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByCalories(Menu.FullMenu(), 400, 500);
            foreach (IOrderItem item in curMenu)
            {
                IOrderItem compare = item;
                Assert.Equal("Garden Orc Omelette", compare.ToString());
            }
        }
        [Fact]
        public void OnlyPriceMinNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByPrice(Menu.FullMenu(), 8, null);
            Assert.Single(curMenu);
        }

        [Fact]
        public void OnlyPriceMaxNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByPrice(Menu.FullMenu(), null, 0);
            Assert.Equal<int>(3, curMenu.Count());
        }
        [Fact]
        public void PriceMaxAndPriceMinNotNull()
        {
            IEnumerable<IOrderItem> curMenu = Menu.FilterByPrice(Menu.FullMenu(), 8, 9);
            foreach (IOrderItem item in curMenu)
            {
                IOrderItem compare = item;
                Assert.Equal("Thalmor Triple", compare.ToString());
            }
        }


    }
}
