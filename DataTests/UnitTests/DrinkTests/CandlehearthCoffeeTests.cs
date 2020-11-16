﻿/*
 * Author: Trevor Prondzinski
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAINotifyPropertyChanged()
        {
            var cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cc);
        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "Ice", () => cc.Ice = true);
            Assert.PropertyChanged(cc, "Ice", () => cc.Ice = false);
        }

        [Fact]
        public void ChangingSizesNotifiesSizeProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Medium);
            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Large);
            Assert.PropertyChanged(cc, "Size", () => cc.Size = Size.Small);
        }

        [Fact]
        public void ChangingCreamNotifiesCreamProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "RoomForCream", () => cc.RoomForCream = true);
            Assert.PropertyChanged(cc, "RoomForCream", () => cc.RoomForCream = false);
        }

        [Fact]
        public void ChangingToDecafNotifiesDecafProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "Decaf", () => cc.Decaf = true);
            Assert.PropertyChanged(cc, "Decaf", () => cc.Decaf = false);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var cc = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream

            };

            if (includeIce) Assert.Contains("Add ice", cc.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", cc.SpecialInstructions);
            if (!includeCream && !includeIce) Assert.Empty(cc.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            cc.Decaf = decaf;
            Assert.Equal(name, cc.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", cc.Description);
        }
    }
}
