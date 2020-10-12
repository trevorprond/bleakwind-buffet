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
using System.Collections.Specialized;
using System.Linq;
using System.Runtime;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {


        [Fact]
        public void AddingComboShouldTriggerPricehanges()
        {
            var bb = new BriarheartBurger();
            var aj = new AretinoAppleJuice();
            var dw = new DragonbornWaffleFries();

            Combo combo1 = new Combo(bb, aj, dw);

            Assert.PropertyChanged(combo1, "Price", () => aj.Size = Size.Large);
            Assert.PropertyChanged(combo1, "Price", () => dw.Size = Size.Medium);

            //make more methods for calories and sizes
            

        }

        [Fact]
        public void AddingComboShouldTriggerCalorieChanges()
        {
            var bb = new BriarheartBurger();
            var aj = new AretinoAppleJuice();
            var dw = new DragonbornWaffleFries();

            
            Combo combo1 = new Combo(bb, aj, dw);

            

            Assert.PropertyChanged(combo1, "Calories", () => aj.Size = Size.Large);
            Assert.PropertyChanged(combo1, "Calories", () => dw.Size = Size.Medium);

            //make more methods for calories and sizes


        }


        [Theory]
        [InlineData(Size.Small, 1011)]
        [InlineData(Size.Medium, 1132)]
        [InlineData(Size.Large, 1254)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint calories)
        { 

            var bb = new BriarheartBurger();
            var aj = new SailorSoda();
            var dw = new FriedMiraak();


            Combo combo1 = new Combo(bb, aj, dw);

            combo1.Side.Size = size;
            combo1.Drink.Size = size;
            Assert.Equal(calories, combo1.Calories);
        }


        [Fact]
        
        public void ShouldHaveCorrectPriceForSize()
        {

            var bb = new BriarheartBurger();
            var aj = new SailorSoda();
            var dw = new FriedMiraak();

            Combo combo1 = new Combo(bb, aj, dw);

            var price = bb.Price + aj.Price + dw.Price - 1.00;

            Assert.Equal(price, combo1.Price);
        }



        [Fact]
        public void AddingComboShouldTriggerSizeChanges()
        {
            var bb = new GardenOrcOmelette();
            var aj = new SailorSoda();
            var dw = new MadOtarGrits();

            Combo combo1 = new Combo(bb, aj, dw);

            aj.Size = Size.Large;
            dw.Size = Size.Medium;

            Assert.PropertyChanged(combo1, "Size", () => combo1.Drink.Size = Size.Medium);
            Assert.PropertyChanged(combo1, "Size", () => combo1.Side.Size = Size.Large);

            //make more methods for calories and sizes


        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void AddingSpecialInstructionsTriggerPropChanges(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            
            var vs = new VokunSalad();
            var ss = new SailorSoda();
                var tt = new ThalmorTriple()
                {
                    Bun = includeBun,
                    Ketchup = includeKetchup,
                    Mustard = includeMustard,
                    Pickle = includePickle,
                    Cheese = includeCheese,
                    Tomato = includeTomato,
                    Lettuce = includeLettuce,
                    Mayo = includeMustard,
                    Bacon = includeBacon,
                    Egg = includeEgg




                };

            

            Combo combo2 = new Combo(tt, ss, vs);
            ss.Ice = false;
            Assert.Contains("Hold ice", combo2.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", combo2.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", combo2.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", combo2.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", combo2.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", combo2.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", combo2.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", combo2.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", combo2.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", combo2.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", combo2.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            }



        
    }
}
