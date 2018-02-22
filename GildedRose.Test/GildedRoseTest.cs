using NUnit.Framework;
using Models.ItemModels;
using ItemService;
using Models;

namespace GildedRose.Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void TestAgedBrie() 
        {
            Item testy = ItemFactory.GetItem("aged BRIE", 0, 0);
            int exp = 0;
            int result = testy.Quality;
            Assert.AreEqual(exp, result);
        }

        [Test]
        public void TestAgedBrie2()
        {
            Item testy = ItemFactory.GetItem("aged BRIE", 0, 0);
            testy.EndOfDay();
            int exp = 2;
            int result = testy.Quality;
            Assert.AreEqual(exp, result);
        }
    }
    //TODO ADD MORE TESTS FOR DIFF OBJECTS
}
