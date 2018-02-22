namespace Models.ItemModels
{
    public class LegendaryItem : Item
    {
        public int SellIn { get; set; }

        public int Quality { get; set; }

        public int DegradeRate { get; set; }

        public string Description { get; set; }

        public LegendaryItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
            DegradeRate = 1;
        }

        public void EndOfDay() 
        {
            //DO NOTHING
            return;
        }
    }
}
