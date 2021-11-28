using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class PriceList
    {
        public int IdPriceList { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ICollection<ValuationPriceList> ValuationPriceLists  { get; set; }
    }
}
