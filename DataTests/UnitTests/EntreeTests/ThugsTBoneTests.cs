/*
 * Author: Trevor Prondzinski
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAINotifyPropertyChanged()
        {
            var tt = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tt);
        }
        [Fact]
        public void ShouldBeAIOrderItem()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal((uint)982, tb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Contains("Thugs T-Bone", tb.ToString());
        }
    }
}