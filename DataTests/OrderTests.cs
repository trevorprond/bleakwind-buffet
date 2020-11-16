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

namespace BleakwindBuffet.DataTests
{
    public class OrderTests : IOrderItem
    {
        public double Price { get; set; }

        public uint Calories { get;  set; }

        public string Description { get; set; }

        public List<string> SpecialInstructions { get; set; }

        [Fact]
        public void ItemsOnlyContainAddedItems()
        {
            var items = new IOrderItem[]
            {
                new OrderTests() {Price = 30},
                new OrderTests() {Price = 15},
                new OrderTests() {Price = 5},
            };
            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }

        [Fact]
        public void AddOrderItemsInItemsProperty()
        {
            var order = new Order();
            var curItem = new OrderTests();
            order.Add(curItem);
            Assert.Contains(curItem, order.Items);

        }


        [Fact]
        public void RemoverOrderItemIsActuallyRemoved()
        {
            var order = new Order();
            var curItem = new OrderTests();
            order.Add(curItem);
            order.Remove(curItem);
            Assert.DoesNotContain(curItem, order.Items);
        }


        [Theory]
        [InlineData(new double[] { })]
        [InlineData(new double[] {30, 50, 70.5 })]
        [InlineData(new double[] {12, 5, 7.8 })]
        [InlineData(new double[] {1, 2, 3, 4, 5 })]
        [InlineData(new double[] {-500, 100 })]
        public void SubTotalIsEqualToSumOfPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new OrderTests()
                {
                    Price = price

                });
            }
            Assert.Equal(total, order.Subtotal);
        }


    }
}
