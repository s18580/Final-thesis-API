using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class SupplyItemType
    {
        public int IdSupplyItemType { get; set; }
        public string Name { get; set; }

        public ICollection<Supply> Supplies { get; set; }
    }
}
