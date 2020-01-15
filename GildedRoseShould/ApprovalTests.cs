using System;
using System.Collections.Generic;
using GildedRose;
using Xunit;

namespace GildedRoseShould
{
    public class GildedRoseTest
    {
        [Fact]
        public void aged_brie_with_positive_quality_and_sellin_0_should_decrease_by_one_each_day()
        {
            IList<Item> roses = new List<Item>
            {
                new Item
                {
                    Name = "Aged Brie", SellIn = 0, Quality = 2
                }
            };

            var app = new GildedRose.GildedRose(roses);
            app.UpdateQuality();

            Assert.Equal("Aged Brie", roses[0].Name);
            Assert.Equal(4, roses[0].Quality);
        }

        [Theory]
        [InlineData(5, 40)]
        [InlineData(4, 40)]
        [InlineData(3, 40)]
        [InlineData(2, 40)]
        [InlineData(1, 40)]
        public void test_sellin_less_then_6(int sellIn, int quality)
        {
            IList<Item> roses = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality
                }
            };

            var app = new GildedRose.GildedRose(roses);
            app.UpdateQuality();

            Assert.Equal(quality + 3, roses[0].Quality);
        }
        
        [Theory]
        [InlineData(1, 40)]
        public void test_rose_with_positive_quality(int sellIn, int quality)
        {
            IList<Item> roses = new List<Item>
            {
                new Item
                {
                    Name = "Rose", SellIn = sellIn, Quality = quality
                }
            };

            var app = new GildedRose.GildedRose(roses);
            app.UpdateQuality();

            Assert.Equal(quality - 1, roses[0].Quality);
        }

        [Theory]
        [InlineData(-1, 40)]
        public void test_rose_with_positive_quality_and_negative_sellin(int sellIn, int quality)
        {
            IList<Item> roses = new List<Item>
            {
                new Item
                {
                    Name = "Rose", SellIn = sellIn, Quality = quality
                }
            };

            var app = new GildedRose.GildedRose(roses);
            app.UpdateQuality();

            Assert.Equal(quality - 2, roses[0].Quality);
        }        
        
        [Theory]
        [InlineData(-1, 40)]
        public void test_Backstage_passes_to_a_TAFKAL80ETC_concert_with_positive_quantity_and_negative_sellin(int sellIn, int quality)
        {
            IList<Item> roses = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality
                }
            };

            var app = new GildedRose.GildedRose(roses);
            app.UpdateQuality();

            Assert.Equal(0, roses[0].Quality);
        }
    }
}
