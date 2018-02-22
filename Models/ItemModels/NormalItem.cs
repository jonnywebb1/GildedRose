namespace Models.ItemModels
{
    public class NormalItem : Item
    {
        public int SellIn { get; set; }

        public int Quality { get; set; }

        public int DegradeRate { get; set; }
        
        public NormalItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            DegradeRate = 1;
        }

        public NormalItem() { }

        public virtual void EndOfDay()
        {
            if (SellIn < 0)
                Quality -= DegradeRate * 2;
            else
                Quality -= DegradeRate;

            if (Quality > 50)
                Quality = 50;

            SellIn -= 1;
        }
    }
}
