using Models.ItemModels;

namespace ItemService
{
    public static class ItemFactory
    {
        public static Item GetItem(string itemName, int sellInValue, int quality) 
        {
            switch (itemName.ToLowerInvariant())
            {
                case "aged brie":
                    return new AgedBrie(sellInValue, quality);
                case "sulfuras":
                    return new LegendaryItem(sellInValue, quality);
                case "normal item":
                    return new NormalItem(sellInValue, quality);
                case "backstage passes":
                    return new BackstagePass(sellInValue, quality);
                case "conjured":
                    NormalItem conjured = new NormalItem(sellInValue, quality);
                    conjured.DegradeRate = 2;
                    return conjured;
                default:
                    return null;
            }
        }
    }
}
