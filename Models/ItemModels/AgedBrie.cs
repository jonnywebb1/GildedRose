namespace Models.ItemModels
{
    public class AgedBrie : NormalItem, Item
    {
        public AgedBrie(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            DegradeRate = 1;
        }

        public override void EndOfDay()
        {
            if (Quality < 50)
                Quality += 1;

            SellIn -= 1;
        }
    }
}
