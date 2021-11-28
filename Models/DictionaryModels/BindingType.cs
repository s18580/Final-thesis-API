using System.Collections.Generic;

namespace Final_thesis_api.Models.DictionaryModels
{
    public class BindingType
    {
        public int IdBindingType { get; set; }
        public string Name { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Valuation> Valuations { get; set; }
    }
}
