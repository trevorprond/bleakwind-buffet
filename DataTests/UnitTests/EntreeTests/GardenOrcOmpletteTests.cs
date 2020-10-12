/*
 * Author: Trevor Prondzinski
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAINotifyPropertyChanged()
        {
            var oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(oo);
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var oo = new GardenOrcOmelette();

            Assert.PropertyChanged(oo, "Tomato", () => oo.Tomato = false);
            Assert.PropertyChanged(oo, "Tomato", () => oo.Tomato = true);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var oo = new GardenOrcOmelette();

            Assert.PropertyChanged(oo, "Broccoli", () => oo.Broccoli = false);
            Assert.PropertyChanged(oo, "Broccoli", () => oo.Broccoli = true);
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var oo = new GardenOrcOmelette();

            Assert.PropertyChanged(oo, "Mushrooms", () => oo.Mushrooms = false);
            Assert.PropertyChanged(oo, "Mushrooms", () => oo.Mushrooms = true);
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var oo = new GardenOrcOmelette();

            Assert.PropertyChanged(oo, "Cheddar", () => oo.Cheddar = false);
            Assert.PropertyChanged(oo, "Cheddar", () => oo.Cheddar = true);
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(oo);
        }
        [Fact]
        public void ShouldBeAIOrderItem()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(oo);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = false;
            Assert.False(oo.Broccoli);
            oo.Broccoli = true;
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Mushrooms = false;
            Assert.False(oo.Mushrooms);
            oo.Mushrooms = true;
            Assert.True(oo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Tomato = false;
            Assert.False(oo.Tomato);
            oo.Tomato = true;
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Cheddar = false;
            Assert.False(oo.Cheddar);
            oo.Cheddar = true;
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();

            Assert.Equal(4.57, oo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();

            Assert.Equal((uint)404, oo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var oo = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };



            if (!includeBroccoli) Assert.Contains("Hold broccoli", oo.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", oo.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", oo.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", oo.SpecialInstructions);
            else Assert.Empty(oo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Contains("Garden Orc Omelette", oo.ToString());

        }
    }
}