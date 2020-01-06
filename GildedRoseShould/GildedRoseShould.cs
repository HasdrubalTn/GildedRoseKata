using System;
using System.Collections.Generic;
using GildedRose;
using Xunit;

namespace GildedRoseShould
{
    public class GildedRoseShould
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose.GildedRose app = new GildedRose.GildedRose(Items);
            app.UpdateQuality();

            Assert.Equal("fixme", Items[0].Name);
        }
    }
}
