namespace Models.ItemModels
{
    public interface Item
    {
        int SellIn { get; set; }
         
        int Quality { get; set; }
         
        int DegradeRate { get; set; }
         
        void EndOfDay();
    }
}
