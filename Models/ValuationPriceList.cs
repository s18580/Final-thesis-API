using Final_thesis_api.Models.DictionaryModels;

namespace Final_thesis_api.Models
{
    public class ValuationPriceList
    {
        public int IdValuation { get; set; }
        public int IdPriceList { get; set; }

        public Valuation Valuation { get; set; }
        public PriceList PriceList { get; set; }
    }
}