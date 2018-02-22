namespace Models.ItemModels
{
    public class BackstagePass : NormalItem, Item
    {
        public BackstagePass(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            DegradeRate = 1;
        }

        public override void EndOfDay()
        {
            if (SellIn > 10)
                Quality += 1;
            else if (SellIn > 5)
                Quality += 2;
            else if (SellIn >= 0)
                Quality += 3;
            else
                Quality = 0;

            SellIn -= 1;
        }
    }
}
